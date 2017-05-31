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

namespace UberFrba.Facturacion
{
    public partial class Facturar : FormBase
    {

        private int idPersona;
        public Facturar()
        {
            InitializeComponent();
        }

        private void Facturar_Load(object sender, EventArgs e)
        {
            
        }

        private void button_Cargar_Persona_Click(object sender, EventArgs e)
        {
            if ((textBox_Nombre.Visible == false) && (textBox_Apellido.Visible == false))
            {
                int dni = Convert.ToInt32(textBox_DNI.Text);
                int telefono = Convert.ToInt32(textBox_Telefono.Text);
                idPersona = DAOFacturacion.getIDPersona(dni, telefono);
                string nombre = DAOFacturacion.getNombrePersona(dni, telefono);
                string apellido = DAOFacturacion.getApellidoPersona(dni, telefono);


                textBox_Nombre.Visible = true;
                textBox_Apellido.Visible = true;
                textBox_Nombre.SelectedText = nombre;
                textBox_Apellido.SelectedText = apellido;

               

            }
            else
            {
                Mensaje_Error("Los datos ya fueron cargados");
                return;
            }
        
        }

        private void button_Buscar_Viajes_Click(object sender, EventArgs e)
        {

            
            if((textBox_Nombre.Visible == false) && (textBox_Apellido.Visible == false))
            {
                Mensaje_Error("Cargue el Cliente");
                return;
               
            }
            if (dateTimePicker_Inicio.Value.Month == dateTimePicker_Fin.Value.Month
                && dateTimePicker_Inicio.Value.Year == dateTimePicker_Fin.Value.Year)
            {

               dataGridView_Viajes.DataSource = DAOFacturacion.getViajes(idPersona, Convert.ToInt32(dateTimePicker_Inicio.Value.Month), Convert.ToInt32(dateTimePicker_Inicio.Value.Year));


            }
            else
            {
                Mensaje_Error("La facturacion debe ser mensual");
                return;
            }
          



        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Fecha_Inicio_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Fecha_Fin_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void groupBox_Viajes_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView_Viajes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {

        }

        private void button_Aceptar_Click(object sender, EventArgs e)
        {

        }

        private void textBox_DNI_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox_Numero_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_Inicio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Nombre_TextChanged_1(object sender, EventArgs e)
        {

        }

        
    }
}
