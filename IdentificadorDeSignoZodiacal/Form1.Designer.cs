namespace IdentificadorDeSignoZodiacal
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
            this.btnGenerar = new System.Windows.Forms.Button();
            this.lblTítulo = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.FechaDeNacimiento = new System.Windows.Forms.MonthCalendar();
            this.lblCiudadanoDeOro = new System.Windows.Forms.Label();
            this.lblSignoZodiacal = new System.Windows.Forms.Label();
            this.lblEdadResultante = new System.Windows.Forms.Label();
            this.lblConfirmaciónCiudadanoDeOro = new System.Windows.Forms.Label();
            this.lblSignoZodiacalResultante = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(158, 218);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 1;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTítulo
            // 
            this.lblTítulo.AutoSize = true;
            this.lblTítulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTítulo.Location = new System.Drawing.Point(85, 18);
            this.lblTítulo.Name = "lblTítulo";
            this.lblTítulo.Size = new System.Drawing.Size(231, 17);
            this.lblTítulo.TabIndex = 2;
            this.lblTítulo.Text = "Seleccione su fecha de nacimiento:";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(389, 64);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(35, 13);
            this.lblEdad.TabIndex = 3;
            this.lblEdad.Text = "Edad:";
            this.lblEdad.Visible = false;
            // 
            // FechaDeNacimiento
            // 
            this.FechaDeNacimiento.BackColor = System.Drawing.Color.Lime;
            this.FechaDeNacimiento.Location = new System.Drawing.Point(68, 44);
            this.FechaDeNacimiento.MaxSelectionCount = 1;
            this.FechaDeNacimiento.Name = "FechaDeNacimiento";
            this.FechaDeNacimiento.TabIndex = 4;
            this.FechaDeNacimiento.TitleBackColor = System.Drawing.Color.DarkRed;
            // 
            // lblCiudadanoDeOro
            // 
            this.lblCiudadanoDeOro.AutoSize = true;
            this.lblCiudadanoDeOro.Location = new System.Drawing.Point(328, 93);
            this.lblCiudadanoDeOro.Name = "lblCiudadanoDeOro";
            this.lblCiudadanoDeOro.Size = new System.Drawing.Size(96, 13);
            this.lblCiudadanoDeOro.TabIndex = 5;
            this.lblCiudadanoDeOro.Text = "Ciudadano de Oro:";
            this.lblCiudadanoDeOro.Visible = false;
            // 
            // lblSignoZodiacal
            // 
            this.lblSignoZodiacal.AutoSize = true;
            this.lblSignoZodiacal.Location = new System.Drawing.Point(343, 132);
            this.lblSignoZodiacal.Name = "lblSignoZodiacal";
            this.lblSignoZodiacal.Size = new System.Drawing.Size(81, 13);
            this.lblSignoZodiacal.TabIndex = 6;
            this.lblSignoZodiacal.Text = "Signo Zodiacal:";
            this.lblSignoZodiacal.Visible = false;
            // 
            // lblEdadResultante
            // 
            this.lblEdadResultante.AutoSize = true;
            this.lblEdadResultante.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEdadResultante.Location = new System.Drawing.Point(430, 64);
            this.lblEdadResultante.MaximumSize = new System.Drawing.Size(40, 40);
            this.lblEdadResultante.Name = "lblEdadResultante";
            this.lblEdadResultante.Size = new System.Drawing.Size(35, 13);
            this.lblEdadResultante.TabIndex = 7;
            this.lblEdadResultante.Text = "label1";
            this.lblEdadResultante.Visible = false;
            // 
            // lblConfirmaciónCiudadanoDeOro
            // 
            this.lblConfirmaciónCiudadanoDeOro.AutoSize = true;
            this.lblConfirmaciónCiudadanoDeOro.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblConfirmaciónCiudadanoDeOro.Location = new System.Drawing.Point(430, 93);
            this.lblConfirmaciónCiudadanoDeOro.MaximumSize = new System.Drawing.Size(40, 40);
            this.lblConfirmaciónCiudadanoDeOro.Name = "lblConfirmaciónCiudadanoDeOro";
            this.lblConfirmaciónCiudadanoDeOro.Size = new System.Drawing.Size(35, 13);
            this.lblConfirmaciónCiudadanoDeOro.TabIndex = 8;
            this.lblConfirmaciónCiudadanoDeOro.Text = "label1";
            this.lblConfirmaciónCiudadanoDeOro.Visible = false;
            // 
            // lblSignoZodiacalResultante
            // 
            this.lblSignoZodiacalResultante.AutoSize = true;
            this.lblSignoZodiacalResultante.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSignoZodiacalResultante.Location = new System.Drawing.Point(430, 132);
            this.lblSignoZodiacalResultante.MaximumSize = new System.Drawing.Size(40, 40);
            this.lblSignoZodiacalResultante.Name = "lblSignoZodiacalResultante";
            this.lblSignoZodiacalResultante.Size = new System.Drawing.Size(35, 13);
            this.lblSignoZodiacalResultante.TabIndex = 9;
            this.lblSignoZodiacalResultante.Text = "label1";
            this.lblSignoZodiacalResultante.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(485, 284);
            this.Controls.Add(this.lblSignoZodiacalResultante);
            this.Controls.Add(this.lblConfirmaciónCiudadanoDeOro);
            this.Controls.Add(this.lblEdadResultante);
            this.Controls.Add(this.lblSignoZodiacal);
            this.Controls.Add(this.lblCiudadanoDeOro);
            this.Controls.Add(this.FechaDeNacimiento);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblTítulo);
            this.Controls.Add(this.btnGenerar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generar signo zodiacal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label lblTítulo;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.MonthCalendar FechaDeNacimiento;
        private System.Windows.Forms.Label lblCiudadanoDeOro;
        private System.Windows.Forms.Label lblSignoZodiacal;
        private System.Windows.Forms.Label lblEdadResultante;
        private System.Windows.Forms.Label lblConfirmaciónCiudadanoDeOro;
        private System.Windows.Forms.Label lblSignoZodiacalResultante;
    }
}

