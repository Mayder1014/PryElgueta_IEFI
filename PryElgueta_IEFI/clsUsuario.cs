using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PryElgueta_IEFI
{
    internal class clsUsuario
    {
        //Datos personales (tabla Usuarios).
        public int id { get; set; }
        public string nombreUsuario { get; set; }
        public string contraseña { get; set; }
        public int permiso { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int edad { get; set; }
        public string DNI { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
        public DateTime fechaCreacion { get; set; }

        //Datos de actividad (tabla ActividadUsuario).
        public DateTime ultimaConexion { get; set; }
        public TimeSpan ultimoTiempoTrabajo { get; set; }
        public TimeSpan tiempoTrabajoTotal { get; set; }

        //Variable para manejar la actividad, modificaciones y tiempo de trabajo del usuario.
        public static clsUsuario usuarioLogueado { get; set; }

        //Variable para manejar datos del usuario seleccionado en frmGestionUsuarios en caso de Modificar al usuario.
        public static clsUsuario usuarioSeleccionado { get; set; }

        public clsUsuario(int id, string nombreUsuario, string contraseña, int permiso, string nombre, string apellido, int edad, string DNI,
                          string telefono, string email, DateTime fechaCreacion, DateTime ultimaConexion, TimeSpan ultimoTiempoTrabajo,
                          TimeSpan tiempoTrabajoTotal)
        {
            this.id = id;
            this.nombreUsuario = nombreUsuario;
            this.contraseña = contraseña;
            this.permiso = permiso;
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.DNI = DNI;
            this.telefono = telefono;
            this.email = email;
            this.fechaCreacion = fechaCreacion;
            this.ultimaConexion = ultimaConexion;
            this.ultimoTiempoTrabajo = ultimoTiempoTrabajo;
            this.tiempoTrabajoTotal = tiempoTrabajoTotal;
        }

    }
}
