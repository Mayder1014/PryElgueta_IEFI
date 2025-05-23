using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PryElgueta_IEFI
{
    internal class clsRegistro
    {
        public int id {  get; set; }
        public int usuarioId {  get; set; }
        public string tipoEvento {  get; set; }
        public DateTime fechaHoraEvento {  get; set; }
        public string descripcion {  get; set; }

        public clsRegistro(int id, int usuarioId, string tipoEvento, DateTime fechaHoraEvento, string descripcion)
        {
            this.id = id;
            this.usuarioId = usuarioId;
            this.tipoEvento = tipoEvento;
            this.fechaHoraEvento = fechaHoraEvento;
            this.descripcion = descripcion;
        }
    }
}
