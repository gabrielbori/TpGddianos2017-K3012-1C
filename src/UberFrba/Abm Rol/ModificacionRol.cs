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

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox_Roles_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable roles = DAORol.getRoles();

            comboBox1.ValueMember = "ROL_ID";
            comboBox1.DisplayMember = "ROL_NOMBRE";
            comboBox1.DataSource = roles;

            rol.Nombre = Convert.ToString(comboBox1.SelectedItem);
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
    }
}
