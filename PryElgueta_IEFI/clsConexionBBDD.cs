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

                //string query = "SELECT * FROM Usuarios";

                //Consulta que une tabla Usuarios y ActividadUsuario
                string query = @"
                SELECT u.*, a.UltimaConexion, a.UltimoTiempoTrabajo, a.TiempoTrabajoTotal 
                FROM Usuarios u
                LEFT JOIN ActividadUsuario a ON u.Id = a.UsuarioId";

                comandoBaseDatos = new SqlCommand(query, conexionBaseDatos);

                lista.lstUsuarios.Clear();

                using (SqlDataReader reader = comandoBaseDatos.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        clsUsuario user = new clsUsuario(
                            reader.GetInt32(reader.GetOrdinal("Id")),
                            reader.GetString(reader.GetOrdinal("NombreUsuario")),
                            reader.GetString(reader.GetOrdinal("Contraseña")),
                            Convert.ToInt32(reader.GetBoolean(reader.GetOrdinal("Permiso"))),
                            reader.GetString(reader.GetOrdinal("Nombre")),
                            reader.GetString(reader.GetOrdinal("Apellido")),
                            reader.GetInt32(reader.GetOrdinal("Edad")),
                            reader.IsDBNull(reader.GetOrdinal("DNI")) ? null : reader.GetString(reader.GetOrdinal("DNI")),
                            reader.IsDBNull(reader.GetOrdinal("Telefono")) ? null : reader.GetString(reader.GetOrdinal("Telefono")),
                            reader.IsDBNull(reader.GetOrdinal("Email")) ? null : reader.GetString(reader.GetOrdinal("Email")),
                            reader.GetDateTime(reader.GetOrdinal("FechaCreacion")),
                            reader.GetDateTime(reader.GetOrdinal("UltimaConexion")),
                            reader.GetTimeSpan(reader.GetOrdinal("UltimoTiempoTrabajo")),
                            reader.GetTimeSpan(reader.GetOrdinal("TiempoTrabajoTotal"))
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

                // Insertar en tabla Usuarios y ActividadUsuario
                string insertQuery = @"INSERT INTO Usuarios 
                                (NombreUsuario, Contraseña, Permiso, Nombre, Apellido, Edad, DNI, Telefono, Email, FechaCreacion) VALUES 
                                (@nombreUsuario, @contraseña, @permiso, @nombre, @apellido, @edad, @dni, @telefono, @email, @fechaCreacion);
                                
                                INSERT INTO ActividadUsuario 
                                (UsuarioId, UltimaConexion, UltimoTiempoTrabajo, TiempoTrabajoTotal) VALUES 
                                (SCOPE_IDENTITY(), @ultConexion, '00:00:00', '00:00:00');";

                SqlCommand cmd = new SqlCommand(insertQuery, conexionBaseDatos);

                cmd.Parameters.AddWithValue("@nombreUsuario", usuario.nombreUsuario);
                cmd.Parameters.AddWithValue("@contraseña", usuario.contraseña);
                cmd.Parameters.AddWithValue("@permiso", usuario.permiso);
                cmd.Parameters.AddWithValue("@nombre", usuario.nombre);
                cmd.Parameters.AddWithValue("@apellido", usuario.apellido);
                cmd.Parameters.AddWithValue("@edad", usuario.edad);
                cmd.Parameters.AddWithValue("@dni", (object)usuario.DNI ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@telefono", (object)usuario.telefono ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@email", (object)usuario.email ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@fechaCreacion", usuario.fechaCreacion);
                cmd.Parameters.AddWithValue("@ultConexion", DateTime.Now);


                cmd.ExecuteNonQuery();

                /*
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

                cmd.ExecuteNonQuery();*/
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

                // Actualizar tabla Usuarios y ActividadUsuario
                string updateQuery = @"UPDATE Usuarios SET 
                                NombreUsuario = @nombreUsuario, 
                                Contraseña = @contraseña, 
                                Permiso = @permiso,
                                Nombre = @nombre,
                                Apellido = @apellido,
                                Edad = @edad,
                                DNI = @dni,
                                Telefono = @telefono,
                                Email = @email
                                WHERE Id = @id;
                                
                                UPDATE ActividadUsuario SET
                                UltimaConexion = @ultConexion,
                                UltimoTiempoTrabajo = @ultTiempoTrabajo,
                                TiempoTrabajoTotal = @tiempoTrabajoTotal
                                WHERE UsuarioId = @id;";

                SqlCommand cmd = new SqlCommand(updateQuery, conexionBaseDatos);

                cmd.Parameters.AddWithValue("@id", usuario.id);
                cmd.Parameters.AddWithValue("@nombreUsuario", usuario.nombreUsuario);
                cmd.Parameters.AddWithValue("@contraseña", usuario.contraseña);
                cmd.Parameters.AddWithValue("@permiso", usuario.permiso);
                cmd.Parameters.AddWithValue("@nombre", usuario.nombre);
                cmd.Parameters.AddWithValue("@apellido", usuario.apellido);
                cmd.Parameters.AddWithValue("@edad", usuario.edad);
                cmd.Parameters.AddWithValue("@dni", (object)usuario.DNI ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@telefono", (object)usuario.telefono ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@email", (object)usuario.email ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@ultConexion", (object)usuario.ultimaConexion ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@ultTiempoTrabajo", (object)usuario.ultimoTiempoTrabajo ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@tiempoTrabajoTotal", usuario.tiempoTrabajoTotal);

                cmd.ExecuteNonQuery();


                /*
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

                cmd.ExecuteNonQuery();*/
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

        #endregion
    }
}
