using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using RedNuc.Data;

namespace RedNuc.Infrastructure.Data.EF_Config
{
    public class ImagenEntityConfiguration : EntityTypeConfiguration<Imagen>
    {
        public ImagenEntityConfiguration()
        {
            this.HasOptional<FichaTecnica>(x => x.FichaTecnica)
                .WithRequired(x => x.Imagen)
                .WillCascadeOnDelete();
        }
    }
}