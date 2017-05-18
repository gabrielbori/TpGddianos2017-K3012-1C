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
        
        private int tipoAmbos = 0, tipoPersona = 0;

        string nombre, apellido, doc;

        public SeleccionDePersona(int tipoS1, int tipoS2)
        {
            tipoAmbos = tipoS1;
            tipoPersona = tipoS2;
            InitializeComponent();
        }

        private void SeleccionDePersona_Load(object sender, EventArgs e)
        {

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

        }
    }
}
