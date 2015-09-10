using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;
using RedNuc.Data;
using RedNuc.Infrastructure.Data.EF_Config;

namespace RedNuc.Infrastructure.Data.Contexts
{
    public class RedNucContext : IdentityDbContext<Usuario>
    {
        public RedNucContext()
            : base("DefaultConnection")
        {

        }

        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            // Remover la convención que pluraliza el nombre de las tablas
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Configurations.Add(new CategoriaEntityConfiguration());
            modelBuilder.Configurations.Add(new FichaTecnicaEntityConfiguration());
            modelBuilder.Configurations.Add(new GaleriaEntityConfiguration());
            modelBuilder.Configurations.Add(new ImagenEntityConfiguration());
            modelBuilder.Configurations.Add(new PerfilEntityConfiguration());
            modelBuilder.Configurations.Add(new PerfilProyectoEntityConfiguration());
            modelBuilder.Configurations.Add(new ProyectoEntityConfiguration());
            modelBuilder.Configurations.Add(new UsuarioEntityConfiguration());
            


            base.OnModelCreating(modelBuilder);

            
        }
    }
}