using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

namespace PryElgueta_IEFI
{
    internal class clsConexionBBDD
    {
        string cadenaConexion = "Server=localhost;Database=Trabajo;Trusted_Connection=True;";

        //conector
        SqlConnection conexionBaseDatos;

        //comando
        SqlCommand comandoBaseDatos;

        public string nombreBaseDeDatos;

        public void cargarLista(clsUsuarios lista)
        {
            try
            {
                conexionBaseDatos = new SqlConnection(cadenaConexion);
                conexionBaseDatos.Open();

                string query = "SELECT * FROM Usuarios";
                comandoBaseDatos = new SqlCommand(query, conexionBaseDatos);

                using (SqlDataReader reader = comandoBaseDatos.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        clsUsuario user = new clsUsuario(
                            reader.GetInt32(0),       // Id
                            reader.GetString(1),      // Usuario
                            reader.GetString(2),      // Contraseña
                            reader.GetInt32(3),       // Permiso
                            reader.GetDateTime(4),    // FechaActualConexion
                            reader.GetDateTime(5),    // FechaUltimaConexion
                            reader.GetTimeSpan(6),    // TiempoUltimaSesion
                            reader.GetTimeSpan(7)     // TiempoTotal
                        );
                        lista.lstUsuarios.Add(user);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexionBaseDatos.Close();
            }
        }

        public void actualizarUsuario(clsUsuario usuario)
        {
            try
            {
                conexionBaseDatos = new SqlConnection(cadenaConexion);

                nombreBaseDeDatos = conexionBaseDatos.Database;

                conexionBaseDatos.Open();

                string updateQuery = "UPDATE Usuarios SET Usuario = @usuario, Contraseña = @contraseña, " +
                    "Permiso = @permiso, FechaActualConexion = @actConexion, FechaUltimaConexion = @ultConexion, " +
                    "TiempoUltimaSesion = @ultSesion, TiempoTotal = @totalSesion WHERE Id = @id";
                SqlCommand cmd = new SqlCommand(updateQuery, conexionBaseDatos);

                cmd.Parameters.AddWithValue("@id", usuario.id);
                cmd.Parameters.AddWithValue("@usuario", usuario.usuario);
                cmd.Parameters.AddWithValue("@contraseña", usuario.contraseña);
                cmd.Parameters.AddWithValue("@permiso", usuario.permiso);
                cmd.Parameters.AddWithValue("@actConexion", usuario.fechaActualConexion);
                cmd.Parameters.AddWithValue("@ultConexion", usuario.fechaUltimaConexion);
                cmd.Parameters.AddWithValue("@ultSesion", usuario.tiempoUltSesion);
                cmd.Parameters.AddWithValue("@totalSesion", usuario.tiempoTotal);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexionBaseDatos.Close();
            }
        }



    }
}
