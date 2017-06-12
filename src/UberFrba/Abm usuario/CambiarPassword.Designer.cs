namespace UberFrba.Abm_usuario
{
    partial class CambiarPassword
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
            this.label1 = new System.Windows.Forms.Label();
            this.passwordActual = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Contraseña = new System.Windows.Forms.Label();
            this.Usuario = new System.Windows.Forms.Label();
            this.repetirNuevaPass = new System.Windows.Forms.TextBox();
            this.nuevaPassword = new System.Windows.Forms.TextBox();
            this.textbox_usuario = new System.Windows.Forms.TextBox();
            this.button_aceptar = new System.Windows.Forms.Button();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Password Actual";
            // 
            // passwordActual
            // 
            this.passwordActual.Location = new System.Drawing.Point(222, 122);
            this.passwordActual.Name = "passwordActual";
            this.passwordActual.PasswordChar = '*';
            this.passwordActual.Size = new System.Drawing.Size(168, 20);
            this.passwordActual.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Repetir nueva password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Contraseña
            // 
            this.Contraseña.AutoSize = true;
            this.Contraseña.Location = new System.Drawing.Point(84, 190);
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.Size = new System.Drawing.Size(87, 13);
            this.Contraseña.TabIndex = 4;
            this.Contraseña.Text = "Nueva password";
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.Location = new System.Drawing.Point(84, 71);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(43, 13);
            this.Usuario.TabIndex = 3;
            this.Usuario.Text = "Usuario";
            // 
            // repetirNuevaPass
            // 
            this.repetirNuevaPass.Location = new System.Drawing.Point(222, 239);
            this.repetirNuevaPass.Name = "repetirNuevaPass";
            this.repetirNuevaPass.PasswordChar = '*';
            this.repetirNuevaPass.Size = new System.Drawing.Size(168, 20);
            this.repetirNuevaPass.TabIndex = 2;
            // 
            // nuevaPassword
            // 
            this.nuevaPassword.Location = new System.Drawing.Point(222, 183);
            this.nuevaPassword.Name = "nuevaPassword";
            this.nuevaPassword.PasswordChar = '*';
            this.nuevaPassword.Size = new System.Drawing.Size(168, 20);
            this.nuevaPassword.TabIndex = 1;
            // 
            // textbox_usuario
            // 
            this.textbox_usuario.Enabled = false;
            this.textbox_usuario.Location = new System.Drawing.Point(222, 71);
            this.textbox_usuario.Name = "textbox_usuario";
            this.textbox_usuario.Size = new System.Drawing.Size(168, 20);
            this.textbox_usuario.TabIndex = 0;
            this.textbox_usuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button_aceptar
            // 
            this.button_aceptar.Location = new System.Drawing.Point(408, 296);
            this.button_aceptar.Name = "button_aceptar";
            this.button_aceptar.Size = new System.Drawing.Size(75, 23);
            this.button_aceptar.TabIndex = 8;
            this.button_aceptar.Text = "Aceptar";
            this.button_aceptar.UseVisualStyleBackColor = true;
            this.button_aceptar.Click += new System.EventHandler(this.button_aceptar_Click);
            // 
            // button_cancelar
            // 
            this.button_cancelar.Location = new System.Drawing.Point(96, 296);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(75, 23);
            this.button_cancelar.TabIndex = 9;
            this.button_cancelar.Text = "Cancelar";
            this.button_cancelar.UseVisualStyleBackColor = true;
            this.button_cancelar.Click += new System.EventHandler(this.button_cancelar_Click);
            // 
            // CambiarPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 331);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.button_aceptar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordActual);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Contraseña);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.repetirNuevaPass);
            this.Controls.Add(this.nuevaPassword);
            this.Controls.Add(this.textbox_usuario);
            this.Name = "CambiarPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CambiarPassword";
            this.Load += new System.EventHandler(this.CambiarPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textbox_usuario;
        private System.Windows.Forms.TextBox nuevaPassword;
        private System.Windows.Forms.TextBox repetirNuevaPass;
        private System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.Label Contraseña;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwordActual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_aceptar;
        private System.Windows.Forms.Button button_cancelar;
    }
}