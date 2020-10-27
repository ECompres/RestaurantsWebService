using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using ws_restaurants.Controlador;
using ws_restaurants.Modelos;
namespace ws_restaurants.Servicios
{
    /// <summary>
    /// Descripción breve de Usuarios
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class Usuarios : System.Web.Services.WebService
    {
        UsuariosController usuarioController = new UsuariosController();

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }
        [WebMethod]
        public List<Usuario> ObtenerUsuarios()
        {
            return usuarioController.ObtenerUsuarios();
        }
        [WebMethod]
        public Usuario ObtenerUsuario(int id)
        {
            return usuarioController.ObtenerUsuario(id);
        }
        [WebMethod]
        public string AgregarUsuario(string Nombre, string Apellido, string Email, string Pass, int Tipo_Usuario)
        {
            return usuarioController.AgregarUsuario(Nombre, Apellido, Email, Pass, Tipo_Usuario);
        }
        [WebMethod]
        public string EditarUsuario(int ID, string Nombre, string Apellido, string Email, string Pass, int Tipo_Usuario)
        {
            return usuarioController.EditarUsuario(ID, Nombre, Apellido, Email, Pass, Tipo_Usuario);
        }
        [WebMethod]
        public string EliminarUsuario(int id)
        {
            return usuarioController.EliminarUsuario(id);
        }
    }
}
