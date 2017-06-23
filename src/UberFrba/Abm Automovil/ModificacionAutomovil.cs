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
    public partial class ModificacionAutomovil : FormBase
    {

        private int modificacionDeEstado = 0;

        public ModificacionAutomovil()
        {
            InitializeComponent();
            DataTable marcas = DAOAutomovil.getMarcas();

            comboBoxMarca.DisplayMember = "MARCA_NOMBRE";
            comboBoxMarca.DataSource = marcas;
            button_buscar_Chofer.Visible = false;
            textBox_chofer_nombre.Visible = false;
            textBox_chofer_dni.Visible = false;
            checkBoxEstado.Visible = false;
            label8.Visible = false;
            label5.Visible = false;
            label7.Visible = false;

        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {

            string patente = comboBoxPatente.Text;
            int estado = Convert.ToInt32(checkBoxEstado.Checked);
            int chofer = Convert.ToInt32(textBox_chofer_dni.Text);
            string nombre = textBox_chofer_nombre.Text;

            var resultado = Mensaje_Pregunta("¿Está seguro que desea modificar el automovil?", "Modificar Automovil");
            if (resultado == DialogResult.Yes)
            {
                if (modificacionDeEstado == 0)
                {
                    if (Turno.CheckedItems.Count == 0) { Mensaje_Error("No se ha/n seleccionado turno/s"); return; }
                }
                if (DAOAutomovil.choferAsignado(chofer, patente) == true) { Mensaje_Error("El chofer ya posee auto"); return; }
                if (!(DAOPersona.choferActivo(chofer, nombre))) { Mensaje_Error("El chofer no se encuentra habilitado"); return; }
                else
                {
                    DAOAutomovil.modificarAutomovilPorPatente(patente, estado, chofer);
                    this.actualizarTurnosAutomovil(patente);
                    Mensaje_OK("El automovil fue modificado");
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
                if (estadoTurno == 0)
                {
                    row = ((DataRowView)this.Turno.Items[cont]).Row;
                    string detalle = (row[this.Turno.ValueMember]).ToString();
                    DAOAutomovil.modificarTurnoAutomovilPorPatente(patente, detalle, estadoTurno);
                }
            }

            for (cont = 0; cont < TurnoDeshabilitado.Items.Count; cont++)
            {
                int estadoTurno = Convert.ToInt32(TurnoDeshabilitado.GetItemChecked(cont));
                if (estadoTurno == 1)
                {
                    row = ((DataRowView)this.TurnoDeshabilitado.Items[cont]).Row;
                    string detalle = (row[this.TurnoDeshabilitado.ValueMember]).ToString();
                    DAOAutomovil.modificarTurnoAutomovilPorPatente(patente, detalle, estadoTurno);
                }
            }

        }

        private void cargarTurnosDeshabilitados(DataTable table, int estado)
        {
            int cont = 0;
            TurnoDeshabilitado.DataSource = table;
            try
            {
                DataRow row = table.Rows[cont];
                while (row != null)
                {
                    TurnoDeshabilitado.ValueMember = "TURNO_DESCRIPCION";
                    TurnoDeshabilitado.SetItemChecked(cont, Convert.ToBoolean(estado));
                    cont++;
                    try { row = table.Rows[cont]; }
                    catch { row = null; }
                }
            }catch
            { Mensaje_OK("No existen turnos a asignar");}
        }

        private void cargarTurnosHabilitados(DataTable table, int estado)
        {
            int cont = 0;
            Turno.DataSource = table;
            try
            {
            DataRow row = table.Rows[cont];
            while (row != null)
            {
                Turno.ValueMember = "TURNO_DESCRIPCION";
                Turno.SetItemChecked(cont, Convert.ToBoolean(estado));
                cont++;
                try { row = table.Rows[cont]; }
                catch { row = null; }
            }
            }
            catch
            { Mensaje_OK("No existen turnos asignados"); }
        }

        private void buttonSeleccionar_Click(object sender, EventArgs e)
        {
            DataTable table = DAOAutomovil.getEstadoYChofer(comboBoxPatente.Text);
                DataRow row = table.Rows[0];
                textBox_chofer_dni.Visible = true;
                checkBoxEstado.Visible = true;
                label5.Visible = true;
                label7.Visible = true;
                int estado = Convert.ToInt32(row["COCHE_ESTADO"]);
                string chofer = row["PERSONA"] as string;
                string dni = Convert.ToString(row["PERS_DNI"]);
                button_buscar_Chofer.Visible = true;
                textBox_chofer_nombre.Visible = true;
                textBox_chofer_dni.Visible = true;
                label8.Visible = true;
                textBox_chofer_nombre.Text = chofer;
                textBox_chofer_nombre.ReadOnly = true;
                textBox_chofer_dni.Text = dni;
                textBox_chofer_dni.ReadOnly = true;           
                if (estado == 1)
                {
                    modificacionDeEstado = 0;
                    checkBoxEstado.Visible = false;
                    label7.Visible = false;
                    textBox_chofer_dni.Enabled = true;
                    checkBoxEstado.Checked = true;
                    labelTurnoHabilitado.Visible = true;
                    Turno.Visible = true;
                    label4.Visible = true;
                    TurnoDeshabilitado.Visible = true;
                    this.cargarTurnosHabilitados(DAOTurno.getTurnoAsignadoACoche(comboBoxPatente.Text), 1);
                    this.cargarTurnosDeshabilitados(DAOTurno.getTurnoNoAsignadoACoche(comboBoxPatente.Text), 0);
                }
                else
                {
                    checkBoxEstado.Visible = true;
                    label7.Visible = true;
                    textBox_chofer_dni.Enabled = false;
                    modificacionDeEstado = 1;
                }
                    buttonAceptar.Visible = true;
                    
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox_Marca_onClick(object sender, EventArgs e)
        {

            DataTable modelos = DAOAutomovil.getModelos(comboBoxMarca.Text);
            comboBoxModelo.DisplayMember = "COCHE_MODELO_CODIGO";
            comboBoxModelo.DataSource = modelos;
        }

        private void comboBox_Modelo_SelectedIndexChanged(object sender, EventArgs e)
        {

            DataTable patentes = DAOAutomovil.getPatentes(comboBoxModelo.Text);
            comboBoxPatente.DisplayMember = "COCHE_PATENTE";
            comboBoxPatente.DataSource = patentes;

        }

        private void button_buscar_Chofer_Click(object sender, EventArgs e)
        {
            Abm_Persona.SeleccionPersonaActiva seleccionarPersonaActiva = new Abm_Persona.SeleccionPersonaActiva(this, "Chofer", 4);
            seleccionarPersonaActiva.Show();
        }

        public string settextBox_Chofer
        {
            set
            {
                this.textBox_chofer_nombre.Text = value;
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
