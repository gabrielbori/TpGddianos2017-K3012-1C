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
            DataTable funcionalidades = DAOFuncionalidad.getfuncionalidades();
            comboBox1.DataSource = funcionalidades;
            comboBox1.DisplayMember = "DESCRIPCION";
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
            foreach (var control in this.dataGridView_ListaFuncionalidades.Controls.OfType<TextBox>()) control.Text = "";
            dataGridView_ListaFuncionalidades.DataSource = new DataTable(); /*mmmmmmm*/
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var resultado = Mensaje_Pregunta("¿Está seguro que desea dar de alta el rol al sistema?", "Alta Rol");
            if (resultado == DialogResult.Yes)
            {
                if (Validaciones())
                {
                    DAORol.altaRol(textBox_Nombre.Text);
                    Mensaje_OK("El rol ha sido dado de alta");
                }
            }
        }

        private bool Validaciones()
        {
            string mensaje = "";
            string nombre = textBox_Nombre.Text;
            if (String.IsNullOrEmpty(nombre)) { mensaje = "El nombre está vacío"; Mensaje_Error(mensaje); return false; }
            if (String.Equals(nombre.ToUpper(), DAORol.getRol(nombre))) { mensaje = "El rol ya existe"; Mensaje_Error(mensaje); return false; }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string func_desc = Convert.ToString(comboBox1.SelectedItem);

            dataGridView_ListaFuncionalidades.DataSource = DAOFuncionalidad.getfuncionalidades();//hacer un procedure para traer una fila?
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView_ListaFuncionalidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
