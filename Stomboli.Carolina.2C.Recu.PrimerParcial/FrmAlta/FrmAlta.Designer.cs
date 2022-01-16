namespace FrmAlta
{
    partial class FrmAlta
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpBoxDatosDueño = new System.Windows.Forms.GroupBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.grpDatosVehiculo = new System.Windows.Forms.GroupBox();
            this.txtCilindrada = new System.Windows.Forms.TextBox();
            this.rdMoto = new System.Windows.Forms.RadioButton();
            this.rdAuto = new System.Windows.Forms.RadioButton();
            this.txtPatenteVehiculo = new System.Windows.Forms.TextBox();
            this.lblCilindrada = new System.Windows.Forms.Label();
            this.lblTransmision = new System.Windows.Forms.Label();
            this.lblTipoVehiculo = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblPatenteVehiculo = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.cmbTransm = new System.Windows.Forms.ComboBox();
            this.grpBoxDatosDueño.SuspendLayout();
            this.grpDatosVehiculo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxDatosDueño
            // 
            this.grpBoxDatosDueño.Controls.Add(this.txtDni);
            this.grpBoxDatosDueño.Controls.Add(this.txtNombre);
            this.grpBoxDatosDueño.Controls.Add(this.lblDni);
            this.grpBoxDatosDueño.Controls.Add(this.lblNombre);
            this.grpBoxDatosDueño.Location = new System.Drawing.Point(13, 13);
            this.grpBoxDatosDueño.Name = "grpBoxDatosDueño";
            this.grpBoxDatosDueño.Size = new System.Drawing.Size(220, 111);
            this.grpBoxDatosDueño.TabIndex = 0;
            this.grpBoxDatosDueño.TabStop = false;
            this.grpBoxDatosDueño.Text = "Datos dueño";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(114, 68);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 20);
            this.txtDni.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(114, 37);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(7, 68);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(26, 13);
            this.lblDni.TabIndex = 1;
            this.lblDni.Text = "DNI";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(7, 37);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // grpDatosVehiculo
            // 
            this.grpDatosVehiculo.Controls.Add(this.cmbTransm);
            this.grpDatosVehiculo.Controls.Add(this.cmbColor);
            this.grpDatosVehiculo.Controls.Add(this.txtCilindrada);
            this.grpDatosVehiculo.Controls.Add(this.rdMoto);
            this.grpDatosVehiculo.Controls.Add(this.rdAuto);
            this.grpDatosVehiculo.Controls.Add(this.txtPatenteVehiculo);
            this.grpDatosVehiculo.Controls.Add(this.lblCilindrada);
            this.grpDatosVehiculo.Controls.Add(this.lblTransmision);
            this.grpDatosVehiculo.Controls.Add(this.lblTipoVehiculo);
            this.grpDatosVehiculo.Controls.Add(this.lblColor);
            this.grpDatosVehiculo.Controls.Add(this.lblPatenteVehiculo);
            this.grpDatosVehiculo.Location = new System.Drawing.Point(13, 148);
            this.grpDatosVehiculo.Name = "grpDatosVehiculo";
            this.grpDatosVehiculo.Size = new System.Drawing.Size(220, 175);
            this.grpDatosVehiculo.TabIndex = 1;
            this.grpDatosVehiculo.TabStop = false;
            this.grpDatosVehiculo.Text = "Datos vehiculo";
            // 
            // txtCilindrada
            // 
            this.txtCilindrada.Location = new System.Drawing.Point(114, 136);
            this.txtCilindrada.Name = "txtCilindrada";
            this.txtCilindrada.Size = new System.Drawing.Size(100, 20);
            this.txtCilindrada.TabIndex = 10;
            // 
            // rdMoto
            // 
            this.rdMoto.AutoSize = true;
            this.rdMoto.Location = new System.Drawing.Point(167, 83);
            this.rdMoto.Name = "rdMoto";
            this.rdMoto.Size = new System.Drawing.Size(49, 17);
            this.rdMoto.TabIndex = 8;
            this.rdMoto.TabStop = true;
            this.rdMoto.Text = "Moto";
            this.rdMoto.UseVisualStyleBackColor = true;
            this.rdMoto.CheckedChanged += new System.EventHandler(this.rdMoto_CheckedChanged);
            // 
            // rdAuto
            // 
            this.rdAuto.AutoSize = true;
            this.rdAuto.Location = new System.Drawing.Point(114, 83);
            this.rdAuto.Name = "rdAuto";
            this.rdAuto.Size = new System.Drawing.Size(47, 17);
            this.rdAuto.TabIndex = 7;
            this.rdAuto.TabStop = true;
            this.rdAuto.Text = "Auto";
            this.rdAuto.UseVisualStyleBackColor = true;
            this.rdAuto.CheckedChanged += new System.EventHandler(this.rdAuto_CheckedChanged);
            // 
            // txtPatenteVehiculo
            // 
            this.txtPatenteVehiculo.Location = new System.Drawing.Point(114, 26);
            this.txtPatenteVehiculo.Name = "txtPatenteVehiculo";
            this.txtPatenteVehiculo.Size = new System.Drawing.Size(100, 20);
            this.txtPatenteVehiculo.TabIndex = 5;
            // 
            // lblCilindrada
            // 
            this.lblCilindrada.AutoSize = true;
            this.lblCilindrada.Location = new System.Drawing.Point(7, 143);
            this.lblCilindrada.Name = "lblCilindrada";
            this.lblCilindrada.Size = new System.Drawing.Size(76, 13);
            this.lblCilindrada.TabIndex = 4;
            this.lblCilindrada.Text = "Cilindrada (CC)";
            // 
            // lblTransmision
            // 
            this.lblTransmision.AutoSize = true;
            this.lblTransmision.Location = new System.Drawing.Point(7, 113);
            this.lblTransmision.Name = "lblTransmision";
            this.lblTransmision.Size = new System.Drawing.Size(63, 13);
            this.lblTransmision.TabIndex = 3;
            this.lblTransmision.Text = "Transmision";
            // 
            // lblTipoVehiculo
            // 
            this.lblTipoVehiculo.AutoSize = true;
            this.lblTipoVehiculo.Location = new System.Drawing.Point(7, 83);
            this.lblTipoVehiculo.Name = "lblTipoVehiculo";
            this.lblTipoVehiculo.Size = new System.Drawing.Size(72, 13);
            this.lblTipoVehiculo.TabIndex = 2;
            this.lblTipoVehiculo.Text = "Tipo Vehiculo";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(7, 58);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(31, 13);
            this.lblColor.TabIndex = 1;
            this.lblColor.Text = "Color";
            // 
            // lblPatenteVehiculo
            // 
            this.lblPatenteVehiculo.AutoSize = true;
            this.lblPatenteVehiculo.Location = new System.Drawing.Point(6, 29);
            this.lblPatenteVehiculo.Name = "lblPatenteVehiculo";
            this.lblPatenteVehiculo.Size = new System.Drawing.Size(88, 13);
            this.lblPatenteVehiculo.TabIndex = 0;
            this.lblPatenteVehiculo.Text = "Patente Vehiculo";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(32, 338);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(127, 338);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cmbColor
            // 
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Location = new System.Drawing.Point(111, 55);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(103, 21);
            this.cmbColor.TabIndex = 11;
            // 
            // cmbTransm
            // 
            this.cmbTransm.FormattingEnabled = true;
            this.cmbTransm.Location = new System.Drawing.Point(114, 104);
            this.cmbTransm.Name = "cmbTransm";
            this.cmbTransm.Size = new System.Drawing.Size(100, 21);
            this.cmbTransm.TabIndex = 12;
            // 
            // FrmAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 387);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.grpDatosVehiculo);
            this.Controls.Add(this.grpBoxDatosDueño);
            this.Name = "FrmAlta";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAlta_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBoxDatosDueño.ResumeLayout(false);
            this.grpBoxDatosDueño.PerformLayout();
            this.grpDatosVehiculo.ResumeLayout(false);
            this.grpDatosVehiculo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxDatosDueño;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox grpDatosVehiculo;
        private System.Windows.Forms.Label lblCilindrada;
        private System.Windows.Forms.Label lblTransmision;
        private System.Windows.Forms.Label lblTipoVehiculo;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblPatenteVehiculo;
        private System.Windows.Forms.TextBox txtCilindrada;
        private System.Windows.Forms.RadioButton rdMoto;
        private System.Windows.Forms.RadioButton rdAuto;
        private System.Windows.Forms.TextBox txtPatenteVehiculo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.ComboBox cmbTransm;
    }
}

