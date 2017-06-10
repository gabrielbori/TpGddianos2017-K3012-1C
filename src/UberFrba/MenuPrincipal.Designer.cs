namespace UberFrba
{
    partial class MenuPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.abmAutomovilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaAutomovil = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaAutomovil = new System.Windows.Forms.ToolStripMenuItem();
            this.modificacionAutomovil = new System.Windows.Forms.ToolStripMenuItem();
            this.abmChoferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaChofer = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaChofer = new System.Windows.Forms.ToolStripMenuItem();
            this.modificacionChofer = new System.Windows.Forms.ToolStripMenuItem();
            this.abmClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.modificacionCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.facturacion = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoEstadistico = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeViajes = new System.Windows.Forms.ToolStripMenuItem();
            this.rendicionDeViajes = new System.Windows.Forms.ToolStripMenuItem();
            this.rolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaRol = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaRol = new System.Windows.Forms.ToolStripMenuItem();
            this.modificacionRol = new System.Windows.Forms.ToolStripMenuItem();
            this.turnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaTurno = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaTurno = new System.Windows.Forms.ToolStripMenuItem();
            this.modificacionTurno = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiònToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abmAutomovilToolStripMenuItem,
            this.abmChoferToolStripMenuItem,
            this.abmClienteToolStripMenuItem,
            this.facturacion,
            this.listadoEstadistico,
            this.registroDeViajes,
            this.rendicionDeViajes,
            this.rolToolStripMenuItem,
            this.turnosToolStripMenuItem,
            this.cambiarPassword,
            this.cerrarSesiònToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1093, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // abmAutomovilToolStripMenuItem
            // 
            this.abmAutomovilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaAutomovil,
            this.bajaAutomovil,
            this.modificacionAutomovil});
            this.abmAutomovilToolStripMenuItem.Name = "abmAutomovilToolStripMenuItem";
            this.abmAutomovilToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.abmAutomovilToolStripMenuItem.Text = "Automovil";
            // 
            // altaAutomovil
            // 
            this.altaAutomovil.Name = "altaAutomovil";
            this.altaAutomovil.Size = new System.Drawing.Size(144, 22);
            this.altaAutomovil.Text = "Alta";
            this.altaAutomovil.Click += new System.EventHandler(this.altaAutomovil_click);
            // 
            // bajaAutomovil
            // 
            this.bajaAutomovil.Name = "bajaAutomovil";
            this.bajaAutomovil.Size = new System.Drawing.Size(144, 22);
            this.bajaAutomovil.Text = "Baja";
            this.bajaAutomovil.Click += new System.EventHandler(this.bajaAutomovil_click);
            // 
            // modificacionAutomovil
            // 
            this.modificacionAutomovil.Name = "modificacionAutomovil";
            this.modificacionAutomovil.Size = new System.Drawing.Size(144, 22);
            this.modificacionAutomovil.Text = "Modificacion";
            this.modificacionAutomovil.Click += new System.EventHandler(this.modificacionAutomovil_click);
            // 
            // abmChoferToolStripMenuItem
            // 
            this.abmChoferToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaChofer,
            this.bajaChofer,
            this.modificacionChofer});
            this.abmChoferToolStripMenuItem.Name = "abmChoferToolStripMenuItem";
            this.abmChoferToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.abmChoferToolStripMenuItem.Text = "Chofer";
            // 
            // altaChofer
            // 
            this.altaChofer.Name = "altaChofer";
            this.altaChofer.Size = new System.Drawing.Size(144, 22);
            this.altaChofer.Text = "Alta";
            this.altaChofer.Click += new System.EventHandler(this.altaChofer_click);
            // 
            // bajaChofer
            // 
            this.bajaChofer.Name = "bajaChofer";
            this.bajaChofer.Size = new System.Drawing.Size(144, 22);
            this.bajaChofer.Text = "Baja";
            this.bajaChofer.Click += new System.EventHandler(this.bajaChofer_click);
            // 
            // modificacionChofer
            // 
            this.modificacionChofer.Name = "modificacionChofer";
            this.modificacionChofer.Size = new System.Drawing.Size(144, 22);
            this.modificacionChofer.Text = "Modificacion";
            this.modificacionChofer.Click += new System.EventHandler(this.modificacionChofer_click);
            // 
            // abmClienteToolStripMenuItem
            // 
            this.abmClienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaCliente,
            this.bajaCliente,
            this.modificacionCliente});
            this.abmClienteToolStripMenuItem.Name = "abmClienteToolStripMenuItem";
            this.abmClienteToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.abmClienteToolStripMenuItem.Text = "Cliente";
            // 
            // altaCliente
            // 
            this.altaCliente.Name = "altaCliente";
            this.altaCliente.Size = new System.Drawing.Size(144, 22);
            this.altaCliente.Text = "Alta";
            this.altaCliente.Click += new System.EventHandler(this.altaCliente_click);
            // 
            // bajaCliente
            // 
            this.bajaCliente.Name = "bajaCliente";
            this.bajaCliente.Size = new System.Drawing.Size(144, 22);
            this.bajaCliente.Text = "Baja";
            this.bajaCliente.Click += new System.EventHandler(this.bajaCliente_click);
            // 
            // modificacionCliente
            // 
            this.modificacionCliente.Name = "modificacionCliente";
            this.modificacionCliente.Size = new System.Drawing.Size(144, 22);
            this.modificacionCliente.Text = "Modificacion";
            this.modificacionCliente.Click += new System.EventHandler(this.modificacionCliente_click);
            // 
            // facturacion
            // 
            this.facturacion.Name = "facturacion";
            this.facturacion.Size = new System.Drawing.Size(81, 20);
            this.facturacion.Text = "Facturacion";
            this.facturacion.Click += new System.EventHandler(this.facturacionToolStripMenuItem_click);
            // 
            // listadoEstadistico
            // 
            this.listadoEstadistico.Name = "listadoEstadistico";
            this.listadoEstadistico.Size = new System.Drawing.Size(116, 20);
            this.listadoEstadistico.Text = "Listado estadistico";
            this.listadoEstadistico.Click += new System.EventHandler(this.listadoEstadisticoToolStripMenuItem_Click);
            // 
            // registroDeViajes
            // 
            this.registroDeViajes.Name = "registroDeViajes";
            this.registroDeViajes.Size = new System.Drawing.Size(110, 20);
            this.registroDeViajes.Text = "Registro de viajes";
            this.registroDeViajes.Click += new System.EventHandler(this.registroDeViajeToolStripMenuItem_Click);
            // 
            // rendicionDeViajes
            // 
            this.rendicionDeViajes.Name = "rendicionDeViajes";
            this.rendicionDeViajes.Size = new System.Drawing.Size(120, 20);
            this.rendicionDeViajes.Text = "Rendicion de viajes";
            this.rendicionDeViajes.Click += new System.EventHandler(this.rendicionDeViajesToolStripMenuItem_Click);
            // 
            // rolToolStripMenuItem
            // 
            this.rolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaRol,
            this.bajaRol,
            this.modificacionRol});
            this.rolToolStripMenuItem.Name = "rolToolStripMenuItem";
            this.rolToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.rolToolStripMenuItem.Text = "Rol";
            // 
            // altaRol
            // 
            this.altaRol.Name = "altaRol";
            this.altaRol.Size = new System.Drawing.Size(144, 22);
            this.altaRol.Text = "Alta";
            this.altaRol.Click += new System.EventHandler(this.altaRol_click);
            // 
            // bajaRol
            // 
            this.bajaRol.Name = "bajaRol";
            this.bajaRol.Size = new System.Drawing.Size(144, 22);
            this.bajaRol.Text = "Baja";
            this.bajaRol.Click += new System.EventHandler(this.bajaRol_click);
            // 
            // modificacionRol
            // 
            this.modificacionRol.Name = "modificacionRol";
            this.modificacionRol.Size = new System.Drawing.Size(144, 22);
            this.modificacionRol.Text = "Modificacion";
            this.modificacionRol.Click += new System.EventHandler(this.modificacionRol_click);
            // 
            // turnosToolStripMenuItem
            // 
            this.turnosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaTurno,
            this.bajaTurno,
            this.modificacionTurno});
            this.turnosToolStripMenuItem.Name = "turnosToolStripMenuItem";
            this.turnosToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.turnosToolStripMenuItem.Text = "Turnos";
            // 
            // altaTurno
            // 
            this.altaTurno.Name = "altaTurno";
            this.altaTurno.Size = new System.Drawing.Size(152, 22);
            this.altaTurno.Text = "Alta";
            this.altaTurno.Click += new System.EventHandler(this.altaTurno_Click);
            // 
            // bajaTurno
            // 
            this.bajaTurno.Name = "bajaTurno";
            this.bajaTurno.Size = new System.Drawing.Size(152, 22);
            this.bajaTurno.Text = "Baja";
            this.bajaTurno.Click += new System.EventHandler(this.bajaTurno_Click);
            // 
            // modificacionTurno
            // 
            this.modificacionTurno.Name = "modificacionTurno";
            this.modificacionTurno.Size = new System.Drawing.Size(152, 22);
            this.modificacionTurno.Text = "Modificacion";
            this.modificacionTurno.Click += new System.EventHandler(this.modificacionTurno_Click);
            // 
            // cambiarPassword
            // 
            this.cambiarPassword.Name = "cambiarPassword";
            this.cambiarPassword.Size = new System.Drawing.Size(119, 20);
            this.cambiarPassword.Text = "Cambiar_Password";
            this.cambiarPassword.Click += new System.EventHandler(this.cambiarPassword_Click);
            // 
            // cerrarSesiònToolStripMenuItem
            // 
            this.cerrarSesiònToolStripMenuItem.Name = "cerrarSesiònToolStripMenuItem";
            this.cerrarSesiònToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.cerrarSesiònToolStripMenuItem.Text = "Cerrar sesiòn";
            this.cerrarSesiònToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 620);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UberFrba";
            this.Load += new System.EventHandler(this.FormBase_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem abmAutomovilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abmChoferToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abmClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturacion;
        private System.Windows.Forms.ToolStripMenuItem altaAutomovil;
        private System.Windows.Forms.ToolStripMenuItem bajaAutomovil;
        private System.Windows.Forms.ToolStripMenuItem modificacionAutomovil;
        private System.Windows.Forms.ToolStripMenuItem altaChofer;
        private System.Windows.Forms.ToolStripMenuItem bajaChofer;
        private System.Windows.Forms.ToolStripMenuItem modificacionChofer;
        private System.Windows.Forms.ToolStripMenuItem altaCliente;
        private System.Windows.Forms.ToolStripMenuItem bajaCliente;
        private System.Windows.Forms.ToolStripMenuItem modificacionCliente;
        private System.Windows.Forms.ToolStripMenuItem listadoEstadistico;
        private System.Windows.Forms.ToolStripMenuItem registroDeViajes;
        private System.Windows.Forms.ToolStripMenuItem rendicionDeViajes;
        private System.Windows.Forms.ToolStripMenuItem rolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaRol;
        private System.Windows.Forms.ToolStripMenuItem bajaRol;
        private System.Windows.Forms.ToolStripMenuItem modificacionRol;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiònToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaTurno;
        private System.Windows.Forms.ToolStripMenuItem bajaTurno;
        private System.Windows.Forms.ToolStripMenuItem modificacionTurno;
        private System.Windows.Forms.ToolStripMenuItem cambiarPassword;
    }
}