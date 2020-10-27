using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using ws_restaurants.Controlador;
using ws_restaurants.Modelos;

namespace ws_restaurants
{
    /// <summary>
    /// Descripción breve de Restaurants
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class Restaurants : System.Web.Services.WebService
    {
        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }
        [WebMethod]
        public bool AgregarRestaurante()
        {
            try
            {
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        [WebMethod]
        public string GetNombre(string nombre)
        {
            return nombre;
        }
        
        
    }
}
