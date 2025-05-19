using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PryElgueta_IEFI
{
    internal class clsUsuarios
    {
        public List<clsUsuario> lstUsuarios {  get; set; }

        public clsUsuarios()
        {
            lstUsuarios = new List<clsUsuario>();
        }

    }
}
