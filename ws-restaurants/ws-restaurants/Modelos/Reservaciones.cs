using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ws_restaurants.Modelos
{
    public class Reservaciones
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "No introdujo un usuario")]
        public Usuario ID_USUARIO { get; set; }
        [Required(ErrorMessage = "No introdujo un Restaurante")]
        public Restaurants ID_RESTAURANTE { get; set; }
        [Required(ErrorMessage = "No introdujo una fecha")]
        public DateTime FECHA { get; set; }
        [Required(ErrorMessage = "No introdujo una hora")]
        public string HORA { get; set; }
        [Required(ErrorMessage = "No introdujo la cantidad de personas")]
        public int CANTIDAD_PERSONAS { get; set; }
    }
}