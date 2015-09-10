using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedNuc.Data
{
    public class Imagen
    {
        public int Id { get; set; }
        public byte[] Datos { get; set; }

        public virtual FichaTecnica FichaTecnica { get; set; }

        public int GaleriaId { get; set; }
        public virtual Galeria Galeria { get; set; }



       

    }
}
