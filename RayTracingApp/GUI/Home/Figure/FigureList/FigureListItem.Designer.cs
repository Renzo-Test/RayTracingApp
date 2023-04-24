namespace GUI
{
    partial class FigureListItem
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
            this.lblFigureName = new System.Windows.Forms.Label();
            this.lblRadius = new System.Windows.Forms.Label();
            this.picIconX = new System.Windows.Forms.PictureBox();
            this.picIconSphere = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picIconX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIconSphere)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFigureName
            // 
            this.lblFigureName.AutoSize = true;
            this.lblFigureName.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFigureName.ForeColor = System.Drawing.Color.White;
            this.lblFigureName.Location = new System.Drawing.Point(116, 19);
            this.lblFigureName.Name = "lblFigureName";
            this.lblFigureName.Size = new System.Drawing.Size(83, 28);
            this.lblFigureName.TabIndex = 2;
            this.lblFigureName.Text = "Planet";
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRadius.ForeColor = System.Drawing.Color.White;
            this.lblRadius.Location = new System.Drawing.Point(117, 60);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(87, 21);
            this.lblRadius.TabIndex = 3;
            this.lblRadius.Text = "Radius: 10";
            // 
            // picIconX
            // 
            this.picIconX.Image = global::GUI.Properties.Resources.mX;
            this.picIconX.Location = new System.Drawing.Point(415, 33);
            this.picIconX.Name = "picIconX";
            this.picIconX.Size = new System.Drawing.Size(32, 32);
            this.picIconX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picIconX.TabIndex = 1;
            this.picIconX.TabStop = false;
            this.picIconX.Click += new System.EventHandler(this.picIconX_Click);
            // 
            // picIconSphere
            // 
            this.picIconSphere.Image = global::GUI.Properties.Resources.lSphereIcon;
            this.picIconSphere.Location = new System.Drawing.Point(19, 19);
            this.picIconSphere.Name = "picIconSphere";
            this.picIconSphere.Size = new System.Drawing.Size(60, 60);
            this.picIconSphere.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIconSphere.TabIndex = 0;
            this.picIconSphere.TabStop = false;
            // 
            // FigureListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.Controls.Add(this.lblRadius);
            this.Controls.Add(this.lblFigureName);
            this.Controls.Add(this.picIconX);
            this.Controls.Add(this.picIconSphere);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.Name = "FigureListItem";
            this.Size = new System.Drawing.Size(470, 100);
            ((System.ComponentModel.ISupportInitialize)(this.picIconX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIconSphere)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picIconSphere;
        private System.Windows.Forms.PictureBox picIconX;
        private System.Windows.Forms.Label lblFigureName;
        private System.Windows.Forms.Label lblRadius;
    }
}
