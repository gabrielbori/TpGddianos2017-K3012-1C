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
            this.textBox_chofer_dni = new System.Windows.Forms.TextBox();
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
            this.labelTurnoHabilitado = new System.Windows.Forms.Label();
            this.TurnoDeshabilitado = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_buscar_Chofer = new System.Windows.Forms.Button();
            this.textBox_chofer_nombre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(10, 334);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 30;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(259, 334);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 29;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Visible = false;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // textBox_chofer_dni
            // 
            this.textBox_chofer_dni.Location = new System.Drawing.Point(124, 117);
            this.textBox_chofer_dni.Name = "textBox_chofer_dni";
            this.textBox_chofer_dni.Size = new System.Drawing.Size(130, 20);
            this.textBox_chofer_dni.TabIndex = 28;
            // 
            // buttonSeleccionar
            // 
            this.buttonSeleccionar.Location = new System.Drawing.Point(259, 36);
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
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Chofer Dni";
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
            this.comboBoxModelo.Location = new System.Drawing.Point(124, 64);
            this.comboBoxModelo.Name = "comboBoxModelo";
            this.comboBoxModelo.Size = new System.Drawing.Size(130, 21);
            this.comboBoxModelo.TabIndex = 48;
            this.comboBoxModelo.SelectedIndexChanged += new System.EventHandler(this.comboBox_Modelo_SelectedIndexChanged);
            // 
            // comboBoxMarca
            // 
            this.comboBoxMarca.FormattingEnabled = true;
            this.comboBoxMarca.Location = new System.Drawing.Point(124, 36);
            this.comboBoxMarca.Name = "comboBoxMarca";
            this.comboBoxMarca.Size = new System.Drawing.Size(130, 21);
            this.comboBoxMarca.TabIndex = 47;
            this.comboBoxMarca.SelectedIndexChanged += new System.EventHandler(this.comboBox_Marca_SelectedIndexChanged);
            // 
            // checkBoxEstado
            // 
            this.checkBoxEstado.AutoSize = true;
            this.checkBoxEstado.Location = new System.Drawing.Point(124, 300);
            this.checkBoxEstado.Name = "checkBoxEstado";
            this.checkBoxEstado.Size = new System.Drawing.Size(73, 17);
            this.checkBoxEstado.TabIndex = 51;
            this.checkBoxEstado.Text = "Habilitado";
            this.checkBoxEstado.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "Estado";
            // 
            // comboBoxPatente
            // 
            this.comboBoxPatente.FormattingEnabled = true;
            this.comboBoxPatente.Location = new System.Drawing.Point(124, 90);
            this.comboBoxPatente.Name = "comboBoxPatente";
            this.comboBoxPatente.Size = new System.Drawing.Size(130, 21);
            this.comboBoxPatente.TabIndex = 52;
            // 
            // Turno
            // 
            this.Turno.FormattingEnabled = true;
            this.Turno.Location = new System.Drawing.Point(124, 190);
            this.Turno.Name = "Turno";
            this.Turno.Size = new System.Drawing.Size(130, 49);
            this.Turno.TabIndex = 53;
            this.Turno.Visible = false;
            // 
            // labelTurnoHabilitado
            // 
            this.labelTurnoHabilitado.AutoSize = true;
            this.labelTurnoHabilitado.Location = new System.Drawing.Point(9, 190);
            this.labelTurnoHabilitado.Name = "labelTurnoHabilitado";
            this.labelTurnoHabilitado.Size = new System.Drawing.Size(85, 13);
            this.labelTurnoHabilitado.TabIndex = 54;
            this.labelTurnoHabilitado.Text = "Turno Habilitado";
            this.labelTurnoHabilitado.Visible = false;
            // 
            // TurnoDeshabilitado
            // 
            this.TurnoDeshabilitado.FormattingEnabled = true;
            this.TurnoDeshabilitado.Location = new System.Drawing.Point(124, 245);
            this.TurnoDeshabilitado.Name = "TurnoDeshabilitado";
            this.TurnoDeshabilitado.Size = new System.Drawing.Size(130, 49);
            this.TurnoDeshabilitado.TabIndex = 55;
            this.TurnoDeshabilitado.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 56;
            this.label4.Text = "Turno Deshabilitado";
            this.label4.Visible = false;
            // 
            // button_buscar_Chofer
            // 
            this.button_buscar_Chofer.Location = new System.Drawing.Point(267, 117);
            this.button_buscar_Chofer.Name = "button_buscar_Chofer";
            this.button_buscar_Chofer.Size = new System.Drawing.Size(75, 23);
            this.button_buscar_Chofer.TabIndex = 57;
            this.button_buscar_Chofer.Text = "Buscar Chofer";
            this.button_buscar_Chofer.UseVisualStyleBackColor = true;
            this.button_buscar_Chofer.Click += new System.EventHandler(this.button_buscar_Chofer_Click);
            // 
            // textBox_chofer_nombre
            // 
            this.textBox_chofer_nombre.Location = new System.Drawing.Point(124, 152);
            this.textBox_chofer_nombre.Name = "textBox_chofer_nombre";
            this.textBox_chofer_nombre.Size = new System.Drawing.Size(130, 20);
            this.textBox_chofer_nombre.TabIndex = 58;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 59;
            this.label8.Text = "Chofer nombre";
            // 
            // ModificacionAutomovil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 395);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_chofer_nombre);
            this.Controls.Add(this.button_buscar_Chofer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TurnoDeshabilitado);
            this.Controls.Add(this.labelTurnoHabilitado);
            this.Controls.Add(this.Turno);
            this.Controls.Add(this.comboBoxPatente);
            this.Controls.Add(this.checkBoxEstado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxModelo);
            this.Controls.Add(this.comboBoxMarca);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.textBox_chofer_dni);
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
        private System.Windows.Forms.TextBox textBox_chofer_dni;
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
        private System.Windows.Forms.Label labelTurnoHabilitado;
        private System.Windows.Forms.CheckedListBox TurnoDeshabilitado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_buscar_Chofer;
        private System.Windows.Forms.TextBox textBox_chofer_nombre;
        private System.Windows.Forms.Label label8;
    }
}