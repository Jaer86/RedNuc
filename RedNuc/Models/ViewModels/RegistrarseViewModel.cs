using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RedNuc.Models.ViewModels
{
    public class RegistrarseViewModel
    {
        [Required]
        public string CorreoElectronico { get; set; }
        [Required]
        public string Contrasena { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string EsAceptado { get; set; }

    }
}