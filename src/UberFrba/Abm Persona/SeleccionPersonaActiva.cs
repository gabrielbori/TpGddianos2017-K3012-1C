﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UberFrba.Model;
using UberFrba.Abm_Persona;
using UberFrba.Registro_Viajes;
using UberFrba.CapaDAO;

namespace UberFrba.Abm_Persona
{
    public partial class SeleccionPersonaActiva : FormBase
    {

        private FormBase caller;
        
        private int tipoAmbos = 1, tipoPersona = 0;
        string nombre, apellido, doc;
        private int abm = 0;
       
       

        


         public SeleccionPersonaActiva(FormBase caller, int tipoS2)
        {
            this.caller = caller;
            tipoPersona = tipoS2;
            InitializeComponent();
        }

         public SeleccionPersonaActiva(FormBase caller, int tipoS2, int id) //para que sepa que es registro viaje=1
         {
             this.caller = caller;
             tipoPersona = tipoS2;
             abm = id;
             InitializeComponent();
         }

        public SeleccionPersonaActiva()
        {
            InitializeComponent();
        }

        private void button_Buscar_Click(object sender, EventArgs e)
        {
            nombre = textBox_Nombre.Text;
            apellido = textBox_Apellido.Text;
            doc = textBox_Documento.Text;

            dataGridView_Seleccion.DataSource = DAOPersona.getPersonaActiva(nombre, apellido, doc, tipoPersona, tipoAmbos);
        }

        private void dataGridView_Seleccion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > 0 || e.RowIndex < 0) return;
            int id = Convert.ToInt32(dataGridView_Seleccion.Rows[e.RowIndex].Cells[1].Value);
            DataTable table = DAOPersona.getPersona(id);
            Persona persona = DAOPersona.dataRowToPersona(table.Rows[0]);
                       

                if (abm == 1) //SI VIENE DE REGISTRAR VIAJE EL ABM ES 1 Y HACE ESTO
                {
                    RegistrarViaje fm = new RegistrarViaje(persona, this.tipoPersona);//ACA ESTA EL PROBLEMA, TENDRIA QUE SER UNA INSTANCIA DEL FORM YA ABIERTO
                    fm.Show();
                    cerrar();
                }
                else
                {
                    nombre = persona.Nombre + ' ' + persona.Apellido;
                    caller.mostrar(this.MdiParent, persona);
                    cerrar();
                }
            
        }

        private void cerrar()
        {
            this.Close();
        }

        private void button_Cerrar_Click(object sender, EventArgs e)
        {
            cerrar();
        }

        private void LimpiarCampos()
        {
            foreach (var control in this.paner_Filtros.Controls.OfType<TextBox>()) control.Text = "";
            dataGridView_Seleccion.DataSource = new DataTable();
        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void textBox_Documento_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Documento_KeyPress(object sender, KeyPressEventArgs e)
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
