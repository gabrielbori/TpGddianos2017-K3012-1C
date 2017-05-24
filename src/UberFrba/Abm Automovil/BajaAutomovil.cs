using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UberFrba.CapaDAO;
using UberFrba.Model;

namespace UberFrba.Abm_Automovil
{
    public partial class BajaAutomovil : FormBase
    {
        public BajaAutomovil()
        {
            InitializeComponent();
            DataTable marcas = DAOAutomovil.getMarcas();

            comboBox_Marca.DisplayMember = "COCHE_MARCA_NOMBRE";
            comboBox_Marca.DataSource = marcas;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
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

            DataTable patentes = DAOAutomovil.getPatentes(comboBox_Modelo.Text);
            comboBox_Patente.DisplayMember = "COCHE_PATENTE";
            comboBox_Patente.DataSource = patentes;

        }

        private void comboBox_Patente_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable table = DAOAutomovil.getEstadoYChofer(comboBox_Patente.Text);
            DataRow row = table.Rows[0];
            string mostrar = "";
            int estado = Convert.ToInt32(row["COCHE_ESTADO"]);
            // string chofer = row["COCHE_CHOFER"] as string;
            if (estado == 1)
                mostrar = "Habilitado";
            else
                mostrar = "Deshabilitado";
            textBox_Estado.Text = mostrar;
            // textBox_Chofer.Text = chofer;


        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox_Estado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
