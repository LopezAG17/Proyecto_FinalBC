
namespace Proyecto_FinalBC
{
    partial class RegistroUser
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
            this.TxTRUsuario = new System.Windows.Forms.TextBox();
            this.TxTRClave = new System.Windows.Forms.TextBox();
            this.TxTRNombre = new System.Windows.Forms.TextBox();
            this.TxTRApellido = new System.Windows.Forms.TextBox();
            this.TxTRCorreo = new System.Windows.Forms.TextBox();
            this.TxTCedula = new System.Windows.Forms.TextBox();
            this.LbLUsuarioR = new System.Windows.Forms.Label();
            this.LbLClave = new System.Windows.Forms.Label();
            this.LbLNombre = new System.Windows.Forms.Label();
            this.LbLApellido = new System.Windows.Forms.Label();
            this.LbLCorreo = new System.Windows.Forms.Label();
            this.LbLCedula = new System.Windows.Forms.Label();
            this.LbLRegistro = new System.Windows.Forms.Label();
            this.LbLSexo = new System.Windows.Forms.Label();
            this.CBSexo = new System.Windows.Forms.ComboBox();
            this.BtNRegistro = new System.Windows.Forms.Button();
            this.BtNSalir = new System.Windows.Forms.Button();
            this.LbLTelefono = new System.Windows.Forms.Label();
            this.TxTRTelefono = new System.Windows.Forms.TextBox();
            this.FechaR = new System.Windows.Forms.DateTimePicker();
            this.TxTFecha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxTRUsuario
            // 
            this.TxTRUsuario.Location = new System.Drawing.Point(322, 130);
            this.TxTRUsuario.MaxLength = 35;
            this.TxTRUsuario.Name = "TxTRUsuario";
            this.TxTRUsuario.Size = new System.Drawing.Size(134, 20);
            this.TxTRUsuario.TabIndex = 0;
            this.TxTRUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxTRUsuario_KeyPress);
            this.TxTRUsuario.Validated += new System.EventHandler(this.TxTRUsuario_Validated);
            // 
            // TxTRClave
            // 
            this.TxTRClave.Location = new System.Drawing.Point(526, 255);
            this.TxTRClave.MaxLength = 35;
            this.TxTRClave.Name = "TxTRClave";
            this.TxTRClave.Size = new System.Drawing.Size(137, 20);
            this.TxTRClave.TabIndex = 4;
            this.TxTRClave.Validated += new System.EventHandler(this.TxTRClave_Validated);
            // 
            // TxTRNombre
            // 
            this.TxTRNombre.Location = new System.Drawing.Point(322, 200);
            this.TxTRNombre.MaxLength = 35;
            this.TxTRNombre.Name = "TxTRNombre";
            this.TxTRNombre.Size = new System.Drawing.Size(134, 20);
            this.TxTRNombre.TabIndex = 1;
            this.TxTRNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxTRNombre_KeyPress);
            this.TxTRNombre.Validated += new System.EventHandler(this.TxTRNombre_Validated);
            // 
            // TxTRApellido
            // 
            this.TxTRApellido.Location = new System.Drawing.Point(526, 200);
            this.TxTRApellido.MaxLength = 35;
            this.TxTRApellido.Name = "TxTRApellido";
            this.TxTRApellido.Size = new System.Drawing.Size(137, 20);
            this.TxTRApellido.TabIndex = 2;
            this.TxTRApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxTRApellido_KeyPress);
            this.TxTRApellido.Validated += new System.EventHandler(this.TxTRApellido_Validated);
            // 
            // TxTRCorreo
            // 
            this.TxTRCorreo.Location = new System.Drawing.Point(322, 255);
            this.TxTRCorreo.MaxLength = 35;
            this.TxTRCorreo.Name = "TxTRCorreo";
            this.TxTRCorreo.Size = new System.Drawing.Size(177, 20);
            this.TxTRCorreo.TabIndex = 4;
            this.TxTRCorreo.Validated += new System.EventHandler(this.TxTRCorreo_Validated);
            // 
            // TxTCedula
            // 
            this.TxTCedula.Location = new System.Drawing.Point(322, 312);
            this.TxTCedula.MaxLength = 15;
            this.TxTCedula.Name = "TxTCedula";
            this.TxTCedula.Size = new System.Drawing.Size(177, 20);
            this.TxTCedula.TabIndex = 5;
            this.TxTCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxTCedula_KeyPress);
            this.TxTCedula.Validated += new System.EventHandler(this.TxTCedula_Validated);
            // 
            // LbLUsuarioR
            // 
            this.LbLUsuarioR.AutoSize = true;
            this.LbLUsuarioR.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbLUsuarioR.Image = global::Proyecto_FinalBC.Properties.Resources.LoginBG;
            this.LbLUsuarioR.Location = new System.Drawing.Point(325, 101);
            this.LbLUsuarioR.Name = "LbLUsuarioR";
            this.LbLUsuarioR.Size = new System.Drawing.Size(68, 18);
            this.LbLUsuarioR.TabIndex = 6;
            this.LbLUsuarioR.Text = "Usuario";
            // 
            // LbLClave
            // 
            this.LbLClave.AutoSize = true;
            this.LbLClave.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbLClave.Image = global::Proyecto_FinalBC.Properties.Resources.LoginBG;
            this.LbLClave.Location = new System.Drawing.Point(523, 234);
            this.LbLClave.Name = "LbLClave";
            this.LbLClave.Size = new System.Drawing.Size(96, 18);
            this.LbLClave.TabIndex = 7;
            this.LbLClave.Text = "Contraceña";
            // 
            // LbLNombre
            // 
            this.LbLNombre.AutoSize = true;
            this.LbLNombre.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbLNombre.Image = global::Proyecto_FinalBC.Properties.Resources.LoginBG;
            this.LbLNombre.Location = new System.Drawing.Point(324, 169);
            this.LbLNombre.Name = "LbLNombre";
            this.LbLNombre.Size = new System.Drawing.Size(69, 18);
            this.LbLNombre.TabIndex = 8;
            this.LbLNombre.Text = "Nombre";
            // 
            // LbLApellido
            // 
            this.LbLApellido.AutoSize = true;
            this.LbLApellido.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbLApellido.Image = global::Proyecto_FinalBC.Properties.Resources.LoginBG;
            this.LbLApellido.Location = new System.Drawing.Point(523, 169);
            this.LbLApellido.Name = "LbLApellido";
            this.LbLApellido.Size = new System.Drawing.Size(69, 18);
            this.LbLApellido.TabIndex = 9;
            this.LbLApellido.Text = "Apellido";
            // 
            // LbLCorreo
            // 
            this.LbLCorreo.AutoSize = true;
            this.LbLCorreo.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbLCorreo.Image = global::Proyecto_FinalBC.Properties.Resources.Login__principal;
            this.LbLCorreo.Location = new System.Drawing.Point(324, 234);
            this.LbLCorreo.Name = "LbLCorreo";
            this.LbLCorreo.Size = new System.Drawing.Size(61, 18);
            this.LbLCorreo.TabIndex = 10;
            this.LbLCorreo.Text = "Correo";
            // 
            // LbLCedula
            // 
            this.LbLCedula.AutoSize = true;
            this.LbLCedula.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbLCedula.Image = global::Proyecto_FinalBC.Properties.Resources.Login__principal;
            this.LbLCedula.Location = new System.Drawing.Point(319, 278);
            this.LbLCedula.Name = "LbLCedula";
            this.LbLCedula.Size = new System.Drawing.Size(61, 18);
            this.LbLCedula.TabIndex = 11;
            this.LbLCedula.Text = "Cedula";
            // 
            // LbLRegistro
            // 
            this.LbLRegistro.AutoSize = true;
            this.LbLRegistro.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbLRegistro.Image = global::Proyecto_FinalBC.Properties.Resources.LoginBG;
            this.LbLRegistro.Location = new System.Drawing.Point(337, 18);
            this.LbLRegistro.Name = "LbLRegistro";
            this.LbLRegistro.Size = new System.Drawing.Size(282, 63);
            this.LbLRegistro.TabIndex = 12;
            this.LbLRegistro.Text = "Registrarse";
            // 
            // LbLSexo
            // 
            this.LbLSexo.AutoSize = true;
            this.LbLSexo.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbLSexo.Image = global::Proyecto_FinalBC.Properties.Resources.LoginBG;
            this.LbLSexo.Location = new System.Drawing.Point(523, 344);
            this.LbLSexo.Name = "LbLSexo";
            this.LbLSexo.Size = new System.Drawing.Size(47, 18);
            this.LbLSexo.TabIndex = 13;
            this.LbLSexo.Text = "Sexo";
            // 
            // CBSexo
            // 
            this.CBSexo.FormattingEnabled = true;
            this.CBSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "Otro..."});
            this.CBSexo.Location = new System.Drawing.Point(526, 365);
            this.CBSexo.Name = "CBSexo";
            this.CBSexo.Size = new System.Drawing.Size(137, 21);
            this.CBSexo.TabIndex = 14;
            this.CBSexo.Text = "Tipo de sexo";
            this.CBSexo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CBSexo_KeyPress);
            this.CBSexo.Validated += new System.EventHandler(this.CBSexo_Validated);
            // 
            // BtNRegistro
            // 
            this.BtNRegistro.Location = new System.Drawing.Point(322, 403);
            this.BtNRegistro.Name = "BtNRegistro";
            this.BtNRegistro.Size = new System.Drawing.Size(109, 35);
            this.BtNRegistro.TabIndex = 19;
            this.BtNRegistro.Tag = "Este boton registrara tus datos en la base de datos.";
            this.BtNRegistro.Text = "Registrarse";
            this.BtNRegistro.UseVisualStyleBackColor = true;
            this.BtNRegistro.Click += new System.EventHandler(this.BtNRegistro_Click);
            // 
            // BtNSalir
            // 
            this.BtNSalir.Location = new System.Drawing.Point(510, 403);
            this.BtNSalir.Name = "BtNSalir";
            this.BtNSalir.Size = new System.Drawing.Size(109, 35);
            this.BtNSalir.TabIndex = 20;
            this.BtNSalir.Text = "Atras";
            this.BtNSalir.UseVisualStyleBackColor = true;
            this.BtNSalir.Click += new System.EventHandler(this.BtNSalir_Click);
            // 
            // LbLTelefono
            // 
            this.LbLTelefono.AutoSize = true;
            this.LbLTelefono.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbLTelefono.Image = global::Proyecto_FinalBC.Properties.Resources.Login__principal;
            this.LbLTelefono.Location = new System.Drawing.Point(324, 344);
            this.LbLTelefono.Name = "LbLTelefono";
            this.LbLTelefono.Size = new System.Drawing.Size(74, 18);
            this.LbLTelefono.TabIndex = 21;
            this.LbLTelefono.Text = "Telefono";
            // 
            // TxTRTelefono
            // 
            this.TxTRTelefono.Location = new System.Drawing.Point(322, 365);
            this.TxTRTelefono.Name = "TxTRTelefono";
            this.TxTRTelefono.Size = new System.Drawing.Size(137, 20);
            this.TxTRTelefono.TabIndex = 13;
            this.TxTRTelefono.Validated += new System.EventHandler(this.TxTRTelefono_Validated);
            // 
            // FechaR
            // 
            this.FechaR.Font = new System.Drawing.Font("Segoe Print", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaR.Location = new System.Drawing.Point(691, 18);
            this.FechaR.Name = "FechaR";
            this.FechaR.Size = new System.Drawing.Size(221, 27);
            this.FechaR.TabIndex = 23;
            // 
            // TxTFecha
            // 
            this.TxTFecha.Location = new System.Drawing.Point(710, 479);
            this.TxTFecha.Name = "TxTFecha";
            this.TxTFecha.Size = new System.Drawing.Size(167, 20);
            this.TxTFecha.TabIndex = 24;
            this.TxTFecha.Text = "(convert(Varchar(40),Getdate(),3))";
            this.TxTFecha.Visible = false;
            // 
            // RegistroUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_FinalBC.Properties.Resources.LoginBG;
            this.ClientSize = new System.Drawing.Size(924, 521);
            this.Controls.Add(this.TxTFecha);
            this.Controls.Add(this.FechaR);
            this.Controls.Add(this.TxTRTelefono);
            this.Controls.Add(this.LbLTelefono);
            this.Controls.Add(this.BtNSalir);
            this.Controls.Add(this.BtNRegistro);
            this.Controls.Add(this.CBSexo);
            this.Controls.Add(this.LbLSexo);
            this.Controls.Add(this.LbLRegistro);
            this.Controls.Add(this.LbLCedula);
            this.Controls.Add(this.LbLCorreo);
            this.Controls.Add(this.LbLApellido);
            this.Controls.Add(this.LbLNombre);
            this.Controls.Add(this.LbLClave);
            this.Controls.Add(this.LbLUsuarioR);
            this.Controls.Add(this.TxTCedula);
            this.Controls.Add(this.TxTRCorreo);
            this.Controls.Add(this.TxTRApellido);
            this.Controls.Add(this.TxTRNombre);
            this.Controls.Add(this.TxTRClave);
            this.Controls.Add(this.TxTRUsuario);
            this.KeyPreview = true;
            this.Name = "RegistroUser";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.RegistroUser_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RegistroUser_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxTRUsuario;
        private System.Windows.Forms.TextBox TxTRClave;
        private System.Windows.Forms.TextBox TxTRNombre;
        private System.Windows.Forms.TextBox TxTRApellido;
        private System.Windows.Forms.TextBox TxTRCorreo;
        private System.Windows.Forms.TextBox TxTCedula;
        private System.Windows.Forms.Label LbLUsuarioR;
        private System.Windows.Forms.Label LbLClave;
        private System.Windows.Forms.Label LbLNombre;
        private System.Windows.Forms.Label LbLApellido;
        private System.Windows.Forms.Label LbLCorreo;
        private System.Windows.Forms.Label LbLCedula;
        private System.Windows.Forms.Label LbLRegistro;
        private System.Windows.Forms.Label LbLSexo;
        private System.Windows.Forms.ComboBox CBSexo;
        private System.Windows.Forms.Button BtNRegistro;
        private System.Windows.Forms.Button BtNSalir;
        private System.Windows.Forms.Label LbLTelefono;
        private System.Windows.Forms.TextBox TxTRTelefono;
        private System.Windows.Forms.DateTimePicker FechaR;
        private System.Windows.Forms.TextBox TxTFecha;
    }
}