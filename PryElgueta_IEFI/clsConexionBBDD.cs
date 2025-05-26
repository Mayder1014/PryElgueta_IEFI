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


        #region Metodos Usuarios...
        public void cargarListaUsuarios(clsUsuarios lista)
        {
            try
            {
                conexionBaseDatos = new SqlConnection(cadenaConexion);
                conexionBaseDatos.Open();

                string query = "SELECT * FROM Usuarios";
                comandoBaseDatos = new SqlCommand(query, conexionBaseDatos);

                lista.lstUsuarios.Clear();

                using (SqlDataReader reader = comandoBaseDatos.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        clsUsuario user = new clsUsuario(
                            reader.GetInt32(0),                        // Id
                            reader.GetString(1),                       // Usuario
                            reader.GetString(2),                       // Contraseña
                            Convert.ToInt32(reader.GetBoolean(3)),     // Permiso
                            reader.GetDateTime(4),                     // FechaCreacion
                            reader.GetDateTime(5),                     // UltimaConexion
                            reader.GetTimeSpan(6),                     // UltimoTiempoTrabajo
                            reader.GetTimeSpan(7),                     // TiempoTrabajoTotal
                            Convert.ToInt32(reader.GetBoolean(8))      // Activo
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

        public void agregarUsuario(clsUsuario usuario)
        {
            try
            {
                conexionBaseDatos = new SqlConnection(cadenaConexion);

                conexionBaseDatos.Open();

                string insertQuery = "INSERT INTO Usuarios (Usuario, Contraseña, Permiso, FechaCreacion, UltimaConexion, UltimoTiempoTrabajo, " +
                    "TiempoTrabajoTotal, Activo) VALUES " +
                    "(@usuario, @contraseña, @permiso, @fechaCreacion, @ultConexion, @ultTiempoTrabajo, @tiempoTrabajoTotal, @activo)";
                SqlCommand cmd = new SqlCommand(insertQuery, conexionBaseDatos);

                cmd.Parameters.AddWithValue("@usuario", usuario.usuario);
                cmd.Parameters.AddWithValue("@contraseña", usuario.contraseña);
                cmd.Parameters.AddWithValue("@permiso", usuario.permiso);
                cmd.Parameters.AddWithValue("@fechaCreacion", usuario.fechaCreacion);
                cmd.Parameters.AddWithValue("@ultConexion", usuario.ultimaConexion);
                cmd.Parameters.AddWithValue("@ultTiempoTrabajo", usuario.ultimoTiempoTrabajo);
                cmd.Parameters.AddWithValue("@tiempoTrabajoTotal", usuario.tiempoTrabajoTotal);
                cmd.Parameters.AddWithValue("@activo", usuario.activo);

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

        public void actualizarUsuario(clsUsuario usuario)
        {
            try
            {
                conexionBaseDatos = new SqlConnection(cadenaConexion);

                nombreBaseDeDatos = conexionBaseDatos.Database;

                conexionBaseDatos.Open();

                string updateQuery = "UPDATE Usuarios SET Usuario = @usuario, Contraseña = @contraseña, " +
                    "Permiso = @permiso, FechaCreacion = @fechaCreacion, UltimaConexion = @ultConexion, " +
                    "UltimoTiempoTrabajo = @ultTiempoTrabajo, TiempoTrabajoTotal = @tiempoTrabajoTotal, " +
                    "Activo = @activo WHERE Id = @id";
                SqlCommand cmd = new SqlCommand(updateQuery, conexionBaseDatos);

                cmd.Parameters.AddWithValue("@id", usuario.id);
                cmd.Parameters.AddWithValue("@usuario", usuario.usuario);
                cmd.Parameters.AddWithValue("@contraseña", usuario.contraseña);
                cmd.Parameters.AddWithValue("@permiso", usuario.permiso);
                cmd.Parameters.AddWithValue("@fechaCreacion", usuario.fechaCreacion);
                cmd.Parameters.AddWithValue("@ultConexion", usuario.ultimaConexion);
                cmd.Parameters.AddWithValue("@ultTiempoTrabajo", usuario.ultimoTiempoTrabajo);
                cmd.Parameters.AddWithValue("@tiempoTrabajoTotal", usuario.tiempoTrabajoTotal);
                cmd.Parameters.AddWithValue("@activo", usuario.activo);

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

        public void eliminarUsuario(int idEliminar)
        {
            try
            {
                conexionBaseDatos = new SqlConnection(cadenaConexion);

                conexionBaseDatos.Open();

                string deleteQuery = "DELETE FROM Usuarios WHERE Id = @id";
                SqlCommand cmd = new SqlCommand(deleteQuery, conexionBaseDatos);

                cmd.Parameters.AddWithValue("@id", idEliminar);

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

        #endregion


        #region Metodos Auditoria...
        public void cargarListaAuditoria(clsAuditoria lista)
        {
            try
            {
                conexionBaseDatos = new SqlConnection(cadenaConexion);
                conexionBaseDatos.Open();

                string query = "SELECT * FROM Auditoria";
                comandoBaseDatos = new SqlCommand(query, conexionBaseDatos);

                lista.lstAuditoria.Clear();

                using (SqlDataReader reader = comandoBaseDatos.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        clsRegistro registro = new clsRegistro(
                            reader.GetInt32(0),       // Id
                            reader.GetInt32(1),       // UsuarioId
                            reader.GetString(2),      // TipoEvento
                            reader.GetDateTime(3),    // FechaHoraEvento
                            reader.GetString(4)       // Descripcion
                        );
                        lista.lstAuditoria.Add(registro);
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

        public void registrarEnAuditoria(clsRegistro registro)
        {
            try
            {
                conexionBaseDatos = new SqlConnection(cadenaConexion);
                conexionBaseDatos.Open();

                string descripcion = registro.descripcion;

                switch (registro.tipoEvento)
                {
                    case "Login": 
                        descripcion = "El usuario inició sesión en el programa.";
                        break;
                    case "Logout":
                        descripcion = "El usuario cerró sesión en el programa.";
                        break;
                    case "Administración - Usuarios":
                        descripcion = "El usuario accedió a Administración - Gestión de Usuarios.";
                        break;
                    case "Administración - Auditoria":
                        descripcion = "El usuario accedió a Administración - Auditoria.";
                        break;
                    default:
                        descripcion = registro.descripcion;
                        break;
                }

                string insertQuery = "INSERT INTO Auditoria (UsuarioId, TipoEvento, FechaHoraEvento, Descripcion) VALUES " +
                    "(@usuarioId, @tipoEvento, @fechaHoraEvento, @descripcion)";
                SqlCommand cmd = new SqlCommand(insertQuery, conexionBaseDatos);

                cmd.Parameters.AddWithValue("@usuarioId", registro.usuarioId);
                cmd.Parameters.AddWithValue("@tipoEvento", registro.tipoEvento);
                cmd.Parameters.AddWithValue("@fechaHoraEvento", registro.fechaHoraEvento);
                cmd.Parameters.AddWithValue("@descripcion", descripcion);

                cmd.ExecuteNonQuery();
            }
            catch ( Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexionBaseDatos.Close();
            }
        }

        public void mostrarTablaAuditoria()
        {
            try
            {
                conexionBaseDatos = new SqlConnection(cadenaConexion);
                conexionBaseDatos.Open();



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

        #endregion
    }
}
