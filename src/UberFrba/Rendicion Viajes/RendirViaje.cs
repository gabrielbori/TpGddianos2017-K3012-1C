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

namespace UberFrba.Rendicion_Viajes
{
    public partial class RendirViaje : FormBase
    {
       

        public RendirViaje()
        {
            InitializeComponent();
        }

       

        private void RendirViaje_Load(object sender, EventArgs e)
        {
            DataTable turnos = DAORendicionViaje.getTurnos();

            comboBox1.ValueMember = "TURNO_ID";
            comboBox1.DisplayMember = "TURNO_DESCRIPCION";
            comboBox1.DataSource = turnos;
        }

        

        private void textBox_Nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Aceptar_Click(object sender, EventArgs e)
        {
            
           //DAORendicionViaje.crearRendicion(Convert.ToInt32(persona.ID)); 

        }

        private void button_Buscar_Viajes_Click(object sender, EventArgs e)
        {

            if (dateTimePicker1.Value <= DateTime.Today)
            {

                dataGridView_Viajes.DataSource = DAORendicionViaje.getViajes(Convert.ToInt32(persona.ID), Convert.ToDateTime(dateTimePicker1.Value), Convert.ToInt32(comboBox1.SelectedValue) );
                this.dataGridView_Viajes.Columns["ID"].Visible = false;
                setTotal();

            }
            else
            {
                Mensaje_Error("La fecha no puede ser a futuro");
                return;
            }

        }

        private void setTotal()
        {
            double total = 0;
            foreach (DataGridViewRow row in dataGridView_Viajes.Rows)
            {
                total += Convert.ToDouble(row.Cells["Precio Unitario"].Value);
            }

            textBox_montoTotal.Text = total.ToString();
        }

        private void button_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Text = Convert.ToString(DateTime.Today);
            dataGridView_Viajes.DataSource = new DataTable();
            textBox_montoTotal.Text = "";
            textBox_Nombre.Text = "";
            textBox_Apellido.Text = "";
            textBox_DNI.Text = "";
                      
        
        }

        private void button_Buscar_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Text = Convert.ToString(DateTime.Today);
            dataGridView_Viajes.DataSource = new DataTable();
            textBox_montoTotal.Text = "";
            textBox_Nombre.Text = "";
            textBox_Apellido.Text = "";
            textBox_DNI.Text = "";

            SeleccionDePersona frm = new SeleccionDePersona(this, 2);
            frm.Show();
        }


        
       
    }
}
