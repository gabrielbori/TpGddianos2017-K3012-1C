namespace UberFrba.Abm_Turno
{
    partial class ModificacionSeleccionTurno
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
            this.paner_Filtros = new System.Windows.Forms.GroupBox();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.button_Limpiar = new System.Windows.Forms.Button();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.button_Buscar = new System.Windows.Forms.Button();
            this.dataGridView_Seleccion = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.paner_Filtros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Seleccion)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(12, 157);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 2;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // paner_Filtros
            // 
            this.paner_Filtros.Controls.Add(this.textBoxDescripcion);
            this.paner_Filtros.Controls.Add(this.button_Limpiar);
            this.paner_Filtros.Controls.Add(this.labelDescripcion);
            this.paner_Filtros.Controls.Add(this.button_Buscar);
            this.paner_Filtros.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.paner_Filtros.ForeColor = System.Drawing.SystemColors.ControlText;
            this.paner_Filtros.Location = new System.Drawing.Point(12, 12);
            this.paner_Filtros.Name = "paner_Filtros";
            this.paner_Filtros.Size = new System.Drawing.Size(387, 118);
            this.paner_Filtros.TabIndex = 43;
            this.paner_Filtros.TabStop = false;
            this.paner_Filtros.Text = "Filtros de busqueda";
            this.paner_Filtros.Enter += new System.EventHandler(this.paner_Filtros_Enter);
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(125, 39);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(232, 20);
            this.textBoxDescripcion.TabIndex = 0;
            this.textBoxDescripcion.Text = "Ingrese la descripcion";
            this.textBoxDescripcion.Click += new System.EventHandler(this.textBoxDescripcion_Click);
            // 
            // button_Limpiar
            // 
            this.button_Limpiar.Location = new System.Drawing.Point(282, 83);
            this.button_Limpiar.Name = "button_Limpiar";
            this.button_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.button_Limpiar.TabIndex = 6;
            this.button_Limpiar.Text = "Limpiar";
            this.button_Limpiar.UseVisualStyleBackColor = true;
            this.button_Limpiar.Click += new System.EventHandler(this.button_Limpiar_Click);
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelDescripcion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelDescripcion.Location = new System.Drawing.Point(42, 46);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(63, 13);
            this.labelDescripcion.TabIndex = 23;
            this.labelDescripcion.Text = "Descripcion";
            // 
            // button_Buscar
            // 
            this.button_Buscar.Location = new System.Drawing.Point(201, 83);
            this.button_Buscar.Name = "button_Buscar";
            this.button_Buscar.Size = new System.Drawing.Size(75, 23);
            this.button_Buscar.TabIndex = 5;
            this.button_Buscar.Text = "Buscar";
            this.button_Buscar.UseVisualStyleBackColor = true;
            this.button_Buscar.Click += new System.EventHandler(this.button_Buscar_Click);
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
            this.dataGridView_Seleccion.Location = new System.Drawing.Point(414, 12);
            this.dataGridView_Seleccion.Name = "dataGridView_Seleccion";
            this.dataGridView_Seleccion.ReadOnly = true;
            this.dataGridView_Seleccion.Size = new System.Drawing.Size(471, 168);
            this.dataGridView_Seleccion.TabIndex = 44;
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
            // ModificacionSeleccionTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 192);
            this.Controls.Add(this.dataGridView_Seleccion);
            this.Controls.Add(this.paner_Filtros);
            this.Controls.Add(this.buttonCancelar);
            this.Name = "ModificacionSeleccionTurno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificacionSeleccionTurno";
            this.paner_Filtros.ResumeLayout(false);
            this.paner_Filtros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Seleccion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.GroupBox paner_Filtros;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.Button button_Limpiar;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Button button_Buscar;
        private System.Windows.Forms.DataGridView dataGridView_Seleccion;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccionar;
    }
}