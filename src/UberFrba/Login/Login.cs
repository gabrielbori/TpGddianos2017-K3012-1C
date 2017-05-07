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
using UberFrba.CapaDAO;


namespace UberFrba.Login
{
    public partial class Login : FormBase
    {
        public Login()
        {
            InitializeComponent();
        }


        private void Cerrar_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void IniciarSesion_Click(object sender, EventArgs e)
        {
           
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button_Cerrar_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
