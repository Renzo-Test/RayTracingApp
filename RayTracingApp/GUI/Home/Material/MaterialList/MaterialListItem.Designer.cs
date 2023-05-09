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
            this.lblRGB = new System.Windows.Forms.Label();
            this.picIconX = new System.Windows.Forms.PictureBox();
            this.picMaterialColor = new System.Windows.Forms.PictureBox();
            this.picIconPencilTick = new System.Windows.Forms.PictureBox();
            this.picXIcon = new System.Windows.Forms.PictureBox();
            this.txtMaterialName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picIconX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaterialColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIconPencilTick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picXIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRGB
            // 
            this.lblRGB.AutoSize = true;
            this.lblRGB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRGB.ForeColor = System.Drawing.Color.White;
            this.lblRGB.Location = new System.Drawing.Point(129, 58);
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
            // picXIcon
            // 
            this.picXIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picXIcon.Image = global::GUI.Properties.Resources.whiteX;
            this.picXIcon.Location = new System.Drawing.Point(97, 58);
            this.picXIcon.Name = "picXIcon";
            this.picXIcon.Size = new System.Drawing.Size(19, 19);
            this.picXIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picXIcon.TabIndex = 5;
            this.picXIcon.TabStop = false;
            this.picXIcon.Visible = false;
            this.picXIcon.Click += new System.EventHandler(this.picXIcon_Click);
            // 
            // txtMaterialName
            // 
            this.txtMaterialName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.txtMaterialName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaterialName.Enabled = false;
            this.txtMaterialName.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaterialName.ForeColor = System.Drawing.Color.White;
            this.txtMaterialName.Location = new System.Drawing.Point(128, 23);
            this.txtMaterialName.Name = "txtMaterialName";
            this.txtMaterialName.Size = new System.Drawing.Size(100, 30);
            this.txtMaterialName.TabIndex = 6;
            this.txtMaterialName.Text = "RedBrick";
            // 
            // MaterialListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.Controls.Add(this.txtMaterialName);
            this.Controls.Add(this.picXIcon);
            this.Controls.Add(this.picIconPencilTick);
            this.Controls.Add(this.picIconX);
            this.Controls.Add(this.lblRGB);
            this.Controls.Add(this.picMaterialColor);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.Name = "MaterialListItem";
            this.Size = new System.Drawing.Size(470, 100);
            ((System.ComponentModel.ISupportInitialize)(this.picIconX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaterialColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIconPencilTick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picXIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picMaterialColor;
        private System.Windows.Forms.Label lblRGB;
        private System.Windows.Forms.PictureBox picIconX;
        private System.Windows.Forms.PictureBox picIconPencilTick;
        private System.Windows.Forms.PictureBox picXIcon;
        private System.Windows.Forms.TextBox txtMaterialName;
    }
}
