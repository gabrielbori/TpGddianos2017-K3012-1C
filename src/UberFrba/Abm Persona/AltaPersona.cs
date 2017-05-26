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
        private int tipo = 0;

        public AltaPersona(int tipoA)
        {
            tipo = tipoA;
            InitializeComponent();
            if (tipo == 2 ) 
            { 
                this.textBox_CodigoPostal.Enabled = false;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void AltaPersona_Load(object sender, EventArgs e)
        {
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private bool Validaciones()
        {
            string mensaje = "";
            int telefono = Convert.ToInt32(textBox_Telefono.Text);
            int dni = Convert.ToInt32(textBox_DNI.Text);
            if (textBox_Direccion.Text == null) { mensaje = "La direccion esta vacía"; Mensaje_Error(mensaje); return false; }
            if (textBox_Apellido.Text == null) { mensaje = "El apellido está vacío"; Mensaje_Error(mensaje); return false; }
            if (textBox_DNI.Text == null) { mensaje = "El apellido está vacío"; Mensaje_Error(mensaje); return false; }
            if (dateTimePicker_FechaNacimiento.Text == null) { mensaje = "El apellido está vacío"; Mensaje_Error(mensaje); return false; }
            if (ValidarTelefono(telefono, dni)) { mensaje = "El telefono ingresado pertenece a otra persona"; Mensaje_Error(mensaje); return false; }
            if (textBox_Nombre.Text == null) { mensaje = "El apellido está vacío"; Mensaje_Error(mensaje); return false; }
            if (textBox_CodigoPostal.Text == null) { mensaje = "El apellido está vacío"; Mensaje_Error(mensaje); return false; }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var resultado = Mensaje_Pregunta("¿Está seguro que desea dar la alta de la persona al sistema?", "Alta Persona");
            if (resultado == DialogResult.Yes)
            {
                int tipoAmbos = 1;
                int tipoASetear = -1;
                string mensaje;

                try
                {
                    int telefono = Convert.ToInt32(textBox_Telefono.Text);
                    string nombre = textBox_Nombre.Text;
                    string apellido = textBox_Apellido.Text;
                    int dni = Convert.ToInt32(textBox_DNI.Text);
                    string direccion = textBox_Direccion.Text;
                    string mail = textBox_Mail.Text;
                    string codPos = textBox_CodigoPostal.Text;
                    
                    if (!Validaciones()) return;
                    if (!(DAOPersona.existePersona(dni))) //Si NO existe la persona, lo agrego con el tipo de donde viene el formulario. 2=chofer 3=cliente 
                    {
                        //Tipo: Variable que depende de donde viene el formulario (alta de chofer o cliente). Ese mismo tipo se usa para setearlo en la base.  
                        DAOPersona.altaPersona(telefono, nombre, apellido, dni, dateTimePicker_FechaNacimiento.Value, direccion, mail, codPos, tipo);
                        Mensaje_OK("La persona ha sido dada de alta");
                    }
                    else //la persona ya existe en la base de datos. 
                    {
                        if (DAOPersona.getTipo(dni) != tipo)//Si el tipo que quiero insertar es distinto al tipo grabado, lo actualizo a 3
                        {
                            DAOPersona.actualizarPersona(dni, tipoASetear, codPos, tipoAmbos);
                            Mensaje_OK("La persona ya existe, se actualizo la base y ahora es chofer/cliente");
                        }
                        else //Se quiere insertar la misma persona con el mismo tipo. Devuelvo error. 
                        {
                            mensaje = "La persona ya se encuentra ingresada"; Mensaje_Error(mensaje); return;
                        }
                    }
                    this.Close();
                }
                catch { Mensaje_Error("El dni y el telefono son campos de numeros"); }
           }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
