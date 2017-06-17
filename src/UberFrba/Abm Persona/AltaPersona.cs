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
using UberFrba.Abm_Persona;
using UberFrba.CapaDAO;

namespace UberFrba.Abm_Persona
{
    public partial class AltaPersona : FormBase
    {
        private string tipo = "";
        private string tipoOpuesto = "";

        public AltaPersona(string tipoF)
        {
            tipo = tipoF;
            InitializeComponent();
            if (tipo.Equals("Chofer"))
            {
                this.textBox_CodigoPostal.Enabled = false;
                tipoOpuesto = "Ciente";
            }
            else
            {
                tipoOpuesto = "Chofer";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidarTelefono(int telefono, int dni)
        {
            if ((DAOPersona.existeTelefono(telefono, dni, tipo)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool Validaciones(string tipo)
        {
            string mensaje = "";
            int cont = 0;
            if ((String.IsNullOrEmpty(textBox_Direccion.Text)) || (textBox_Direccion.Text == "")) { mensaje = "La direccion esta vacía"; Mensaje_Error(mensaje); cont++; }
            if ((String.IsNullOrEmpty(textBox_Apellido.Text)) || (textBox_Apellido.Text == "")) { mensaje = "El apellido está vacío"; Mensaje_Error(mensaje); cont++; }
            if ((String.IsNullOrEmpty(textBox_Nombre.Text)) || (textBox_Nombre.Text == "")) { mensaje = "El nombre está vacío"; Mensaje_Error(mensaje); cont++; }
            if ((tipo.Equals("Cliente")) & (String.IsNullOrEmpty(textBox_CodigoPostal.Text)) & (textBox_CodigoPostal.Text == "")) { mensaje = "El codigo postal está vacío"; Mensaje_Error(mensaje); cont++; }
            if ((tipo.Equals("Chofer")) & (String.IsNullOrEmpty(textBox_Mail.Text)) & (textBox_Mail.Text == "")) { mensaje = "El mail está vacío"; Mensaje_Error(mensaje); cont++; }
            if (cont == 0) { return true; } else { return false; }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var resultado = Mensaje_Pregunta("¿Está seguro que desea dar la alta de la persona al sistema?", "Alta Persona");
            if (resultado == DialogResult.Yes)
            {

                try
                {
                    if (textBox_DNI.Text == "") { string mensaje1 = "El dni está vacío"; Mensaje_Error(mensaje1);}
                    if (textBox_Telefono.Text == "") { string mensaje1 = "El telefono está vacío"; Mensaje_Error(mensaje1);}
                    int telefono1 = Convert.ToInt32(textBox_Telefono.Text);
                    int dni1 = Convert.ToInt32(textBox_DNI.Text);
                    if (!(ValidarTelefono(telefono1, dni1))) { string mensaje1 = "El telefono ingresado o el dni pertenece a otra persona"; Mensaje_Error(mensaje1);}
                }
                catch { Mensaje_Error("El dni y el telefono son campos de numeros"); return; }

                string mensaje;
                int telefono = Convert.ToInt32(textBox_Telefono.Text);
                int dni = Convert.ToInt32(textBox_DNI.Text);
                string nombre = textBox_Nombre.Text;
                string apellido = textBox_Apellido.Text;
                string direccion = textBox_Direccion.Text;
                string mail = textBox_Mail.Text;
                string codPos = textBox_CodigoPostal.Text;

                if (!Validaciones(tipo)) { return; };
                if (DAOPersona.existePersona(dni, tipo)) //Si existe la persona, devuelve un errr 
                {
                    mensaje = "La persona ya se encuentraba ingresada"; Mensaje_Error(mensaje); return;
                }
                else if (!(DAOPersona.existePersona(dni, tipoOpuesto)))
                {
                    //Tipo: Variable que depende de donde viene el formulario (alta de chofer o cliente).
                    //Ese mismo tipo se usa para saber que tipo de persona se dará de alta en la BD.  
                    DAOPersona.altaPersona(telefono, nombre, apellido, dni, dateTimePicker_FechaNacimiento.Value, direccion, mail, codPos, tipo);
                    Mensaje_OK("La persona ha sido dada de alta");
                }
                else //la persona ya existe en la base de datos, pero con otro rol. 
                {
                    DAOPersona.actuaizarTipoPersona(telefono, codPos, tipo);
                    mensaje = "La persona ya se encuentraba ingresada, se le agregó el nuevo perfil"; Mensaje_OK(mensaje); return;
                }
            
                this.Close();
            }
        }

        private void textBox_DNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox_Telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox_CodigoPostal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

    }
}
