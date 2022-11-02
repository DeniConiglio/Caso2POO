namespace WindowsPresentacion2
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
            this.btnMoverCaballo = new System.Windows.Forms.Button();
            this.btnMoverTorre = new System.Windows.Forms.Button();
            this.btnMoverPeon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMoverCaballo
            // 
            this.btnMoverCaballo.Location = new System.Drawing.Point(136, 144);
            this.btnMoverCaballo.Name = "btnMoverCaballo";
            this.btnMoverCaballo.Size = new System.Drawing.Size(124, 45);
            this.btnMoverCaballo.TabIndex = 0;
            this.btnMoverCaballo.Text = "Mover Caballo";
            this.btnMoverCaballo.UseVisualStyleBackColor = true;
            this.btnMoverCaballo.Click += new System.EventHandler(this.btnMoverCaballo_Click);
            // 
            // btnMoverTorre
            // 
            this.btnMoverTorre.Location = new System.Drawing.Point(454, 144);
            this.btnMoverTorre.Name = "btnMoverTorre";
            this.btnMoverTorre.Size = new System.Drawing.Size(124, 45);
            this.btnMoverTorre.TabIndex = 1;
            this.btnMoverTorre.Text = "Mover Torre";
            this.btnMoverTorre.UseVisualStyleBackColor = true;
            this.btnMoverTorre.Click += new System.EventHandler(this.btnMoverTorre_Click);
            // 
            // btnMoverPeon
            // 
            this.btnMoverPeon.Location = new System.Drawing.Point(297, 144);
            this.btnMoverPeon.Name = "btnMoverPeon";
            this.btnMoverPeon.Size = new System.Drawing.Size(124, 45);
            this.btnMoverPeon.TabIndex = 2;
            this.btnMoverPeon.Text = "Mover Peon";
            this.btnMoverPeon.UseVisualStyleBackColor = true;
            this.btnMoverPeon.Click += new System.EventHandler(this.btnMoverPeon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMoverPeon);
            this.Controls.Add(this.btnMoverTorre);
            this.Controls.Add(this.btnMoverCaballo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMoverCaballo;
        private System.Windows.Forms.Button btnMoverTorre;
        private System.Windows.Forms.Button btnMoverPeon;
    }
}

