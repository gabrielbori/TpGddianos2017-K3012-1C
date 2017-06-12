namespace UberFrba.Abm_Automovil
{

    using UberFrba.Model;

    partial class AltaAutomovil : FormBase
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Chofer = new System.Windows.Forms.TextBox();
            this.textBox_Patente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Marca = new System.Windows.Forms.ComboBox();
            this.comboBox_Modelo = new System.Windows.Forms.ComboBox();
            this.labelTurno = new System.Windows.Forms.Label();
            this.Turno = new System.Windows.Forms.CheckedListBox();
            this.button_buscar_chofer = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_chofer_dni = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(274, 326);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 25;
            this.button2.Text = "Crear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Ingrese Los Datos Correspondientes";
            // 
            // textBox_Chofer
            // 
            this.textBox_Chofer.Enabled = false;
            this.textBox_Chofer.Location = new System.Drawing.Point(86, 129);
            this.textBox_Chofer.Name = "textBox_Chofer";
            this.textBox_Chofer.Size = new System.Drawing.Size(181, 20);
            this.textBox_Chofer.TabIndex = 22;
            // 
            // textBox_Patente
            // 
            this.textBox_Patente.Location = new System.Drawing.Point(86, 103);
            this.textBox_Patente.Name = "textBox_Patente";
            this.textBox_Patente.Size = new System.Drawing.Size(181, 20);
            this.textBox_Patente.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Chofer Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Patente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Modelo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Marca";
            // 
            // comboBox_Marca
            // 
            this.comboBox_Marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Marca.FormattingEnabled = true;
            this.comboBox_Marca.Location = new System.Drawing.Point(86, 49);
            this.comboBox_Marca.Name = "comboBox_Marca";
            this.comboBox_Marca.Size = new System.Drawing.Size(181, 21);
            this.comboBox_Marca.TabIndex = 26;
            this.comboBox_Marca.SelectedIndexChanged += new System.EventHandler(this.comboBox_Marca_SelectedIndexChanged);
            // 
            // comboBox_Modelo
            // 
            this.comboBox_Modelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Modelo.FormattingEnabled = true;
            this.comboBox_Modelo.Location = new System.Drawing.Point(86, 76);
            this.comboBox_Modelo.Name = "comboBox_Modelo";
            this.comboBox_Modelo.Size = new System.Drawing.Size(181, 21);
            this.comboBox_Modelo.TabIndex = 27;
            // 
            // labelTurno
            // 
            this.labelTurno.AutoSize = true;
            this.labelTurno.Location = new System.Drawing.Point(26, 210);
            this.labelTurno.Name = "labelTurno";
            this.labelTurno.Size = new System.Drawing.Size(35, 13);
            this.labelTurno.TabIndex = 28;
            this.labelTurno.Text = "Turno";
            // 
            // Turno
            // 
            this.Turno.FormattingEnabled = true;
            this.Turno.Location = new System.Drawing.Point(86, 210);
            this.Turno.Name = "Turno";
            this.Turno.Size = new System.Drawing.Size(181, 94);
            this.Turno.TabIndex = 31;
            // 
            // button_buscar_chofer
            // 
            this.button_buscar_chofer.Location = new System.Drawing.Point(274, 131);
            this.button_buscar_chofer.Name = "button_buscar_chofer";
            this.button_buscar_chofer.Size = new System.Drawing.Size(75, 23);
            this.button_buscar_chofer.TabIndex = 32;
            this.button_buscar_chofer.Text = "Buscar";
            this.button_buscar_chofer.UseVisualStyleBackColor = true;
            this.button_buscar_chofer.Click += new System.EventHandler(this.button_buscar_chofer_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Chofer Dni";
            // 
            // textBox_chofer_dni
            // 
            this.textBox_chofer_dni.Enabled = false;
            this.textBox_chofer_dni.Location = new System.Drawing.Point(86, 164);
            this.textBox_chofer_dni.MaxLength = 9;
            this.textBox_chofer_dni.Name = "textBox_chofer_dni";
            this.textBox_chofer_dni.Size = new System.Drawing.Size(181, 20);
            this.textBox_chofer_dni.TabIndex = 34;
            this.textBox_chofer_dni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_chofer_dni_KeyPress);
            // 
            // AltaAutomovil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 361);
            this.Controls.Add(this.textBox_chofer_dni);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_buscar_chofer);
            this.Controls.Add(this.Turno);
            this.Controls.Add(this.labelTurno);
            this.Controls.Add(this.comboBox_Modelo);
            this.Controls.Add(this.comboBox_Marca);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_Chofer);
            this.Controls.Add(this.textBox_Patente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AltaAutomovil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta De Automovil";
            this.Load += new System.EventHandler(this.AltaAutomovil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Chofer;
        private System.Windows.Forms.TextBox textBox_Patente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Marca;
        private System.Windows.Forms.ComboBox comboBox_Modelo;
        private System.Windows.Forms.Label labelTurno;
        private System.Windows.Forms.CheckedListBox Turno;
        private System.Windows.Forms.Button button_buscar_chofer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_chofer_dni;


    }
}