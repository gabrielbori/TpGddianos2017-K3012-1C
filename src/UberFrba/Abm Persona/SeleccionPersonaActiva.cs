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
using UberFrba.Registro_Viajes;
using UberFrba.CapaDAO;
using UberFrba.Abm_Automovil;

namespace UberFrba.Abm_Persona
{
    public partial class SeleccionPersonaActiva : FormBase
    {

        private FormBase caller;
        
        private int tipoAmbos = 1, tipoPersona = 0;
        string nombre, apellido, doc;
        private int abm = 0;
        private RegistrarViaje otro;
        private AltaAutomovil altaAutomovil;
        private ModificacionAutomovil modificacionAutomovil;

       

        


         public SeleccionPersonaActiva(FormBase caller, int tipoS2)
        {
            this.caller = caller;
            caller.Hide();
             tipoPersona = tipoS2;
            InitializeComponent();
        }

         public SeleccionPersonaActiva(RegistrarViaje caller, int tipoS2, int id) //para que sepa que es registro registro de viaje chofer=1 registro de viaje cliente=2 , abm automovil seleccionarChofer=3
         {
             this.otro = caller;
             otro.Hide();
             tipoPersona = tipoS2;
             abm = id;
             InitializeComponent();
         }

         public SeleccionPersonaActiva(AltaAutomovil caller, int tipoS2, int id) // abm automovil seleccionarChofer=3
         {
             this.altaAutomovil = caller;
             altaAutomovil.Hide();
             tipoPersona = tipoS2;
             abm = id;
             InitializeComponent();
         }

         public SeleccionPersonaActiva(ModificacionAutomovil caller, int tipoS2, int id) // abm automovil seleccionarChofer=4
         {
             caller.Hide();
             this.modificacionAutomovil = caller;
             tipoPersona = tipoS2;
             abm = id;
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
                       

                if (abm == 1) //SI VIENE DE REGISTRAR VIAJE EL ABM ES 1 Y HACE ESTO
                {                    
                    otro.setnombreChofer = persona.Nombre;
                    otro.setapellidoChofer = persona.Apellido;
                    otro.setndniChofer = persona.Dni.ToString();
                    otro.Show();
                    //fm.Show();
                    cerrar();
                } else
                if (abm == 2)
                {
                    otro.setnombreCliente = persona.Nombre;
                    otro.setapellidoCliente = persona.Apellido;
                    otro.setndniCliente = persona.Dni.ToString();
                    cerrar();
                    otro.Show();
                }
                else
                if (abm == 3)
                {   
                    altaAutomovil.settextBox_Chofer_dni = persona.Dni.ToString();
                    altaAutomovil.settextBox_Chofer = persona.Nombre + ' ' + persona.Apellido;
                    cerrar();
                    altaAutomovil.Show();
                } else
                 if (abm == 4)
                 {
                     modificacionAutomovil.settextBox_Chofer_dni = persona.Dni.ToString();
                     modificacionAutomovil.settextBox_Chofer = persona.Nombre + ' ' + persona.Apellido;
                     cerrar();
                     modificacionAutomovil.Show();
                 } else
                {
                    nombre = persona.Nombre + ' ' + persona.Apellido;
                    caller.mostrar(this.MdiParent, persona);
                    cerrar();
                    caller.Show();
                }
            
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

        private void SeleccionPersonaActiva_Load(object sender, EventArgs e)
        {
            dataGridView_Seleccion.DataSource = DAOPersona.getPersonaActiva(nombre, apellido, doc, tipoPersona, tipoAmbos);
        }

        private void paner_Filtros_Enter(object sender, EventArgs e)
        {

        }
    }
}
