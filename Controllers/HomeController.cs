using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCLibroteca.Models;
using MVCLibroteca.Data;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;

namespace MVCLibroteca.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ConexionMysqlDataContext contexto;

        public HomeController(ConexionMysqlDataContext _contexto)
        {
            contexto = _contexto;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult AccessDenied(){
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public async Task<IActionResult> Login([Bind("correo, password")] Usuarios usuario)
        {
            try
            {
                var usu = await AuthenticateUser(usuario.correo, usuario.password);
                if (usu == null)
                {
                    ModelState.AddModelError("Errorlogin", "Credenciales no válidas.");
                    //Retornar a login
                    return View("../Home/login", usu);
                }
                //Cookies
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, usu.correo),
                    new Claim(ClaimTypes.Role, usu.rol),//Creamos la cookie
                };
                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity),
                    new AuthenticationProperties
                    {
                        IsPersistent = false // No recordar el inicio de sesión
                    });
                //Retornar a la vista principal del panel
                return RedirectToAction("Index", "Admin");
            }
            catch (Exception ex)
            {
                //Generar una error controlado
                ModelState.AddModelError("Errorlogin", "No se permite el inicio de sesión." +
                    "Trata nuevamente o consulta al administrador" + ex.ToString());
                //Retornar a Login
                return View("../Home/login");
            }
        }

        public async Task<Usuarios> AuthenticateUser(String correo, String password)
        {
            try
            {
                var usuario = await contexto.usuarios.FirstOrDefaultAsync(u => u.correo == correo
                        && u.password == password);
                return usuario;
            }
            catch (Exception ex)
            {
                //Generar una error controlado
                ModelState.AddModelError("", "No se puede establecer conexión." +
                    "Trata nuevamente o consulta al administrador" + ex.ToString());
                return null;
            }
        }
    }
}
