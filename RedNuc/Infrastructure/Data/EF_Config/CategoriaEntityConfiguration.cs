using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using RedNuc.Data;

namespace RedNuc.Infrastructure.Data.EF_Config
{
    public class CategoriaEntityConfiguration : EntityTypeConfiguration<Categoria>
    {
        public CategoriaEntityConfiguration()
        {
            this.HasMany<Subcategoria>(x => x.Subcategorias)
                .WithRequired(x => x.Categoria)
                .HasForeignKey(x => x.CategoriaId);
        }
    }
}