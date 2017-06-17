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
using UberFrba.Abm_Persona;
using UberFrba.CapaDAO;

namespace UberFrba.Abm_Persona
{
    public partial class SeleccionDePersona : FormBase
    {
        private FormBase caller;
      

        private string tipoPersona = "";

        string nombre, apellido, doc;

        public SeleccionDePersona(FormBase caller, string tipoS2)
        {
            this.caller = caller;
            tipoPersona = tipoS2;
            InitializeComponent();
        }

        private void button_Buscar_Click(object sender, EventArgs e)
        {
            nombre = textBox_Nombre.Text;
            apellido = textBox_Apellido.Text;
            doc = textBox_Documento.Text;

            dataGridView_Seleccion.DataSource = DAOPersona.getPersona(nombre, apellido, doc, tipoPersona);
        }

        private void dataGridView_Seleccion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > 0 || e.RowIndex < 0) return;
            int id = Convert.ToInt32(dataGridView_Seleccion.Rows[e.RowIndex].Cells[1].Value);
            DataTable table = DAOPersona.getPersona(id);
            Persona persona = DAOPersona.dataRowToPersona(table.Rows[0]);
            string codigoPostal = DAOPersona.getCodigoPostal(persona.ID);
            caller.mostrar(this.MdiParent, persona, codigoPostal, tipoPersona);
            cerrar();
                     
        }

        private void cerrar()
        {
            this.Close();
        }

        private void button_Cerrar_Click(object sender, EventArgs e)
        {
            cerrar();
        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            foreach (var control in this.paner_Filtros.Controls.OfType<TextBox>()) control.Text = "";
            dataGridView_Seleccion.DataSource = new DataTable();
        }

        private void textBox_Documento_KeyPress(object sender, KeyPressEventArgs e)
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
