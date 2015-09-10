using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using RedNuc.Data;

namespace RedNuc.Infrastructure.Data.EF_Config
{
    public class PerfilProyectoEntityConfiguration : EntityTypeConfiguration<PerfilProyecto>
    {
        public PerfilProyectoEntityConfiguration()
        {
            this.HasKey(x => new { x.PerfilId, x.ProyectoId });
        }
    }
}