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

namespace UberFrba.Rendicion_Viajes
{
    public partial class RendirViaje : FormBase
    {
        public decimal total;

        public RendirViaje()
        {
            InitializeComponent();
            textBox1.Text = Convert.ToString(30);
        }

       

        private void RendirViaje_Load(object sender, EventArgs e)
        {
            DataTable turnos = DAORendicionViaje.getTurnos();

            comboBox1.ValueMember = "TURNO_ID";
            comboBox1.DisplayMember = "TURNO_DESCRIPCION";
            comboBox1.DataSource = turnos;
            dateTimePicker1.Value = Globals.getDateFechaSistema();
            button_Buscar_Viajes_Click(sender, e);
        }

        

        private void textBox_Nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Aceptar_Click(object sender, EventArgs e)
        {
            

            if (textBox_Numero.Text != "A generar") 
            {
                Mensaje_Error("Limpie los datos de la última operación");
                return;
            }
            if (Validaciones())
            {
                Mensaje_Error("No están todos los datos obligatorios");
                return;
            }

            if (dataGridView_Viajes.RowCount == 0)
            {
                Mensaje_Error("No hay viajes para rendir");
                return;
            }
            else
            {

                var resultado = Mensaje_Pregunta("¿Está seguro que desea realizar el pago?", "Generar Pago");
                if (resultado == DialogResult.Yes)
                {

                    try
                    {
                        DAORendicionViaje.crearRendicion(Convert.ToDateTime(dateTimePicker1.Value), Convert.ToInt32(persona.ID),
                                                  Convert.ToInt32(comboBox1.SelectedValue), this.total, Convert.ToDecimal(textBox1.Text));

                        int numPago = DAORendicionViaje.buscarIDPagoInsertado();
                        textBox_Numero.Text = Convert.ToString(numPago);

                        Mensaje_OK("El pago fue realizado con éxito");
                        button_Buscar_Viajes_Click(sender, e);
                        

                    }
                    catch
                    {
                        Mensaje_Error("Falló la creación del pago en la base de datos");
                    }
                }
            }
        }

        private bool Validaciones()
        {
            bool vacio = false;
            if (textBox_montoTotal.Text == "" && dataGridView_Viajes.Rows.Count == 0)
            {
                vacio = true;
            }


            return vacio;
        }
           

        private void button_Buscar_Viajes_Click(object sender, EventArgs e)
        {
            if ((textBox_Nombre.Text == "") && (textBox_Apellido.Text == "") && (textBox_DNI.Text == ""))
            {
                Mensaje_Error("Cargue el Cliente");
                return;

            }

            
            if (dateTimePicker1.Value <= Globals.getDateFechaSistema())
            {

                dataGridView_Viajes.DataSource = DAORendicionViaje.getViajes(Convert.ToInt32(persona.ID), 
                                                                Convert.ToDateTime(dateTimePicker1.Value), 
                                                                   Convert.ToInt32(comboBox1.SelectedValue), 
                                                                   Convert.ToDecimal(textBox1.Text));
                if(dataGridView_Viajes.DataSource!=null)
                {
                    this.dataGridView_Viajes.Columns["ID"].Visible = false;
                }

                setTotal();
                
            }
            else
            {
                Mensaje_Error("La fecha no puede ser a futuro");
                return;
            }

        }

        private void setTotal()
        {
            this.total = 0;
            foreach (DataGridViewRow row in dataGridView_Viajes.Rows)
            {
                total += Convert.ToDecimal(row.Cells["Precio Unitario"].Value);
            }

            textBox_montoTotal.Text = total.ToString();
        }

        private void button_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = Globals.getDateFechaSistema();
            dataGridView_Viajes.DataSource = new DataTable();
            textBox_montoTotal.Text = "";
            textBox_Nombre.Text = "";
            textBox_Apellido.Text = "";
            textBox_DNI.Text = "";
            textBox_Numero.Text = "A generar";
                      
        
        }

        private void button_Buscar_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = Globals.getDateFechaSistema();
            dataGridView_Viajes.DataSource = new DataTable();
            textBox_montoTotal.Text = "";
            textBox_Nombre.Text = "";
            textBox_Apellido.Text = "";
            textBox_DNI.Text = "";

            SeleccionPersonaActiva frm = new SeleccionPersonaActiva(this, "Cliente");
            frm.Show();
            
        }

        private void groupBox_Pago_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //dataGridView_Viajes.DataSource = null;
            button_Buscar_Viajes_Click(sender, e);
            textBox_Numero.Text = "A generar";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void keypressporcentaje(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }


        
       
    }
}
