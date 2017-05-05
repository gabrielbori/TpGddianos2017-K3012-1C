using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UberFrba.Model;

namespace UberFrba.Login
{
    public partial class Login : FormBase
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button_Cerrar_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MenuPrincipal.showControls();
            this.Close();
        }
    }
}
