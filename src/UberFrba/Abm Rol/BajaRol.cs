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
    public partial class BajaRol : FormBase
    {
       

        public BajaRol()
        {
            InitializeComponent();

            DataTable roles = DAORol.getRoles();

            comboBox1.ValueMember = "ROL_ESTADO";
            comboBox1.DisplayMember = "ROL_NOMBRE";
            comboBox1.DataSource = roles;
     
        }


        private void BajaRol_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) 
        {
            
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_Aceptar_Click(object sender, EventArgs e)
        {
                    int estado = Convert.ToInt32(comboBox1.SelectedValue);
                    if (estado == 1)
                    {
                        var resultado = Mensaje_Pregunta("¿Está seguro que desea dar de baja el rol?", "Baja Rol");
                        if (resultado == DialogResult.Yes)
                        {
                            string nombre = comboBox1.Text;
                            DAORol.bajaRolSeleccionado(nombre);
                            Mensaje_OK("El rol ha sido dado de baja");
                            this.Close();
                        }
                    }
                    else
                    {
                        Mensaje_Error("El rol ya está deshabilitado");
                        return;
                    }
        }

        private void button_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
