namespace UberFrba.Abm_Turno
{
    partial class AltaTurno
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
            this.TextBoxDescripcion = new System.Windows.Forms.TextBox();
            this.TextBoxHoraInicio = new System.Windows.Forms.TextBox();
            this.TextBoxHoraFin = new System.Windows.Forms.TextBox();
            this.TextBoxValorKM = new System.Windows.Forms.TextBox();
            this.TextBoxPrecioBase = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelDescripcion = new System.Windows.Forms.Label();
            this.LabelHoraInicio = new System.Windows.Forms.Label();
            this.LabelHoraFin = new System.Windows.Forms.Label();
            this.LabelValorKM = new System.Windows.Forms.Label();
            this.LabelPrecioBase = new System.Windows.Forms.Label();
            this.Cancelar = new System.Windows.Forms.Button();
            this.Alta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxDescripcion
            // 
            this.TextBoxDescripcion.Location = new System.Drawing.Point(79, 48);
            this.TextBoxDescripcion.Name = "TextBoxDescripcion";
            this.TextBoxDescripcion.Size = new System.Drawing.Size(182, 20);
            this.TextBoxDescripcion.TabIndex = 1;
            // 
            // TextBoxHoraInicio
            // 
            this.TextBoxHoraInicio.Location = new System.Drawing.Point(79, 74);
            this.TextBoxHoraInicio.Name = "TextBoxHoraInicio";
            this.TextBoxHoraInicio.Size = new System.Drawing.Size(182, 20);
            this.TextBoxHoraInicio.TabIndex = 2;
            // 
            // TextBoxHoraFin
            // 
            this.TextBoxHoraFin.Location = new System.Drawing.Point(79, 100);
            this.TextBoxHoraFin.Name = "TextBoxHoraFin";
            this.TextBoxHoraFin.Size = new System.Drawing.Size(182, 20);
            this.TextBoxHoraFin.TabIndex = 3;
            // 
            // TextBoxValorKM
            // 
            this.TextBoxValorKM.Location = new System.Drawing.Point(79, 126);
            this.TextBoxValorKM.Name = "TextBoxValorKM";
            this.TextBoxValorKM.Size = new System.Drawing.Size(182, 20);
            this.TextBoxValorKM.TabIndex = 4;
            this.TextBoxValorKM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxValorKM_KeyPress);
            // 
            // TextBoxPrecioBase
            // 
            this.TextBoxPrecioBase.Location = new System.Drawing.Point(79, 152);
            this.TextBoxPrecioBase.Name = "TextBoxPrecioBase";
            this.TextBoxPrecioBase.Size = new System.Drawing.Size(182, 20);
            this.TextBoxPrecioBase.TabIndex = 5;
            this.TextBoxPrecioBase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxPrecioBase_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ingrese los datos del turno a dar de alta";
            // 
            // LabelDescripcion
            // 
            this.LabelDescripcion.AutoSize = true;
            this.LabelDescripcion.Location = new System.Drawing.Point(9, 55);
            this.LabelDescripcion.Name = "LabelDescripcion";
            this.LabelDescripcion.Size = new System.Drawing.Size(63, 13);
            this.LabelDescripcion.TabIndex = 7;
            this.LabelDescripcion.Text = "Descripcion";
            // 
            // LabelHoraInicio
            // 
            this.LabelHoraInicio.AutoSize = true;
            this.LabelHoraInicio.Location = new System.Drawing.Point(9, 81);
            this.LabelHoraInicio.Name = "LabelHoraInicio";
            this.LabelHoraInicio.Size = new System.Drawing.Size(58, 13);
            this.LabelHoraInicio.TabIndex = 8;
            this.LabelHoraInicio.Text = "Hora Inicio";
            // 
            // LabelHoraFin
            // 
            this.LabelHoraFin.AutoSize = true;
            this.LabelHoraFin.Location = new System.Drawing.Point(9, 107);
            this.LabelHoraFin.Name = "LabelHoraFin";
            this.LabelHoraFin.Size = new System.Drawing.Size(47, 13);
            this.LabelHoraFin.TabIndex = 9;
            this.LabelHoraFin.Text = "Hora Fin";
            // 
            // LabelValorKM
            // 
            this.LabelValorKM.AutoSize = true;
            this.LabelValorKM.Location = new System.Drawing.Point(9, 133);
            this.LabelValorKM.Name = "LabelValorKM";
            this.LabelValorKM.Size = new System.Drawing.Size(66, 13);
            this.LabelValorKM.TabIndex = 10;
            this.LabelValorKM.Text = "Valor del Km";
            // 
            // LabelPrecioBase
            // 
            this.LabelPrecioBase.AutoSize = true;
            this.LabelPrecioBase.Location = new System.Drawing.Point(9, 159);
            this.LabelPrecioBase.Name = "LabelPrecioBase";
            this.LabelPrecioBase.Size = new System.Drawing.Size(64, 13);
            this.LabelPrecioBase.TabIndex = 11;
            this.LabelPrecioBase.Text = "Precio Base";
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(12, 203);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 12;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Alta
            // 
            this.Alta.Location = new System.Drawing.Point(197, 203);
            this.Alta.Name = "Alta";
            this.Alta.Size = new System.Drawing.Size(75, 23);
            this.Alta.TabIndex = 13;
            this.Alta.Text = "Alta";
            this.Alta.UseVisualStyleBackColor = true;
            this.Alta.Click += new System.EventHandler(this.Alta_Click);
            // 
            // AltaTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 238);
            this.Controls.Add(this.Alta);
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
            this.Name = "AltaTurno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AltaTurno";
            this.Load += new System.EventHandler(this.AltaTurno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxDescripcion;
        private System.Windows.Forms.TextBox TextBoxHoraInicio;
        private System.Windows.Forms.TextBox TextBoxHoraFin;
        private System.Windows.Forms.TextBox TextBoxValorKM;
        private System.Windows.Forms.TextBox TextBoxPrecioBase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelDescripcion;
        private System.Windows.Forms.Label LabelHoraInicio;
        private System.Windows.Forms.Label LabelHoraFin;
        private System.Windows.Forms.Label LabelValorKM;
        private System.Windows.Forms.Label LabelPrecioBase;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button Alta;
    }
}