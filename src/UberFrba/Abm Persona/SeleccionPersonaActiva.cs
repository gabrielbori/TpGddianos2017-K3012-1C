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
    public partial class SeleccionPersonaActiva : FormBase
    {

        private FormBase caller;
        private int tipoAmbos = 1, tipoPersona = 0;
        string nombre, apellido, doc;

         public SeleccionPersonaActiva(FormBase caller, int tipoS2)
        {
            this.caller = caller;
            tipoPersona = tipoS2;
            InitializeComponent();
        }

        public SeleccionPersonaActiva()
        {
            InitializeComponent();
        }

        private void button_Buscar_Click(object sender, EventArgs e)
        {
            nombre = textBox_Nombre.Text;
            apellido = textBox_Apellido.Text;
            doc = textBox_Documento.Text;

            dataGridView_Seleccion.DataSource = DAOPersona.getPersonaActiva(nombre, apellido, doc, tipoPersona, tipoAmbos);
        }

        private void dataGridView_Seleccion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > 0 || e.RowIndex < 0) return;
            int id = Convert.ToInt32(dataGridView_Seleccion.Rows[e.RowIndex].Cells[1].Value);
            DataTable table = DAOPersona.getPersona(id);
            Persona persona = DAOPersona.dataRowToPersona(table.Rows[0]);
            
                nombre = persona.Nombre + ' ' + persona.Apellido;
                caller.mostrar(this.MdiParent, persona);
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

        private void LimpiarCampos()
        {
            foreach (var control in this.paner_Filtros.Controls.OfType<TextBox>()) control.Text = "";
            dataGridView_Seleccion.DataSource = new DataTable();
        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
