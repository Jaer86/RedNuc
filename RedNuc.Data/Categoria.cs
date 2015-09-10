using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedNuc.Data
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public ICollection<Subcategoria> Subcategorias { get; set; }

        public int ProyectoId { get; set; }
        public virtual Proyecto Proyecto { get; set; }

        public Categoria()
        {
            Subcategorias = new List<Subcategoria>();

        }
    }
}
