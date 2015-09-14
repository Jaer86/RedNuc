using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity.Owin;
using RedNuc.Infrastructure.Identity_Config;
using Ninject.Extensions.Logging;
using RedNuc.Data;
using RedNuc.Models.ViewModels;

namespace RedNuc.Controllers
{
    public class CuentaController : Controller
    {

        private readonly ManejadorDeRegistro _manejadorDeRegistro;
        private readonly ManejadorDeUsuario _manejadorDeUsuario;
        private readonly ILogger _logger;

        public CuentaController(ManejadorDeUsuario manejadorDeUsuario, ManejadorDeRegistro manejedorDeRegistro, ILogger logger)
        {
            _manejadorDeUsuario = manejadorDeUsuario;
            _manejadorDeRegistro = manejedorDeRegistro;
            _logger = logger;

        }


        public ActionResult Registrarse()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Registrarse(RegistrarseViewModel modelo)
        {
            if (!ModelState.IsValid)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.InternalServerError, "MODELO_INVALIDO");

            }

            var nuevoUsuario = new Usuario
            {
                Nombre = modelo.Nombre,
                Apellidos = modelo.Apellidos,
                UserName = modelo.CorreoElectronico,
                Email = modelo.CorreoElectronico
            };


            var result = await _manejadorDeUsuario.CreateAsync(nuevoUsuario, modelo.Contrasena);

            return result.Succeeded ? new HttpStatusCodeResult(System.Net.HttpStatusCode.OK) : new HttpStatusCodeResult(System.Net.HttpStatusCode.InternalServerError, "ERROR_REGISTRO");
        }

        public ActionResult IniciarSesion()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> IniciarSesion(IniciarSesionViewModel modelo)
        {
            if (!ModelState.IsValid) return View(modelo);

            var usuarioAIniciarSesion = await _manejadorDeUsuario.FindByNameAsync(modelo.UserName);

            if (usuarioAIniciarSesion == null) return View(modelo);

            var result = await _manejadorDeRegistro.PasswordSignInAsync(modelo.UserName, modelo.Contrasena, false, false);

            if (result == SignInStatus.Success)
            {
                return RedirectToAction("Escritorio", "Usuario");
            }

            return View(modelo);

        }

        public async Task<ActionResult> EsCorreoNoExistente(string correoElectronico)
        {
            var respuesta = new { valid = false };

            var usuario = await _manejadorDeUsuario.FindByEmailAsync(correoElectronico);

            // Si no existe el usuario, entonces el correo es válido
            if (usuario == null)
            {
                respuesta = new { valid = true };
            }

            return Json(respuesta, JsonRequestBehavior.AllowGet);
        }

        [Authorize]
        public ActionResult CerrarSesion()
        {
            _manejadorDeRegistro.AuthenticationManager.SignOut();

            return RedirectToAction("Index", "Home");
        }

    }
}

