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
        public DateTime fechaActualConexion { get; set; }
        public DateTime fechaUltimaConexion { get; set; }
        public TimeSpan tiempoUltSesion { get; set; }
        public TimeSpan tiempoTotal { get; set; }

        static public clsUsuario usuarioLogueado { get; set; }

        public clsUsuario(int id, string usuario, string contraseña, int permiso, DateTime fechaActualConexion,
            DateTime fechaUltimaConexion, TimeSpan tiempoUltSesion, TimeSpan tiempoTotal)
        {
            this.id = id;
            this.usuario = usuario;
            this.contraseña = contraseña;
            this.permiso = permiso;
            this.fechaActualConexion = fechaActualConexion;
            this.fechaUltimaConexion = fechaUltimaConexion;
            this.tiempoUltSesion = tiempoUltSesion;
            this.tiempoTotal = tiempoTotal;
        }

    }
}
