namespace GUI.HomeUserController
{
    partial class Figure
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
            this.lblFigureTitle = new System.Windows.Forms.Label();
            this.picDarkRectangleName = new System.Windows.Forms.PictureBox();
            this.picCardBackground = new System.Windows.Forms.PictureBox();
            this.picDarkRectangleRadius = new System.Windows.Forms.PictureBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtRadius = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picDarkRectangleName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCardBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDarkRectangleRadius)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFigureTitle
            // 
            this.lblFigureTitle.AutoSize = true;
            this.lblFigureTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.lblFigureTitle.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFigureTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblFigureTitle.Location = new System.Drawing.Point(304, 81);
            this.lblFigureTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblFigureTitle.Name = "lblFigureTitle";
            this.lblFigureTitle.Size = new System.Drawing.Size(189, 38);
            this.lblFigureTitle.TabIndex = 1;
            this.lblFigureTitle.Text = "New Figure";
            // 
            // picDarkRectangleName
            // 
            this.picDarkRectangleName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.picDarkRectangleName.Image = global::GUI.Properties.Resources.darkFieldRectangle;
            this.picDarkRectangleName.Location = new System.Drawing.Point(251, 207);
            this.picDarkRectangleName.Margin = new System.Windows.Forms.Padding(0);
            this.picDarkRectangleName.Name = "picDarkRectangleName";
            this.picDarkRectangleName.Size = new System.Drawing.Size(323, 45);
            this.picDarkRectangleName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picDarkRectangleName.TabIndex = 2;
            this.picDarkRectangleName.TabStop = false;
            // 
            // picCardBackground
            // 
            this.picCardBackground.Image = global::GUI.Properties.Resources.card;
            this.picCardBackground.Location = new System.Drawing.Point(15, 14);
            this.picCardBackground.Margin = new System.Windows.Forms.Padding(0);
            this.picCardBackground.Name = "picCardBackground";
            this.picCardBackground.Size = new System.Drawing.Size(783, 537);
            this.picCardBackground.TabIndex = 0;
            this.picCardBackground.TabStop = false;
            // 
            // picDarkRectangleRadius
            // 
            this.picDarkRectangleRadius.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.picDarkRectangleRadius.Image = global::GUI.Properties.Resources.darkFieldRectangle;
            this.picDarkRectangleRadius.Location = new System.Drawing.Point(251, 283);
            this.picDarkRectangleRadius.Margin = new System.Windows.Forms.Padding(0);
            this.picDarkRectangleRadius.Name = "picDarkRectangleRadius";
            this.picDarkRectangleRadius.Size = new System.Drawing.Size(323, 45);
            this.picDarkRectangleRadius.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picDarkRectangleRadius.TabIndex = 5;
            this.picDarkRectangleRadius.TabStop = false;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtName.Location = new System.Drawing.Point(289, 216);
            this.txtName.Margin = new System.Windows.Forms.Padding(0);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(251, 27);
            this.txtName.TabIndex = 7;
            this.txtName.Text = "Name";
            // 
            // txtRadius
            // 
            this.txtRadius.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.txtRadius.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRadius.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRadius.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtRadius.Location = new System.Drawing.Point(289, 292);
            this.txtRadius.Margin = new System.Windows.Forms.Padding(0);
            this.txtRadius.Multiline = true;
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(251, 27);
            this.txtRadius.TabIndex = 8;
            this.txtRadius.Text = "Radius";
            // 
            // Figure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.Controls.Add(this.txtRadius);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.picDarkRectangleRadius);
            this.Controls.Add(this.picDarkRectangleName);
            this.Controls.Add(this.lblFigureTitle);
            this.Controls.Add(this.picCardBackground);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(801, 600);
            this.MinimumSize = new System.Drawing.Size(801, 600);
            this.Name = "Figure";
            this.Size = new System.Drawing.Size(824, 600);
            ((System.ComponentModel.ISupportInitialize)(this.picDarkRectangleName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCardBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDarkRectangleRadius)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCardBackground;
        private System.Windows.Forms.Label lblFigureTitle;
        private System.Windows.Forms.PictureBox picDarkRectangleName;
        private System.Windows.Forms.PictureBox picDarkRectangleRadius;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtRadius;
    }
}
