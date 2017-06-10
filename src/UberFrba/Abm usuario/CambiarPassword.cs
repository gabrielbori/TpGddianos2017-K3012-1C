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
namespace UberFrba.Abm_usuario
{
    public partial class CambiarPassword : FormBase
    {
        public CambiarPassword()
        {
            InitializeComponent();
        }

        private void CambiarPassword_Load(object sender, EventArgs e)
        {
            textbox_usuario.Text = Globals.username;
            this.ActiveControl = passwordActual;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_aceptar_Click(object sender, EventArgs e)
        {
            
          //public static bool contraseniaCorrecta(string user, string pass)
            if(DAOLogin.contraseniaCorrecta(Globals.username,passwordActual.Text))
            {
                if (nuevaPassword.Text.Equals(repetirNuevaPass.Text))
                {
                    DAOUsuario.cambiarPassword(Globals.username, nuevaPassword.Text);

                    if (DAOLogin.contraseniaCorrecta(Globals.username, nuevaPassword.Text))
                    {
                        Mensaje_OK("Se realizo el cambio de contraseña");
                    }
                    else Mensaje_Error("Error, no se cambio la contraseña");
                    Close();

                }
                else
                {
                    Mensaje_Error("LAS CONTRASEÑAS NUEVAS NO COINCIDEN");  
                }
            } else
            {
                Mensaje_Error("CONTRASEÑA ACTUAL INCORRECTA");
            }
            
        }
    }
}
