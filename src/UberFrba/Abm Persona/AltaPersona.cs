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

namespace UberFrba.Abm_Persona
{
    public partial class AltaPersona : FormBase
    {
        private int tipo = 0;
        public AltaPersona(int tipoA)
        {
            tipo = tipoA;
            InitializeComponent();
            if (tipo == 2) 
            { 
                this.textBox_CodigoPostal.Enabled = false;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void AltaPersona_Load(object sender, EventArgs e)
        {
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
