namespace UberFrba.Abm_Automovil
{

    using UberFrba.Model;

    partial class ModificacionAutomovil : FormBase
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
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.textBoxChofer = new System.Windows.Forms.TextBox();
            this.buttonSeleccionar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxModelo = new System.Windows.Forms.ComboBox();
            this.comboBoxMarca = new System.Windows.Forms.ComboBox();
            this.checkBoxEstado = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxPatente = new System.Windows.Forms.ComboBox();
            this.Turno = new System.Windows.Forms.CheckedListBox();
            this.labelTurno = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(12, 277);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 30;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(197, 277);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 29;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Visible = false;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // textBoxChofer
            // 
            this.textBoxChofer.Location = new System.Drawing.Point(62, 117);
            this.textBoxChofer.Name = "textBoxChofer";
            this.textBoxChofer.Size = new System.Drawing.Size(130, 20);
            this.textBoxChofer.TabIndex = 28;
            // 
            // buttonSeleccionar
            // 
            this.buttonSeleccionar.Location = new System.Drawing.Point(197, 36);
            this.buttonSeleccionar.Name = "buttonSeleccionar";
            this.buttonSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.buttonSeleccionar.TabIndex = 24;
            this.buttonSeleccionar.Text = "Seleccionar";
            this.buttonSeleccionar.UseVisualStyleBackColor = true;
            this.buttonSeleccionar.Click += new System.EventHandler(this.buttonSeleccionar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Chofer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Patente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Modelo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Marca";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Ingrese La Patente Del Automovil A Modificar";
            // 
            // comboBoxModelo
            // 
            this.comboBoxModelo.FormattingEnabled = true;
            this.comboBoxModelo.Location = new System.Drawing.Point(62, 64);
            this.comboBoxModelo.Name = "comboBoxModelo";
            this.comboBoxModelo.Size = new System.Drawing.Size(130, 21);
            this.comboBoxModelo.TabIndex = 48;
            this.comboBoxModelo.SelectedIndexChanged += new System.EventHandler(this.comboBox_Modelo_SelectedIndexChanged);
            // 
            // comboBoxMarca
            // 
            this.comboBoxMarca.FormattingEnabled = true;
            this.comboBoxMarca.Location = new System.Drawing.Point(62, 36);
            this.comboBoxMarca.Name = "comboBoxMarca";
            this.comboBoxMarca.Size = new System.Drawing.Size(130, 21);
            this.comboBoxMarca.TabIndex = 47;
            this.comboBoxMarca.SelectedIndexChanged += new System.EventHandler(this.comboBox_Marca_SelectedIndexChanged);
            // 
            // checkBoxEstado
            // 
            this.checkBoxEstado.AutoSize = true;
            this.checkBoxEstado.Location = new System.Drawing.Point(62, 243);
            this.checkBoxEstado.Name = "checkBoxEstado";
            this.checkBoxEstado.Size = new System.Drawing.Size(73, 17);
            this.checkBoxEstado.TabIndex = 51;
            this.checkBoxEstado.Text = "Habilitado";
            this.checkBoxEstado.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "Estado";
            // 
            // comboBoxPatente
            // 
            this.comboBoxPatente.FormattingEnabled = true;
            this.comboBoxPatente.Location = new System.Drawing.Point(62, 90);
            this.comboBoxPatente.Name = "comboBoxPatente";
            this.comboBoxPatente.Size = new System.Drawing.Size(130, 21);
            this.comboBoxPatente.TabIndex = 52;
            // 
            // Turno
            // 
            this.Turno.FormattingEnabled = true;
            this.Turno.Location = new System.Drawing.Point(62, 143);
            this.Turno.Name = "Turno";
            this.Turno.Size = new System.Drawing.Size(130, 94);
            this.Turno.TabIndex = 53;
            this.Turno.Visible = false;
            // 
            // labelTurno
            // 
            this.labelTurno.AutoSize = true;
            this.labelTurno.Location = new System.Drawing.Point(9, 143);
            this.labelTurno.Name = "labelTurno";
            this.labelTurno.Size = new System.Drawing.Size(35, 13);
            this.labelTurno.TabIndex = 54;
            this.labelTurno.Text = "Turno";
            this.labelTurno.Visible = false;
            // 
            // ModificacionAutomovil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 312);
            this.Controls.Add(this.labelTurno);
            this.Controls.Add(this.Turno);
            this.Controls.Add(this.comboBoxPatente);
            this.Controls.Add(this.checkBoxEstado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxModelo);
            this.Controls.Add(this.comboBoxMarca);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.textBoxChofer);
            this.Controls.Add(this.buttonSeleccionar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ModificacionAutomovil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificacion De Automovil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.TextBox textBoxChofer;
        private System.Windows.Forms.Button buttonSeleccionar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxModelo;
        private System.Windows.Forms.ComboBox comboBoxMarca;
        private System.Windows.Forms.CheckBox checkBoxEstado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxPatente;
        private System.Windows.Forms.CheckedListBox Turno;
        private System.Windows.Forms.Label labelTurno;
    }
}