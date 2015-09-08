using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedNuc.Data
{
    public class Arte
    {
        public int Id { get; set; }

        public int GaleriaId { get; set; }
        public Galeria Galeria { get; set; }

    }
}
