using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCLibroteca.Models;
using MVCLibroteca.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Authorization;

namespace MVCLibroteca.Controllers
{
    [Authorize(Roles = "Administrador")]
    public class LibrosController : Controller
    {
        private ConexionMysqlDataContext contexto;
        private readonly IWebHostEnvironment webHostEnvironment;

        //Constructor de la clase
        public LibrosController(ConexionMysqlDataContext _contexto, IWebHostEnvironment webhost)
        {
            this.contexto = _contexto;//Inicializar la variable
            this.webHostEnvironment = webhost;
        }
        /*
        * Método para invocar la vista create.
        */
        public IActionResult Create()
        {
            List<Autores> autoresDisponibles = contexto.Autores.ToList().Where(autor => autor.estatus == true).ToList();
            ViewData["autores"] = autoresDisponibles.Select(autor => new SelectListItem
            {
                Text = autor.nombre + " " + autor.aPaterno + " " + autor.aMaterno,
                Value = autor.idAutor.ToString()

            });
            return View("Views/Admin/Libros/Create.cshtml");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(
            [Bind("idAutor, titulo, ISBN, Editorial, fechaPublicacion, archivo, precio, stock")] Libros libro)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    //Proceso para guardar la portada
                    String ruta = String.Empty;
                    if (libro.archivo != null)
                    {
                        //Ubicar ruta de la carpeta
                        String rutaCarpeta = Path.Combine(webHostEnvironment.WebRootPath, "portadas");
                        ruta = "libroteca_" + libro.archivo.FileName;
                        String rutaFinal = Path.Combine(rutaCarpeta, ruta);
                        //Guardar archivo en el proyecto
                        using (var fileStream = new FileStream(rutaFinal, FileMode.Create))
                        {
                            libro.archivo.CopyTo(fileStream);
                        }
                    }
                    //Guardar a la base de datos
                    libro.portada = ruta;
                    libro.estatus = true;
                    contexto.Add(libro);
                    await contexto.SaveChangesAsync();

                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Error al registrar un libro." +
                    "Trata nuevamente o consulta al administrador." + ex.ToString());
                Console.WriteLine(ex.ToString());
            }

            List<Autores> autores = contexto.Autores.ToList().Where(autor => autor.estatus == true).ToList();
            ViewData["autores"] = autores.Select(autor => new SelectListItem
            {
                Text = autor.nombre + " " + autor.aPaterno + " " + autor.aMaterno,
                Value = autor.idAutor.ToString()
            });

            return View("Views/Admin/Libros/Create.cshtml");
        }

        public IActionResult List()
        {
            List<Libros> listaLibros = contexto.Libros.ToList();
            ViewBag.Inactivos = listaLibros.Where(libro => libro.estatus == false).Count();
            ViewBag.Inactivos = listaLibros.Where(libro => libro.estatus == true).Count();

            //Recuperar el autor de cada libro
            foreach (Libros l in listaLibros)
            {
                l.autores = contexto.Autores.ToList()
                    .Where(autor => autor.idAutor == l.idAutor).FirstOrDefault();
            }

            return View("Views/Admin/Libros/List.cshtml", listaLibros.Where(libro => libro.estatus == true));

        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var libroUpd = await contexto.Libros.FirstOrDefaultAsync(l => l.idLibro == id);
            if (libroUpd == null)
            {
                return NotFound();
            }

            List<Autores> autores = contexto.Autores.ToList().Where(autor => autor.estatus == true).ToList();
            ViewData["autores"] = autores.Select(autor => new SelectListItem
            {
                Text = autor.nombre + " " + autor.aPaterno + " " + autor.aMaterno,
                Value = autor.idAutor.ToString()
            });

            return View("Views/Admin/Libros/Edit.cshtml", libroUpd);
        }
    }
}