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
            if (TextBoxHoraInicio.Text == "") { Mensaje_Error("Hora de inicio vacía"); return false; }
            if (TextBoxHoraFin.Text == "") { Mensaje_Error("Hora de fin vacía"); return false; }
            if (TextBoxValorKM.Text == "") { Mensaje_Error("Valor del kilometro vacío"); return false; }
            if (TextBoxPrecioBase.Text == "") { Mensaje_Error("Precio base vacío"); return false; }
            try
            {
                if ((Convert.ToDouble(TextBoxValorKM.Text) == 0)) { Mensaje_Error("El valor base es 0");}
                if ((Convert.ToDouble(TextBoxPrecioBase.Text) == 0)) { Mensaje_Error("El precio base es 0");}
                if ((Convert.ToDouble(TextBoxHoraInicio.Text) >= 0) && !(Convert.ToDouble(TextBoxHoraInicio.Text) < 24)) { Mensaje_Error("Hora de inicio fuera del rango de 24hs"); return false; }
                if ((Convert.ToDouble(TextBoxHoraFin.Text) >= 0) && !(Convert.ToDouble(TextBoxHoraFin.Text) < 24)) { Mensaje_Error("Hora de fin fuera del rango de 24hs"); return false; }
            }
            catch
            {
                Mensaje_Error("Los horarios, el precio base y el valor por kilometro, deben ser números");
                return false;
            }
            return true;
        }

        private void buttomModificar_Click(object sender, EventArgs e)
        {
            var resultado = Mensaje_Pregunta("¿Está seguro que desea guardar las modificaciones del turno?", "Modificar Turno");
            if (resultado == DialogResult.Yes)
            {
                if (!(this.validaciones()))
                {
                    Mensaje_Error("Los datos no fueron modificados");
                }
                else
                {
                    int finalizo = DAOTurno.modificarTurno(new Turno(0, Convert.ToInt32(TextBoxHoraInicio.Text),
                            Convert.ToInt32(TextBoxHoraFin.Text), TextBoxDescripcion.Text, Convert.ToInt32(TextBoxValorKM.Text)
                , Convert.ToInt32(TextBoxPrecioBase.Text), Convert.ToInt32(checkBoxEstado.Checked)), turno.id);
                    if (finalizo == 1)
                    {
                        Mensaje_OK("Los datos han sido modificados con éxito");
                        this.Close();
                    }
                    else
                    {
                        Mensaje_Error("Falló la modificación del turno ya que los horarios del turno de alta está superpuesto a algun/os turno/s");
                    }
                }
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
