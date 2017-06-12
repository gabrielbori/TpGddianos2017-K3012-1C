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
using UberFrba.Abm_Persona;

namespace UberFrba.Registro_Viajes
{
    public partial class RegistrarViaje : FormBase
    {


        private int choferDoc;


        public RegistrarViaje()
        {
            InitializeComponent();
        }

        private void RegistrarViaje_Load(object sender, EventArgs e)
        {
            TimeSpan time = new TimeSpan(12, 00, 00);
            dateTimePicker2.Value = dateTimePicker2.Value.Date + time;
            dateTimePicker3.Value = dateTimePicker2.Value.Date + time;
            dateTimePicker1.Value = Globals.getDateFechaSistema();
        }               

        private void button_Buscar_Click(object sender, EventArgs e)
        {

            //ABRE EL FORM DE SELECCION DE PERSONA para chofer
            SeleccionPersonaActiva frm = new SeleccionPersonaActiva(this, 2, 1);
            frm.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //ABRE EL FORM DE SELECCION DE PERSONA para cliente
            SeleccionPersonaActiva frm2 = new SeleccionPersonaActiva(this, 3, 2);
            frm2.Show();
           
        }
        private void textBox_DNI_TextChanged(object sender, EventArgs e)
        {
            if (textBox_DNI.Text != "")
            {

                choferDoc = Convert.ToInt32(textBox_DNI.Text);


                DataTable automoviles = DAORegistroViaje.getAutos(choferDoc);

                comboBox1.ValueMember = "COCHE_ESTADO";
                comboBox1.DisplayMember = "COCHE_PATENTE";
                comboBox1.DataSource = automoviles;
            }


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {


            TimeSpan time = new TimeSpan(12, 00, 00);
            dateTimePicker2.Value = dateTimePicker2.Value.Date + time;
            dateTimePicker3.Value = dateTimePicker2.Value.Date + time;
                 
            
        }

        private void RegistrarViaje_Shown(object sender, EventArgs e)
        {

        }

        private void RegistrarViaje_FormClosed(object sender, FormClosedEventArgs e)
        {


        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }



        public string setnombreChofer
        {
            set
            {
                this.textBox_Nombre.Text = value;
            }

        }

        public string setapellidoChofer
        {
            set
            {
                this.textBox_Apellido.Text = value;
            }

        }

        public string setndniChofer
        {
            set
            {
                this.textBox_DNI.Text = value;

            }

        }


        //----
        public string setnombreCliente
        {
            set
            {
                this.textBox_nombre_cliente.Text = value;
            }

        }

        public string setapellidoCliente
        {
            set
            {
                this.textBox_apellido_cliente.Text = value;
            }

        }

        public string setndniCliente
        {
            set
            {
                this.textBox_dni_cliente.Text = value;
            }

        }



        private void limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            
            foreach (var control in this.groupBox3.Controls.OfType<ComboBox>()) control.Text = "";
            foreach (var control in this.groupBox5.Controls.OfType<TextBox>()) control.Text = "";
            foreach (var control in this.groupBox6.Controls.OfType<TextBox>()) control.Text = "";
            textBox3.Text = "";
            dateTimePicker1.Value = Globals.getDateFechaSistema();
            dateTimePicker2.Value = Globals.getDateFechaSistema();
            dateTimePicker3.Value = Globals.getDateFechaSistema();
            
            TimeSpan time = new TimeSpan(12, 00, 00);
            dateTimePicker2.Value = dateTimePicker2.Value.Date + time;
            dateTimePicker3.Value = dateTimePicker2.Value.Date + time;

            
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guardar_Click(object sender, EventArgs e)
        {

            if (Validaciones())
            {
                Mensaje_Error("No están todos los datos obligatorios");
                return;
            }
            if (textBox3.Text != "" && Convert.ToDecimal(textBox3.Text) == 0)
            {
                Mensaje_Error("Los kilometros no pueden ser cero");
                return;
            }
            if (dateTimePicker1.Value > Globals.getDateFechaSistema()) 
            {
                Mensaje_Error("No se puede registrar un viaje con fecha futura");
                return;
            }
            if(Convert.ToDateTime(dateTimePicker2.Value) == Convert.ToDateTime(dateTimePicker3.Value) )
            {
                Mensaje_Error("La hora de inicio no puede ser igual a la hora final");
                return;
            }
            if (Convert.ToDateTime(dateTimePicker3.Value) < Convert.ToDateTime(dateTimePicker2.Value))
            {
                Mensaje_Error("La hora final no puede ser menor a la hora de inicio");
                return;
            }

            if (DAORegistroViaje.validarTurno(Convert.ToInt32(dateTimePicker2.Value.Hour), Convert.ToInt32(dateTimePicker3.Value.Hour), Convert.ToInt32(comboBox2.SelectedValue))==1)
            {
                Mensaje_Error("La hora ingresada no corresponde al turno asignado");
                return;
            }

            if (DAORegistroViaje.viajeYaRegistrado(Convert.ToDateTime(dateTimePicker1.Value),
                                  Convert.ToDateTime(dateTimePicker2.Value), Convert.ToDateTime(dateTimePicker3.Value),                             
                                  Convert.ToInt32(textBox_DNI.Text)) == 0)
            { Mensaje_Error("El viaje ya fue registrado"); }
            else
            {

                var resultado = Mensaje_Pregunta("¿Está seguro que desea registrar el viaje ingresado?", "Registro viaje");
                if (resultado == DialogResult.Yes)
                {

                    try
                    {                           //turno,  fecha,  horaI, horaF, km,  chofer,  cliente
                        DAORegistroViaje.registrarViaje(Convert.ToInt32(comboBox2.SelectedValue),
                                                        Convert.ToDateTime(dateTimePicker1.Value),
                                                        Convert.ToDateTime(dateTimePicker2.Value),
                                                        Convert.ToDateTime(dateTimePicker3.Value),  
                                                        Convert.ToDecimal(textBox3.Text),
                                                        Convert.ToInt32(textBox_DNI.Text),
                                                        Convert.ToInt32(textBox_dni_cliente.Text));

                        Mensaje_OK("Los datos han sido actualizados con éxito");
                        this.Close();
                    }
                    catch
                    {
                        Mensaje_Error("Falló la modificación del rol en la base de datos");
                    }
                }
            }        

        }

        private bool Validaciones()
        {
            bool vacio = false;
            if (textBox_Nombre.Text == "" || textBox_nombre_cliente.Text == "" || textBox3.Text == "")
            {
                vacio = true;
            }


            return vacio;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            DataTable turnos = DAORegistroViaje.getTurnosAuto(Convert.ToString(comboBox1.Text));
                        
            comboBox2.ValueMember = "TURNO_TURNO_ID";
            comboBox2.DisplayMember = "TURNO_DESCRIPCION";
            comboBox2.DataSource = turnos;

        }


        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
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
            else if (Char.IsPunctuation(e.KeyChar))
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
