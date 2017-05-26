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
    public partial class ModificacionTurno : FormBase
    {
        public ModificacionTurno()
        {
            InitializeComponent();
        }

        private bool validaciones()
        {
            if (TextBoxDescripcion == null) { Mensaje_Error("Descripcion vacía"); return false; }
            if (TextBoxHoraInicio == null) { Mensaje_Error("Hora de inicio vacía"); return false; }
            if (TextBoxHoraInicio == null) { Mensaje_Error("Hora de fin vacía"); return false; }
            if (TextBoxValorKM == null) { Mensaje_Error("Valor del kilometro vacío"); return false; }
            if (TextBoxPrecioBase == null) { Mensaje_Error("Precio base vacío"); return false; }
            if ((Convert.ToInt32(TextBoxHoraInicio.Text) >= 0) && (Convert.ToInt32(TextBoxHoraInicio.Text) < 24)) { Mensaje_Error("Hora de inicio fuera del rango de 24hs"); return false; }
            if ((Convert.ToInt32(TextBoxHoraFin.Text) >= 0) && (Convert.ToInt32(TextBoxHoraFin.Text) < 24)) { Mensaje_Error("Hora de fin fuera del rango de 24hs"); return false; }
            return true;
        }

        private void buttomModificar_Click(object sender, EventArgs e)
        {
            var resultado = Mensaje_Pregunta("¿Está seguro que desea guardar las modificaciones del turno?", "Modificar Turno");
            if (resultado == DialogResult.Yes)
            {
                if (!(this.validaciones())) { Mensaje_Error("Los datos no fueron modificados"); }
                try
                {
                    DAOTurno.modificarTurno(new Turno(0, Convert.ToInt32(TextBoxHoraInicio.Text),
                        Convert.ToInt32(TextBoxHoraFin.Text), TextBoxDescripcion.Text, Convert.ToInt32(TextBoxValorKM.Text)
            , Convert.ToInt32(TextBoxPrecioBase.Text), Convert.ToInt32(checkBoxEstado.Checked)), turno.id);

                    Mensaje_OK("Los datos han sido almacenados con éxito");

                    this.Close();
                }
                catch
                {
                    Mensaje_Error("Falló la modificación del turno en la base de datos");
                }
                
            }
        }
    }
}
