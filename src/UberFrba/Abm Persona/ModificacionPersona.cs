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

        private int rolTipo = 0;

        public ModificacionPersona(int tipo)
        {
            InitializeComponent();
            rolTipo = tipo;
        }

        private bool Validaciones()
        {
            string mensaje = "";
            int telefono = Convert.ToInt32(textBox_Telefono.Text);
            int dni = Convert.ToInt32(textBox_DNI.Text);
            if (textBox_Direccion.Text == null) { mensaje = "La direccion esta vacía"; Mensaje_Error(mensaje); return false; }
            if (textBox_Apellido.Text == null) { mensaje = "El apellido está vacío"; Mensaje_Error(mensaje); return false; }
            if (textBox_DNI.Text == null) {mensaje = "El apellido está vacío"; Mensaje_Error(mensaje); return false;}
            if (dateTimePicker_FechaNacimiento.Text == null) { mensaje = "El apellido está vacío"; Mensaje_Error(mensaje); return false; }
            if (ValidarTelefono(telefono, dni)) {mensaje = "El telefono ingresado pertenece a otra persona"; Mensaje_Error(mensaje); return false;}
            if (textBox_Nombre.Text == null) {mensaje = "El apellido está vacío"; Mensaje_Error(mensaje); return false;}
            if (textBox_CodigoPostal.Text == null) {mensaje = "El apellido está vacío"; Mensaje_Error(mensaje); return false;}
            return true;
        }

        private bool ValidarTelefono(int telefono, int dni)
        {
            if (!(DAOPersona.existeTelefono(telefono, dni)))
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
                    textBox_CodigoPostal.Text
                    );
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var resultado = Mensaje_Pregunta("¿Está seguro que desea guardar los datos ingresados en el formulario?", "Modificar Persona");
            if (resultado == DialogResult.Yes)
            {
                try
                {
                if (!Validaciones()) return;
                
                    DAOPersona.ModificarPersona(GenerarPersona(), persona.ID, rolTipo);

                    Mensaje_OK("Los datos han sido almacenados con éxito");

                    this.Close();
                }
                catch
                {
                    Mensaje_Error("El dni y el telefono son campos de numeros");
                }
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
        
    }
}
