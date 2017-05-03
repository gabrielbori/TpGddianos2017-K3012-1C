using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UberFrba;
namespace UberFrba
{
    public partial class MenuPrincipal : Form
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
        }

        private void abmUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
                                           
}

