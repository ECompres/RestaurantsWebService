using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ws_restaurants.Modelos
{
    public class Imagenes
    {
        [Key]
        public int ID { get; set; }
        public string NOMBRE { get; set; }
        public string EXTENSION { get; set; }
        public double TAMANIO { get; set; }
        public string UBICACION { get; set; }
        [Required]
        [ForeignKey("restaurante")]
        public int restauranteId { get; set; }
        public Restaurants Restaurante { get; set; }
        [Required]
        public Boolean IsProfile { get; set; }
    }
}