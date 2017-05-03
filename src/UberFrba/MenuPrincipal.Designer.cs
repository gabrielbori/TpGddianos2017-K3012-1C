


namespace UberFrba
{
    partial class MenuPrincipal
    {
        
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.abmUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abmClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abmClienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.abmRolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abmFacturacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeViajesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rendicionDeViajesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 5);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abmUsuarioToolStripMenuItem,
            this.abmClienteToolStripMenuItem,
            this.abmClienteToolStripMenuItem1,
            this.abmRolToolStripMenuItem,
            this.abmFacturacionToolStripMenuItem,
            this.registroDeViajesToolStripMenuItem,
            this.rendicionDeViajesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1443, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // abmUsuarioToolStripMenuItem
            // 
            this.abmUsuarioToolStripMenuItem.Name = "abmUsuarioToolStripMenuItem";
            this.abmUsuarioToolStripMenuItem.Size = new System.Drawing.Size(104, 19);
            this.abmUsuarioToolStripMenuItem.Text = "Abm Automovil";
            this.abmUsuarioToolStripMenuItem.Click += new System.EventHandler(this.abmUsuarioToolStripMenuItem_Click);
            // 
            // abmClienteToolStripMenuItem
            // 
            this.abmClienteToolStripMenuItem.Name = "abmClienteToolStripMenuItem";
            this.abmClienteToolStripMenuItem.Size = new System.Drawing.Size(84, 19);
            this.abmClienteToolStripMenuItem.Text = "Abm Chofer";
            // 
            // abmClienteToolStripMenuItem1
            // 
            this.abmClienteToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaToolStripMenuItem,
            this.bajaToolStripMenuItem,
            this.modificacionToolStripMenuItem});
            this.abmClienteToolStripMenuItem1.Name = "abmClienteToolStripMenuItem1";
            this.abmClienteToolStripMenuItem1.Size = new System.Drawing.Size(85, 19);
            this.abmClienteToolStripMenuItem1.Text = "Abm Cliente";
            // 
            // abmRolToolStripMenuItem
            // 
            this.abmRolToolStripMenuItem.Name = "abmRolToolStripMenuItem";
            this.abmRolToolStripMenuItem.Size = new System.Drawing.Size(65, 19);
            this.abmRolToolStripMenuItem.Text = "Abm Rol";
            // 
            // abmFacturacionToolStripMenuItem
            // 
            this.abmFacturacionToolStripMenuItem.Name = "abmFacturacionToolStripMenuItem";
            this.abmFacturacionToolStripMenuItem.Size = new System.Drawing.Size(110, 19);
            this.abmFacturacionToolStripMenuItem.Text = "Abm Facturacion";
            // 
            // registroDeViajesToolStripMenuItem
            // 
            this.registroDeViajesToolStripMenuItem.Name = "registroDeViajesToolStripMenuItem";
            this.registroDeViajesToolStripMenuItem.Size = new System.Drawing.Size(111, 19);
            this.registroDeViajesToolStripMenuItem.Text = "Registro de Viajes";
            // 
            // rendicionDeViajesToolStripMenuItem
            // 
            this.rendicionDeViajesToolStripMenuItem.Name = "rendicionDeViajesToolStripMenuItem";
            this.rendicionDeViajesToolStripMenuItem.Size = new System.Drawing.Size(121, 19);
            this.rendicionDeViajesToolStripMenuItem.Text = "Rendicion de Viajes";
            // 
            // altaToolStripMenuItem
            // 
            this.altaToolStripMenuItem.Name = "altaToolStripMenuItem";
            this.altaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.altaToolStripMenuItem.Text = "Alta";
            // 
            // bajaToolStripMenuItem
            // 
            this.bajaToolStripMenuItem.Name = "bajaToolStripMenuItem";
            this.bajaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bajaToolStripMenuItem.Text = "Baja";
            // 
            // modificacionToolStripMenuItem
            // 
            this.modificacionToolStripMenuItem.Name = "modificacionToolStripMenuItem";
            this.modificacionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.modificacionToolStripMenuItem.Text = "Modificacion";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 629);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuPrincipal";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem abmUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abmClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abmClienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem abmRolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abmFacturacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeViajesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rendicionDeViajesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificacionToolStripMenuItem;


    }
}

