namespace UberFrba.Listado_Estadistico
{
    partial class ListadoEstadistico
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxTrimestre = new System.Windows.Forms.ComboBox();
            this.textBox_Anio = new System.Windows.Forms.TextBox();
            this.comboBox_Campo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Listado = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView_Listado = new System.Windows.Forms.DataGridView();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Listado)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxTrimestre);
            this.groupBox1.Controls.Add(this.textBox_Anio);
            this.groupBox1.Controls.Add(this.comboBox_Campo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox_Listado);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 320);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selección de Listado y período";
            // 
            // comboBoxTrimestre
            // 
            this.comboBoxTrimestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTrimestre.FormattingEnabled = true;
            this.comboBoxTrimestre.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBoxTrimestre.Location = new System.Drawing.Point(104, 170);
            this.comboBoxTrimestre.Name = "comboBoxTrimestre";
            this.comboBoxTrimestre.Size = new System.Drawing.Size(140, 21);
            this.comboBoxTrimestre.TabIndex = 53;
            // 
            // textBox_Anio
            // 
            this.textBox_Anio.AllowDrop = true;
            this.textBox_Anio.Location = new System.Drawing.Point(104, 126);
            this.textBox_Anio.MaxLength = 4;
            this.textBox_Anio.Name = "textBox_Anio";
            this.textBox_Anio.Size = new System.Drawing.Size(140, 20);
            this.textBox_Anio.TabIndex = 52;
            this.textBox_Anio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Anio_KeyPress);
            // 
            // comboBox_Campo
            // 
            this.comboBox_Campo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Campo.FormattingEnabled = true;
            this.comboBox_Campo.Location = new System.Drawing.Point(104, 72);
            this.comboBox_Campo.Name = "comboBox_Campo";
            this.comboBox_Campo.Size = new System.Drawing.Size(222, 21);
            this.comboBox_Campo.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Campo principal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "Año:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Top 5 de:";
            // 
            // comboBox_Listado
            // 
            this.comboBox_Listado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Listado.FormattingEnabled = true;
            this.comboBox_Listado.Location = new System.Drawing.Point(74, 33);
            this.comboBox_Listado.Name = "comboBox_Listado";
            this.comboBox_Listado.Size = new System.Drawing.Size(252, 21);
            this.comboBox_Listado.TabIndex = 0;
            this.comboBox_Listado.SelectedValueChanged += new System.EventHandler(this.comboBox_Listado_SelectedValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(223, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 45;
            this.button1.Text = "Realizar consulta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Trimestre:";
            // 
            // dataGridView_Listado
            // 
            this.dataGridView_Listado.AllowUserToAddRows = false;
            this.dataGridView_Listado.AllowUserToDeleteRows = false;
            this.dataGridView_Listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Listado.Location = new System.Drawing.Point(379, 12);
            this.dataGridView_Listado.Name = "dataGridView_Listado";
            this.dataGridView_Listado.ReadOnly = true;
            this.dataGridView_Listado.Size = new System.Drawing.Size(518, 320);
            this.dataGridView_Listado.TabIndex = 1;
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.Location = new System.Drawing.Point(792, 350);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(105, 23);
            this.buttonCerrar.TabIndex = 2;
            this.buttonCerrar.Text = "Cerrar";
            this.buttonCerrar.UseVisualStyleBackColor = true;
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(681, 350);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(105, 23);
            this.buttonLimpiar.TabIndex = 4;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // ListadoEstadistico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 385);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.dataGridView_Listado);
            this.Controls.Add(this.groupBox1);
            this.Name = "ListadoEstadistico";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ListadoEstadistico_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Listado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Listado;
        private System.Windows.Forms.DataGridView dataGridView_Listado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.ComboBox comboBox_Campo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Anio;
        private System.Windows.Forms.ComboBox comboBoxTrimestre;
    }
}