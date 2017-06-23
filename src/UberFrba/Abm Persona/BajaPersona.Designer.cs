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

namespace UberFrba.Abm_Persona
{
    partial class BajaPersona
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
            string codigoPostal = values[1] as string;
            string tipo = values[2] as string;

            this.persona = persona;
            textBox_Direccion.Text = persona.Direccion;
            textBox_Apellido.Text = persona.Apellido;
            textBox_DNI.Text = Convert.ToString(persona.Dni);
            dateTimePicker_FechaNacimiento.Text = persona.FechaDeNacimiento.ToString();
            dateTimePicker_FechaNacimiento.Enabled = false;
            textBox_Telefono.Text = Convert.ToString(persona.Telefono);
            textBox_Mail.Text = persona.Mail;
            textBox_Nombre.Text = persona.Nombre;
            textBox_CodigoPostal.Text = codigoPostal;
            if (!(DAOPersona.estadoDePerfil(persona.Telefono, persona.Dni, tipo)))
            {
                checkBox_Estado.Visible = false;
                label8.Visible = false;
            }
            else
            {
                checkBox_Estado.Visible = false;
                label8.Visible = false;
            }
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
            this.textBox_CodigoPostal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_Mail = new System.Windows.Forms.TextBox();
            this.textBox_Direccion = new System.Windows.Forms.TextBox();
            this.textBox_Telefono = new System.Windows.Forms.TextBox();
            this.textBox_DNI = new System.Windows.Forms.TextBox();
            this.textBox_Apellido = new System.Windows.Forms.TextBox();
            this.textBox_Nombre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker_FechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.checkBox_Estado = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_CodigoPostal
            // 
            this.textBox_CodigoPostal.Location = new System.Drawing.Point(175, 224);
            this.textBox_CodigoPostal.Name = "textBox_CodigoPostal";
            this.textBox_CodigoPostal.ReadOnly = true;
            this.textBox_CodigoPostal.Size = new System.Drawing.Size(226, 20);
            this.textBox_CodigoPostal.TabIndex = 77;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label10.Location = new System.Drawing.Point(34, 231);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 76;
            this.label10.Text = "Codigo Postal";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 301);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 75;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(348, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 74;
            this.button1.Text = "Baja";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_Mail
            // 
            this.textBox_Mail.Location = new System.Drawing.Point(175, 198);
            this.textBox_Mail.Name = "textBox_Mail";
            this.textBox_Mail.ReadOnly = true;
            this.textBox_Mail.Size = new System.Drawing.Size(226, 20);
            this.textBox_Mail.TabIndex = 73;
            // 
            // textBox_Direccion
            // 
            this.textBox_Direccion.Location = new System.Drawing.Point(175, 172);
            this.textBox_Direccion.Name = "textBox_Direccion";
            this.textBox_Direccion.ReadOnly = true;
            this.textBox_Direccion.Size = new System.Drawing.Size(226, 20);
            this.textBox_Direccion.TabIndex = 72;
            // 
            // textBox_Telefono
            // 
            this.textBox_Telefono.Location = new System.Drawing.Point(175, 120);
            this.textBox_Telefono.Name = "textBox_Telefono";
            this.textBox_Telefono.ReadOnly = true;
            this.textBox_Telefono.Size = new System.Drawing.Size(226, 20);
            this.textBox_Telefono.TabIndex = 70;
            // 
            // textBox_DNI
            // 
            this.textBox_DNI.Location = new System.Drawing.Point(175, 94);
            this.textBox_DNI.Name = "textBox_DNI";
            this.textBox_DNI.ReadOnly = true;
            this.textBox_DNI.Size = new System.Drawing.Size(226, 20);
            this.textBox_DNI.TabIndex = 69;
            // 
            // textBox_Apellido
            // 
            this.textBox_Apellido.Location = new System.Drawing.Point(175, 68);
            this.textBox_Apellido.Name = "textBox_Apellido";
            this.textBox_Apellido.ReadOnly = true;
            this.textBox_Apellido.Size = new System.Drawing.Size(226, 20);
            this.textBox_Apellido.TabIndex = 68;
            // 
            // textBox_Nombre
            // 
            this.textBox_Nombre.Location = new System.Drawing.Point(175, 42);
            this.textBox_Nombre.Name = "textBox_Nombre";
            this.textBox_Nombre.ReadOnly = true;
            this.textBox_Nombre.Size = new System.Drawing.Size(226, 20);
            this.textBox_Nombre.TabIndex = 67;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(113, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(228, 20);
            this.label9.TabIndex = 66;
            this.label9.Text = "Información De La Persona";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 65;
            this.label7.Text = "Mail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 64;
            this.label6.Text = "Direccion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 63;
            this.label5.Text = "Fecha De Nacimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 62;
            this.label4.Text = "Telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "DNI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 60;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "Nombre";
            // 
            // dateTimePicker_FechaNacimiento
            // 
            this.dateTimePicker_FechaNacimiento.Location = new System.Drawing.Point(175, 146);
            this.dateTimePicker_FechaNacimiento.Name = "dateTimePicker_FechaNacimiento";
            this.dateTimePicker_FechaNacimiento.Size = new System.Drawing.Size(226, 20);
            this.dateTimePicker_FechaNacimiento.TabIndex = 78;
            // 
            // checkBox_Estado
            // 
            this.checkBox_Estado.AutoSize = true;
            this.checkBox_Estado.Location = new System.Drawing.Point(175, 250);
            this.checkBox_Estado.Name = "checkBox_Estado";
            this.checkBox_Estado.Size = new System.Drawing.Size(90, 17);
            this.checkBox_Estado.TabIndex = 80;
            this.checkBox_Estado.Text = "Deshabilitado";
            this.checkBox_Estado.UseVisualStyleBackColor = true;
            this.checkBox_Estado.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 79;
            this.label8.Text = "Estado";
            // 
            // BajaPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 336);
            this.Controls.Add(this.checkBox_Estado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePicker_FechaNacimiento);
            this.Controls.Add(this.textBox_CodigoPostal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_Mail);
            this.Controls.Add(this.textBox_Direccion);
            this.Controls.Add(this.textBox_Telefono);
            this.Controls.Add(this.textBox_DNI);
            this.Controls.Add(this.textBox_Apellido);
            this.Controls.Add(this.textBox_Nombre);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BajaPersona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BajaPersona";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_CodigoPostal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_Mail;
        private System.Windows.Forms.TextBox textBox_Direccion;
        private System.Windows.Forms.TextBox textBox_Telefono;
        private System.Windows.Forms.TextBox textBox_DNI;
        private System.Windows.Forms.TextBox textBox_Apellido;
        private System.Windows.Forms.TextBox textBox_Nombre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DateTimePicker dateTimePicker_FechaNacimiento;
        private Label label8;
        private System.Windows.Forms.CheckBox checkBox_Estado;
    }
}