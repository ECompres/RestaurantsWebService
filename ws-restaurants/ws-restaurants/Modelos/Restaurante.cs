using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ws_restaurants.Modelos
{
    public class Restaurante
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string DIRECCION { get; set; }
        [Required]
        public string CIUDAD { get; set; }
        [Required]
        public string PAIS { get; set; }
        public List<Imagenes> IMAGENES { get; set; }
        [Required]
        public double LAT { get; set; }
        [Required]
        public double LNG { get; set; }
        [Required]
        public string NOMBRE_RESTAURANTE { get; set; }
        [Required]
        public float CALIFICACION { get; set; }
        [Required]
        public string ESTADO { get; set; }
    }
}