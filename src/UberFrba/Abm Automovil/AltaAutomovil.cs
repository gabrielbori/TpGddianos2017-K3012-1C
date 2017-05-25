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
    public partial class AltaAutomovil : FormBase
    {
        public AltaAutomovil()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidarAutomovil(string marca, string modelo, string patente, string chofer)
        {
            if (marca == null) { Mensaje_Error("Marca del automovil vacia"); return false; }
            if (modelo == null) { Mensaje_Error("Modelo del automovil vacio"); return false; }
            if (patente == null) { Mensaje_Error("Patente del automovil vacia"); return false; }
            if (chofer == null) { Mensaje_Error("Chofer del automovil vacio"); return false; }
            if (DAOAutomovil.validarPatente(patente)) { Mensaje_Error("La patente ya existe"); return false; }
            if (DAOAutomovil.validarChofer(chofer)) { Mensaje_Error("El chofer ya posee automovil"); return false; }
            return true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var resultado = Mensaje_Pregunta("¿Está seguro que desea dar la baja del automovil?", "Baja Automovil");
            if (resultado == DialogResult.Yes)
            {
            string marca = textBox_Marca.Text;
            string modelo = textBox_Modelo.Text;
            string patente = textBox_Patente.Text;
            string chofer = textBox_Chofer.Text;
            int estado = 1;
            
            if (!(ValidarAutomovil(marca,modelo,patente,chofer))) {Mensaje_Error("Error al generar la alta"); Close();}
            DAOAutomovil.altaAutomovil(marca,modelo,patente,chofer,estado);
            Mensaje_OK("El automovil fue dado de baja");
            this.Close();
            }
        }

        private void textBox_Marca_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox_Modelo_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void TextBox_Patente_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void TextBox_Chofer_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
