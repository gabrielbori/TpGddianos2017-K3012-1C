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

            controles = new ToolStripMenuItem[] {facturacionToolStripMenuItem, altaToolStripMenuItem, bajaToolStripMenuItem, modificacionToolStripMenuItem, altaToolStripMenuItem1, bajaToolStripMenuItem1, modificacionToolStripMenuItem1, altaToolStripMenuItem2, bajaToolStripMenuItem2, modificacionToolStripMenuItem2, listadoEstadisticoToolStripMenuItem, registroDeViajesToolStripMenuItem, rendicionDeViajesToolStripMenuItem, altaToolStripMenuItem3, bajaToolStripMenuItem3, modificacionToolStripMenuItem3 };

            foreach (ToolStripMenuItem tool in this.menuStrip1.Items/*Controls.OfType<ToolStripMenuItem>()*/)
                allControles.Add(tool);
            allControles.Remove(cerrarSesiònToolStripMenuItem);
            allControles.Remove(salirToolStripMenuItem);
        }
        private void registroDeViajeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
