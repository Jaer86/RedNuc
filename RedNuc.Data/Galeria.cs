using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedNuc.Data
{
    public class Galeria
    {
        
        public virtual ICollection<Arte> Artes { get; set; }

       

        public Galeria()
        {
            Artes = new List<Arte>();
        }
    }
}
