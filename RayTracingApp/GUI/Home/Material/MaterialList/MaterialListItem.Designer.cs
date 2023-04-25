namespace GUI
{
    partial class MaterialListItem
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMaterialName = new System.Windows.Forms.Label();
            this.lblRGB = new System.Windows.Forms.Label();
            this.picIconX = new System.Windows.Forms.PictureBox();
            this.picMaterialColor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picIconX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaterialColor)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaterialName
            // 
            this.lblMaterialName.AutoSize = true;
            this.lblMaterialName.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterialName.ForeColor = System.Drawing.Color.White;
            this.lblMaterialName.Location = new System.Drawing.Point(116, 19);
            this.lblMaterialName.Name = "lblMaterialName";
            this.lblMaterialName.Size = new System.Drawing.Size(114, 28);
            this.lblMaterialName.TabIndex = 1;
            this.lblMaterialName.Text = "RedBrick";
            // 
            // lblRGB
            // 
            this.lblRGB.AutoSize = true;
            this.lblRGB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRGB.ForeColor = System.Drawing.Color.White;
            this.lblRGB.Location = new System.Drawing.Point(117, 60);
            this.lblRGB.Name = "lblRGB";
            this.lblRGB.Size = new System.Drawing.Size(159, 21);
            this.lblRGB.TabIndex = 2;
            this.lblRGB.Text = "Red: 255 - G: 0 - B: 0";
            // 
            // picIconX
            // 
            this.picIconX.Image = global::GUI.Properties.Resources.mX;
            this.picIconX.Location = new System.Drawing.Point(415, 33);
            this.picIconX.Name = "picIconX";
            this.picIconX.Size = new System.Drawing.Size(32, 32);
            this.picIconX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picIconX.TabIndex = 3;
            this.picIconX.TabStop = false;
            this.picIconX.Click += new System.EventHandler(this.picIconX_Click);
            // 
            // picMaterialColor
            // 
            this.picMaterialColor.BackColor = System.Drawing.Color.Red;
            this.picMaterialColor.Location = new System.Drawing.Point(19, 19);
            this.picMaterialColor.Name = "picMaterialColor";
            this.picMaterialColor.Size = new System.Drawing.Size(60, 60);
            this.picMaterialColor.TabIndex = 0;
            this.picMaterialColor.TabStop = false;
            // 
            // MaterialListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.Controls.Add(this.picIconX);
            this.Controls.Add(this.lblRGB);
            this.Controls.Add(this.lblMaterialName);
            this.Controls.Add(this.picMaterialColor);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "MaterialListItem";
            this.Size = new System.Drawing.Size(470, 100);
            ((System.ComponentModel.ISupportInitialize)(this.picIconX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaterialColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picMaterialColor;
        private System.Windows.Forms.Label lblMaterialName;
        private System.Windows.Forms.Label lblRGB;
        private System.Windows.Forms.PictureBox picIconX;
    }
}
