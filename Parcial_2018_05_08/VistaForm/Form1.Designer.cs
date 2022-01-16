namespace VistaForm
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblAño = new System.Windows.Forms.Label();
            this.lblNombreAlumno = new System.Windows.Forms.Label();
            this.lblDivision = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblIngreso = new System.Windows.Forms.Label();
            this.lblApellidoAlumno = new System.Windows.Forms.Label();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.lblAnio = new System.Windows.Forms.Label();
            this.lblDivisionAlumno = new System.Windows.Forms.Label();
            this.anioCurso = new System.Windows.Forms.NumericUpDown();
            this.anioAlumno = new System.Windows.Forms.NumericUpDown();
            this.cmbDivisionCurso = new System.Windows.Forms.ComboBox();
            this.cmbDivisionAlumno = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtNombreAlumno = new System.Windows.Forms.TextBox();
            this.txtApellidoAlumno = new System.Windows.Forms.TextBox();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.btnCrearCurso = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.rtbDatos = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anioCurso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anioAlumno)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMostrar);
            this.groupBox1.Controls.Add(this.btnCrearCurso);
            this.groupBox1.Controls.Add(this.txtDni);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.cmbDivisionCurso);
            this.groupBox1.Controls.Add(this.anioCurso);
            this.groupBox1.Controls.Add(this.lblIngreso);
            this.groupBox1.Controls.Add(this.lblDni);
            this.groupBox1.Controls.Add(this.lblApellido);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.lblDivision);
            this.groupBox1.Controls.Add(this.lblAño);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 482);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Curso";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAgregar);
            this.groupBox2.Controls.Add(this.txtLegajo);
            this.groupBox2.Controls.Add(this.txtApellidoAlumno);
            this.groupBox2.Controls.Add(this.txtNombreAlumno);
            this.groupBox2.Controls.Add(this.cmbDivisionAlumno);
            this.groupBox2.Controls.Add(this.anioAlumno);
            this.groupBox2.Controls.Add(this.lblDivisionAlumno);
            this.groupBox2.Controls.Add(this.lblAnio);
            this.groupBox2.Controls.Add(this.lblLegajo);
            this.groupBox2.Controls.Add(this.lblApellidoAlumno);
            this.groupBox2.Controls.Add(this.lblNombreAlumno);
            this.groupBox2.Location = new System.Drawing.Point(474, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(408, 461);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Alumno";
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Location = new System.Drawing.Point(7, 44);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(50, 25);
            this.lblAño.TabIndex = 0;
            this.lblAño.Text = "Año";
            // 
            // lblNombreAlumno
            // 
            this.lblNombreAlumno.AutoSize = true;
            this.lblNombreAlumno.Location = new System.Drawing.Point(18, 51);
            this.lblNombreAlumno.Name = "lblNombreAlumno";
            this.lblNombreAlumno.Size = new System.Drawing.Size(87, 25);
            this.lblNombreAlumno.TabIndex = 0;
            this.lblNombreAlumno.Text = "Nombre";
            // 
            // lblDivision
            // 
            this.lblDivision.AutoSize = true;
            this.lblDivision.Location = new System.Drawing.Point(12, 98);
            this.lblDivision.Name = "lblDivision";
            this.lblDivision.Size = new System.Drawing.Size(88, 25);
            this.lblDivision.TabIndex = 1;
            this.lblDivision.Text = "Division";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(17, 150);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(87, 25);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(17, 200);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(89, 25);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellido";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(22, 245);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(47, 25);
            this.lblDni.TabIndex = 4;
            this.lblDni.Text = "DNI";
            // 
            // lblIngreso
            // 
            this.lblIngreso.AutoSize = true;
            this.lblIngreso.Location = new System.Drawing.Point(17, 295);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(83, 25);
            this.lblIngreso.TabIndex = 5;
            this.lblIngreso.Text = "Ingreso";
            // 
            // lblApellidoAlumno
            // 
            this.lblApellidoAlumno.AutoSize = true;
            this.lblApellidoAlumno.Location = new System.Drawing.Point(23, 100);
            this.lblApellidoAlumno.Name = "lblApellidoAlumno";
            this.lblApellidoAlumno.Size = new System.Drawing.Size(89, 25);
            this.lblApellidoAlumno.TabIndex = 1;
            this.lblApellidoAlumno.Text = "Apellido";
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Location = new System.Drawing.Point(28, 155);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(77, 25);
            this.lblLegajo.TabIndex = 2;
            this.lblLegajo.Text = "Legajo";
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Location = new System.Drawing.Point(28, 223);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(50, 25);
            this.lblAnio.TabIndex = 3;
            this.lblAnio.Text = "Año";
            // 
            // lblDivisionAlumno
            // 
            this.lblDivisionAlumno.AutoSize = true;
            this.lblDivisionAlumno.Location = new System.Drawing.Point(33, 273);
            this.lblDivisionAlumno.Name = "lblDivisionAlumno";
            this.lblDivisionAlumno.Size = new System.Drawing.Size(88, 25);
            this.lblDivisionAlumno.TabIndex = 4;
            this.lblDivisionAlumno.Text = "Division";
            // 
            // anioCurso
            // 
            this.anioCurso.Location = new System.Drawing.Point(161, 44);
            this.anioCurso.Name = "anioCurso";
            this.anioCurso.Size = new System.Drawing.Size(120, 31);
            this.anioCurso.TabIndex = 6;
            // 
            // anioAlumno
            // 
            this.anioAlumno.Location = new System.Drawing.Point(145, 216);
            this.anioAlumno.Name = "anioAlumno";
            this.anioAlumno.Size = new System.Drawing.Size(120, 31);
            this.anioAlumno.TabIndex = 5;
            // 
            // cmbDivisionCurso
            // 
            this.cmbDivisionCurso.FormattingEnabled = true;
            this.cmbDivisionCurso.Location = new System.Drawing.Point(161, 98);
            this.cmbDivisionCurso.Name = "cmbDivisionCurso";
            this.cmbDivisionCurso.Size = new System.Drawing.Size(121, 33);
            this.cmbDivisionCurso.TabIndex = 7;
            // 
            // cmbDivisionAlumno
            // 
            this.cmbDivisionAlumno.FormattingEnabled = true;
            this.cmbDivisionAlumno.Location = new System.Drawing.Point(178, 273);
            this.cmbDivisionAlumno.Name = "cmbDivisionAlumno";
            this.cmbDivisionAlumno.Size = new System.Drawing.Size(121, 33);
            this.cmbDivisionAlumno.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(161, 150);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 31);
            this.txtNombre.TabIndex = 8;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(183, 200);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 31);
            this.txtApellido.TabIndex = 9;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(183, 245);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 31);
            this.txtDni.TabIndex = 10;
            // 
            // txtNombreAlumno
            // 
            this.txtNombreAlumno.Location = new System.Drawing.Point(163, 44);
            this.txtNombreAlumno.Name = "txtNombreAlumno";
            this.txtNombreAlumno.Size = new System.Drawing.Size(100, 31);
            this.txtNombreAlumno.TabIndex = 7;
            // 
            // txtApellidoAlumno
            // 
            this.txtApellidoAlumno.Location = new System.Drawing.Point(163, 93);
            this.txtApellidoAlumno.Name = "txtApellidoAlumno";
            this.txtApellidoAlumno.Size = new System.Drawing.Size(100, 31);
            this.txtApellidoAlumno.TabIndex = 8;
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(178, 148);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(100, 31);
            this.txtLegajo.TabIndex = 9;
            // 
            // btnCrearCurso
            // 
            this.btnCrearCurso.Location = new System.Drawing.Point(0, 362);
            this.btnCrearCurso.Name = "btnCrearCurso";
            this.btnCrearCurso.Size = new System.Drawing.Size(212, 100);
            this.btnCrearCurso.TabIndex = 11;
            this.btnCrearCurso.Text = "Crear Curso";
            this.btnCrearCurso.UseVisualStyleBackColor = true;
            this.btnCrearCurso.Click += new System.EventHandler(this.btnCrearCurso_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(282, 389);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(120, 73);
            this.btnMostrar.TabIndex = 12;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(220, 341);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(171, 100);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // rtbDatos
            // 
            this.rtbDatos.Location = new System.Drawing.Point(24, 518);
            this.rtbDatos.Name = "rtbDatos";
            this.rtbDatos.Size = new System.Drawing.Size(818, 204);
            this.rtbDatos.TabIndex = 2;
            this.rtbDatos.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 734);
            this.Controls.Add(this.rtbDatos);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anioCurso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anioAlumno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnCrearCurso;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cmbDivisionCurso;
        private System.Windows.Forms.NumericUpDown anioCurso;
        private System.Windows.Forms.Label lblIngreso;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDivision;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.TextBox txtApellidoAlumno;
        private System.Windows.Forms.TextBox txtNombreAlumno;
        private System.Windows.Forms.ComboBox cmbDivisionAlumno;
        private System.Windows.Forms.NumericUpDown anioAlumno;
        private System.Windows.Forms.Label lblDivisionAlumno;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.Label lblApellidoAlumno;
        private System.Windows.Forms.Label lblNombreAlumno;
        private System.Windows.Forms.RichTextBox rtbDatos;
    }
}

