using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryElgueta_IEFI
{
    internal class clsConexionBBDD
    {
        string cadenaConexion = "Server=localhost;Database=Usuarios;Trusted_Connection=True;";

        //conector
        SqlConnection conexionBaseDatos;

        //comando
        SqlCommand comandoBaseDatos;

        public string nombreBaseDeDatos;




        public void cargarLista()
        {

        }

        public void cargarLista(clsUsuarios lista)
        {
            try
            {
                conexionBaseDatos = new SqlConnection(cadenaConexion);

                conexionBaseDatos.Open();

                string query = "SELECT * FROM Usuarios";
                comandoBaseDatos = new SqlCommand(query, conexionBaseDatos);

                //Crear un DataTable
                DataTable tablaProductos = new DataTable();

                //Llenar el DataTable
                using (SqlDataReader reader = comandoBaseDatos.ExecuteReader())
                {
                    tablaProductos.Load(reader);
                }

                //Empieza a llenar la lista con los valores correspondientes de un producto fila por fila.
                foreach (DataRow fila in tablaProductos.Rows)
                {
                    

                    clsUsuario user = new clsUsuario(Convert.ToInt32(fila[0]), fila[1].ToString(), fila[2].ToString(),
                        Convert.ToInt32(fila[3]), Convert.ToDateTime(fila[4]), Convert.ToDateTime(fila[5]), (TimeSpan)fila[6], (TimeSpan)fila[7]);

                    lista.lstUsuarios.Add(user);
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

    }
}
