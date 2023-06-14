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
            this.lblRadius = new System.Windows.Forms.Label();
            this.txtFigureName = new System.Windows.Forms.TextBox();
            this.picXIcon = new System.Windows.Forms.PictureBox();
            this.picIconPencilTick = new System.Windows.Forms.PictureBox();
            this.picIconX = new System.Windows.Forms.PictureBox();
            this.picIconSphere = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picXIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIconPencilTick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIconX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIconSphere)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRadius.ForeColor = System.Drawing.Color.White;
            this.lblRadius.Location = new System.Drawing.Point(124, 58);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(87, 21);
            this.lblRadius.TabIndex = 3;
            this.lblRadius.Text = "Radius: 10";
            // 
            // txtFigureName
            // 
            this.txtFigureName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.txtFigureName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFigureName.Enabled = false;
            this.txtFigureName.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFigureName.ForeColor = System.Drawing.Color.White;
            this.txtFigureName.Location = new System.Drawing.Point(128, 23);
            this.txtFigureName.Name = "txtFigureName";
            this.txtFigureName.Size = new System.Drawing.Size(260, 30);
            this.txtFigureName.TabIndex = 5;
            this.txtFigureName.Text = "Planet";
            // 
            // picXIcon
            // 
            this.picXIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picXIcon.Image = global::GUI.Properties.Resources.whiteX;
            this.picXIcon.Location = new System.Drawing.Point(97, 58);
            this.picXIcon.Name = "picXIcon";
            this.picXIcon.Size = new System.Drawing.Size(19, 19);
            this.picXIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picXIcon.TabIndex = 6;
            this.picXIcon.TabStop = false;
            this.picXIcon.Visible = false;
            this.picXIcon.Click += new System.EventHandler(this.picXIcon_Click);
            // 
            // picIconPencilTick
            // 
            this.picIconPencilTick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picIconPencilTick.Image = global::GUI.Properties.Resources.pencil;
            this.picIconPencilTick.Location = new System.Drawing.Point(97, 28);
            this.picIconPencilTick.Name = "picIconPencilTick";
            this.picIconPencilTick.Size = new System.Drawing.Size(20, 20);
            this.picIconPencilTick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIconPencilTick.TabIndex = 4;
            this.picIconPencilTick.TabStop = false;
            this.picIconPencilTick.Click += new System.EventHandler(this.picIconPencilTick_Click);
            // 
            // picIconX
            // 
            this.picIconX.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.Controls.Add(this.picXIcon);
            this.Controls.Add(this.txtFigureName);
            this.Controls.Add(this.picIconPencilTick);
            this.Controls.Add(this.lblRadius);
            this.Controls.Add(this.picIconX);
            this.Controls.Add(this.picIconSphere);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.Name = "FigureListItem";
            this.Size = new System.Drawing.Size(470, 100);
            ((System.ComponentModel.ISupportInitialize)(this.picXIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIconPencilTick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIconX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIconSphere)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picIconSphere;
        private System.Windows.Forms.PictureBox picIconX;
        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.PictureBox picIconPencilTick;
        private System.Windows.Forms.TextBox txtFigureName;
        private System.Windows.Forms.PictureBox picXIcon;
    }
}
