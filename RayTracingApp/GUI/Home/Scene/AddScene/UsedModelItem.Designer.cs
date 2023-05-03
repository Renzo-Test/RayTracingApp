namespace GUI
{
    partial class UsedModelItem
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.picIconX = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picIconX)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(9, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(94, 21);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Planetoide";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.ForeColor = System.Drawing.Color.White;
            this.lblPosition.Location = new System.Drawing.Point(9, 33);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(65, 21);
            this.lblPosition.TabIndex = 2;
            this.lblPosition.Text = "(0, 2, 5)";
            // 
            // picIconX
            // 
            this.picIconX.Image = global::GUI.Properties.Resources.sX;
            this.picIconX.Location = new System.Drawing.Point(87, 38);
            this.picIconX.Name = "picIconX";
            this.picIconX.Size = new System.Drawing.Size(16, 16);
            this.picIconX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picIconX.TabIndex = 3;
            this.picIconX.TabStop = false;
            // 
            // UsedModelItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.Controls.Add(this.picIconX);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblName);
            this.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.Name = "UsedModelItem";
            this.Size = new System.Drawing.Size(127, 70);
            ((System.ComponentModel.ISupportInitialize)(this.picIconX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.PictureBox picIconX;
    }
}
