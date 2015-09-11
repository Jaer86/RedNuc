using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RedNuc.Models.ViewModels
{
    public class IniciarSesionViewModel
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Contrasena { get; set; }
    }
}