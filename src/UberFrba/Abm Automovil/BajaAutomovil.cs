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

            comboBox_Marca.DisplayMember = "MARCA_NOMBRE";
            comboBox_Marca.DataSource = marcas;
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
            checkBox_Estado.Enabled = false;
            if (Convert.ToInt32(row["COCHE_ESTADO"]) == 1)
            {
                checkBox_Estado.Checked = true;
                checkBox_Estado.Visible = true;
            }
            else
                checkBox_Estado.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            var resultado = Mensaje_Pregunta("¿Está seguro que desea dar la baja del automovil?", "Baja Automovil");
            if (resultado == DialogResult.Yes)
            {
                string patente = comboBox_Patente.Text;
                DAOAutomovil.bajaAutomovilPorPatente(patente);
                Mensaje_OK("El automovil fue dado de baja");
                this.Close();
            }

        }

        private void BajaAutomovil_Load(object sender, EventArgs e)
        {

        }
    }
}
