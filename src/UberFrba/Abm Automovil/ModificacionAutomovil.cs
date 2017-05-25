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

            comboBoxMarca.DisplayMember = "COCHE_MARCA_NOMBRE";
            comboBoxMarca.DataSource = marcas;

            textBoxChofer.Visible = false;
            checkBoxEstado.Visible = false;
            label5.Visible = false;
            label7.Visible = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private bool ValidarChofer(/*, string chofer*/)
        {
//            if (chofer == null) Mensaje_Errr("El chofer se encuentra vacio"); return false;
//            if (choferAsignado(chofer) Mensaje_Error ("El chofer ya posee auto"); return false;
            return true;
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {

            string patente = comboBoxPatente.Text;
            int estado = Convert.ToInt32(checkBoxEstado.Checked);
//            string chofer = textBoxChofer.Text;

            var resultado = Mensaje_Pregunta("¿Está seguro que desea modificar el automovil?", "Modificar Automovil");
            if (resultado == DialogResult.Yes)
            {
                if (!ValidarChofer(/*, chofer*/)) { Mensaje_Error("Modificacion no valida"); Close(); }
                DAOAutomovil.modificarAutomovilPorPatente(patente, estado /*,chofer*/ );
                Mensaje_OK("El automovil fue modificado");
                this.Close();
            }
        }

        private void textBoxChofer_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSeleccionar_Click(object sender, EventArgs e)
        {
            DataTable table = DAOAutomovil.getEstadoYChofer(comboBoxPatente.Text);
            try
            {
                DataRow row = table.Rows[0];
                textBoxChofer.Visible = true;
                checkBoxEstado.Visible = true;
                label5.Visible = true;
                label7.Visible = true;
                int estado = Convert.ToInt32(row["COCHE_ESTADO"]);
                // string chofer = row["COCHE_CHOFER"] as string;
                // textoBox_Chofer = chofer;
                if (estado == 1)
                {
                    checkBoxEstado.Visible = false;
                    label7.Visible = false;
                    textBoxChofer.Enabled = true;
                }
                else
                {
                    checkBoxEstado.Visible = true;
                    label7.Visible = true;
                    textBoxChofer.Enabled = false;
                }
                    buttonAceptar.Visible = true;
                    
            }catch{Mensaje_Error("El automovil ingresado no existe");}
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

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox_Marca_SelectedIndexChanged(object sender, EventArgs e)
        {

            DataTable modelos = DAOAutomovil.getModelos(comboBoxMarca.Text);
            comboBoxModelo.DisplayMember = "COCHE_MODELO_CODIGO";
            comboBoxModelo.DataSource = modelos;

        }

        private void comboBox_Modelo_SelectedIndexChanged(object sender, EventArgs e)
        {

            DataTable patentes = DAOAutomovil.getPatentes(comboBoxModelo.Text);
            comboBoxPatente.DisplayMember = "COCHE_PATENTE";
            comboBoxPatente.DataSource = patentes;

        }

        private void ModificacionAutomovil_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxPatente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
