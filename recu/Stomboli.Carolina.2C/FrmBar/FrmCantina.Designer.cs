namespace FrmBar
{
    partial class FrmCantina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCantina));
            this.txtMarca = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.Label();
            this.labelCapacidad = new System.Windows.Forms.Label();
            this.labelContenido = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.btnCerveza = new System.Windows.Forms.RadioButton();
            this.btnAgua = new System.Windows.Forms.RadioButton();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.barra1 = new ControlCantina.Barra();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMarca
            // 
            this.txtMarca.AutoSize = true;
            this.txtMarca.Location = new System.Drawing.Point(139, 402);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(37, 13);
            this.txtMarca.TabIndex = 1;
            this.txtMarca.Text = "Marca";
            // 
            // txtTipo
            // 
            this.txtTipo.AutoSize = true;
            this.txtTipo.Location = new System.Drawing.Point(359, 402);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(63, 13);
            this.txtTipo.TabIndex = 2;
            this.txtTipo.Text = "Botella Tipo";
            // 
            // labelCapacidad
            // 
            this.labelCapacidad.AutoSize = true;
            this.labelCapacidad.Location = new System.Drawing.Point(141, 447);
            this.labelCapacidad.Name = "labelCapacidad";
            this.labelCapacidad.Size = new System.Drawing.Size(58, 13);
            this.labelCapacidad.TabIndex = 3;
            this.labelCapacidad.Text = "Capacidad";
            // 
            // labelContenido
            // 
            this.labelContenido.AutoSize = true;
            this.labelContenido.Location = new System.Drawing.Point(241, 447);
            this.labelContenido.Name = "labelContenido";
            this.labelContenido.Size = new System.Drawing.Size(55, 13);
            this.labelContenido.TabIndex = 4;
            this.labelContenido.Text = "Contenido";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(142, 463);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(84, 20);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(244, 463);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(78, 20);
            this.numericUpDown2.TabIndex = 6;
            this.numericUpDown2.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // btnCerveza
            // 
            this.btnCerveza.AutoSize = true;
            this.btnCerveza.Location = new System.Drawing.Point(12, 402);
            this.btnCerveza.Name = "btnCerveza";
            this.btnCerveza.Size = new System.Drawing.Size(64, 17);
            this.btnCerveza.TabIndex = 7;
            this.btnCerveza.TabStop = true;
            this.btnCerveza.Text = "Cerveza";
            this.btnCerveza.UseVisualStyleBackColor = true;
            // 
            // btnAgua
            // 
            this.btnAgua.AutoSize = true;
            this.btnAgua.Location = new System.Drawing.Point(12, 434);
            this.btnAgua.Name = "btnAgua";
            this.btnAgua.Size = new System.Drawing.Size(50, 17);
            this.btnAgua.TabIndex = 8;
            this.btnAgua.TabStop = true;
            this.btnAgua.Text = "Agua";
            this.btnAgua.UseVisualStyleBackColor = true;
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Plastico",
            "Vidrio"});
            this.cmbTipo.Location = new System.Drawing.Point(362, 419);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipo.TabIndex = 9;
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.Location = new System.Drawing.Point(142, 419);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(180, 20);
            this.textBoxMarca.TabIndex = 10;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(362, 447);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(101, 39);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // barra1
            // 
            this.barra1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("barra1.BackgroundImage")));
            this.barra1.Location = new System.Drawing.Point(12, 12);
            this.barra1.Name = "barra1";
            this.barra1.Size = new System.Drawing.Size(551, 368);
            this.barra1.TabIndex = 0;
            // 
            // FrmCantina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 508);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.textBoxMarca);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.btnAgua);
            this.Controls.Add(this.btnCerveza);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.labelContenido);
            this.Controls.Add(this.labelCapacidad);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.barra1);
            this.Name = "FrmCantina";
            this.Text = "Stomboli Carolina";
            this.Load += new System.EventHandler(this.FrmCantina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlCantina.Barra barra1;
        private System.Windows.Forms.Label txtMarca;
        private System.Windows.Forms.Label txtTipo;
        private System.Windows.Forms.Label labelCapacidad;
        private System.Windows.Forms.Label labelContenido;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.RadioButton btnCerveza;
        private System.Windows.Forms.RadioButton btnAgua;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.TextBox textBoxMarca;
        private System.Windows.Forms.Button btnAgregar;
    }
}

