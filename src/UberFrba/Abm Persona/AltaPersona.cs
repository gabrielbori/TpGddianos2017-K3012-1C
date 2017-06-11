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
        private int tipoA = 1;

        public AltaPersona(int tipoF)
        {
            tipo = tipoF;
            InitializeComponent();
            if (tipo == 2 ) 
            { 
                this.textBox_CodigoPostal.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidarTelefono(int telefono, int dni)
        {
            if ((DAOPersona.existeTelefono(telefono, dni)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool Validaciones(int tipo)
        {
            string mensaje = "";
            int tipoCliente = 3;
            int cont = 0;
            if ((String.IsNullOrEmpty(textBox_Direccion.Text)) || (textBox_Direccion.Text == "")) { mensaje = "La direccion esta vacía"; Mensaje_Error(mensaje); cont++; }
            if ((String.IsNullOrEmpty(textBox_Apellido.Text)) || (textBox_Apellido.Text == "")) { mensaje = "El apellido está vacío"; Mensaje_Error(mensaje); cont++; }
            if ((String.IsNullOrEmpty(textBox_Nombre.Text)) || (textBox_Nombre.Text == "")) { mensaje = "El nombre está vacío"; Mensaje_Error(mensaje); cont++; }
            if ((tipo == tipoCliente) & (String.IsNullOrEmpty(textBox_CodigoPostal.Text)) & (textBox_CodigoPostal.Text == "")) { mensaje = "El codigo postal está vacío"; Mensaje_Error(mensaje); cont++; }
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
                    if (ValidarTelefono(telefono1, dni1)) { string mensaje1 = "El telefono ingresado o el dni pertenece a otra persona"; Mensaje_Error(mensaje1);}
                }
                catch { Mensaje_Error("El dni y el telefono son campos de numeros"); return; }

                int tipoAmbos = 1;
                string mensaje;
                int telefono = Convert.ToInt32(textBox_Telefono.Text);
                int dni = Convert.ToInt32(textBox_DNI.Text);
                string nombre = textBox_Nombre.Text;
                string apellido = textBox_Apellido.Text;
                string direccion = textBox_Direccion.Text;
                string mail = textBox_Mail.Text;
                string codPos = textBox_CodigoPostal.Text;

                if (!Validaciones(tipo)) { return; };
                if (!(DAOPersona.existePersona(dni))) //Si NO existe la persona, lo agrego con el tipo de donde viene el formulario. 2=chofer 3=cliente 
                {
                    //Tipo: Variable que depende de donde viene el formulario (alta de chofer o cliente). Ese mismo tipo se usa para setearlo en la base.  
                    DAOPersona.altaPersona(telefono, nombre, apellido, dni, dateTimePicker_FechaNacimiento.Value, direccion, mail, codPos, tipo);
                    Mensaje_OK("La persona ha sido dada de alta");
                }
                else //la persona ya existe en la base de datos. 
                {
                    if (DAOPersona.getTipo(dni) == tipoA)//Si el tipo que quiero insertar es distinto al tipo grabado, lo actualizo a 3
                    {
                        mensaje = "La persona ya se encuentra ingresada"; Mensaje_Error(mensaje); return;
                    }
                    else //Se quiere insertar la misma persona con el mismo tipo. Devuelvo error. 
                    {
                        if (DAOPersona.getTipo(dni) == tipo)
                        {
                            mensaje = "La persona ya se encuentra ingresada"; Mensaje_Error(mensaje); return;
                        }
                        else
                        {
                            DAOPersona.actualizarPersona(dni, tipoAmbos, codPos, tipo);
                            Mensaje_OK("La persona ya existe, se actualizo la base y ahora es chofer/cliente");
                        }
                    }
                }
                this.Close();
            }
        }

    }
}
