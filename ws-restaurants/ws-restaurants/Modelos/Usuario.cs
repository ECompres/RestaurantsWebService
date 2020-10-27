using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ws_restaurants.Modelos
{
    public class Usuario
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "No introdujo un nombre")]
        public string NOMBRE { get; set; }
        [Required(ErrorMessage = "No introdujo un apellido")]
        public string APELLIDO { get; set; }
        [Required(ErrorMessage = "No introdujo un email")]
        public string EMAIL { get; set; }
        [Required(ErrorMessage = "No introdujo una clave")]
        public string PASS { get; set; }
        [Required(ErrorMessage = "No introdujo un tipo de usuario")]
        public int TIPO_USUARIO { get; set; }
    }
}