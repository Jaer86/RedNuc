using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using RedNuc.Infrastructure.Data.Contexts;

namespace RedNuc.Infrastructure.Identity_Config
{
    public class ManejadorDeRoles : RoleManager<IdentityRole>
    {

        public ManejadorDeRoles(IRoleStore<IdentityRole, string> store)
            : base(store)
        {
        }

        public static ManejadorDeRoles Create(IdentityFactoryOptions<ManejadorDeRoles> options, IOwinContext context)
        {
            var roleStore = new RoleStore<IdentityRole>(context.Get<RedNucContext>());
            return new ManejadorDeRoles(roleStore);
        }
    }
}