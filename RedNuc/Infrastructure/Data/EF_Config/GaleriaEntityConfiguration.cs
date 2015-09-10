using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using RedNuc.Data;

namespace RedNuc.Infrastructure.Data.EF_Config
{
    public class GaleriaEntityConfiguration : EntityTypeConfiguration<Galeria>
    {
        public GaleriaEntityConfiguration()
        {
            this.HasMany<Imagen>(x => x.Imagenes)
                .WithRequired(x => x.Galeria)
                .HasForeignKey(x => x.GaleriaId);
        }
    }
}