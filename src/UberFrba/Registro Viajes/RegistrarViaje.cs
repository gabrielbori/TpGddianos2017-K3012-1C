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

namespace UberFrba.Registro_Viajes
{
    public partial class RegistrarViaje : FormBase
    {
        
        private string choferNombre, choferApellido, clienteNombre, clienteApellido;
        private int choferDoc , clienteDoc ;
        

        
        public RegistrarViaje(Persona persona, int tipo) 
        {
            
            //se fija donde asignar el valor que le llega segun si es chofer o cliente
            if (tipo == 2) 
            { 
                choferNombre = persona.Nombre;
                choferApellido = persona.Apellido;
                choferDoc = persona.Dni;
                
            }
            if (tipo == 3) 
            {
                clienteNombre = persona.Nombre;
                clienteApellido = persona.Apellido;
                clienteDoc = persona.Dni;                                        
            }
            InitializeComponent();
        }

        public RegistrarViaje()
        {
            InitializeComponent();
        }

        private void RegistrarViaje_Load(object sender, EventArgs e)
        {
            textBox_Nombre.Text = choferNombre;
            textBox_Apellido.Text = choferApellido;
            textBox_DNI.Text =Convert.ToString( choferDoc);

            textBox5.Text = clienteNombre; 
            textBox8.Text = clienteApellido;
            textBox2.Text = Convert.ToString(clienteDoc);

            DataTable turnos = DAORegistroViaje.getTurnos();

            comboBox1.ValueMember = "TURNO_ID";
            comboBox1.DisplayMember = "TURNO_DESCRIPCION";
            comboBox1.DataSource = turnos;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_Buscar_Click(object sender, EventArgs e)
        {

            //ABRE EL FORM DE SELECCION DE PERSONA
            SeleccionPersonaActiva frm = new SeleccionPersonaActiva(this, 2, 1);
            frm.Show();
            Close();
            

            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //ABRE EL FORM DE SELECCION DE PERSONA
            SeleccionPersonaActiva frm = new SeleccionPersonaActiva(this, 3, 1);
            frm.Show();
            Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RegistrarViaje_Shown(object sender, EventArgs e)
        {
           
        }

        private void RegistrarViaje_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            
        }
    }
}
