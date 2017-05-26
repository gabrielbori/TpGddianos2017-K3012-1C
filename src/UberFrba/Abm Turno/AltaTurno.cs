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
    public partial class AltaTurno : FormBase
    {
        public AltaTurno()
        {
            InitializeComponent();
        }

        private void AltaTurno_Load(object sender, EventArgs e)
        {

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool validaciones(string descripcion, int hi, int hf, int valor, int precio)
        {
            if (descripcion == null) { Mensaje_Error("La descripcion se encuentra vacia"); return false; }
            if (hi == null) { Mensaje_Error("La descripcion se encuentra vacia"); return false; }
            if (hf == null) { Mensaje_Error("La descripcion se encuentra vacia"); return false; }
            if (hi >= hf) { Mensaje_Error("La hora de inicio es mayor que la hora de fin "); return false; }
            if (valor == null) { Mensaje_Error("La descripcion se encuentra vacia"); return false; }
            if (precio == null) { Mensaje_Error("La descripcion se encuentra vacia"); return false; }
            return true;
        }


        private void Alta_Click(object sender, EventArgs e)
        {

            string descripcion = TextBoxDescripcion.Text;
            int hi = Convert.ToInt32(TextBoxHoraInicio.Text); 
            int hf = Convert.ToInt32(TextBoxHoraFin.Text);
            int valor = Convert.ToInt32(TextBoxValorKM.Text);
            int pb = Convert.ToInt32(TextBoxPrecioBase.Text);

            if (!(this.validaciones(descripcion, hi, hf, valor, pb))) { Mensaje_Error("El alta de turno no pudo ser dada"); Close(); }
            DAOTurno.altaTurno(descripcion, hi, hf, valor, pb);
            Mensaje_OK("El turno ha sido dada de alta");

            Close();
        }

    }
}
