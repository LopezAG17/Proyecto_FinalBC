
namespace Proyecto_FinalBC
{
    partial class Loging
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
            this.components = new System.ComponentModel.Container();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.LblClave = new System.Windows.Forms.Label();
            this.TxTUsuario = new System.Windows.Forms.TextBox();
            this.TxTClave = new System.Windows.Forms.TextBox();
            this.BtNEntrar = new System.Windows.Forms.Button();
            this.BtNSalir = new System.Windows.Forms.Button();
            this.BtNRegistro = new System.Windows.Forms.Button();
            this.LBLContador = new System.Windows.Forms.Label();
            this.CloseTime = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.Image = global::Proyecto_FinalBC.Properties.Resources.Login__principal;
            this.LblUsuario.Location = new System.Drawing.Point(381, 161);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(99, 28);
            this.LblUsuario.TabIndex = 0;
            this.LblUsuario.Text = "Usuario";
            // 
            // LblClave
            // 
            this.LblClave.AutoSize = true;
            this.LblClave.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblClave.Image = global::Proyecto_FinalBC.Properties.Resources.Login__principal;
            this.LblClave.Location = new System.Drawing.Point(381, 225);
            this.LblClave.Name = "LblClave";
            this.LblClave.Size = new System.Drawing.Size(142, 28);
            this.LblClave.TabIndex = 1;
            this.LblClave.Text = "Contraceña";
            this.LblClave.Click += new System.EventHandler(this.label2_Click);
            // 
            // TxTUsuario
            // 
            this.TxTUsuario.Location = new System.Drawing.Point(386, 192);
            this.TxTUsuario.Name = "TxTUsuario";
            this.TxTUsuario.Size = new System.Drawing.Size(155, 20);
            this.TxTUsuario.TabIndex = 2;
            this.TxTUsuario.Validated += new System.EventHandler(this.TxTUsuario_Validated);
            // 
            // TxTClave
            // 
            this.TxTClave.Location = new System.Drawing.Point(386, 256);
            this.TxTClave.MaxLength = 35;
            this.TxTClave.Name = "TxTClave";
            this.TxTClave.PasswordChar = '*';
            this.TxTClave.Size = new System.Drawing.Size(155, 20);
            this.TxTClave.TabIndex = 3;
            this.TxTClave.Validated += new System.EventHandler(this.TxTClave_Validated);
            // 
            // BtNEntrar
            // 
            this.BtNEntrar.Location = new System.Drawing.Point(386, 282);
            this.BtNEntrar.Name = "BtNEntrar";
            this.BtNEntrar.Size = new System.Drawing.Size(75, 23);
            this.BtNEntrar.TabIndex = 4;
            this.BtNEntrar.Text = "Iniciar";
            this.BtNEntrar.UseVisualStyleBackColor = true;
            this.BtNEntrar.Click += new System.EventHandler(this.BtNEntrar_Click);
            // 
            // BtNSalir
            // 
            this.BtNSalir.Location = new System.Drawing.Point(466, 282);
            this.BtNSalir.Name = "BtNSalir";
            this.BtNSalir.Size = new System.Drawing.Size(75, 23);
            this.BtNSalir.TabIndex = 5;
            this.BtNSalir.Text = "Salir";
            this.BtNSalir.UseVisualStyleBackColor = true;
            this.BtNSalir.Click += new System.EventHandler(this.BtNSalir_Click);
            // 
            // BtNRegistro
            // 
            this.BtNRegistro.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtNRegistro.Location = new System.Drawing.Point(386, 311);
            this.BtNRegistro.Name = "BtNRegistro";
            this.BtNRegistro.Size = new System.Drawing.Size(155, 23);
            this.BtNRegistro.TabIndex = 6;
            this.BtNRegistro.Text = "Registrarse";
            this.BtNRegistro.UseVisualStyleBackColor = false;
            this.BtNRegistro.Click += new System.EventHandler(this.BtNRegistro_Click);
            // 
            // LBLContador
            // 
            this.LBLContador.AccessibleDescription = "LbLContador";
            this.LBLContador.AutoSize = true;
            this.LBLContador.Location = new System.Drawing.Point(847, 499);
            this.LBLContador.Name = "LBLContador";
            this.LBLContador.Size = new System.Drawing.Size(0, 13);
            this.LBLContador.TabIndex = 7;
            this.LBLContador.Visible = false;
            // 
            // CloseTime
            // 
            this.CloseTime.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Loging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_FinalBC.Properties.Resources.Login__principal;
            this.ClientSize = new System.Drawing.Size(924, 521);
            this.Controls.Add(this.LBLContador);
            this.Controls.Add(this.BtNRegistro);
            this.Controls.Add(this.BtNSalir);
            this.Controls.Add(this.BtNEntrar);
            this.Controls.Add(this.TxTClave);
            this.Controls.Add(this.TxTUsuario);
            this.Controls.Add(this.LblClave);
            this.Controls.Add(this.LblUsuario);
            this.KeyPreview = true;
            this.Name = "Loging";
            this.Text = "Inicio de seccion";
            this.Load += new System.EventHandler(this.Loging_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Loging_KeyDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Loging_MouseMove);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Loging_PreviewKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Label LblClave;
        private System.Windows.Forms.TextBox TxTUsuario;
        private System.Windows.Forms.TextBox TxTClave;
        private System.Windows.Forms.Button BtNEntrar;
        private System.Windows.Forms.Button BtNSalir;
        private System.Windows.Forms.Button BtNRegistro;
        private System.Windows.Forms.Label LBLContador;
        private System.Windows.Forms.Timer CloseTime;
    }
}