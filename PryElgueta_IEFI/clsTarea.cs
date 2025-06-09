using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PryElgueta_IEFI
{
    internal class clsTarea
    {
        public int id {  get; set; }
        public int usuarioId {  get; set; }
        public DateTime fecha {  get; set; }
        public string tarea {  get; set; }
        public string lugar {  get; set; }
        public string uniforme {  get; set; }
        public string licencia {  get; set; }
        public string reclamo {  get; set; }
        public string comentario {  get; set; }

        public clsTarea(int id, int usuarioId, DateTime fecha, string tarea, string lugar, string uniforme, 
            string licencia, string reclamo, string comentario)
        {
            this.id = id;
            this.usuarioId = usuarioId;
            this.fecha = fecha;
            this.tarea = tarea;
            this.lugar = lugar;
            this.uniforme = uniforme;
            this.licencia = licencia;
            this.reclamo = reclamo;
            this.comentario = comentario;
        }

    }
}
