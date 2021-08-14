
namespace Proyecto_FinalBC
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
            this.components = new System.ComponentModel.Container();
            this.BtNregistroM = new System.Windows.Forms.Button();
            this.BtNEditar = new System.Windows.Forms.Button();
            this.BtNBorrar = new System.Windows.Forms.Button();
            this.BtNSalirM = new System.Windows.Forms.Button();
            this.BtNBuscar = new System.Windows.Forms.Button();
            this.CloseTime = new System.Windows.Forms.Timer(this.components);
            this.TimerClose = new System.Windows.Forms.DateTimePicker();
            this.Inactividad = new System.Windows.Forms.Label();
            this.Busqueda = new System.Windows.Forms.DataGridView();
            this.CBBusqueda = new System.Windows.Forms.ComboBox();
            this.TxTReferencia = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Busqueda)).BeginInit();
            this.SuspendLayout();
            // 
            // BtNregistroM
            // 
            this.BtNregistroM.Location = new System.Drawing.Point(805, 91);
            this.BtNregistroM.Name = "BtNregistroM";
            this.BtNregistroM.Size = new System.Drawing.Size(107, 23);
            this.BtNregistroM.TabIndex = 0;
            this.BtNregistroM.Text = "Nuevo Cliente";
            this.BtNregistroM.UseVisualStyleBackColor = true;
            this.BtNregistroM.Click += new System.EventHandler(this.BtNregistroM_Click);
            // 
            // BtNEditar
            // 
            this.BtNEditar.Location = new System.Drawing.Point(805, 120);
            this.BtNEditar.Name = "BtNEditar";
            this.BtNEditar.Size = new System.Drawing.Size(107, 23);
            this.BtNEditar.TabIndex = 1;
            this.BtNEditar.Text = "Editar Cliente";
            this.BtNEditar.UseVisualStyleBackColor = true;
            // 
            // BtNBorrar
            // 
            this.BtNBorrar.Location = new System.Drawing.Point(805, 149);
            this.BtNBorrar.Name = "BtNBorrar";
            this.BtNBorrar.Size = new System.Drawing.Size(107, 23);
            this.BtNBorrar.TabIndex = 2;
            this.BtNBorrar.Text = "Borrar Cliente";
            this.BtNBorrar.UseVisualStyleBackColor = true;
            this.BtNBorrar.Validated += new System.EventHandler(this.BtNBorrar_Validated);
            // 
            // BtNSalirM
            // 
            this.BtNSalirM.Location = new System.Drawing.Point(805, 473);
            this.BtNSalirM.Name = "BtNSalirM";
            this.BtNSalirM.Size = new System.Drawing.Size(107, 36);
            this.BtNSalirM.TabIndex = 3;
            this.BtNSalirM.Text = "Salir";
            this.BtNSalirM.UseVisualStyleBackColor = true;
            this.BtNSalirM.Click += new System.EventHandler(this.BtNSalirM_Click);
            // 
            // BtNBuscar
            // 
            this.BtNBuscar.Location = new System.Drawing.Point(805, 178);
            this.BtNBuscar.Name = "BtNBuscar";
            this.BtNBuscar.Size = new System.Drawing.Size(107, 23);
            this.BtNBuscar.TabIndex = 4;
            this.BtNBuscar.Text = "Buscar Cliente";
            this.BtNBuscar.UseVisualStyleBackColor = true;
            this.BtNBuscar.Click += new System.EventHandler(this.BtNBuscar_Click);
            // 
            // CloseTime
            // 
            this.CloseTime.Tick += new System.EventHandler(this.Close_Tick);
            // 
            // TimerClose
            // 
            this.TimerClose.Location = new System.Drawing.Point(12, 12);
            this.TimerClose.Name = "TimerClose";
            this.TimerClose.Size = new System.Drawing.Size(197, 20);
            this.TimerClose.TabIndex = 5;
            // 
            // Inactividad
            // 
            this.Inactividad.AutoSize = true;
            this.Inactividad.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inactividad.Image = global::Proyecto_FinalBC.Properties.Resources.Login__principal;
            this.Inactividad.Location = new System.Drawing.Point(215, 18);
            this.Inactividad.Name = "Inactividad";
            this.Inactividad.Size = new System.Drawing.Size(0, 17);
            this.Inactividad.TabIndex = 6;
            // 
            // Busqueda
            // 
            this.Busqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Busqueda.Location = new System.Drawing.Point(463, 207);
            this.Busqueda.Name = "Busqueda";
            this.Busqueda.Size = new System.Drawing.Size(449, 57);
            this.Busqueda.TabIndex = 7;
            // 
            // CBBusqueda
            // 
            this.CBBusqueda.FormattingEnabled = true;
            this.CBBusqueda.Items.AddRange(new object[] {
            "Nombre",
            "Correo",
            "Cedula"});
            this.CBBusqueda.Location = new System.Drawing.Point(463, 181);
            this.CBBusqueda.Name = "CBBusqueda";
            this.CBBusqueda.Size = new System.Drawing.Size(163, 21);
            this.CBBusqueda.TabIndex = 8;
            this.CBBusqueda.Text = "Tipo de Busqueda";
            this.CBBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CBBusqueda_KeyPress);
            // 
            // TxTReferencia
            // 
            this.TxTReferencia.Location = new System.Drawing.Point(632, 181);
            this.TxTReferencia.Name = "TxTReferencia";
            this.TxTReferencia.Size = new System.Drawing.Size(167, 20);
            this.TxTReferencia.TabIndex = 10;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_FinalBC.Properties.Resources.Menu;
            this.ClientSize = new System.Drawing.Size(924, 521);
            this.Controls.Add(this.TxTReferencia);
            this.Controls.Add(this.CBBusqueda);
            this.Controls.Add(this.Busqueda);
            this.Controls.Add(this.Inactividad);
            this.Controls.Add(this.TimerClose);
            this.Controls.Add(this.BtNBuscar);
            this.Controls.Add(this.BtNSalirM);
            this.Controls.Add(this.BtNBorrar);
            this.Controls.Add(this.BtNEditar);
            this.Controls.Add(this.BtNregistroM);
            this.KeyPreview = true;
            this.Name = "MenuPrincipal";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MenuPrincipal_KeyDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MenuPrincipal_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.Busqueda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtNregistroM;
        private System.Windows.Forms.Button BtNEditar;
        private System.Windows.Forms.Button BtNBorrar;
        private System.Windows.Forms.Button BtNSalirM;
        private System.Windows.Forms.Button BtNBuscar;
        private System.Windows.Forms.Timer CloseTime;
        private System.Windows.Forms.DateTimePicker TimerClose;
        private System.Windows.Forms.Label Inactividad;
        private System.Windows.Forms.DataGridView Busqueda;
        private System.Windows.Forms.ComboBox CBBusqueda;
        private System.Windows.Forms.TextBox TxTReferencia;
    }
}