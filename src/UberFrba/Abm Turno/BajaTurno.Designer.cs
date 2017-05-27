namespace UberFrba.Abm_Turno
{
    partial class BajaTurno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxHoraInicio = new System.Windows.Forms.ComboBox();
            this.comboBoxHoraFin = new System.Windows.Forms.ComboBox();
            this.comboBoxDescripcion = new System.Windows.Forms.ComboBox();
            this.LabelHoraFin = new System.Windows.Forms.Label();
            this.LabelHoraInicio = new System.Windows.Forms.Label();
            this.LabelDescripcion = new System.Windows.Forms.Label();
            this.Cancelar = new System.Windows.Forms.Button();
            this.buttonBaja = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione los datos del turno a dar de baja";
            // 
            // comboBoxHoraInicio
            // 
            this.comboBoxHoraInicio.FormattingEnabled = true;
            this.comboBoxHoraInicio.Location = new System.Drawing.Point(98, 80);
            this.comboBoxHoraInicio.Name = "comboBoxHoraInicio";
            this.comboBoxHoraInicio.Size = new System.Drawing.Size(172, 21);
            this.comboBoxHoraInicio.TabIndex = 1;
            this.comboBoxHoraInicio.SelectedIndexChanged += new System.EventHandler(this.comboBoxHoraInicio_SelectedIndexChanged);
            // 
            // comboBoxHoraFin
            // 
            this.comboBoxHoraFin.FormattingEnabled = true;
            this.comboBoxHoraFin.Location = new System.Drawing.Point(98, 107);
            this.comboBoxHoraFin.Name = "comboBoxHoraFin";
            this.comboBoxHoraFin.Size = new System.Drawing.Size(172, 21);
            this.comboBoxHoraFin.TabIndex = 2;
            // 
            // comboBoxDescripcion
            // 
            this.comboBoxDescripcion.FormattingEnabled = true;
            this.comboBoxDescripcion.Location = new System.Drawing.Point(98, 55);
            this.comboBoxDescripcion.Name = "comboBoxDescripcion";
            this.comboBoxDescripcion.Size = new System.Drawing.Size(172, 21);
            this.comboBoxDescripcion.TabIndex = 3;
            this.comboBoxDescripcion.SelectedIndexChanged += new System.EventHandler(this.comboBoxDescripcion_SelectedIndexChanged);
            // 
            // LabelHoraFin
            // 
            this.LabelHoraFin.AutoSize = true;
            this.LabelHoraFin.Location = new System.Drawing.Point(29, 114);
            this.LabelHoraFin.Name = "LabelHoraFin";
            this.LabelHoraFin.Size = new System.Drawing.Size(47, 13);
            this.LabelHoraFin.TabIndex = 12;
            this.LabelHoraFin.Text = "Hora Fin";
            // 
            // LabelHoraInicio
            // 
            this.LabelHoraInicio.AutoSize = true;
            this.LabelHoraInicio.Location = new System.Drawing.Point(29, 88);
            this.LabelHoraInicio.Name = "LabelHoraInicio";
            this.LabelHoraInicio.Size = new System.Drawing.Size(58, 13);
            this.LabelHoraInicio.TabIndex = 11;
            this.LabelHoraInicio.Text = "Hora Inicio";
            // 
            // LabelDescripcion
            // 
            this.LabelDescripcion.AutoSize = true;
            this.LabelDescripcion.Location = new System.Drawing.Point(29, 62);
            this.LabelDescripcion.Name = "LabelDescripcion";
            this.LabelDescripcion.Size = new System.Drawing.Size(63, 13);
            this.LabelDescripcion.TabIndex = 10;
            this.LabelDescripcion.Text = "Descripcion";
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(12, 171);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 13;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // buttonBaja
            // 
            this.buttonBaja.Location = new System.Drawing.Point(218, 171);
            this.buttonBaja.Name = "buttonBaja";
            this.buttonBaja.Size = new System.Drawing.Size(75, 23);
            this.buttonBaja.TabIndex = 14;
            this.buttonBaja.Text = "Baja";
            this.buttonBaja.UseVisualStyleBackColor = true;
            this.buttonBaja.Click += new System.EventHandler(this.buttonBaja_Click);
            // 
            // BajaTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 206);
            this.Controls.Add(this.buttonBaja);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.LabelHoraFin);
            this.Controls.Add(this.LabelHoraInicio);
            this.Controls.Add(this.LabelDescripcion);
            this.Controls.Add(this.comboBoxDescripcion);
            this.Controls.Add(this.comboBoxHoraFin);
            this.Controls.Add(this.comboBoxHoraInicio);
            this.Controls.Add(this.label1);
            this.Name = "BajaTurno";
            this.Text = "BajaTurno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxHoraInicio;
        private System.Windows.Forms.ComboBox comboBoxHoraFin;
        private System.Windows.Forms.ComboBox comboBoxDescripcion;
        private System.Windows.Forms.Label LabelHoraFin;
        private System.Windows.Forms.Label LabelHoraInicio;
        private System.Windows.Forms.Label LabelDescripcion;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button buttonBaja;
    }
}