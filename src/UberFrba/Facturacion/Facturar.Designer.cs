namespace UberFrba.Facturacion
{
    partial class Facturar
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
            this.groupBox_DatosFactura = new System.Windows.Forms.GroupBox();
            this.button_Buscar_Viajes = new System.Windows.Forms.Button();
            this.textBox_Fecha_Fin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Fecha_Inicio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox_Viajes = new System.Windows.Forms.GroupBox();
            this.textBox_montoTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView_Viajes = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioBase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorKM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_Limpiar = new System.Windows.Forms.Button();
            this.button_Aceptar = new System.Windows.Forms.Button();
            this.button_Cerrar = new System.Windows.Forms.Button();
            this.groupBox_Cliente = new System.Windows.Forms.GroupBox();
            this.textBox_DNI = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox_DatosFactura.SuspendLayout();
            this.groupBox_Viajes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Viajes)).BeginInit();
            this.groupBox_Cliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_DatosFactura
            // 
            this.groupBox_DatosFactura.Controls.Add(this.button_Buscar_Viajes);
            this.groupBox_DatosFactura.Controls.Add(this.textBox_Fecha_Fin);
            this.groupBox_DatosFactura.Controls.Add(this.label1);
            this.groupBox_DatosFactura.Controls.Add(this.textBox_Fecha_Inicio);
            this.groupBox_DatosFactura.Controls.Add(this.label8);
            this.groupBox_DatosFactura.Location = new System.Drawing.Point(12, 154);
            this.groupBox_DatosFactura.Name = "groupBox_DatosFactura";
            this.groupBox_DatosFactura.Size = new System.Drawing.Size(327, 181);
            this.groupBox_DatosFactura.TabIndex = 1;
            this.groupBox_DatosFactura.TabStop = false;
            this.groupBox_DatosFactura.Text = "Datos de factura";
            // 
            // button_Buscar_Viajes
            // 
            this.button_Buscar_Viajes.Location = new System.Drawing.Point(197, 126);
            this.button_Buscar_Viajes.Name = "button_Buscar_Viajes";
            this.button_Buscar_Viajes.Size = new System.Drawing.Size(103, 23);
            this.button_Buscar_Viajes.TabIndex = 36;
            this.button_Buscar_Viajes.Text = "Buscar Viajes";
            this.button_Buscar_Viajes.UseVisualStyleBackColor = true;
            this.button_Buscar_Viajes.Click += new System.EventHandler(this.button_Buscar_Viajes_Click);
            // 
            // textBox_Fecha_Fin
            // 
            this.textBox_Fecha_Fin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_Fecha_Fin.Location = new System.Drawing.Point(109, 69);
            this.textBox_Fecha_Fin.Name = "textBox_Fecha_Fin";
            this.textBox_Fecha_Fin.ReadOnly = true;
            this.textBox_Fecha_Fin.Size = new System.Drawing.Size(151, 20);
            this.textBox_Fecha_Fin.TabIndex = 35;
            this.textBox_Fecha_Fin.TabStop = false;
            this.textBox_Fecha_Fin.TextChanged += new System.EventHandler(this.textBox_Fecha_Fin_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Fecha fin";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_Fecha_Inicio
            // 
            this.textBox_Fecha_Inicio.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_Fecha_Inicio.Location = new System.Drawing.Point(109, 43);
            this.textBox_Fecha_Inicio.Name = "textBox_Fecha_Inicio";
            this.textBox_Fecha_Inicio.ReadOnly = true;
            this.textBox_Fecha_Inicio.Size = new System.Drawing.Size(151, 20);
            this.textBox_Fecha_Inicio.TabIndex = 29;
            this.textBox_Fecha_Inicio.TabStop = false;
            this.textBox_Fecha_Inicio.TextChanged += new System.EventHandler(this.textBox_Fecha_Inicio_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Fecha inicio";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // groupBox_Viajes
            // 
            this.groupBox_Viajes.Controls.Add(this.textBox_montoTotal);
            this.groupBox_Viajes.Controls.Add(this.label6);
            this.groupBox_Viajes.Controls.Add(this.dataGridView_Viajes);
            this.groupBox_Viajes.Location = new System.Drawing.Point(345, 12);
            this.groupBox_Viajes.Name = "groupBox_Viajes";
            this.groupBox_Viajes.Size = new System.Drawing.Size(556, 323);
            this.groupBox_Viajes.TabIndex = 3;
            this.groupBox_Viajes.TabStop = false;
            this.groupBox_Viajes.Text = "Viajes facturados";
            this.groupBox_Viajes.Enter += new System.EventHandler(this.groupBox_Viajes_Enter);
            // 
            // textBox_montoTotal
            // 
            this.textBox_montoTotal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_montoTotal.Location = new System.Drawing.Point(452, 297);
            this.textBox_montoTotal.Name = "textBox_montoTotal";
            this.textBox_montoTotal.ReadOnly = true;
            this.textBox_montoTotal.Size = new System.Drawing.Size(100, 20);
            this.textBox_montoTotal.TabIndex = 24;
            this.textBox_montoTotal.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(375, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Total a Pagar";
            // 
            // dataGridView_Viajes
            // 
            this.dataGridView_Viajes.AllowUserToAddRows = false;
            this.dataGridView_Viajes.AllowUserToDeleteRows = false;
            this.dataGridView_Viajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Viajes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.PrecioBase,
            this.KM,
            this.ValorKM,
            this.Precio});
            this.dataGridView_Viajes.Location = new System.Drawing.Point(6, 19);
            this.dataGridView_Viajes.Name = "dataGridView_Viajes";
            this.dataGridView_Viajes.ReadOnly = true;
            this.dataGridView_Viajes.Size = new System.Drawing.Size(543, 272);
            this.dataGridView_Viajes.TabIndex = 0;
            this.dataGridView_Viajes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Viajes_CellContentClick);
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // PrecioBase
            // 
            this.PrecioBase.HeaderText = "Precio base";
            this.PrecioBase.Name = "PrecioBase";
            this.PrecioBase.ReadOnly = true;
            // 
            // KM
            // 
            this.KM.HeaderText = "KM";
            this.KM.Name = "KM";
            this.KM.ReadOnly = true;
            // 
            // ValorKM
            // 
            this.ValorKM.HeaderText = "Valor KM";
            this.ValorKM.Name = "ValorKM";
            this.ValorKM.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio unitario";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // button_Limpiar
            // 
            this.button_Limpiar.Location = new System.Drawing.Point(745, 345);
            this.button_Limpiar.Name = "button_Limpiar";
            this.button_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.button_Limpiar.TabIndex = 12;
            this.button_Limpiar.Text = "Limpiar";
            this.button_Limpiar.UseVisualStyleBackColor = true;
            this.button_Limpiar.Click += new System.EventHandler(this.button_Limpiar_Click);
            // 
            // button_Aceptar
            // 
            this.button_Aceptar.Location = new System.Drawing.Point(664, 345);
            this.button_Aceptar.Name = "button_Aceptar";
            this.button_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.button_Aceptar.TabIndex = 11;
            this.button_Aceptar.Text = "Aceptar";
            this.button_Aceptar.UseVisualStyleBackColor = true;
            this.button_Aceptar.Click += new System.EventHandler(this.button_Aceptar_Click);
            // 
            // button_Cerrar
            // 
            this.button_Cerrar.Location = new System.Drawing.Point(826, 345);
            this.button_Cerrar.Name = "button_Cerrar";
            this.button_Cerrar.Size = new System.Drawing.Size(75, 23);
            this.button_Cerrar.TabIndex = 13;
            this.button_Cerrar.Text = "Cerrar";
            this.button_Cerrar.UseVisualStyleBackColor = true;
            this.button_Cerrar.Click += new System.EventHandler(this.button_Cerrar_Click);
            // 
            // groupBox_Cliente
            // 
            this.groupBox_Cliente.Controls.Add(this.textBox_DNI);
            this.groupBox_Cliente.Controls.Add(this.label3);
            this.groupBox_Cliente.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Cliente.Name = "groupBox_Cliente";
            this.groupBox_Cliente.Size = new System.Drawing.Size(327, 136);
            this.groupBox_Cliente.TabIndex = 14;
            this.groupBox_Cliente.TabStop = false;
            this.groupBox_Cliente.Text = "Cliente";
            // 
            // textBox_DNI
            // 
            this.textBox_DNI.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_DNI.Location = new System.Drawing.Point(109, 42);
            this.textBox_DNI.MaxLength = 8;
            this.textBox_DNI.Name = "textBox_DNI";
            this.textBox_DNI.Size = new System.Drawing.Size(151, 20);
            this.textBox_DNI.TabIndex = 38;
            this.textBox_DNI.TabStop = false;
            this.textBox_DNI.TextChanged += new System.EventHandler(this.textBox_DNI_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "DNI";
            // 
            // Facturar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 380);
            this.Controls.Add(this.groupBox_Cliente);
            this.Controls.Add(this.button_Limpiar);
            this.Controls.Add(this.button_Aceptar);
            this.Controls.Add(this.button_Cerrar);
            this.Controls.Add(this.groupBox_Viajes);
            this.Controls.Add(this.groupBox_DatosFactura);
            this.Name = "Facturar";
            this.Text = "Facturación de clientes";
            this.Load += new System.EventHandler(this.Facturar_Load);
            this.groupBox_DatosFactura.ResumeLayout(false);
            this.groupBox_DatosFactura.PerformLayout();
            this.groupBox_Viajes.ResumeLayout(false);
            this.groupBox_Viajes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Viajes)).EndInit();
            this.groupBox_Cliente.ResumeLayout(false);
            this.groupBox_Cliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_DatosFactura;
        private System.Windows.Forms.TextBox textBox_Fecha_Inicio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_Fecha_Fin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Buscar_Viajes;
        private System.Windows.Forms.GroupBox groupBox_Viajes;
        private System.Windows.Forms.DataGridView dataGridView_Viajes;
        private System.Windows.Forms.TextBox textBox_montoTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioBase;
        private System.Windows.Forms.DataGridViewTextBoxColumn KM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorKM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.Button button_Limpiar;
        private System.Windows.Forms.Button button_Aceptar;
        private System.Windows.Forms.Button button_Cerrar;
        private System.Windows.Forms.GroupBox groupBox_Cliente;
        private System.Windows.Forms.TextBox textBox_DNI;
        private System.Windows.Forms.Label label3;
    }
}