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

namespace UberFrba.Facturacion
{
    public partial class Facturar : FormBase
    {

        private int idPersona;
        public Facturar()
        {
            InitializeComponent();
        }

        private void Facturar_Load(object sender, EventArgs e)
        {
            
        }

        private void button_Cargar_Persona_Click(object sender, EventArgs e)
        {
            if ((textBox_Nombre.Visible == false) && (textBox_Apellido.Visible == false))
            {
                try
                {
                    int dni = Convert.ToInt32(textBox_DNI.Text);
                    int telefono = Convert.ToInt32(textBox_Telefono.Text);
                    idPersona = DAOFacturacion.getIDPersona(dni, telefono);
                    string nombre = DAOFacturacion.getNombrePersona(dni, telefono);
                    string apellido = DAOFacturacion.getApellidoPersona(dni, telefono);

                    textBox_Nombre.Visible = true;
                    textBox_Apellido.Visible = true;
                    textBox_Nombre.SelectedText = nombre;
                    textBox_Apellido.SelectedText = apellido;
                }

                catch { Mensaje_Error("La persona no se encuentra en la base de datos"); }

                         

            }
            else
            {
                Mensaje_Error("Los datos ya fueron cargados");
                return;
            }
        
        }

        private void button_Buscar_Viajes_Click(object sender, EventArgs e)
        {
            if (textBox_Numero.Text != "A generar")
            {
                Mensaje_Error("Limpie los datos de la última operación");
                return;
            }
            
            if((textBox_Nombre.Visible == false) && (textBox_Apellido.Visible == false))
            {
                Mensaje_Error("Cargue el Cliente");
                return;
               
            }
            if (dateTimePicker_Inicio.Value.Month == dateTimePicker_Fin.Value.Month
                && dateTimePicker_Inicio.Value.Year == dateTimePicker_Fin.Value.Year)
            {

               dataGridView_Viajes.DataSource = DAOFacturacion.getViajes(idPersona, Convert.ToInt32(dateTimePicker_Inicio.Value.Month), Convert.ToInt32(dateTimePicker_Inicio.Value.Year));
               this.dataGridView_Viajes.Columns["ID"].Visible = false;
               setTotal();

            }
            else
            {
                Mensaje_Error("La facturacion debe ser mensual");
                return;
            }
          



        }

        private void setTotal()
        {
            double total = 0;
            foreach (DataGridViewRow row in dataGridView_Viajes.Rows)
            {
                total += Convert.ToDouble(row.Cells["Precio Unitario"].Value);
            }

            textBox_montoTotal.Text = total.ToString();
        }


        private void button_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            foreach (var control in this.groupBox_Cliente.Controls.OfType<TextBox>()) control.Text = "";
            textBox_Nombre.Visible = false;
            textBox_Apellido.Visible = false;
            dateTimePicker_Inicio.Text = Globals.getFechaSistema();
            dateTimePicker_Fin.Text = Globals.getFechaSistema();
            dataGridView_Viajes.DataSource = new DataTable();
            textBox_Numero.Text = "A generar";
            textBox_montoTotal.Text = "";
           
        }

        private void button_Aceptar_Click(object sender, EventArgs e)
        {
            if (Validaciones())
            {
                Mensaje_Error("No están todos los datos obligatorios");
                return;
            }
            if (textBox_Numero.Text != "A generar")
            {
                Mensaje_Error("Limpie los datos de la última operación");
                return;
            }
            
           
            var resultado = Mensaje_Pregunta("¿Está seguro que desea realizar la facturación?", "Generar Factura");
            if (resultado == DialogResult.Yes)
            {
                if (!Validaciones()) return;
                try
                {

                    long numFactura = DAOFacturacion.crearFactura(idPersona, Convert.ToDateTime(dateTimePicker_Inicio.Text),
                                                        Convert.ToDateTime(dateTimePicker_Fin.Text),dataGridView_Viajes.Rows,
                                                        Convert.ToDecimal(textBox_montoTotal.Text));
                    textBox_Numero.Text = Convert.ToString(numFactura);
                    //revisarViajes(); //Me tengo que fijar si los viajes estan facturados o no
                    Mensaje_OK("La facturación fue realizada con éxito");
                }
                catch 
                {
                    Mensaje_Error("Falló creación de la factura en la base de datos");
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
           
      


        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Fecha_Inicio_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Fecha_Fin_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void groupBox_Viajes_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView_Viajes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
      
        private void textBox_DNI_TextChanged(object sender, EventArgs e)
        {
           
        }

        

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox_Numero_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_Inicio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Nombre_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void groupBox_Cliente_Enter(object sender, EventArgs e)
        {

        }

        private void textBox_Telefono_TextChanged(object sender, EventArgs e)
        {

        }

      //NO PERMITE ESCRIBIR LETRAS EN EL TEXTBOX DNI
        private void textBox_DNI_KeyPress(object sender, KeyPressEventArgs e)
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
            else
            {
                e.Handled = true;
            }
        }

        //NO PERMITE ESCRIBIR LETRAS EN EL TEXTBOX TELEFONO
        private void textBox_Telefono_KeyPress(object sender, KeyPressEventArgs e)
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
            else
            {
                e.Handled = true;
            }
        }
        
    }
}
