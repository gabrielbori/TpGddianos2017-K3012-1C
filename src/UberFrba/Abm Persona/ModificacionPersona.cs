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
        public ModificacionPersona()
        {
            InitializeComponent();
        }

        private void ModificacionPersona_Load(object sender, EventArgs e)
        {

        }

        private void textBox_FechaNac_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

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
                if (!Validaciones()) return;
                try
                {
                    DAOPersona.ModificarPersona(GenerarPersona(), persona.ID, rol.RolId);

                    Mensaje_OK("Los datos han sido almacenados con éxito");

                    this.Close();
                }
                catch (Exception ex)
                {
                    Mensaje_Error("ERROR: " + ex.Message);
                }
            }
        }

        private void textBox_DNI_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void cerrar()
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cerrar();
        }

        private void checkBox_Estado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        
    }
}
