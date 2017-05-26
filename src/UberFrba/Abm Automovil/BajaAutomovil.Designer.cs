namespace UberFrba.Abm_Automovil
{

    using UberFrba.Model;

    partial class BajaAutomovil : FormBase
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
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox_Chofer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Marca = new System.Windows.Forms.ComboBox();
            this.comboBox_Modelo = new System.Windows.Forms.ComboBox();
            this.comboBox_Patente = new System.Windows.Forms.ComboBox();
            this.checkBox_Estado = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(15, 213);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 44;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(200, 213);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 43;
            this.button4.Text = "Baja";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox_Chofer
            // 
            this.textBox_Chofer.Enabled = false;
            this.textBox_Chofer.Location = new System.Drawing.Point(65, 133);
            this.textBox_Chofer.Name = "textBox_Chofer";
            this.textBox_Chofer.Size = new System.Drawing.Size(195, 20);
            this.textBox_Chofer.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Chofer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Patente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Modelo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Patente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Ingrese La Patente Del Automovil A Dar De Baja";
            // 
            // comboBox_Marca
            // 
            this.comboBox_Marca.FormattingEnabled = true;
            this.comboBox_Marca.Location = new System.Drawing.Point(65, 52);
            this.comboBox_Marca.Name = "comboBox_Marca";
            this.comboBox_Marca.Size = new System.Drawing.Size(195, 21);
            this.comboBox_Marca.TabIndex = 45;
            this.comboBox_Marca.SelectedIndexChanged += new System.EventHandler(this.comboBox_Marca_SelectedIndexChanged);
            // 
            // comboBox_Modelo
            // 
            this.comboBox_Modelo.FormattingEnabled = true;
            this.comboBox_Modelo.Location = new System.Drawing.Point(65, 80);
            this.comboBox_Modelo.Name = "comboBox_Modelo";
            this.comboBox_Modelo.Size = new System.Drawing.Size(195, 21);
            this.comboBox_Modelo.TabIndex = 46;
            this.comboBox_Modelo.SelectedIndexChanged += new System.EventHandler(this.comboBox_Modelo_SelectedIndexChanged);
            // 
            // comboBox_Patente
            // 
            this.comboBox_Patente.FormattingEnabled = true;
            this.comboBox_Patente.Location = new System.Drawing.Point(65, 106);
            this.comboBox_Patente.Name = "comboBox_Patente";
            this.comboBox_Patente.Size = new System.Drawing.Size(195, 21);
            this.comboBox_Patente.TabIndex = 47;
            this.comboBox_Patente.SelectedIndexChanged += new System.EventHandler(this.comboBox_Patente_SelectedIndexChanged);
            // 
            // checkBox_Estado
            // 
            this.checkBox_Estado.AutoSize = true;
            this.checkBox_Estado.Location = new System.Drawing.Point(65, 159);
            this.checkBox_Estado.Name = "checkBox_Estado";
            this.checkBox_Estado.Size = new System.Drawing.Size(73, 17);
            this.checkBox_Estado.TabIndex = 49;
            this.checkBox_Estado.Text = "Habilitado";
            this.checkBox_Estado.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "Estado";
            // 
            // BajaAutomovil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.checkBox_Estado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox_Patente);
            this.Controls.Add(this.comboBox_Modelo);
            this.Controls.Add(this.comboBox_Marca);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox_Chofer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BajaAutomovil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baja De Automovil";
            this.Load += new System.EventHandler(this.BajaAutomovil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox_Chofer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Marca;
        private System.Windows.Forms.ComboBox comboBox_Modelo;
        private System.Windows.Forms.ComboBox comboBox_Patente;
        private System.Windows.Forms.CheckBox checkBox_Estado;
        private System.Windows.Forms.Label label7;

    }
}