using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using RedNuc.Data;

namespace RedNuc.Infrastructure.Data.EF_Config
{
    public class UsuarioEntityConfiguration :EntityTypeConfiguration<Usuario>
    {
        public UsuarioEntityConfiguration()
        {
            this.HasOptional(x => x.Perfil)
                .WithRequired(x => x.Usuario)
                .WillCascadeOnDelete();
        }
    }
}