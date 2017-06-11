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

namespace UberFrba.Listado_Estadistico
{
    public partial class ListadoEstadistico : FormBase
    {
        string[] listado = new string[4];
        int idConsulta = 1;

        public ListadoEstadistico()
        {
            InitializeComponent();
        }

        private void ListadoEstadistico_Load(object sender, EventArgs e)
        {
            listado[0] = "Choferes con mayor recaudación";
            listado[1] = "Choferes con el viaje más largo realizado";
            listado[2] = "Clientes con mayor consumo";
            listado[3] = "Cliente que utilizó mas veces el mismo automovil";

            comboBox_Listado.DataSource = listado;
            
            if (String.Equals(Convert.ToString(comboBox_Listado.SelectedValue),listado[0])) { comboBox_Campo.DataSource = DAOListadoEstadistico.getCampos("Chofer", "Recaudacion"); }

            comboBoxTrimestre.SelectedItem = "1";
        }

        private void comboBox_Listado_SelectedValueChanged(object sender, EventArgs e)
        {
            if (String.Equals(Convert.ToString(comboBox_Listado.SelectedValue), listado[0])) { comboBox_Campo.DataSource = DAOListadoEstadistico.getCampos("Chofer", "Recaudacion"); idConsulta = 1; }
            if (String.Equals(Convert.ToString(comboBox_Listado.SelectedValue), listado[1])) { comboBox_Campo.DataSource = DAOListadoEstadistico.getCampos("Chofer", "Viaje"); idConsulta = 2; }
            if (String.Equals(Convert.ToString(comboBox_Listado.SelectedValue), listado[2])) { comboBox_Campo.DataSource = DAOListadoEstadistico.getCampos("Cliente", "Consumo"); idConsulta = 3; }
            if (String.Equals(Convert.ToString(comboBox_Listado.SelectedValue), listado[3])) { comboBox_Campo.DataSource = DAOListadoEstadistico.getCampos("Cliente", "Viaje"); idConsulta = 4; }
            
        }

        private void textBox_Anio_KeyPress(object sender, KeyPressEventArgs e)
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

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBox_Anio.Text = "";
            DataTable lista = (DataTable)dataGridView_Listado.DataSource;
            if (lista != null)
            {
                lista.Rows.Clear();  
            }
          
            
            dataGridView_Listado.DataSource = lista;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_Anio.Text == "") { Mensaje_Error("Inserte año de consulta"); }
            else{
            int orderBy=4;

            if (String.Equals(Convert.ToString(comboBox_Campo.SelectedValue), "Chofer Nombre") | String.Equals(Convert.ToString(comboBox_Campo.SelectedValue), "Cliente Nombre"))
            { orderBy = 1; };
            if (String.Equals(Convert.ToString(comboBox_Campo.SelectedValue), "Chofer Apellido") | String.Equals(Convert.ToString(comboBox_Campo.SelectedValue), "Cliente Apellido"))
            { orderBy = 2; };
            if (String.Equals(Convert.ToString(comboBox_Campo.SelectedValue), "Chofer DNI") | String.Equals(Convert.ToString(comboBox_Campo.SelectedValue), "Cliente DNI"))
            { orderBy = 3; };
            if (String.Equals(Convert.ToString(comboBox_Campo.SelectedValue), "Chofer Recaudacion") | String.Equals(Convert.ToString(comboBox_Campo.SelectedValue), "KM") | String.Equals(Convert.ToString(comboBox_Campo.SelectedValue), "Cliente Consumo") | String.Equals(Convert.ToString(comboBox_Campo.SelectedValue), "Automovil"))
            { orderBy = 4; };
            if (String.Equals(Convert.ToString(comboBox_Campo.SelectedValue), "Cantidad Viajes"))
            { orderBy = 5; }

            dataGridView_Listado.DataSource = DAOListadoEstadistico.showListado(idConsulta, Convert.ToInt32(textBox_Anio.Text), Convert.ToInt32(comboBoxTrimestre.SelectedItem));

            dataGridView_Listado.Sort(dataGridView_Listado.Columns[orderBy-1], ListSortDirection.Descending);
            }   
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}