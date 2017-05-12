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


        private void Login_Load(object sender, EventArgs e)
        {
            this.ActiveControl = textBox_Username;
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void IniciarSesion_Click(object sender, EventArgs e)
        {
            string user = textBox_Username.Text;
            if (!DAOLogin.existeUsuario(user))
            {
                Mensaje_Error("El usuario no existe");
                return;
               
            }

            if (comboBox_Roles.SelectedIndex == -1)
            {
                Mensaje_Error("No se seleccionó rol");
                return;
            }

           if (DAOLogin.iniciarSesionConPassword(user, Convert.ToInt32(comboBox_Roles.SelectedValue), textBox_password.Text))
            {
               // DAOCuenta.deshabilitarCuentasPorVigencia();
                MenuPrincipal.showControls();
                this.Close();
            }
            else
                Mensaje_Error("Contraseña incorrecta");
           
        }

        private void textBox_Username_TextChanged(object sender, EventArgs e)
        {
            DataTable roles = DAOLogin.getRolesUsuario(textBox_Username.Text);

            comboBox_Roles.ValueMember = "ROL_ID";
            comboBox_Roles.DisplayMember = "ROL_NOMBRE";
            comboBox_Roles.DataSource = roles;
        }

        private void button_Cerrar_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
