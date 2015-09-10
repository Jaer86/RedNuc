using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using RedNuc.Data;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;

namespace RedNuc.Infrastructure.Identity_Config
{
    public class ManejadorDeUsuario : UserManager<Usuario>
    {
        public ManejadorDeUsuario(IUserStore<Usuario> store)
            : base(store)
        {
            this.UserValidator = new UserValidator<Usuario>(this)
            {
                AllowOnlyAlphanumericUserNames = false,
                //RequireUniqueEmail = true
            };

            // Configure la lógica de validación de contraseñas
            this.PasswordValidator = new PasswordValidator
            {
                RequiredLength = 6,
                RequireDigit = true,
                RequireLowercase = true,
                RequireUppercase = true,
            };

            // Configurar valores predeterminados para bloqueo de usuario
            this.UserLockoutEnabledByDefault = true;
            this.DefaultAccountLockoutTimeSpan = TimeSpan.FromMinutes(5);
            this.MaxFailedAccessAttemptsBeforeLockout = 5;

            // Registre proveedores de autenticación en dos fases. Esta aplicación usa los pasos Teléfono y Correo electrónico para recibir un código para comprobar el usuario
            // Puede escribir su propio proveedor y conectarlo aquí.
            this.RegisterTwoFactorProvider("Código telefónico", new PhoneNumberTokenProvider<Usuario>
            {
                MessageFormat = "Su código de seguridad es {0}"
            });
            this.RegisterTwoFactorProvider("Código de correo electrónico", new EmailTokenProvider<Usuario>
            {
                Subject = "Código de seguridad",
                BodyFormat = "Su código de seguridad es {0}"
            });
            this.EmailService = new ServicioDeCorreo();
            this.SmsService = new SmsService();

            var dataProtectionProvider = Startup.DataProtectionProvider;

            if (dataProtectionProvider != null)
            {
                this.UserTokenProvider =
                    new DataProtectorTokenProvider<Usuario>(dataProtectionProvider.Create("ASP.NET Identity"));
            }
        }

    }
}