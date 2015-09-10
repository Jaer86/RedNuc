using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using RedNuc.Data;

namespace RedNuc.Infrastructure.Data.EF_Config
{
    public class PerfilEntityConfiguration : EntityTypeConfiguration<Perfil>
    {
        public PerfilEntityConfiguration()
        {
            this.HasKey(x => x.UsuarioId);
            this.HasMany<PerfilProyecto>(x => x.PerfilProyectos)
                .WithRequired(x => x.Perfil);
        }
    }
}