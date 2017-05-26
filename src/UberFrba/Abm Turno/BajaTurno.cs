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
    public partial class BajaTurno : FormBase
    {
        public BajaTurno()
        {
            InitializeComponent();
            DataTable detalles = DAOTurno.getDetalleTurnos();

            comboBoxDescripcion.DisplayMember = "TURNO_DESCRIPCION";
            comboBoxDescripcion.DataSource = detalles;
        }
        
        private void comboBoxDescripcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable horasInicio = DAOTurno.getHoraInicioTurnos(comboBoxDescripcion.Text);

            comboBoxHoraInicio.DisplayMember = "TURNO_HORA_INICIO";
            comboBoxHoraInicio.DataSource = horasInicio;
        }

        private void comboBoxHoraInicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable horasFin = DAOTurno.getHoraFinTurnos(comboBoxDescripcion.Text);

            comboBoxHoraFin.DisplayMember = "TURNO_HORA_FIN";
            comboBoxHoraFin.DataSource = horasFin;
        }

        private void buttonBaja_Click(object sender, EventArgs e)
        {

            string descripcion = comboBoxDescripcion.Text;
            int hi = Convert.ToInt32(comboBoxHoraInicio.Text);
            int hf = Convert.ToInt32(comboBoxHoraFin.Text);

            var resultado = Mensaje_Pregunta("¿Está seguro que desea dar la baja del turno?", "Baja Turno");
            if (resultado == DialogResult.Yes)
            {
                DAOTurno.bajaTurnoPorDescripcionYHorarios(descripcion, hi, hf);
                Mensaje_OK("El turno fue dado de baja");
                this.Close();
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
