using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedNuc.Data
{
    public class Proyecto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Categoria> Categorias { get; set; }
        public virtual ICollection<Galeria> Galerias { get; set; }
        public virtual ICollection<PerfilProyecto> PerfilProyectos { get; set; }
         
        public Proyecto()
        {
            Categorias = new List<Categoria>();
            Galerias = new List<Galeria>();
            PerfilProyectos =  new List<PerfilProyecto>();
        }
    }
}
