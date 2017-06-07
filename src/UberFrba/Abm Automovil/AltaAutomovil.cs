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
            DataTable marcas = DAOAutomovil.getMarcas();
            comboBox_Marca.DisplayMember = "MARCA_NOMBRE";
            comboBox_Marca.DataSource = marcas;
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
            if (DAOAutomovil.choferAsignado(chofer, patente)) { Mensaje_Error("El chofer ya posee automovil"); return false; }
            if (Turno.CheckedItems.Count == 0) { Mensaje_Error("No se ha/n seleccionado turno/s"); return false; }
            return true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var resultado = Mensaje_Pregunta("¿Está seguro que desea dar la alta del automovil?", "Alta Automovil");
            if (resultado == DialogResult.Yes)
            {
            string marca = comboBox_Marca.Text;
            string modelo = comboBox_Modelo.Text;
            string patente = textBox_Patente.Text;
            string chofer = textBox_Chofer.Text;
            int estado = 1;

            if (!(ValidarAutomovil(marca, modelo, patente, chofer))) { Mensaje_Error("Error al generar la alta"); }
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
                row = ((DataRowView)this.Turno.Items[cont]).Row;
                string detalle = (row[this.Turno.ValueMember]).ToString();
                DAOAutomovil.modificarTurnoAutomovilPorPatente(patente, detalle, estadoTurno);
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


    }
}
