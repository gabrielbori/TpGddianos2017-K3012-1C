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

namespace UberFrba.Abm_Rol
{
    public partial class AltaRol : FormBase
    {
        public AltaRol()
        {
            InitializeComponent();
        }

        private void AltaRol_Load(object sender, EventArgs e)
        {
            //mostrar lista funcionalidades
            DataTable funcionalidades = DAORol.getFuncionalidades();
            comboBox1.DataSource = funcionalidades;
            comboBox1.ValueMember = "ID";
            comboBox1.DisplayMember = "Funcionalidad";
            checkBox1.Checked = true;
        }

        private void textBox_Nombre_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            foreach (var control in this.paner_Alta.Controls.OfType<TextBox>()) control.Text = "";
            foreach (var control in this.paner_Alta.Controls.OfType<TextBox>()) control.Text = "";
            comboBox1.SelectedIndex = -1;
            checkBox1.Checked = true;
            dataGridView_ListaFuncionalidades.Rows.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var resultado = Mensaje_Pregunta("¿Está seguro que desea dar de alta el rol al sistema?", "Alta Rol");
            if (resultado == DialogResult.Yes & Validaciones())
            {            
                int estado = 0;
                if (checkBox1.Checked == true){
                    estado = 1;
                }
                DAORol.altaRol(textBox_Nombre.Text, dataGridView_ListaFuncionalidades.Rows, estado);
                Mensaje_OK("El rol ha sido dado de alta");
            }
        }

        private bool Validaciones()
        {
            string nombre = textBox_Nombre.Text;
            if (String.IsNullOrEmpty(nombre)) { Mensaje_Error("El nombre de rol está vacío"); return false; }
            if (String.Equals(nombre.ToUpper(), DAORol.getRol(nombre))) { Mensaje_Error("El rol ya existe"); return false; }
            if (dataGridView_ListaFuncionalidades.Rows.Count < 1) { Mensaje_Error("Lista de funcionalidades vacía"); return false; }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<String> indices = new List<String>();

            for (int i = 0; i < dataGridView_ListaFuncionalidades.Rows.Count; i++)
            {
                indices.Add(Convert.ToString(dataGridView_ListaFuncionalidades.Rows[i].Cells[0].Value));
            }
            if (!indices.Contains(Convert.ToString(comboBox1.SelectedValue)))
            {
                dataGridView_ListaFuncionalidades.Rows.Add(comboBox1.SelectedValue, comboBox1.Text);
            }
            else
            {
                Mensaje_Error("La funcionalidad ya esta seleccionada");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView_ListaFuncionalidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView_ListaFuncionalidades.Rows.RemoveAt(e.RowIndex);
        }
    }
}
