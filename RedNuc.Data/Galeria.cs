﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedNuc.Data
{
    public class Galeria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Imagen> Imagenes { get; set; }

        public int ProyectoId { get; set; }
        public virtual Proyecto Proyecto { get; set; }

        public Galeria()
        {
            Imagenes = new List<Imagen>();
        }
    }
}
