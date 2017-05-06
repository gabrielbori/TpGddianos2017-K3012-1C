using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            this.menuStrip1.Visible = false;//Es false. Cuando entra el login correcto, pasa a true y muestra todas las opciones del sistema .

            controles = new ToolStripMenuItem[] {abmClienteToolStripMenuItem1};

            foreach (ToolStripMenuItem tool in this.menuStrip1.Items/*Controls.OfType<ToolStripMenuItem>()*/ )
            allControles.Add(tool);
            //allControles.Remove(cerrarSesion);
            //allControles.Remove(Salir);

            strip = this.menuStrip1;
           
 
        }

        private void abmUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void cerrarSeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void abmRolToolStripMenuItem_Click(object sender, EventArgs e)
        {
      
        }
    }
                                           
}

