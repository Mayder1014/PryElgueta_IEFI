using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PryElgueta_IEFI
{
    internal class clsUsuario
    {
        public int id { get; set; }
        public string usuario { get; set; }
        public string contraseña { get; set; }
        public int permiso { get; set; }
        public DateTime fechaCreacion { get; set; }
        public DateTime ultimaConexion { get; set; }
        public TimeSpan ultimoTiempoTrabajo { get; set; }
        public TimeSpan tiempoTrabajoTotal { get; set; }
        public int activo { get; set; }

        static public clsUsuario usuarioLogueado { get; set; }

        public clsUsuario(int id, string usuario, string contraseña, int permiso, DateTime fechaCreacion,
            DateTime ultimaConexion, TimeSpan ultimoTiempoTrabajo, TimeSpan tiempoTrabajoTotal, int activo)
        {
            this.id = id;
            this.usuario = usuario;
            this.contraseña = contraseña;
            this.permiso = permiso;
            this.fechaCreacion = fechaCreacion;
            this.ultimaConexion = ultimaConexion;
            this.ultimoTiempoTrabajo = ultimoTiempoTrabajo;
            this.tiempoTrabajoTotal = tiempoTrabajoTotal;
            this.activo = activo;
        }

    }
}
