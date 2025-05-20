using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryElgueta_IEFI
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        //1. Se instancian variables estaticas que permitiran su uso en otros formularios.
        static public Form formPrincipal;
        static public Timer timerS;
        static public ToolStripLabel mostrarUsuario;
        static public ToolStripLabel mostrarFecha;

        clsConexionBBDD conexion = new clsConexionBBDD();
        clsUsuarios lstUsuarios = new clsUsuarios();
        int segundos = 0; int minutos = 0; int horas = 0;

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            conexion.cargarLista(lstUsuarios);
            
            #region Mostrar al usuario frmLogin antes que frmPrincipal
            //2. Se termina de instanciar la variable para que se pueda manipular el frmPrincipal dentro de frmLogin.
            formPrincipal = this;
            formPrincipal.Hide(); //3. Se oculta el frmPrincipal.

            //4. Se termina de instanciar la variable para manipular el timerSesion (Se habilitará dentro de frmLogin una vez logueado.)
            timerS = timerSesion;
            timerSesion.Enabled = false;

            //5. Se termina de instanciar las variables para manipular el estado del usuario desde frmLogin.
            mostrarUsuario = lblMostrarUsuario;
            mostrarFecha = lblMostrarFecha;

            //6. Abre el frmLogin. Dando la ilusión de que el primer form que se abre es este antes que frmPrincipal.
            frmLogin v = new frmLogin();
            v.ShowDialog();
            #endregion
        }

        private void timerSesion_Tick(object sender, EventArgs e)
        {
            if (segundos != 60)
            {
                segundos++;
            }
            else
            {
                segundos = 0;
                if (minutos != 60)
                {
                    minutos++;
                }
                else
                {
                    minutos = 0;
                    horas++;
                }
            }
            label1.Text = $"Tiempo: {horas.ToString()}:{minutos.ToString()}:{segundos.ToString()}";
        }

    }
}
