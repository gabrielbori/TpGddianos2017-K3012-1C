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
            this.textBox_Marca = new System.Windows.Forms.TextBox();
            this.textBox_Modelo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(197, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 25;
            this.button2.Text = "Crear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 227);
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
            this.textBox_Chofer.Location = new System.Drawing.Point(76, 129);
            this.textBox_Chofer.Name = "textBox_Chofer";
            this.textBox_Chofer.Size = new System.Drawing.Size(150, 20);
            this.textBox_Chofer.TabIndex = 22;
            this.textBox_Chofer.TextChanged += new System.EventHandler(this.TextBox_Chofer_TextChanged_1);
            // 
            // textBox_Patente
            // 
            this.textBox_Patente.Location = new System.Drawing.Point(76, 103);
            this.textBox_Patente.Name = "textBox_Patente";
            this.textBox_Patente.Size = new System.Drawing.Size(150, 20);
            this.textBox_Patente.TabIndex = 21;
            this.textBox_Patente.TextChanged += new System.EventHandler(this.TextBox_Patente_TextChanged_1);
            // 
            // textBox_Marca
            // 
            this.textBox_Marca.Location = new System.Drawing.Point(76, 51);
            this.textBox_Marca.Name = "textBox_Marca";
            this.textBox_Marca.Size = new System.Drawing.Size(150, 20);
            this.textBox_Marca.TabIndex = 20;
            this.textBox_Marca.TextChanged += new System.EventHandler(this.textBox_Marca_TextChanged);
            // 
            // textBox_Modelo
            // 
            this.textBox_Modelo.Location = new System.Drawing.Point(76, 77);
            this.textBox_Modelo.Name = "textBox_Modelo";
            this.textBox_Modelo.Size = new System.Drawing.Size(150, 20);
            this.textBox_Modelo.TabIndex = 19;
            this.textBox_Modelo.TextChanged += new System.EventHandler(this.TextBox_Modelo_TextChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Chofer";
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
            // AltaAutomovil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_Chofer);
            this.Controls.Add(this.textBox_Patente);
            this.Controls.Add(this.textBox_Marca);
            this.Controls.Add(this.textBox_Modelo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AltaAutomovil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta De Automovil";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Chofer;
        private System.Windows.Forms.TextBox textBox_Patente;
        private System.Windows.Forms.TextBox textBox_Marca;
        private System.Windows.Forms.TextBox textBox_Modelo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;


    }
}