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
        private int idRol;
        private int idFun;

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


        //Panel Editar Nombre
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        //ComboBox Roles
        private void comboBox_Roles_SelectedIndexChanged(object sender, EventArgs e)
        {

            estado = Convert.ToInt32(comboBox_Roles.SelectedValue);
            idRol = DAORol.getId(comboBox_Roles.Text);
           
            
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
            comboBox1.ValueMember = "ID";
            comboBox1.DisplayMember = "Funcionalidad";
            comboBox1.DataSource = funcionalidades;

            dataGridView_ListaFuncionalidades.DataSource = DAORol.getFuncionalidadesPorRol(idRol); //muestro solo las funcionalidades del rol
            dataGridView_ListaFuncionalidades.Columns[0].DisplayIndex = 2;

            

        }

        private void button_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }


       private void dataGridView_ListaFuncionalidades_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
            dataGridView_ListaFuncionalidades.Rows.RemoveAt(e.RowIndex);
           
        }
        
        //Funcionalidades a agregar
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            idFun = Convert.ToInt32(comboBox1.SelectedValue);            
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        //Boton Guardar
        private void button_Guardar_Click(object sender, EventArgs e)
        {
            
            if (!CamposCorrectos())
            {
                Mensaje_Error("No están todos los datos obligatorios");
                return;
            }
            if (textBox1.Text.ToUpper() != comboBox_Roles.Text)
            {
                string mensaje = DAORol.getRol(textBox1.Text);
                if (textBox1.Text.ToUpper() == mensaje) { Mensaje_Error("El rol ya existe"); return; }

            }
            var resultado = Mensaje_Pregunta("¿Está seguro que desea guardar los datos ingresados en el formulario?", "Guardar Rol");
            if (resultado == DialogResult.Yes)
            {
                int estado = 0;
                if (checkBox1.Checked == true)
                {
                    estado = 1;
                }
                try 
                {
                DAORol.modificarRol(idRol, Convert.ToString(textBox1.Text), dataGridView_ListaFuncionalidades.Rows, estado);

                Mensaje_OK("Los datos han sido actualizados con éxito");
                this.Close();
                }
                catch
                {
                    Mensaje_Error("Falló la modificación del rol en la base de datos");
                }
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
        

        //Boton de agregar funcionalidad
        private void button1_Click(object sender, EventArgs e) 
        {
             if (existeFuncionalidad())
            {
                Mensaje_Error("Ya existe la funcionalidad seleccionada");
                return;
            }
            else
            {
                DataTable funcs = (DataTable)dataGridView_ListaFuncionalidades.DataSource;
                funcs.Rows.Add(idFun, comboBox1.Text);
                dataGridView_ListaFuncionalidades.DataSource = funcs;
                
                }
            }
        

       private bool existeFuncionalidad() 
        {
            List<int> ides = new List<int>();
            int cantFilas;      
            
            cantFilas = dataGridView_ListaFuncionalidades.Rows.Count;           
                       
            //Recorre la grilla y arma una lista con los id de funcionalidades
            for (int i = 0; i < cantFilas; i++)
            {
               ides.Add(Convert.ToInt32(dataGridView_ListaFuncionalidades.Rows[i].Cells["ID"].Value));                
            }

            //Se fija si el id de funcionalidad que se quiere agregar está en la lista          
            return ides.Contains(idFun);
        }
       
     

        private void LimpiarCampos()
        {
            foreach (var control in this.groupBox1.Controls.OfType<ComboBox>()) control.Text = "";
            foreach (var control in this.groupBox3.Controls.OfType<TextBox>()) control.Text = "";
            comboBox1.SelectedIndex = -1;
            checkBox1.Checked = false;
            DataTable funcs = (DataTable)dataGridView_ListaFuncionalidades.DataSource;
            funcs.Rows.Clear();
            dataGridView_ListaFuncionalidades.DataSource = funcs;
            
        }

      
    }
}
