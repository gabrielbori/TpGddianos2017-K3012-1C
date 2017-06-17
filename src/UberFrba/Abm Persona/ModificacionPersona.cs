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


namespace UberFrba.Abm_Persona
{
    public partial class ModificacionPersona : FormBase
    {

        private string tipo = "";

        public ModificacionPersona(string tipoF)
        {
            tipo = tipoF;
            InitializeComponent();
        }

        private bool Validaciones()
            {
                string mensaje = "";
                int cont = 0;
                if ((String.IsNullOrEmpty(textBox_Direccion.Text)) || (textBox_Direccion.Text == "")) { mensaje = "La direccion esta vacía"; Mensaje_Error(mensaje); cont++; }
                if ((String.IsNullOrEmpty(textBox_Apellido.Text)) || (textBox_Apellido.Text == "")) { mensaje = "El apellido está vacío"; Mensaje_Error(mensaje); cont++; }
                if ((String.IsNullOrEmpty(textBox_Nombre.Text)) || (textBox_Nombre.Text == "")) { mensaje = "El nombre está vacío"; Mensaje_Error(mensaje); cont++; }
                if ((tipo.Equals("Cliente") & (String.IsNullOrEmpty(textBox_CodigoPostal.Text)) & (textBox_CodigoPostal.Text == ""))) { mensaje = "El codigo postal está vacío"; Mensaje_Error(mensaje); cont++; }
                if ((tipo.Equals("Chofer") & (String.IsNullOrEmpty(textBox_Mail.Text)) & (textBox_Mail.Text == ""))) { mensaje = "El mail está vacío"; Mensaje_Error(mensaje); cont++; }
                if (cont == 0) { return true; } else { return false; }
            }

        private bool ValidarTelefono(int telefono, int dni)
        {
            if (!(DAOPersona.existeTelefono(telefono, dni, tipo)))
            {
                 return false;
            }
            else 
            {
                return true;
            }
        }
        
        private Persona GenerarPersona()
        {
            string codigoPostal = "";

            if (textBox_CodigoPostal.Text != null) { codigoPostal = textBox_CodigoPostal.Text; }


            return new Persona(
                    0,
                    Convert.ToInt32(textBox_Telefono.Text),
                    textBox_Nombre.Text,
                    textBox_Apellido.Text,
                    Convert.ToInt32(textBox_DNI.Text),
                    textBox_Direccion.Text,
                    dateTimePicker_FechaNacimiento.Value,
                    Convert.ToInt32(checkBox_Estado.Checked),
                    textBox_Mail.Text,
                    codigoPostal
                    );
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var resultado = Mensaje_Pregunta("¿Está seguro que desea guardar los datos ingresados en el formulario?", "Modificar Persona");
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    if (textBox_DNI.Text == "") { string mensaje1 = "El dni está vacío"; Mensaje_Error(mensaje1); }
                    int telefono1 = Convert.ToInt32(textBox_Telefono.Text);
                    int dni1 = Convert.ToInt32(textBox_DNI.Text);
                    if ((!ValidarTelefono(telefono1, dni1))) { string mensaje1 = "El telefono ingresado o el dni pertenece a otra persona"; Mensaje_Error(mensaje1); }
                }
                catch { Mensaje_Error("El dni y el telefono son campos de numeros"); return; }

            if (!Validaciones()) return;
            int estadoPerfil = Convert.ToInt32(checkBox_Estado.Checked);
            DAOPersona.ModificarPersona(GenerarPersona(), persona.ID, estadoPerfil, tipo);

            if (!Validaciones(rolTipo)) return;
            int estadoRol = Convert.ToInt32(checkBox_Estado.Checked);
            string codPostal = Convert.ToString(textBox_CodigoPostal.Text);
            DAOPersona.ModificarPersona(GenerarPersona(), persona.ID, rolTipo,estadoRol,codPostal);

            Mensaje_OK("Los datos han sido almacenados con éxito");
            this.Close();
            }
        }

        private void cerrar()
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cerrar();
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

        private void ModificacionPersona_Load(object sender, EventArgs e)
        {

        }
        
    }
}
