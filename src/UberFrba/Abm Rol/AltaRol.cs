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

        }

        private void textBox_Nombre_TextChanged(object sender, EventArgs e)
        {

        }


        /*        private static List<int> getFuncionalidades(int rolID)
                {
            
                    DataTable funcs = retrieveDataTable("GET_FUNCIONALIDADES_ROL", rolID);
                    List<int> funcionalidades = new List<int>();

                    for (int i = 0; i < funcs.Rows.Count; i++)
                    {
                        funcionalidades.Add((int)funcs.Rows[i][0]);
                    }
                    return funcionalidades;
                }*/

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

                /* DataTable funcionalidades = DAOFuncionalidades.getfuncionalidades(textBox_Username.Text);

                 comboBox1.ValueMember = "ROL_ID";
                 comboBox1.DisplayMember = "ROL_NOMBRE";
                 comboBox1.DataSource = funcionalidades;*/
            }
        }

        private bool Validaciones()
        {
            string mensaje = "";
            string nombre = textBox_Nombre.Text;
            if (nombre == null) { mensaje = "El nombre está vacío"; Mensaje_Error(mensaje); return false; }
            if (String.Equals(nombre, DAORol.getRol(nombre))) { mensaje = "El rol ya existe"; Mensaje_Error(mensaje); return false; }
            return true;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string func_desc = Convert.ToString(comboBox1.SelectedItem);
            //getFuncionalidades(idfuncionalidad);
            //mostrarFuncionalidad(int id, string func_desc);
            //executeProcedure("GET_FUNCIONALIDAD",func_desc);
            //dataGridView_ListaFuncionalidades add 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*DataTable funcionalidades = DAOFuncionalidad.getfuncionalidades(textBox_Username.Text);

            comboBox1.ValueMember = "ROL_ID";
            comboBox1.DisplayMember = "ROL_NOMBRE";
            comboBox1.DataSource = funcionalidades;*/
            //mostrar lista funcionalidades
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_ListaFuncionalidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        /*CREATE PROCEDURE GDDIANOS.FIND_ROL(@NOMBRE VARCHAR(255) = NULL) AS
BEGIN
    SELECT ROL_NOMBRE
    FROM GDDIANOS.ROL
    WHERE (@NOMBRE IS NULL OR ROL_NOMBRE LIKE @NOMBRE) 
		  
END;*/


    }
}
