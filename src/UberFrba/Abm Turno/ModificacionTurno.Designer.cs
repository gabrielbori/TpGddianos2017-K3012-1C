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

namespace UberFrba.Abm_Turno
{
    partial class ModificacionTurno : FormBase
    {

        private Turno turno;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public override void mostrar(Form parent, params object[] values)
        {
            Turno turno = (Turno)values[0];
            
            this.turno = turno;
            TextBoxDescripcion.Text = turno.descripcion;
            TextBoxHoraInicio.Text = Convert.ToString(turno.horaInicio);
            TextBoxHoraFin.Text = Convert.ToString(turno.horaFin);
            TextBoxValorKM.Text = Convert.ToString(turno.valorKm);
            TextBoxPrecioBase.Text = Convert.ToString(turno.precioBase);
            
            if (turno.estado == 0)
            {
                checkBoxEstado.Visible = true;
                labelEstado.Visible = true;
            }
            else
            {
                checkBoxEstado.Visible = false;
                labelEstado.Visible = false;
                checkBoxEstado.Checked = true;
            }
            base.mostrar(parent);
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.buttomModificar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.LabelPrecioBase = new System.Windows.Forms.Label();
            this.LabelValorKM = new System.Windows.Forms.Label();
            this.LabelHoraFin = new System.Windows.Forms.Label();
            this.LabelHoraInicio = new System.Windows.Forms.Label();
            this.LabelDescripcion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxPrecioBase = new System.Windows.Forms.TextBox();
            this.TextBoxValorKM = new System.Windows.Forms.TextBox();
            this.TextBoxHoraFin = new System.Windows.Forms.TextBox();
            this.TextBoxHoraInicio = new System.Windows.Forms.TextBox();
            this.TextBoxDescripcion = new System.Windows.Forms.TextBox();
            this.checkBoxEstado = new System.Windows.Forms.CheckBox();
            this.labelEstado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttomModificar
            // 
            this.buttomModificar.Location = new System.Drawing.Point(199, 216);
            this.buttomModificar.Name = "buttomModificar";
            this.buttomModificar.Size = new System.Drawing.Size(75, 23);
            this.buttomModificar.TabIndex = 26;
            this.buttomModificar.Text = "Modificar";
            this.buttomModificar.UseVisualStyleBackColor = true;
            this.buttomModificar.Click += new System.EventHandler(this.buttomModificar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(14, 216);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 25;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // LabelPrecioBase
            // 
            this.LabelPrecioBase.AutoSize = true;
            this.LabelPrecioBase.Location = new System.Drawing.Point(10, 145);
            this.LabelPrecioBase.Name = "LabelPrecioBase";
            this.LabelPrecioBase.Size = new System.Drawing.Size(64, 13);
            this.LabelPrecioBase.TabIndex = 24;
            this.LabelPrecioBase.Text = "Precio Base";
            // 
            // LabelValorKM
            // 
            this.LabelValorKM.AutoSize = true;
            this.LabelValorKM.Location = new System.Drawing.Point(10, 119);
            this.LabelValorKM.Name = "LabelValorKM";
            this.LabelValorKM.Size = new System.Drawing.Size(66, 13);
            this.LabelValorKM.TabIndex = 23;
            this.LabelValorKM.Text = "Valor del Km";
            // 
            // LabelHoraFin
            // 
            this.LabelHoraFin.AutoSize = true;
            this.LabelHoraFin.Location = new System.Drawing.Point(10, 93);
            this.LabelHoraFin.Name = "LabelHoraFin";
            this.LabelHoraFin.Size = new System.Drawing.Size(47, 13);
            this.LabelHoraFin.TabIndex = 22;
            this.LabelHoraFin.Text = "Hora Fin";
            // 
            // LabelHoraInicio
            // 
            this.LabelHoraInicio.AutoSize = true;
            this.LabelHoraInicio.Location = new System.Drawing.Point(10, 67);
            this.LabelHoraInicio.Name = "LabelHoraInicio";
            this.LabelHoraInicio.Size = new System.Drawing.Size(58, 13);
            this.LabelHoraInicio.TabIndex = 21;
            this.LabelHoraInicio.Text = "Hora Inicio";
            // 
            // LabelDescripcion
            // 
            this.LabelDescripcion.AutoSize = true;
            this.LabelDescripcion.Location = new System.Drawing.Point(10, 41);
            this.LabelDescripcion.Name = "LabelDescripcion";
            this.LabelDescripcion.Size = new System.Drawing.Size(63, 13);
            this.LabelDescripcion.TabIndex = 20;
            this.LabelDescripcion.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Modifique los datos que desee";
            // 
            // TextBoxPrecioBase
            // 
            this.TextBoxPrecioBase.Location = new System.Drawing.Point(80, 138);
            this.TextBoxPrecioBase.Name = "TextBoxPrecioBase";
            this.TextBoxPrecioBase.Size = new System.Drawing.Size(182, 20);
            this.TextBoxPrecioBase.TabIndex = 18;
            // 
            // TextBoxValorKM
            // 
            this.TextBoxValorKM.Location = new System.Drawing.Point(80, 112);
            this.TextBoxValorKM.Name = "TextBoxValorKM";
            this.TextBoxValorKM.Size = new System.Drawing.Size(182, 20);
            this.TextBoxValorKM.TabIndex = 17;
            // 
            // TextBoxHoraFin
            // 
            this.TextBoxHoraFin.Location = new System.Drawing.Point(80, 86);
            this.TextBoxHoraFin.Name = "TextBoxHoraFin";
            this.TextBoxHoraFin.Size = new System.Drawing.Size(182, 20);
            this.TextBoxHoraFin.TabIndex = 16;
            // 
            // TextBoxHoraInicio
            // 
            this.TextBoxHoraInicio.Location = new System.Drawing.Point(80, 60);
            this.TextBoxHoraInicio.Name = "TextBoxHoraInicio";
            this.TextBoxHoraInicio.Size = new System.Drawing.Size(182, 20);
            this.TextBoxHoraInicio.TabIndex = 15;
            // 
            // TextBoxDescripcion
            // 
            this.TextBoxDescripcion.Location = new System.Drawing.Point(80, 34);
            this.TextBoxDescripcion.Name = "TextBoxDescripcion";
            this.TextBoxDescripcion.Size = new System.Drawing.Size(182, 20);
            this.TextBoxDescripcion.TabIndex = 14;
            // 
            // checkBoxEstado
            // 
            this.checkBoxEstado.AutoSize = true;
            this.checkBoxEstado.Location = new System.Drawing.Point(80, 165);
            this.checkBoxEstado.Name = "checkBoxEstado";
            this.checkBoxEstado.Size = new System.Drawing.Size(65, 17);
            this.checkBoxEstado.TabIndex = 27;
            this.checkBoxEstado.Text = "Halitado";
            this.checkBoxEstado.UseVisualStyleBackColor = true;
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(10, 169);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(40, 13);
            this.labelEstado.TabIndex = 28;
            this.labelEstado.Text = "Estado";
            // 
            // ModificacionTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.checkBoxEstado);
            this.Controls.Add(this.buttomModificar);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.LabelPrecioBase);
            this.Controls.Add(this.LabelValorKM);
            this.Controls.Add(this.LabelHoraFin);
            this.Controls.Add(this.LabelHoraInicio);
            this.Controls.Add(this.LabelDescripcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxPrecioBase);
            this.Controls.Add(this.TextBoxValorKM);
            this.Controls.Add(this.TextBoxHoraFin);
            this.Controls.Add(this.TextBoxHoraInicio);
            this.Controls.Add(this.TextBoxDescripcion);
            this.Name = "ModificacionTurno";
            this.Text = "ModificacionTurno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttomModificar;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Label LabelPrecioBase;
        private System.Windows.Forms.Label LabelValorKM;
        private System.Windows.Forms.Label LabelHoraFin;
        private System.Windows.Forms.Label LabelHoraInicio;
        private System.Windows.Forms.Label LabelDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxPrecioBase;
        private System.Windows.Forms.TextBox TextBoxValorKM;
        private System.Windows.Forms.TextBox TextBoxHoraFin;
        private System.Windows.Forms.TextBox TextBoxHoraInicio;
        private System.Windows.Forms.TextBox TextBoxDescripcion;
        private CheckBox checkBoxEstado;
        private Label labelEstado;
    }
}