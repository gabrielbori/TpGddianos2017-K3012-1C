using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UberFrba.CapaDAO;
using UberFrba.Model;

namespace UberFrba.Abm_Rol
{
    public partial class ModificacionRol : FormBase
    {
        public ModificacionRol()
        {
            InitializeComponent();

            DataTable roles = DAORol.getRoles();

            comboBox_Roles.ValueMember = "ROL_ID";
            comboBox_Roles.DisplayMember = "ROL_NOMBRE";
            comboBox_Roles.DataSource = roles;

        }

        private void ModificacionRol_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView_ListaFuncionalidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox_Roles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }


        private void dataGridView_ListaFuncionalidades_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
