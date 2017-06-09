namespace UberFrba.Abm_Persona
{
    partial class SeleccionDePersona
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
            this.button_Cerrar = new System.Windows.Forms.Button();
            this.dataGridView_Seleccion = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.paner_Filtros = new System.Windows.Forms.GroupBox();
            this.textBox_Nombre = new System.Windows.Forms.TextBox();
            this.textBox_Apellido = new System.Windows.Forms.TextBox();
            this.button_Limpiar = new System.Windows.Forms.Button();
            this.label_Nombre = new System.Windows.Forms.Label();
            this.label_Apellido = new System.Windows.Forms.Label();
            this.label_Documento = new System.Windows.Forms.Label();
            this.textBox_Documento = new System.Windows.Forms.TextBox();
            this.button_Buscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Seleccion)).BeginInit();
            this.paner_Filtros.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Cerrar
            // 
            this.button_Cerrar.Location = new System.Drawing.Point(818, 225);
            this.button_Cerrar.Name = "button_Cerrar";
            this.button_Cerrar.Size = new System.Drawing.Size(75, 23);
            this.button_Cerrar.TabIndex = 41;
            this.button_Cerrar.Text = "Cerrar";
            this.button_Cerrar.UseVisualStyleBackColor = true;
            this.button_Cerrar.Click += new System.EventHandler(this.button_Cerrar_Click);
            // 
            // dataGridView_Seleccion
            // 
            this.dataGridView_Seleccion.AllowUserToAddRows = false;
            this.dataGridView_Seleccion.AllowUserToDeleteRows = false;
            this.dataGridView_Seleccion.AllowUserToResizeColumns = false;
            this.dataGridView_Seleccion.AllowUserToResizeRows = false;
            this.dataGridView_Seleccion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView_Seleccion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_Seleccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Seleccion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.dataGridView_Seleccion.Location = new System.Drawing.Point(328, 12);
            this.dataGridView_Seleccion.Name = "dataGridView_Seleccion";
            this.dataGridView_Seleccion.ReadOnly = true;
            this.dataGridView_Seleccion.Size = new System.Drawing.Size(565, 168);
            this.dataGridView_Seleccion.TabIndex = 40;
            this.dataGridView_Seleccion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Seleccion_CellContentClick);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            this.Seleccionar.Text = "Seleccionar";
            this.Seleccionar.UseColumnTextForButtonValue = true;
            this.Seleccionar.Width = 69;
            // 
            // paner_Filtros
            // 
            this.paner_Filtros.Controls.Add(this.textBox_Nombre);
            this.paner_Filtros.Controls.Add(this.textBox_Apellido);
            this.paner_Filtros.Controls.Add(this.button_Limpiar);
            this.paner_Filtros.Controls.Add(this.label_Nombre);
            this.paner_Filtros.Controls.Add(this.label_Apellido);
            this.paner_Filtros.Controls.Add(this.label_Documento);
            this.paner_Filtros.Controls.Add(this.textBox_Documento);
            this.paner_Filtros.Controls.Add(this.button_Buscar);
            this.paner_Filtros.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.paner_Filtros.ForeColor = System.Drawing.SystemColors.ControlText;
            this.paner_Filtros.Location = new System.Drawing.Point(8, 8);
            this.paner_Filtros.Name = "paner_Filtros";
            this.paner_Filtros.Size = new System.Drawing.Size(314, 172);
            this.paner_Filtros.TabIndex = 42;
            this.paner_Filtros.TabStop = false;
            this.paner_Filtros.Text = "Filtros de busqueda";
            // 
            // textBox_Nombre
            // 
            this.textBox_Nombre.Location = new System.Drawing.Point(76, 30);
            this.textBox_Nombre.Name = "textBox_Nombre";
            this.textBox_Nombre.Size = new System.Drawing.Size(232, 20);
            this.textBox_Nombre.TabIndex = 0;
            // 
            // textBox_Apellido
            // 
            this.textBox_Apellido.Location = new System.Drawing.Point(76, 56);
            this.textBox_Apellido.Name = "textBox_Apellido";
            this.textBox_Apellido.Size = new System.Drawing.Size(232, 20);
            this.textBox_Apellido.TabIndex = 1;
            // 
            // button_Limpiar
            // 
            this.button_Limpiar.Location = new System.Drawing.Point(220, 143);
            this.button_Limpiar.Name = "button_Limpiar";
            this.button_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.button_Limpiar.TabIndex = 6;
            this.button_Limpiar.Text = "Limpiar";
            this.button_Limpiar.UseVisualStyleBackColor = true;
            this.button_Limpiar.Click += new System.EventHandler(this.button_Limpiar_Click);
            // 
            // label_Nombre
            // 
            this.label_Nombre.AutoSize = true;
            this.label_Nombre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Nombre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Nombre.Location = new System.Drawing.Point(26, 33);
            this.label_Nombre.Name = "label_Nombre";
            this.label_Nombre.Size = new System.Drawing.Size(44, 13);
            this.label_Nombre.TabIndex = 23;
            this.label_Nombre.Text = "Nombre";
            // 
            // label_Apellido
            // 
            this.label_Apellido.AutoSize = true;
            this.label_Apellido.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Apellido.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Apellido.Location = new System.Drawing.Point(26, 59);
            this.label_Apellido.Name = "label_Apellido";
            this.label_Apellido.Size = new System.Drawing.Size(44, 13);
            this.label_Apellido.TabIndex = 24;
            this.label_Apellido.Text = "Apellido";
            // 
            // label_Documento
            // 
            this.label_Documento.AutoSize = true;
            this.label_Documento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Documento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Documento.Location = new System.Drawing.Point(8, 85);
            this.label_Documento.Name = "label_Documento";
            this.label_Documento.Size = new System.Drawing.Size(62, 13);
            this.label_Documento.TabIndex = 25;
            this.label_Documento.Text = "Documento";
            // 
            // textBox_Documento
            // 
            this.textBox_Documento.Location = new System.Drawing.Point(76, 82);
            this.textBox_Documento.Name = "textBox_Documento";
            this.textBox_Documento.Size = new System.Drawing.Size(129, 20);
            this.textBox_Documento.TabIndex = 4;
            // 
            // button_Buscar
            // 
            this.button_Buscar.Location = new System.Drawing.Point(139, 143);
            this.button_Buscar.Name = "button_Buscar";
            this.button_Buscar.Size = new System.Drawing.Size(75, 23);
            this.button_Buscar.TabIndex = 5;
            this.button_Buscar.Text = "Buscar";
            this.button_Buscar.UseVisualStyleBackColor = true;
            this.button_Buscar.Click += new System.EventHandler(this.button_Buscar_Click);
            // 
            // SeleccionDePersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 293);
            this.Controls.Add(this.button_Cerrar);
            this.Controls.Add(this.dataGridView_Seleccion);
            this.Controls.Add(this.paner_Filtros);
            this.Name = "SeleccionDePersona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SeleccionDePersona";
            this.Load += new System.EventHandler(this.SeleccionDePersona_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Seleccion)).EndInit();
            this.paner_Filtros.ResumeLayout(false);
            this.paner_Filtros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Cerrar;
        private System.Windows.Forms.DataGridView dataGridView_Seleccion;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccionar;
        private System.Windows.Forms.GroupBox paner_Filtros;
        private System.Windows.Forms.TextBox textBox_Nombre;
        private System.Windows.Forms.TextBox textBox_Apellido;
        private System.Windows.Forms.Button button_Limpiar;
        private System.Windows.Forms.Label label_Nombre;
        private System.Windows.Forms.Label label_Apellido;
        private System.Windows.Forms.Label label_Documento;
        private System.Windows.Forms.TextBox textBox_Documento;
        private System.Windows.Forms.Button button_Buscar;
    }
}