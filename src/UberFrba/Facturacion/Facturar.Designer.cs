using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UberFrba.Model;
using UberFrba.CapaDAO;

namespace UberFrba.Facturacion
{
    partial class Facturar
    {
        private Persona persona;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        /// 


        public override void mostrar(Form parent, params object[] values)
        {
            Persona persona = (Persona)values[0];


            this.persona = persona;

            textBox_Nombre.Text = persona.Nombre;
            textBox_Apellido.Text = persona.Apellido;
            textBox_DNI.Text = Convert.ToString(persona.Dni);



            base.mostrar(parent);
        }



        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox_DatosFactura = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_Fin = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_Inicio = new System.Windows.Forms.DateTimePicker();
            this.textBox_Numero = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button_Buscar_Viajes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox_Viajes = new System.Windows.Forms.GroupBox();
            this.textBox_montoTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView_Viajes = new System.Windows.Forms.DataGridView();
            this.button_Limpiar = new System.Windows.Forms.Button();
            this.button_Aceptar = new System.Windows.Forms.Button();
            this.button_Cerrar = new System.Windows.Forms.Button();
            this.groupBox_Cliente = new System.Windows.Forms.GroupBox();
            this.button_Buscar = new System.Windows.Forms.Button();
            this.textBox_DNI = new System.Windows.Forms.TextBox();
            this.textBox_Apellido = new System.Windows.Forms.TextBox();
            this.textBox_Nombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox_DatosFactura.SuspendLayout();
            this.groupBox_Viajes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Viajes)).BeginInit();
            this.groupBox_Cliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_DatosFactura
            // 
            this.groupBox_DatosFactura.Controls.Add(this.label7);
            this.groupBox_DatosFactura.Controls.Add(this.dateTimePicker1);
            this.groupBox_DatosFactura.Controls.Add(this.dateTimePicker_Fin);
            this.groupBox_DatosFactura.Controls.Add(this.dateTimePicker_Inicio);
            this.groupBox_DatosFactura.Controls.Add(this.textBox_Numero);
            this.groupBox_DatosFactura.Controls.Add(this.label10);
            this.groupBox_DatosFactura.Controls.Add(this.button_Buscar_Viajes);
            this.groupBox_DatosFactura.Controls.Add(this.label1);
            this.groupBox_DatosFactura.Controls.Add(this.label8);
            this.groupBox_DatosFactura.Location = new System.Drawing.Point(12, 154);
            this.groupBox_DatosFactura.Name = "groupBox_DatosFactura";
            this.groupBox_DatosFactura.Size = new System.Drawing.Size(327, 181);
            this.groupBox_DatosFactura.TabIndex = 1;
            this.groupBox_DatosFactura.TabStop = false;
            this.groupBox_DatosFactura.Text = "Datos de factura";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Ingrese mes a facturar";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM/yyyy";
            this.dateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(133, 45);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(102, 20);
            this.dateTimePicker1.TabIndex = 41;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker_Fin
            // 
            this.dateTimePicker_Fin.Enabled = false;
            this.dateTimePicker_Fin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_Fin.Location = new System.Drawing.Point(133, 113);
            this.dateTimePicker_Fin.Name = "dateTimePicker_Fin";
            this.dateTimePicker_Fin.Size = new System.Drawing.Size(102, 20);
            this.dateTimePicker_Fin.TabIndex = 40;
            // 
            // dateTimePicker_Inicio
            // 
            this.dateTimePicker_Inicio.CustomFormat = "";
            this.dateTimePicker_Inicio.Enabled = false;
            this.dateTimePicker_Inicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_Inicio.Location = new System.Drawing.Point(133, 87);
            this.dateTimePicker_Inicio.Name = "dateTimePicker_Inicio";
            this.dateTimePicker_Inicio.Size = new System.Drawing.Size(102, 20);
            this.dateTimePicker_Inicio.TabIndex = 39;
            this.dateTimePicker_Inicio.ValueChanged += new System.EventHandler(this.dateTimePicker_Inicio_ValueChanged);
            // 
            // textBox_Numero
            // 
            this.textBox_Numero.Location = new System.Drawing.Point(133, 19);
            this.textBox_Numero.Name = "textBox_Numero";
            this.textBox_Numero.ReadOnly = true;
            this.textBox_Numero.Size = new System.Drawing.Size(85, 20);
            this.textBox_Numero.TabIndex = 38;
            this.textBox_Numero.TabStop = false;
            this.textBox_Numero.Text = "A generar";
            this.textBox_Numero.TextChanged += new System.EventHandler(this.textBox_Numero_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(83, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "Numero";
            this.label10.Click += new System.EventHandler(this.label10_Click_1);
            // 
            // button_Buscar_Viajes
            // 
            this.button_Buscar_Viajes.Location = new System.Drawing.Point(201, 139);
            this.button_Buscar_Viajes.Name = "button_Buscar_Viajes";
            this.button_Buscar_Viajes.Size = new System.Drawing.Size(103, 23);
            this.button_Buscar_Viajes.TabIndex = 36;
            this.button_Buscar_Viajes.Text = "Buscar Viajes";
            this.button_Buscar_Viajes.UseVisualStyleBackColor = true;
            this.button_Buscar_Viajes.Click += new System.EventHandler(this.button_Buscar_Viajes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Fecha fin";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(63, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Fecha inicio";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // groupBox_Viajes
            // 
            this.groupBox_Viajes.Controls.Add(this.textBox_montoTotal);
            this.groupBox_Viajes.Controls.Add(this.label6);
            this.groupBox_Viajes.Controls.Add(this.dataGridView_Viajes);
            this.groupBox_Viajes.Location = new System.Drawing.Point(345, 12);
            this.groupBox_Viajes.Name = "groupBox_Viajes";
            this.groupBox_Viajes.Size = new System.Drawing.Size(556, 323);
            this.groupBox_Viajes.TabIndex = 3;
            this.groupBox_Viajes.TabStop = false;
            this.groupBox_Viajes.Text = "Viajes facturados";
            this.groupBox_Viajes.Enter += new System.EventHandler(this.groupBox_Viajes_Enter);
            // 
            // textBox_montoTotal
            // 
            this.textBox_montoTotal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_montoTotal.Location = new System.Drawing.Point(452, 297);
            this.textBox_montoTotal.Name = "textBox_montoTotal";
            this.textBox_montoTotal.ReadOnly = true;
            this.textBox_montoTotal.Size = new System.Drawing.Size(100, 20);
            this.textBox_montoTotal.TabIndex = 24;
            this.textBox_montoTotal.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(375, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Total a Pagar";
            // 
            // dataGridView_Viajes
            // 
            this.dataGridView_Viajes.AllowUserToAddRows = false;
            this.dataGridView_Viajes.AllowUserToDeleteRows = false;
            this.dataGridView_Viajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Viajes.Location = new System.Drawing.Point(6, 19);
            this.dataGridView_Viajes.Name = "dataGridView_Viajes";
            this.dataGridView_Viajes.ReadOnly = true;
            this.dataGridView_Viajes.Size = new System.Drawing.Size(543, 272);
            this.dataGridView_Viajes.TabIndex = 0;
            this.dataGridView_Viajes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Viajes_CellContentClick);
            // 
            // button_Limpiar
            // 
            this.button_Limpiar.Location = new System.Drawing.Point(745, 345);
            this.button_Limpiar.Name = "button_Limpiar";
            this.button_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.button_Limpiar.TabIndex = 12;
            this.button_Limpiar.Text = "Limpiar";
            this.button_Limpiar.UseVisualStyleBackColor = true;
            this.button_Limpiar.Click += new System.EventHandler(this.button_Limpiar_Click);
            // 
            // button_Aceptar
            // 
            this.button_Aceptar.Location = new System.Drawing.Point(664, 345);
            this.button_Aceptar.Name = "button_Aceptar";
            this.button_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.button_Aceptar.TabIndex = 11;
            this.button_Aceptar.Text = "Aceptar";
            this.button_Aceptar.UseVisualStyleBackColor = true;
            this.button_Aceptar.Click += new System.EventHandler(this.button_Aceptar_Click);
            // 
            // button_Cerrar
            // 
            this.button_Cerrar.Location = new System.Drawing.Point(826, 345);
            this.button_Cerrar.Name = "button_Cerrar";
            this.button_Cerrar.Size = new System.Drawing.Size(75, 23);
            this.button_Cerrar.TabIndex = 13;
            this.button_Cerrar.Text = "Cerrar";
            this.button_Cerrar.UseVisualStyleBackColor = true;
            this.button_Cerrar.Click += new System.EventHandler(this.button_Cerrar_Click);
            // 
            // groupBox_Cliente
            // 
            this.groupBox_Cliente.Controls.Add(this.button_Buscar);
            this.groupBox_Cliente.Controls.Add(this.textBox_DNI);
            this.groupBox_Cliente.Controls.Add(this.textBox_Apellido);
            this.groupBox_Cliente.Controls.Add(this.textBox_Nombre);
            this.groupBox_Cliente.Controls.Add(this.label4);
            this.groupBox_Cliente.Controls.Add(this.label2);
            this.groupBox_Cliente.Controls.Add(this.label9);
            this.groupBox_Cliente.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Cliente.Name = "groupBox_Cliente";
            this.groupBox_Cliente.Size = new System.Drawing.Size(327, 136);
            this.groupBox_Cliente.TabIndex = 14;
            this.groupBox_Cliente.TabStop = false;
            this.groupBox_Cliente.Text = "Cliente";
            this.groupBox_Cliente.Enter += new System.EventHandler(this.groupBox_Cliente_Enter);
            // 
            // button_Buscar
            // 
            this.button_Buscar.Location = new System.Drawing.Point(201, 107);
            this.button_Buscar.Name = "button_Buscar";
            this.button_Buscar.Size = new System.Drawing.Size(103, 23);
            this.button_Buscar.TabIndex = 83;
            this.button_Buscar.Text = "Buscar cliente";
            this.button_Buscar.UseVisualStyleBackColor = true;
            this.button_Buscar.Click += new System.EventHandler(this.button_Buscar_Click);
            // 
            // textBox_DNI
            // 
            this.textBox_DNI.Location = new System.Drawing.Point(78, 74);
            this.textBox_DNI.Name = "textBox_DNI";
            this.textBox_DNI.ReadOnly = true;
            this.textBox_DNI.Size = new System.Drawing.Size(226, 20);
            this.textBox_DNI.TabIndex = 82;
            this.textBox_DNI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_Apellido
            // 
            this.textBox_Apellido.Location = new System.Drawing.Point(78, 48);
            this.textBox_Apellido.Name = "textBox_Apellido";
            this.textBox_Apellido.ReadOnly = true;
            this.textBox_Apellido.Size = new System.Drawing.Size(226, 20);
            this.textBox_Apellido.TabIndex = 81;
            this.textBox_Apellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_Nombre
            // 
            this.textBox_Nombre.Location = new System.Drawing.Point(78, 22);
            this.textBox_Nombre.Name = "textBox_Nombre";
            this.textBox_Nombre.ReadOnly = true;
            this.textBox_Nombre.Size = new System.Drawing.Size(226, 20);
            this.textBox_Nombre.TabIndex = 80;
            this.textBox_Nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 79;
            this.label4.Text = "DNI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 78;
            this.label2.Text = "Apellido";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 77;
            this.label9.Text = "Nombre";
            // 
            // Facturar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 380);
            this.Controls.Add(this.groupBox_Cliente);
            this.Controls.Add(this.button_Limpiar);
            this.Controls.Add(this.button_Aceptar);
            this.Controls.Add(this.button_Cerrar);
            this.Controls.Add(this.groupBox_Viajes);
            this.Controls.Add(this.groupBox_DatosFactura);
            this.Name = "Facturar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturación de clientes";
            this.Load += new System.EventHandler(this.Facturar_Load);
            this.groupBox_DatosFactura.ResumeLayout(false);
            this.groupBox_DatosFactura.PerformLayout();
            this.groupBox_Viajes.ResumeLayout(false);
            this.groupBox_Viajes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Viajes)).EndInit();
            this.groupBox_Cliente.ResumeLayout(false);
            this.groupBox_Cliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_DatosFactura;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Buscar_Viajes;
        private System.Windows.Forms.GroupBox groupBox_Viajes;
        private System.Windows.Forms.DataGridView dataGridView_Viajes;
        private System.Windows.Forms.TextBox textBox_montoTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_Limpiar;
        private System.Windows.Forms.Button button_Aceptar;
        private System.Windows.Forms.Button button_Cerrar;
        private System.Windows.Forms.GroupBox groupBox_Cliente;
        private System.Windows.Forms.TextBox textBox_Numero;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Fin;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Inicio;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_Buscar;
        private System.Windows.Forms.TextBox textBox_DNI;
        private System.Windows.Forms.TextBox textBox_Apellido;
        private System.Windows.Forms.TextBox textBox_Nombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
    }
}