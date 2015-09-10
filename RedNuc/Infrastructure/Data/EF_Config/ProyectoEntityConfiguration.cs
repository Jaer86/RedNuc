using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using RedNuc.Data;

namespace RedNuc.Infrastructure.Data.EF_Config
{
    public class ProyectoEntityConfiguration : EntityTypeConfiguration<Proyecto>
    {
        public ProyectoEntityConfiguration()
        {
            this.HasMany<Categoria>(x => x.Categorias)
                .WithRequired(x => x.Proyecto)
                .HasForeignKey(x => x.ProyectoId);

            this.HasMany<Galeria>(x => x.Galerias)
                .WithRequired(x => x.Proyecto)
                .HasForeignKey(x => x.ProyectoId);

            this.HasMany<PerfilProyecto>(x => x.PerfilProyectos)
                .WithRequired(x => x.Proyecto);
        }
    }
}