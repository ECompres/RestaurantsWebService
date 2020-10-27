using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using ws_restaurants.Modelos;

namespace ws_restaurants.Controlador
{
    public class UsuariosController
    {
        string conStr = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

        public string AgregarUsuario(string Nombre, string Apellido, string Email, string Pass, int Tipo_Usuario)
        {
            using (SqlConnection sqlCon = new SqlConnection(conStr))
            {
                SqlCommand sqlCmd= new SqlCommand("spInsertarUsuario",sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@NOMBRE", Nombre);
                sqlCmd.Parameters.AddWithValue("@APELLIDO", Apellido);
                sqlCmd.Parameters.AddWithValue("@EMAIL", Email);
                sqlCmd.Parameters.AddWithValue("@PASS", Pass);
                sqlCmd.Parameters.AddWithValue("@TIPO_USUARIO", Tipo_Usuario);
                sqlCon.Open();
                int count = sqlCmd.ExecuteNonQuery();
                sqlCon.Close();

                if (count > 0)
                {
                    return "Usuario agregado";
                }
                else
                {
                    return "Usuario no agregado";
                }
            }
        }
        public string EditarUsuario(int ID, string Nombre, string Apellido, string Email, string Pass, int Tipo_Usuario)
        {
            using (SqlConnection sqlCon = new SqlConnection(conStr))
            {
                SqlCommand sqlCmd = new SqlCommand("spModificarUsuario", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@ID", ID);
                sqlCmd.Parameters.AddWithValue("@NOMBRE", Nombre);
                sqlCmd.Parameters.AddWithValue("@APELLIDO", Apellido);
                sqlCmd.Parameters.AddWithValue("@EMAIL", Email);
                sqlCmd.Parameters.AddWithValue("@PASS", Pass);
                sqlCmd.Parameters.AddWithValue("@TIPO_USUARIO", Tipo_Usuario);
                sqlCon.Open();
                int count = sqlCmd.ExecuteNonQuery();
                sqlCon.Close();
                if (count > 0)
                {
                    return "Usuario modificado";
                }
                else
                {
                    return "Usuario no modificado";
                }
            }
        }
        public string EliminarUsuario(int id)
        {
            using (SqlConnection sqlCon = new SqlConnection(conStr))
            {
                SqlCommand sqlCmd = new SqlCommand("spBorrarUsuario", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@ID", id);
                sqlCon.Open();
                int count = sqlCmd.ExecuteNonQuery();
                sqlCon.Close();
                if (count > 0)
                {
                    return "Usuario eliminado";
                }
                else
                {
                    return "Usuario no eliminado";
                }
            }
        }
        public List<Usuario> ObtenerUsuarios()
        {
            using (SqlConnection sqlCon = new SqlConnection(conStr))
            {
                SqlCommand sqlCmd = new SqlCommand("spObtenerUsuarios", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCon.Open();
                SqlDataReader dr = sqlCmd.ExecuteReader();
                List<Usuario> usuarios = new List<Usuario>();

                while (dr.Read())
                {
                    var usuario = new Usuario
                    {
                        ID = int.Parse(dr["ID"].ToString()),
                        NOMBRE = dr["NOMBRE"].ToString(),
                        APELLIDO = dr["APELLIDO"].ToString(),
                        EMAIL = dr["EMAIL"].ToString(),
                        PASS = dr["PASS"].ToString(),
                        TIPO_USUARIO = int.Parse(dr["TIPO_USUARIO"].ToString())
                    };
                    usuarios.Add(usuario);
                }
                return usuarios;
            }
        }
        public Usuario ObtenerUsuario(int id)
        {
            using (SqlConnection sqlCon = new SqlConnection(conStr))
            {
                SqlCommand sqlCmd = new SqlCommand("spObtenerUsuario", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@ID", id);
                sqlCon.Open();
                SqlDataReader dr = sqlCmd.ExecuteReader();
                Usuario usuario = new Usuario();

                while (dr.Read())
                {
                    usuario.ID = int.Parse(dr["ID"].ToString());
                    usuario.NOMBRE = dr["NOMBRE"].ToString();
                    usuario.APELLIDO = dr["APELLIDO"].ToString();
                    usuario.EMAIL = dr["EMAIL"].ToString();
                    usuario.PASS = dr["PASS"].ToString();
                    usuario.TIPO_USUARIO = int.Parse(dr["TIPO_USUARIO"].ToString());
                }
                return usuario;
            }
        }
    }
}