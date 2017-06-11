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


namespace UberFrba.Rendicion_Viajes
{
    partial class RendirViaje
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
            this.groupBox_Viajes = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox_montoTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView_Viajes = new System.Windows.Forms.DataGridView();
            this.groupBox_Chofer = new System.Windows.Forms.GroupBox();
            this.button_Buscar = new System.Windows.Forms.Button();
            this.textBox_DNI = new System.Windows.Forms.TextBox();
            this.textBox_Apellido = new System.Windows.Forms.TextBox();
            this.textBox_Nombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox_Pago = new System.Windows.Forms.GroupBox();
            this.button_Buscar_Viajes = new System.Windows.Forms.Button();
            this.button_Limpiar = new System.Windows.Forms.Button();
            this.button_Aceptar = new System.Windows.Forms.Button();
            this.button_Cerrar = new System.Windows.Forms.Button();
            this.textBox_Numero = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox_Viajes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Viajes)).BeginInit();
            this.groupBox_Chofer.SuspendLayout();
            this.groupBox_Pago.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Viajes
            // 
            this.groupBox_Viajes.Controls.Add(this.label1);
            this.groupBox_Viajes.Controls.Add(this.textBox1);
            this.groupBox_Viajes.Controls.Add(this.textBox_montoTotal);
            this.groupBox_Viajes.Controls.Add(this.label6);
            this.groupBox_Viajes.Controls.Add(this.dataGridView_Viajes);
            this.groupBox_Viajes.Location = new System.Drawing.Point(323, 12);
            this.groupBox_Viajes.Name = "groupBox_Viajes";
            this.groupBox_Viajes.Size = new System.Drawing.Size(556, 323);
            this.groupBox_Viajes.TabIndex = 4;
            this.groupBox_Viajes.TabStop = false;
            this.groupBox_Viajes.Text = "Viajes a rendir";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Porcentaje aplicado a cada viaje";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.Location = new System.Drawing.Point(174, 297);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 25;
            this.textBox1.TabStop = false;
            // 
            // textBox_montoTotal
            // 
            this.textBox_montoTotal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_montoTotal.Enabled = false;
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
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Importe total";
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
            // 
            // groupBox_Chofer
            // 
            this.groupBox_Chofer.Controls.Add(this.button_Buscar);
            this.groupBox_Chofer.Controls.Add(this.textBox_DNI);
            this.groupBox_Chofer.Controls.Add(this.textBox_Apellido);
            this.groupBox_Chofer.Controls.Add(this.textBox_Nombre);
            this.groupBox_Chofer.Controls.Add(this.label4);
            this.groupBox_Chofer.Controls.Add(this.label7);
            this.groupBox_Chofer.Controls.Add(this.label9);
            this.groupBox_Chofer.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Chofer.Name = "groupBox_Chofer";
            this.groupBox_Chofer.Size = new System.Drawing.Size(305, 147);
            this.groupBox_Chofer.TabIndex = 5;
            this.groupBox_Chofer.TabStop = false;
            this.groupBox_Chofer.Text = "Chofer";
            // 
            // button_Buscar
            // 
            this.button_Buscar.Location = new System.Drawing.Point(196, 118);
            this.button_Buscar.Name = "button_Buscar";
            this.button_Buscar.Size = new System.Drawing.Size(103, 23);
            this.button_Buscar.TabIndex = 76;
            this.button_Buscar.Text = "Buscar chofer";
            this.button_Buscar.UseVisualStyleBackColor = true;
            this.button_Buscar.Click += new System.EventHandler(this.button_Buscar_Click);
            // 
            // textBox_DNI
            // 
            this.textBox_DNI.Location = new System.Drawing.Point(73, 85);
            this.textBox_DNI.Name = "textBox_DNI";
            this.textBox_DNI.ReadOnly = true;
            this.textBox_DNI.Size = new System.Drawing.Size(226, 20);
            this.textBox_DNI.TabIndex = 75;
            this.textBox_DNI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_Apellido
            // 
            this.textBox_Apellido.Location = new System.Drawing.Point(73, 59);
            this.textBox_Apellido.Name = "textBox_Apellido";
            this.textBox_Apellido.ReadOnly = true;
            this.textBox_Apellido.Size = new System.Drawing.Size(226, 20);
            this.textBox_Apellido.TabIndex = 74;
            this.textBox_Apellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_Nombre
            // 
            this.textBox_Nombre.Location = new System.Drawing.Point(73, 33);
            this.textBox_Nombre.Name = "textBox_Nombre";
            this.textBox_Nombre.ReadOnly = true;
            this.textBox_Nombre.Size = new System.Drawing.Size(226, 20);
            this.textBox_Nombre.TabIndex = 73;
            this.textBox_Nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_Nombre.TextChanged += new System.EventHandler(this.textBox_Nombre_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 72;
            this.label4.Text = "DNI";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 71;
            this.label7.Text = "Apellido";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 70;
            this.label9.Text = "Nombre";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Fecha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Turno";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(59, 100);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(212, 21);
            this.comboBox1.TabIndex = 47;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(59, 73);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(212, 20);
            this.dateTimePicker1.TabIndex = 48;
            // 
            // groupBox_Pago
            // 
            this.groupBox_Pago.Controls.Add(this.textBox_Numero);
            this.groupBox_Pago.Controls.Add(this.label10);
            this.groupBox_Pago.Controls.Add(this.button_Buscar_Viajes);
            this.groupBox_Pago.Controls.Add(this.comboBox1);
            this.groupBox_Pago.Controls.Add(this.label5);
            this.groupBox_Pago.Controls.Add(this.dateTimePicker1);
            this.groupBox_Pago.Controls.Add(this.label8);
            this.groupBox_Pago.Location = new System.Drawing.Point(12, 165);
            this.groupBox_Pago.Name = "groupBox_Pago";
            this.groupBox_Pago.Size = new System.Drawing.Size(305, 170);
            this.groupBox_Pago.TabIndex = 6;
            this.groupBox_Pago.TabStop = false;
            this.groupBox_Pago.Text = "Datos de pago";
            this.groupBox_Pago.Enter += new System.EventHandler(this.groupBox_Pago_Enter);
            // 
            // button_Buscar_Viajes
            // 
            this.button_Buscar_Viajes.Location = new System.Drawing.Point(196, 137);
            this.button_Buscar_Viajes.Name = "button_Buscar_Viajes";
            this.button_Buscar_Viajes.Size = new System.Drawing.Size(103, 23);
            this.button_Buscar_Viajes.TabIndex = 49;
            this.button_Buscar_Viajes.Text = "Buscar Viajes";
            this.button_Buscar_Viajes.UseVisualStyleBackColor = true;
            this.button_Buscar_Viajes.Click += new System.EventHandler(this.button_Buscar_Viajes_Click);
            // 
            // button_Limpiar
            // 
            this.button_Limpiar.Location = new System.Drawing.Point(723, 341);
            this.button_Limpiar.Name = "button_Limpiar";
            this.button_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.button_Limpiar.TabIndex = 15;
            this.button_Limpiar.Text = "Limpiar";
            this.button_Limpiar.UseVisualStyleBackColor = true;
            this.button_Limpiar.Click += new System.EventHandler(this.button_Limpiar_Click);
            // 
            // button_Aceptar
            // 
            this.button_Aceptar.Location = new System.Drawing.Point(642, 341);
            this.button_Aceptar.Name = "button_Aceptar";
            this.button_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.button_Aceptar.TabIndex = 14;
            this.button_Aceptar.Text = "Aceptar";
            this.button_Aceptar.UseVisualStyleBackColor = true;
            this.button_Aceptar.Click += new System.EventHandler(this.button_Aceptar_Click);
            // 
            // button_Cerrar
            // 
            this.button_Cerrar.Location = new System.Drawing.Point(804, 341);
            this.button_Cerrar.Name = "button_Cerrar";
            this.button_Cerrar.Size = new System.Drawing.Size(75, 23);
            this.button_Cerrar.TabIndex = 16;
            this.button_Cerrar.Text = "Cerrar";
            this.button_Cerrar.UseVisualStyleBackColor = true;
            this.button_Cerrar.Click += new System.EventHandler(this.button_Cerrar_Click);
            // 
            // textBox_Numero
            // 
            this.textBox_Numero.Location = new System.Drawing.Point(132, 31);
            this.textBox_Numero.Name = "textBox_Numero";
            this.textBox_Numero.ReadOnly = true;
            this.textBox_Numero.Size = new System.Drawing.Size(85, 20);
            this.textBox_Numero.TabIndex = 51;
            this.textBox_Numero.TabStop = false;
            this.textBox_Numero.Text = "A generar";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(82, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 50;
            this.label10.Text = "Numero";
            // 
            // RendirViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 369);
            this.Controls.Add(this.button_Limpiar);
            this.Controls.Add(this.button_Aceptar);
            this.Controls.Add(this.button_Cerrar);
            this.Controls.Add(this.groupBox_Pago);
            this.Controls.Add(this.groupBox_Chofer);
            this.Controls.Add(this.groupBox_Viajes);
            this.Name = "RendirViaje";
            this.Text = "RendirViaje";
            this.Load += new System.EventHandler(this.RendirViaje_Load);
            this.groupBox_Viajes.ResumeLayout(false);
            this.groupBox_Viajes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Viajes)).EndInit();
            this.groupBox_Chofer.ResumeLayout(false);
            this.groupBox_Chofer.PerformLayout();
            this.groupBox_Pago.ResumeLayout(false);
            this.groupBox_Pago.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Viajes;
        private System.Windows.Forms.TextBox textBox_montoTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView_Viajes;
        private System.Windows.Forms.GroupBox groupBox_Chofer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox_Pago;
        private System.Windows.Forms.Button button_Limpiar;
        private System.Windows.Forms.Button button_Aceptar;
        private System.Windows.Forms.Button button_Cerrar;
        private System.Windows.Forms.TextBox textBox_DNI;
        private System.Windows.Forms.TextBox textBox_Apellido;
        private System.Windows.Forms.TextBox textBox_Nombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private Button button_Buscar_Viajes;
        private Button button_Buscar;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox_Numero;
        private Label label10;
    }
}