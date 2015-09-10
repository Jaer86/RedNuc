using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace RedNuc.Data
{
    public class Perfil
    {
        public string UsuarioId { get; set; }
        public string Curriculum { get; set; }
        public byte[] FotoPerfil { get; set; }

        public ICollection<PerfilProyecto> PerfilProyectos { get; set; }

        public virtual Usuario Usuario { get; set; }

        public Perfil()
        {
            PerfilProyectos = new List<PerfilProyecto>();

        }
    }
}
