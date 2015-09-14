using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Ninject.Extensions.Logging;
using RedNuc.Data;
using RedNuc.Infrastructure.Identity_Config;
using RedNuc.Models.ViewModels;

namespace RedNuc.Controllers.API
{
    public class UsuariosController : ApiController
    {

        private readonly ManejadorDeRegistro _manejadorDeRegistro;
        private readonly ManejadorDeUsuario _manejadorDeUsuario;
        private readonly ILogger _logger;

        public UsuariosController(ManejadorDeUsuario manejadorDeUsuario, ManejadorDeRegistro manejedorDeRegistro, ILogger logger)
        {
            _manejadorDeUsuario = manejadorDeUsuario;
            _manejadorDeRegistro = manejedorDeRegistro;
            _logger = logger;

        }

        public IEnumerable<UsuarioViewModel> GetUsuarios()
        {
            var modelo = new List<UsuarioViewModel>();

            foreach (var usuario in _manejadorDeUsuario.Users)
            {
                modelo.Add(new UsuarioViewModel
                {
                    Apellidos = usuario.Apellidos,
                    Nombre = usuario.Nombre,
                    CorreoElectronico = usuario.Email

                });
            }

            return modelo;

        }
    }
}
