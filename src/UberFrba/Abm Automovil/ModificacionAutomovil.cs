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

namespace UberFrba.Abm_Automovil
{
    public partial class ModificacionAutomovil : FormBase
    {
        public ModificacionAutomovil()
        {
            InitializeComponent();
            DataTable marcas = DAOAutomovil.getMarcas();

            comboBox_Marca.DisplayMember = "COCHE_MARCA_NOMBRE";
            comboBox_Marca.DataSource = marcas;         
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            DataTable table = DAOAutomovil.getEstadoYChofer(textBox_Patente.Text);
            DataRow row = table.Rows[0];
            int estado = Convert.ToInt32(row["COCHE_ESTADO"]);
            string mostrar = "";
            // string chofer = row["COCHE_CHOFER"] as string;
            if (estado != 1)
            {
                mostrar = "Deshabilitado";
                textBox_Estado.Text = mostrar;
            }
            else
            {
                mostrar = "Habilitado";
                textBox_Estado.Text = mostrar;
                textBox_Estado.Enabled = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox_Marca_SelectedIndexChanged(object sender, EventArgs e)
        {

            DataTable modelos = DAOAutomovil.getModelos(comboBox_Marca.Text);
            comboBox_Modelo.DisplayMember = "COCHE_MODELO_CODIGO";
            comboBox_Modelo.DataSource = modelos;

        }

        private void comboBox_Modelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
