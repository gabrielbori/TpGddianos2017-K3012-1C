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

namespace UberFrba.Abm_Turno
{
    public partial class ModificacionSeleccionTurno : FormBase
    {

        private FormBase caller;
        string descripcion;
        int idTurno;
        

        public ModificacionSeleccionTurno()
        {
            InitializeComponent();
        }

        private void paner_Filtros_Enter(object sender, EventArgs e)
        {

        }

        private void button_Buscar_Click(object sender, EventArgs e)
        {
            descripcion = textBoxDescripcion.Text;
            
            dataGridView_Seleccion.DataSource = DAOTurno.getTurnoDescripcion(descripcion);
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

        private void cerrar()
        {
            this.Close();
        }

        private void dataGridView_Seleccion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > 0 || e.RowIndex < 0) return;
            int id = Convert.ToInt32(dataGridView_Seleccion.Rows[e.RowIndex].Cells[1].Value);
            idTurno = id;
            DataTable table = DAOTurno.getTurnoPorId(id);
            Turno turno = DAOTurno.dataRowToTurno(table.Rows[0]);
            caller.mostrar(this.MdiParent, turno);
            cerrar();
            
        }

    }
}
