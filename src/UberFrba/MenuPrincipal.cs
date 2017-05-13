using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UberFrba;
using UberFrba.Model;
using UberFrba.Abm_Automovil;

namespace UberFrba
{
    public partial class MenuPrincipal : FormBase
    {
        public static ToolStripMenuItem[] controles = new ToolStripMenuItem[] { };
        public static List<ToolStripMenuItem> allControles = new List<ToolStripMenuItem>();
        public static ToolStrip strip = null;

        public MenuPrincipal()
        {
            InitializeComponent();
        }


        private void FormBase_Load(object sender, EventArgs e)
        {
            Login.Login login = new Login.Login();
            login.mostrar(this);
            this.menuStrip1.Visible = false;
            controles = new ToolStripMenuItem[] { abmAutomovilToolStripMenuItem, abmChoferToolStripMenuItem, abmClienteToolStripMenuItem, facturacionToolStripMenuItem, listadoEstadisticoToolStripMenuItem,registroDeViajesToolStripMenuItem, rendicionDeViajesToolStripMenuItem, rolToolStripMenuItem, cerrarSesiònToolStripMenuItem, salirToolStripMenuItem };

            foreach (ToolStripMenuItem tool in this.menuStrip1.Items/*Controls.OfType<ToolStripMenuItem>()*/)
                allControles.Add(tool);
            allControles.Remove(cerrarSesiònToolStripMenuItem);
            allControles.Remove(salirToolStripMenuItem);

            strip = this.menuStrip1; 
        }
        private void registroDeViajeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void altaAutomovil_click(object sender, EventArgs e) 
        {
            Abm_Automovil.AltaAutomovil altaAutomovil = new Abm_Automovil.AltaAutomovil();
            altaAutomovil.mostrar(this);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globals.username == "")
            {
                Mensaje_Error("¡Todavía no inicio sesión!", "Inicie una sesión");
                return;
            }
            var mensaje = Mensaje_Pregunta("¿Desea cerrar la sesión actual: " + Globals.username + "?", "Cerrar sesión");
            if (mensaje == DialogResult.No) return;

            Globals.cerrarSesion();
            if (ActiveMdiChild != null) ActiveMdiChild.Close();
            Login.Login login = new Login.Login();
            login.mostrar(this);
            this.menuStrip1.Visible = false;
        }

        private static void hideControls()
        {
            foreach (ToolStripMenuItem control in allControles)
                control.Visible = false;
        }

        public static void showControls()
        {
            strip.Visible = true;
            hideControls();

            for (int i = 0; i < controles.Count(); i++)
            {
                //if (Globals.tieneFuncionalidad(i + 1))
                if(true)
                {
                    controles[i].Visible = true;
                    if (controles[i].OwnerItem != null)
                        controles[i].OwnerItem.Visible = true;
                }
            }
        }
        
    }
}
