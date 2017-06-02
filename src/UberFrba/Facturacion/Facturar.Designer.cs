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
            this.dateTimePicker_Fin = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_Inicio = new System.Windows.Forms.DateTimePicker();
            this.textBox_Numero = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button_Buscar_Viajes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox_Viajes = new System.Windows.Forms.GroupBox();
            this.textBox_montoTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView_Viajes = new System.Windows.Forms.DataGridView();
            this.button_Limpiar = new System.Windows.Forms.Button();
            this.button_Aceptar = new System.Windows.Forms.Button();
            this.button_Cerrar = new System.Windows.Forms.Button();
            this.groupBox_Cliente = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Apellido = new System.Windows.Forms.TextBox();
            this.textBox_Nombre = new System.Windows.Forms.TextBox();
            this.button_Cargar_Persona = new System.Windows.Forms.Button();
            this.textBox_Telefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
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
            this.groupBox_DatosFactura.Controls.Add(this.dateTimePicker_Fin);
            this.groupBox_DatosFactura.Controls.Add(this.dateTimePicker_Inicio);
            this.groupBox_DatosFactura.Controls.Add(this.textBox_Numero);
            this.groupBox_DatosFactura.Controls.Add(this.label10);
            this.groupBox_DatosFactura.Controls.Add(this.button_Buscar_Viajes);
            this.groupBox_DatosFactura.Controls.Add(this.label1);
            this.groupBox_DatosFactura.Controls.Add(this.label8);
            this.groupBox_DatosFactura.Location = new System.Drawing.Point(12, 154);
            this.groupBox_DatosFactura.Name = "groupBox_DatosFactura";
            this.groupBox_DatosFactura.Size = new System.Drawing.Size(327, 181);
            this.groupBox_DatosFactura.TabIndex = 1;
            this.groupBox_DatosFactura.TabStop = false;
            this.groupBox_DatosFactura.Text = "Datos de factura";
            // 
            // dateTimePicker_Fin
            // 
            this.dateTimePicker_Fin.Location = new System.Drawing.Point(109, 90);
            this.dateTimePicker_Fin.Name = "dateTimePicker_Fin";
            this.dateTimePicker_Fin.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_Fin.TabIndex = 40;
            // 
            // dateTimePicker_Inicio
            // 
            this.dateTimePicker_Inicio.CustomFormat = "";
            this.dateTimePicker_Inicio.Location = new System.Drawing.Point(109, 64);
            this.dateTimePicker_Inicio.Name = "dateTimePicker_Inicio";
            this.dateTimePicker_Inicio.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_Inicio.TabIndex = 39;
            this.dateTimePicker_Inicio.ValueChanged += new System.EventHandler(this.dateTimePicker_Inicio_ValueChanged);
            // 
            // textBox_Numero
            // 
            this.textBox_Numero.Location = new System.Drawing.Point(109, 41);
            this.textBox_Numero.Name = "textBox_Numero";
            this.textBox_Numero.ReadOnly = true;
            this.textBox_Numero.Size = new System.Drawing.Size(85, 20);
            this.textBox_Numero.TabIndex = 38;
            this.textBox_Numero.TabStop = false;
            this.textBox_Numero.Text = "A generar";
            this.textBox_Numero.TextChanged += new System.EventHandler(this.textBox_Numero_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(59, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "Numero";
            this.label10.Click += new System.EventHandler(this.label10_Click_1);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Fecha fin";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 70);
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
            this.dataGridView_Viajes.Location = new System.Drawing.Point(6, 19);
            this.dataGridView_Viajes.Name = "dataGridView_Viajes";
            this.dataGridView_Viajes.ReadOnly = true;
            this.dataGridView_Viajes.Size = new System.Drawing.Size(543, 272);
            this.dataGridView_Viajes.TabIndex = 0;
            this.dataGridView_Viajes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Viajes_CellContentClick);
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
            this.groupBox_Cliente.Controls.Add(this.label5);
            this.groupBox_Cliente.Controls.Add(this.label2);
            this.groupBox_Cliente.Controls.Add(this.textBox_Apellido);
            this.groupBox_Cliente.Controls.Add(this.textBox_Nombre);
            this.groupBox_Cliente.Controls.Add(this.button_Cargar_Persona);
            this.groupBox_Cliente.Controls.Add(this.textBox_Telefono);
            this.groupBox_Cliente.Controls.Add(this.label4);
            this.groupBox_Cliente.Controls.Add(this.textBox_DNI);
            this.groupBox_Cliente.Controls.Add(this.label3);
            this.groupBox_Cliente.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Cliente.Name = "groupBox_Cliente";
            this.groupBox_Cliente.Size = new System.Drawing.Size(327, 136);
            this.groupBox_Cliente.TabIndex = 14;
            this.groupBox_Cliente.TabStop = false;
            this.groupBox_Cliente.Text = "Cliente";
            this.groupBox_Cliente.Enter += new System.EventHandler(this.groupBox_Cliente_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Apellido";
            // 
            // textBox_Apellido
            // 
            this.textBox_Apellido.Location = new System.Drawing.Point(84, 97);
            this.textBox_Apellido.Name = "textBox_Apellido";
            this.textBox_Apellido.ReadOnly = true;
            this.textBox_Apellido.Size = new System.Drawing.Size(151, 20);
            this.textBox_Apellido.TabIndex = 43;
            this.textBox_Apellido.Visible = false;
            // 
            // textBox_Nombre
            // 
            this.textBox_Nombre.Location = new System.Drawing.Point(84, 71);
            this.textBox_Nombre.Name = "textBox_Nombre";
            this.textBox_Nombre.ReadOnly = true;
            this.textBox_Nombre.Size = new System.Drawing.Size(151, 20);
            this.textBox_Nombre.TabIndex = 42;
            this.textBox_Nombre.Visible = false;
            this.textBox_Nombre.TextChanged += new System.EventHandler(this.textBox_Nombre_TextChanged_1);
            // 
            // button_Cargar_Persona
            // 
            this.button_Cargar_Persona.Location = new System.Drawing.Point(246, 42);
            this.button_Cargar_Persona.Name = "button_Cargar_Persona";
            this.button_Cargar_Persona.Size = new System.Drawing.Size(75, 23);
            this.button_Cargar_Persona.TabIndex = 41;
            this.button_Cargar_Persona.Text = "Cargar";
            this.button_Cargar_Persona.UseVisualStyleBackColor = true;
            this.button_Cargar_Persona.Click += new System.EventHandler(this.button_Cargar_Persona_Click);
            // 
            // textBox_Telefono
            // 
            this.textBox_Telefono.Location = new System.Drawing.Point(84, 45);
            this.textBox_Telefono.Name = "textBox_Telefono";
            this.textBox_Telefono.Size = new System.Drawing.Size(151, 20);
            this.textBox_Telefono.TabIndex = 40;
            this.textBox_Telefono.TextChanged += new System.EventHandler(this.textBox_Telefono_TextChanged);
            this.textBox_Telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Telefono_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Telefono";
            // 
            // textBox_DNI
            // 
            this.textBox_DNI.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_DNI.Location = new System.Drawing.Point(84, 19);
            this.textBox_DNI.MaxLength = 8;
            this.textBox_DNI.Name = "textBox_DNI";
            this.textBox_DNI.Size = new System.Drawing.Size(151, 20);
            this.textBox_DNI.TabIndex = 38;
            this.textBox_DNI.TabStop = false;
            this.textBox_DNI.TextChanged += new System.EventHandler(this.textBox_DNI_TextChanged);
            this.textBox_DNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_DNI_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 22);
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Buscar_Viajes;
        private System.Windows.Forms.GroupBox groupBox_Viajes;
        private System.Windows.Forms.DataGridView dataGridView_Viajes;
        private System.Windows.Forms.TextBox textBox_montoTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_Limpiar;
        private System.Windows.Forms.Button button_Aceptar;
        private System.Windows.Forms.Button button_Cerrar;
        private System.Windows.Forms.GroupBox groupBox_Cliente;
        private System.Windows.Forms.TextBox textBox_DNI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Numero;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Fin;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Inicio;
        private System.Windows.Forms.TextBox textBox_Telefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_Cargar_Persona;
        private System.Windows.Forms.TextBox textBox_Apellido;
        private System.Windows.Forms.TextBox textBox_Nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
    }
}