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
using Microsoft.AspNetCore.Authorization;

namespace MVCLibroteca.Controllers
{
    [Authorize(Roles = "Administrador")]
    public class AutoresController : Controller
    {
        private ConexionMysqlDataContext contexto;

        //Constructur de la clase
        public AutoresController(ConexionMysqlDataContext _contexto)
        {
            this.contexto = _contexto;//Inicializar la variable
        }

        //Métodos para la carpeta Admin / Autores

        /*Método para invocar la vista Create en Autores*/
        public IActionResult Create()
        {
            return View("Views/Admin/Autores/Create.cshtml");
        }

        /*Método para registrar Autor en la base de datos*/
        [Route("Autores/List")]
        [HttpPost]
        public async Task<IActionResult> Add([Bind("nombre, aPaterno, aMaterno, nacionalidad")] Autores autor)
        {
            try
            {
                //Todo código que pueda generar un error
                if (ModelState.IsValid)
                {
                    //Si el modelo es válido
                    autor.estatus = true; //Asignamos un estatus activo.
                    contexto.Add(autor);//Guardo autor en el Contexto
                    await contexto.SaveChangesAsync(); //Se reflejan los datos en la bd
                    return RedirectToAction("List", "Autores");
                }
            }
            catch (Exception ex)
            {
                //Codigo para controlar el error
                ModelState.AddModelError("", "Error al guardar autor: " + ex.ToString());
            }
            return View("Views/Admin/Autores/Create.cshtml");
        }

        //Método para invocar la vista List
        public IActionResult List()
        {
            //Contando a los autores inactivos
            ViewBag.Inactivos = contexto.Autores.ToList().Where(autor => autor.estatus == false).Count();
            //Contando a los autores activos
            ViewBag.Activos = contexto.Autores.ToList().Where(autor => autor.estatus == true).Count();

            return View("Views/Admin/Autores/List.cshtml", contexto.Autores.ToList().Where(autor => autor.estatus == true));
        }

        public IActionResult ListInactive()
        {
            //Contando a los autores inactivos
            ViewBag.Inactivos = contexto.Autores.ToList().Where(autor => autor.estatus == false).Count();
            //Contando a los autores activos
            ViewBag.Activos = contexto.Autores.ToList().Where(autor => autor.estatus == true).Count();

            return View("Views/Admin/Autores/ListInactive.cshtml", contexto.Autores.ToList()
                .Where(autor => autor.estatus == false));
        }

        //Método para recuperar la información del autor seleccionado
        // GET: /Autores/Update/5
        public async Task<IActionResult> Update(int? id)
        {
            //Validar el id
            if (id == null)
            {
                return NotFound(); //No encontrado
            }
            //Recuperar los datos del autor, con ese id
            var autorUpd = await contexto.Autores.FirstOrDefaultAsync(a => a.idAutor == id);
            if (autorUpd == null)
            {
                return NotFound(); //No encontrado
            }
            return View("Views/Admin/Autores/Update.cshtml", autorUpd);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update([Bind("idAutor,nombre, aPaterno, aMaterno, nacionalidad")] Autores autor)
        {
            if (ModelState.IsValid)
            {
                autor.estatus = true; //Asignamos un estatus activo.
                contexto.Entry(autor).State = EntityState.Modified;//Indicamos que el autor se modifico
                contexto.SaveChanges(); // Guardamos cambios
                return RedirectToAction("List", "Autores"); //Volvemos a la lista
            }
            else
            {//El modelo no es válido
                return View("Views/Admin/Autores/Update.cshtml", autor); //Nos mantenemos en autores.
            }
        }

        //Eliminar Definitivamente
        // GET: /Autores/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            //Validar el id
            if (id == null)
            {
                return NotFound(); //No encontrado
            }
            //Recuperar los datos del autor, con ese id
            var autorDel = await contexto.Autores.FirstOrDefaultAsync(a => a.idAutor == id);
            if (autorDel == null)
            {
                return NotFound(); //No encontrado
            }
            return View("Views/Admin/Autores/Delete.cshtml", autorDel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                Autores autorDel = contexto.Autores.Find(id);//Buscamos al autor, para eliminarlo
                contexto.Autores.Remove(autorDel); //Eliminación definitiva
                contexto.SaveChanges(); //Guardamos cambios
                return RedirectToAction("List", "Autores");
            }
            catch (Exception ex)
            {
                //Generar una error controlado
                ModelState.AddModelError("", "No se permiten eliminar el autor definitivamente" +
                    "Trata nuevamente o consulta al administrador" + ex.ToString());
            }
            return RedirectToAction("List", "Autores");

        }

        /*Método para la baja temporal de un autor*/
        public async Task<ActionResult> Baja(int? id)
        {
            try
            {
                Autores autorBaja = await contexto.Autores.FindAsync(id);//Buscamos al autor, para eliminarlo
                autorBaja.estatus = false; //Cambiamos el estatus a 0
                contexto.Entry(autorBaja).State = EntityState.Modified; //Indicamos la modificación
                contexto.SaveChanges(); //Guardamos cambios
                return RedirectToAction("List", "Autores");
            }
            catch (Exception ex)
            {
                //Generar una error controlado
                ModelState.AddModelError("", "No se permiten eliminar el autor temporalmente" +
                    "Trata nuevamente o consulta al administrador" + ex.ToString());
            }
            return RedirectToAction("List", "Autores");

        }

        public async Task<ActionResult> Restaurar(int? id)
        {
            try
            {
                Autores autorRestaurar = await contexto.Autores.FindAsync(id);//Buscamos al autor, para activarlo
                autorRestaurar.estatus = true; //Cambiamos el estatus a 1
                contexto.Entry(autorRestaurar).State = EntityState.Modified; //Indicamos la modificación
                contexto.SaveChanges(); //Guardamos cambios
                return RedirectToAction("ListInactive", "Autores");
            }
            catch (Exception ex)
            {
                //Generar una error controlado
                ModelState.AddModelError("", "No se permiten restaurar el autor." +
                    "Trata nuevamente o consulta al administrador" + ex.ToString());
            }
            return RedirectToAction("ListInactive", "Autores");

        }
    }
}