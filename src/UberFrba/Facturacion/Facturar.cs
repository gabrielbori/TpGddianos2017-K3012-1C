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

namespace UberFrba.Facturacion
{
    public partial class Facturar : FormBase
    {

        
        public Facturar()
        {
            InitializeComponent();
        }

        private void Facturar_Load(object sender, EventArgs e)
        {
             dateTimePicker1.Value = new DateTime(Globals.getDateFechaSistema().Year, Globals.getDateFechaSistema().Month, 1);            
            DateTime fechaI = new DateTime(Globals.getDateFechaSistema().Year, Globals.getDateFechaSistema().Month, 1);
            dateTimePicker_Inicio.Value = fechaI;

            DateTime fechaF = new DateTime(Globals.getDateFechaSistema().Year, Globals.getDateFechaSistema().Month, DateTime.DaysInMonth(Globals.getDateFechaSistema().Year, Globals.getDateFechaSistema().Month));
            dateTimePicker_Fin.Value = fechaF;
        }

       

        private void button_Buscar_Viajes_Click(object sender, EventArgs e)
        {
            if (textBox_Numero.Text != "A generar") // son todas validaciones, se podrian juntar
            {
                Mensaje_Error("Limpie los datos de la última operación");
                return;
            }
            if ((textBox_Nombre.Text == "") && (textBox_Apellido.Text == "") && (textBox_DNI.Text == ""))
            {
                Mensaje_Error("Cargue el Cliente");
                return;
            }
            if (dateTimePicker_Fin.Value < Globals.getDateFechaSistema())
            {
                dataGridView_Viajes.DataSource = DAOFacturacion.getViajes(Convert.ToInt32(persona.ID), Convert.ToInt32(dateTimePicker_Inicio.Value.Month), Convert.ToInt32(dateTimePicker_Inicio.Value.Year));
                this.dataGridView_Viajes.Columns["ID"].Visible = false;
                setTotal();
            }
            else
            {
                Mensaje_Error("La fecha final es posterior a la fecha actual, la facturación no puede realizarse");
                return;
            }
        }

        private void setTotal()
        {
            Decimal total = 0;
            foreach (DataGridViewRow row in dataGridView_Viajes.Rows)
            {
                total += Convert.ToDecimal(row.Cells["Precio unitario"].Value);
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

            dateTimePicker1.Value = new DateTime(Globals.getDateFechaSistema().Year, Globals.getDateFechaSistema().Month, 1);
            DateTime fechaI = new DateTime(Globals.getDateFechaSistema().Year, Globals.getDateFechaSistema().Month, 1);
            dateTimePicker_Inicio.Value = fechaI;
            DateTime fechaF = new DateTime(Globals.getDateFechaSistema().Year, Globals.getDateFechaSistema().Month, DateTime.DaysInMonth(Globals.getDateFechaSistema().Year, Globals.getDateFechaSistema().Month));
            dateTimePicker_Fin.Value = fechaF;
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
            if ((DAOFacturacion.viajeYaFacturado(dataGridView_Viajes.Rows)) == 0) 
            { 
                Mensaje_Error("Los viajes ya han sido facturados");            
                return;
            }
            else
            {
                var resultado = Mensaje_Pregunta("¿Está seguro que desea realizar la facturación?", "Generar Factura");
                if (resultado == DialogResult.Yes)
                {
                    int numFactura;
                    try
                    {
                        DAOFacturacion.crearFactura(Convert.ToInt32(persona.ID), Convert.ToDateTime(dateTimePicker_Inicio.Value),
                                                            Convert.ToDateTime(dateTimePicker_Fin.Value),
                                                            Convert.ToDecimal(textBox_montoTotal.Text));
                        
                        numFactura = DAOFacturacion.buscarIDFacturaInsertado();                        
                        textBox_Numero.Text = Convert.ToString(numFactura);
                        Mensaje_OK("La facturación fue realizada con éxito");
                        
                       
                    }
                    catch
                    {
                        Mensaje_Error("Falló la creación de la factura en la base de datos");
                    }
                }
            }
        }


        private bool Validaciones()
        {
            if (textBox_montoTotal.Text == "" && dataGridView_Viajes.Rows.Count == 0)
            {
                return true;
            }
            return false;
        }
       

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Value = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, 1);

            DateTime fechaI = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, 1);
            dateTimePicker_Inicio.Value = fechaI;


            DateTime fechaF = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, DateTime.DaysInMonth(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month));
            dateTimePicker_Fin.Value = fechaF;
        }

        private void button_Buscar_Click(object sender, EventArgs e)
        {
            foreach (var control in this.groupBox_Cliente.Controls.OfType<TextBox>()) control.Text = "";

            dateTimePicker1.Value = new DateTime(Globals.getDateFechaSistema().Year, Globals.getDateFechaSistema().Month, 1);
            DateTime fechaI = new DateTime(Globals.getDateFechaSistema().Year, Globals.getDateFechaSistema().Month, 1);
            dateTimePicker_Inicio.Value = fechaI;
            DateTime fechaF = new DateTime(Globals.getDateFechaSistema().Year, Globals.getDateFechaSistema().Month, DateTime.DaysInMonth(Globals.getDateFechaSistema().Year, Globals.getDateFechaSistema().Month));
            dateTimePicker_Fin.Value = fechaF;
            dataGridView_Viajes.DataSource = new DataTable();
            textBox_Numero.Text = "A generar";
            textBox_montoTotal.Text = "";

            SeleccionPersonaActiva frm = new SeleccionPersonaActiva(this, "Cliente");
            frm.Show();
        }

        private void label10_Click(object sender, EventArgs e) { }

        private void textBox_Fecha_Inicio_TextChanged(object sender, EventArgs e) { }

        private void label8_Click(object sender, EventArgs e) { }

        private void label1_Click(object sender, EventArgs e) { }

        private void textBox_Fecha_Fin_TextChanged(object sender, EventArgs e) { }

        private void groupBox_Viajes_Enter(object sender, EventArgs e) { }

        private void dataGridView_Viajes_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void textBox_DNI_TextChanged(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e) { }

        private void label10_Click_1(object sender, EventArgs e) { }

        private void textBox_Numero_TextChanged(object sender, EventArgs e) { }

        private void dateTimePicker_Inicio_ValueChanged(object sender, EventArgs e) { }

        private void textBox_Nombre_TextChanged_1(object sender, EventArgs e) { }

        private void groupBox_Cliente_Enter(object sender, EventArgs e) { }

        private void textBox_Telefono_TextChanged(object sender, EventArgs e) { }

        private void dateTimePicker1_Enter(object sender, EventArgs e)  {  }

        private void dateTimePicker1_KeyPress(object sender, KeyPressEventArgs e)  {  }

      
        }
    }

