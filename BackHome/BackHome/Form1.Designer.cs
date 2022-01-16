namespace BackHome
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
            this.btnPerdido = new System.Windows.Forms.Button();
            this.btnAdoptar = new System.Windows.Forms.Button();
            this.btnApoyar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPerdido
            // 
            this.btnPerdido.Location = new System.Drawing.Point(56, 103);
            this.btnPerdido.Name = "btnPerdido";
            this.btnPerdido.Size = new System.Drawing.Size(131, 66);
            this.btnPerdido.TabIndex = 0;
            this.btnPerdido.Text = "Perdido / Encontrado";
            this.btnPerdido.UseVisualStyleBackColor = true;
            // 
            // btnAdoptar
            // 
            this.btnAdoptar.Location = new System.Drawing.Point(242, 103);
            this.btnAdoptar.Name = "btnAdoptar";
            this.btnAdoptar.Size = new System.Drawing.Size(122, 66);
            this.btnAdoptar.TabIndex = 1;
            this.btnAdoptar.Text = "Adoptar";
            this.btnAdoptar.UseVisualStyleBackColor = true;
            // 
            // btnApoyar
            // 
            this.btnApoyar.Location = new System.Drawing.Point(431, 103);
            this.btnApoyar.Name = "btnApoyar";
            this.btnApoyar.Size = new System.Drawing.Size(97, 66);
            this.btnApoyar.TabIndex = 2;
            this.btnApoyar.Text = "Apoyar";
            this.btnApoyar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 235);
            this.Controls.Add(this.btnApoyar);
            this.Controls.Add(this.btnAdoptar);
            this.Controls.Add(this.btnPerdido);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPerdido;
        private System.Windows.Forms.Button btnAdoptar;
        private System.Windows.Forms.Button btnApoyar;
    }
}

