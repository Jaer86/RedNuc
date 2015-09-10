using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedNuc.Data
{
    public class PerfilProyecto
    {
        public string PerfilId { get; set; }
        public int ProyectoId { get; set; }

        public virtual Perfil Perfil { get; set; }
        public virtual Proyecto Proyecto { get; set; }
    }
}
