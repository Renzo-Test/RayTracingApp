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
			this.txtPosition = new System.Windows.Forms.TextBox();
			this.picIconPencilTick = new System.Windows.Forms.PictureBox();
			this.picXIcon = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.picIconX)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picIconPencilTick)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picXIcon)).BeginInit();
			this.SuspendLayout();
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblName.ForeColor = System.Drawing.Color.White;
			this.lblName.Location = new System.Drawing.Point(28, 11);
			this.lblName.MaximumSize = new System.Drawing.Size(94, 21);
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
			this.lblPosition.Size = new System.Drawing.Size(0, 21);
			this.lblPosition.TabIndex = 2;
			// 
			// picIconX
			// 
			this.picIconX.Cursor = System.Windows.Forms.Cursors.Hand;
			this.picIconX.Image = global::GUI.Properties.Resources.sX;
			this.picIconX.Location = new System.Drawing.Point(128, 17);
			this.picIconX.Name = "picIconX";
			this.picIconX.Size = new System.Drawing.Size(16, 16);
			this.picIconX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picIconX.TabIndex = 3;
			this.picIconX.TabStop = false;
			this.picIconX.Click += new System.EventHandler(this.picIconX_Click);
			// 
			// txtPosition
			// 
			this.txtPosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
			this.txtPosition.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtPosition.Enabled = false;
			this.txtPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPosition.ForeColor = System.Drawing.Color.White;
			this.txtPosition.Location = new System.Drawing.Point(32, 34);
			this.txtPosition.Name = "txtPosition";
			this.txtPosition.Size = new System.Drawing.Size(120, 19);
			this.txtPosition.TabIndex = 4;
			this.txtPosition.Text = "x,y,z";
			// 
			// picIconPencilTick
			// 
			this.picIconPencilTick.Cursor = System.Windows.Forms.Cursors.Hand;
			this.picIconPencilTick.Image = global::GUI.Properties.Resources.pencil;
			this.picIconPencilTick.Location = new System.Drawing.Point(5, 34);
			this.picIconPencilTick.Name = "picIconPencilTick";
			this.picIconPencilTick.Size = new System.Drawing.Size(21, 20);
			this.picIconPencilTick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picIconPencilTick.TabIndex = 7;
			this.picIconPencilTick.TabStop = false;
			this.picIconPencilTick.Click += new System.EventHandler(this.picIconPencilTick_Click);
			// 
			// picXIcon
			// 
			this.picXIcon.Cursor = System.Windows.Forms.Cursors.Hand;
			this.picXIcon.Image = global::GUI.Properties.Resources.whiteX;
			this.picXIcon.Location = new System.Drawing.Point(7, 11);
			this.picXIcon.Name = "picXIcon";
			this.picXIcon.Size = new System.Drawing.Size(17, 17);
			this.picXIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picXIcon.TabIndex = 8;
			this.picXIcon.TabStop = false;
			this.picXIcon.Visible = false;
			this.picXIcon.Click += new System.EventHandler(this.picXIcon_Click);
			// 
			// UsedModelItem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
			this.Controls.Add(this.picXIcon);
			this.Controls.Add(this.picIconPencilTick);
			this.Controls.Add(this.txtPosition);
			this.Controls.Add(this.picIconX);
			this.Controls.Add(this.lblPosition);
			this.Controls.Add(this.lblName);
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "UsedModelItem";
			this.Size = new System.Drawing.Size(152, 65);
			((System.ComponentModel.ISupportInitialize)(this.picIconX)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picIconPencilTick)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picXIcon)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.PictureBox picIconX;
        private System.Windows.Forms.TextBox txtPosition;
		private System.Windows.Forms.PictureBox picIconPencilTick;
		private System.Windows.Forms.PictureBox picXIcon;
	}
}
