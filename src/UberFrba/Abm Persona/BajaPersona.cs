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

namespace UberFrba.Abm_Persona
{
    public partial class BajaPersona : FormBase
    {
        
        public BajaPersona()
        {
            InitializeComponent();
        }

        private void BajaPersona_Load(object sender, EventArgs e)
        {

        }

        private void cerrar()
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cerrar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var resultado = Mensaje_Pregunta("¿Está seguro que desea dar la baja a la persona del sistema?", "Baja Persona");
            if (resultado == DialogResult.Yes)
            {
                int id = persona.ID;
                int tipo = persona.Tipo;
                DAOPersona.bajaPersona(id, tipo);
                Mensaje_OK("La persona ha sido dada de baja");
                this.Close();
            }
        }

        private void textBox_Nombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
