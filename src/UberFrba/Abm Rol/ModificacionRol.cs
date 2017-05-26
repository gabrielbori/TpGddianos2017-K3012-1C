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
       
        private int estado;
        private int id;
        public ModificacionRol()
        {
            InitializeComponent();

            DataTable roles = DAORol.getRoles();

            comboBox_Roles.ValueMember = "ROL_ESTADO";
            comboBox_Roles.DisplayMember = "ROL_NOMBRE";
            comboBox_Roles.DataSource = roles;



        }

        private void ModificacionRol_Load(object sender, EventArgs e)
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

            estado = Convert.ToInt32(comboBox_Roles.SelectedValue);
            id = DAORol.getId(comboBox_Roles.Text);

            //Tilda el check solo si está habilitado
            if (estado == 1)
            {
                checkBox1.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;
            }

            textBox1.Text = comboBox_Roles.Text;

            DataTable funcionalidades = DAORol.getFuncionalidades(); //obtengo todas las funcionalidades que existen
            //comboBox1.Text = "Seleccione la opcion";
            comboBox1.ValueMember = "ID";
            comboBox1.DisplayMember = "Funcionalidad";
            comboBox1.DataSource = funcionalidades;

            dataGridView_ListaFuncionalidades.DataSource = DAORol.getFuncionalidadesPorRol(id);
            dataGridView_ListaFuncionalidades.Columns["FUN_ID"].Visible = false;
           // dataGridView_ListaFuncionalidades.Columns[0].DisplayIndex = 2;

            

        }

        private void button_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }


       private void dataGridView_ListaFuncionalidades_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != 0) return;
            dataGridView_ListaFuncionalidades.Rows.RemoveAt(e.RowIndex);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!CamposCorrectos())
            {
                Mensaje_Error("No están todos los datos obligatorios");
                return;
            }
            var resultado = Mensaje_Pregunta("¿Está seguro que desea guardar los datos ingresados en el formulario?", "Guardar Rol");
            if (resultado == DialogResult.Yes)
            {
                int estado = 0;
                if (checkBox1.Checked == true)
                {
                    estado = 1;
                }

                DAORol.modificarRol(id, textBox1.Text, dataGridView_ListaFuncionalidades.Rows, estado);

                Mensaje_OK("Los datos han sido actualizados con éxito");
                this.Close();
            }
        }
        private bool CamposCorrectos()
        {
            return textBox1.Text != "" &&
            dataGridView_ListaFuncionalidades.Rows.Count > 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //Boton de agregar funcionalidad
        {
            List<string> indices = new List<string>();
           
            for (int i = 0; i < dataGridView_ListaFuncionalidades.Rows.Count; i++)
            {
                indices.Add(Convert.ToString(dataGridView_ListaFuncionalidades.Rows[i].Cells["FUN_ID"].Value));
            }

            if (!indices.Contains(Convert.ToString(comboBox1.SelectedValue)))
            {
                DataTable funcs = (DataTable)dataGridView_ListaFuncionalidades.DataSource;
                funcs.Rows.Add(id, comboBox1.Text);
                dataGridView_ListaFuncionalidades.DataSource = funcs;
            }
        }
        private void LimpiarCampos()
        {
            foreach (var control in this.groupBox1.Controls.OfType<ComboBox>()) control.Text = "";
           // foreach (var control in this.paner_Alta.Controls.OfType<TextBox>()) control.Text = "";
            comboBox1.SelectedIndex = -1;
            DataTable funcs = (DataTable)dataGridView_ListaFuncionalidades.DataSource;
            funcs.Rows.Clear();
            dataGridView_ListaFuncionalidades.DataSource = funcs;
            
        }
    }
}
