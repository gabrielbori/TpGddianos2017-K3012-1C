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

namespace UberFrba.Abm_Automovil
{
    
    public partial class AltaAutomovil : FormBase
    {
        public AltaAutomovil()
        {
            InitializeComponent();
            DataTable marcas = DAOAutomovil.getMarcas();
            comboBox_Marca.DisplayMember = "MARCA_NOMBRE";
            comboBox_Marca.DataSource = marcas;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidarAutomovil(string patente, int chofer)
        {
            int cont = 0;
            if ((String.IsNullOrEmpty(patente)) || (patente == "")) { Mensaje_Error("Patente del automovil vacia"); cont++;}
            if (DAOAutomovil.validarPatente(patente)) { Mensaje_Error("La patente ya existe"); cont++; }
            if (DAOAutomovil.choferAsignado(chofer, patente)) { Mensaje_Error("El chofer ya posee automovil"); cont++; }
            if (Turno.CheckedItems.Count == 0) { Mensaje_Error("No se ha/n seleccionado turno/s"); cont++; }
            if (cont == 0) { return true; } else { return false; }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var resultado = Mensaje_Pregunta("¿Está seguro que desea dar la alta del automovil?", "Alta Automovil");
            if (resultado == DialogResult.Yes)
            {
            string marca = comboBox_Marca.Text;
            string modelo = comboBox_Modelo.Text;
            string patente = textBox_Patente.Text;
            int chofer = Convert.ToInt32(textBox_chofer_dni.Text);
            int estado = 1;

            if (!(ValidarAutomovil(patente, chofer))) {return; }
                else
                {
                DAOAutomovil.altaAutomovil(marca, modelo, patente,chofer,estado);
                this.actualizarTurnosAutomovil(patente);
                Mensaje_OK("El automovil fue dado de alta");
                this.Close();
                }
            }
        }

        private void actualizarTurnosAutomovil(string patente)
        {
            DataRow row;
            int cont;
            for (cont = 0; cont < Turno.Items.Count; cont++)
            {
                int estadoTurno = Convert.ToInt32(Turno.GetItemChecked(cont));
                if (estadoTurno == 1)
                {
                    row = ((DataRowView)this.Turno.Items[cont]).Row;
                    string detalle = (row[this.Turno.ValueMember]).ToString();
                    DAOAutomovil.ingresarTurnoAutomovilPorPatente(patente, detalle);
                }
            }
        }

        private void comboBox_Marca_SelectedIndexChanged(object sender, EventArgs e)
        {

            DataTable modelos = DAOAutomovil.getModelos(comboBox_Marca.Text);
            comboBox_Modelo.DisplayMember = "COCHE_MODELO_CODIGO";
            comboBox_Modelo.DataSource = modelos;
            Turno.DataSource = DAOTurno.getTurnoDescripcionHabilitado();
            Turno.ValueMember = "TURNO_DESCRIPCION";

        }

        private void button_buscar_chofer_Click(object sender, EventArgs e)
        {
            Abm_Persona.SeleccionPersonaActiva seleccionarPersonaActiva = new Abm_Persona.SeleccionPersonaActiva(this,"Chofer",3);
            seleccionarPersonaActiva.Show();
        }

        private void AltaAutomovil_Load(object sender, EventArgs e)
        {

        }

        public string settextBox_Chofer
        {
            set
            {
                this.textBox_Chofer.Text = value;
            }

        }

         public string settextBox_Chofer_dni
        {
            set
            {
                this.textBox_chofer_dni.Text = value;
            }

        }

         private void textBox_chofer_dni_KeyPress(object sender, KeyPressEventArgs e)
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
             else
             {
                 e.Handled = true;
             }
         }
        
    }
}
