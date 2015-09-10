using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using RedNuc.Data;

namespace RedNuc.Infrastructure.Identity_Config
{
    public class ManejadorDeRegistro : SignInManager<Usuario, string>
    {
        public ManejadorDeRegistro(ManejadorDeUsuario userManager, IAuthenticationManager authenticationManager)
            : base(userManager, authenticationManager)
        {
        }

        public static ManejadorDeRegistro Create(IdentityFactoryOptions<ManejadorDeRegistro> options, IOwinContext context)
        {
            return new ManejadorDeRegistro(context.GetUserManager<ManejadorDeUsuario>(), context.Authentication);
        }
    }
}