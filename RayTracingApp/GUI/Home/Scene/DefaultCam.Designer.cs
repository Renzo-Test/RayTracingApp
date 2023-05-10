namespace GUI
{
    partial class DefaultCam
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
			this.lblSave = new System.Windows.Forms.Label();
			this.lblCancel = new System.Windows.Forms.Label();
			this.txtInputLookFrom = new System.Windows.Forms.TextBox();
			this.txtInputFov = new System.Windows.Forms.TextBox();
			this.lblTitle = new System.Windows.Forms.Label();
			this.picRectangleFieldCancel = new System.Windows.Forms.PictureBox();
			this.picRectangleFieldSave = new System.Windows.Forms.PictureBox();
			this.picDarkRectangleFieldLookFrom = new System.Windows.Forms.PictureBox();
			this.picDarkRectangleFieldFov = new System.Windows.Forms.PictureBox();
			this.picCard = new System.Windows.Forms.PictureBox();
			this.txtInputLookAt = new System.Windows.Forms.TextBox();
			this.picDarkRectangleFieldLookAt = new System.Windows.Forms.PictureBox();
			this.lblFOV = new System.Windows.Forms.Label();
			this.lblLookFrom = new System.Windows.Forms.Label();
			this.lblLookAt = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.picRectangleFieldCancel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picRectangleFieldSave)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picDarkRectangleFieldLookFrom)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picDarkRectangleFieldFov)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picCard)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picDarkRectangleFieldLookAt)).BeginInit();
			this.SuspendLayout();
			// 
			// lblSave
			// 
			this.lblSave.AutoSize = true;
			this.lblSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(158)))), ((int)(((byte)(140)))));
			this.lblSave.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblSave.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSave.ForeColor = System.Drawing.Color.White;
			this.lblSave.Location = new System.Drawing.Point(505, 418);
			this.lblSave.Name = "lblSave";
			this.lblSave.Size = new System.Drawing.Size(56, 23);
			this.lblSave.TabIndex = 20;
			this.lblSave.Text = "Save";
			// 
			// lblCancel
			// 
			this.lblCancel.AutoSize = true;
			this.lblCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(158)))), ((int)(((byte)(140)))));
			this.lblCancel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblCancel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCancel.ForeColor = System.Drawing.Color.White;
			this.lblCancel.Location = new System.Drawing.Point(261, 419);
			this.lblCancel.Name = "lblCancel";
			this.lblCancel.Size = new System.Drawing.Size(78, 23);
			this.lblCancel.TabIndex = 19;
			this.lblCancel.Text = "Cancel";
			this.lblCancel.Click += new System.EventHandler(this.lblCancel_Click);
			// 
			// txtInputLookFrom
			// 
			this.txtInputLookFrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
			this.txtInputLookFrom.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtInputLookFrom.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtInputLookFrom.ForeColor = System.Drawing.Color.DimGray;
			this.txtInputLookFrom.Location = new System.Drawing.Point(271, 269);
			this.txtInputLookFrom.Name = "txtInputLookFrom";
			this.txtInputLookFrom.Size = new System.Drawing.Size(278, 24);
			this.txtInputLookFrom.TabIndex = 16;
			this.txtInputLookFrom.Text = "Look From";
			// 
			// txtInputFov
			// 
			this.txtInputFov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
			this.txtInputFov.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtInputFov.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtInputFov.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.txtInputFov.Location = new System.Drawing.Point(271, 180);
			this.txtInputFov.Name = "txtInputFov";
			this.txtInputFov.Size = new System.Drawing.Size(276, 24);
			this.txtInputFov.TabIndex = 14;
			this.txtInputFov.Text = "Fov";
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
			this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.lblTitle.Location = new System.Drawing.Point(258, 96);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(318, 32);
			this.lblTitle.TabIndex = 12;
			this.lblTitle.Text = "Default Camera Values";
			// 
			// picRectangleFieldCancel
			// 
			this.picRectangleFieldCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
			this.picRectangleFieldCancel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.picRectangleFieldCancel.Image = global::GUI.Properties.Resources.homeButtonsBackground;
			this.picRectangleFieldCancel.Location = new System.Drawing.Point(219, 408);
			this.picRectangleFieldCancel.Name = "picRectangleFieldCancel";
			this.picRectangleFieldCancel.Size = new System.Drawing.Size(165, 45);
			this.picRectangleFieldCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picRectangleFieldCancel.TabIndex = 18;
			this.picRectangleFieldCancel.TabStop = false;
			this.picRectangleFieldCancel.Click += new System.EventHandler(this.picRectangleFieldCancel_Click);
			// 
			// picRectangleFieldSave
			// 
			this.picRectangleFieldSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
			this.picRectangleFieldSave.Cursor = System.Windows.Forms.Cursors.Hand;
			this.picRectangleFieldSave.Image = global::GUI.Properties.Resources.homeButtonsBackground;
			this.picRectangleFieldSave.Location = new System.Drawing.Point(448, 408);
			this.picRectangleFieldSave.Name = "picRectangleFieldSave";
			this.picRectangleFieldSave.Size = new System.Drawing.Size(165, 45);
			this.picRectangleFieldSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picRectangleFieldSave.TabIndex = 17;
			this.picRectangleFieldSave.TabStop = false;
			this.picRectangleFieldSave.Click += new System.EventHandler(this.picRectangleFieldSave_Click);
			// 
			// picDarkRectangleFieldLookFrom
			// 
			this.picDarkRectangleFieldLookFrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
			this.picDarkRectangleFieldLookFrom.Image = global::GUI.Properties.Resources.darkFieldRectangle;
			this.picDarkRectangleFieldLookFrom.Location = new System.Drawing.Point(253, 257);
			this.picDarkRectangleFieldLookFrom.Name = "picDarkRectangleFieldLookFrom";
			this.picDarkRectangleFieldLookFrom.Size = new System.Drawing.Size(323, 45);
			this.picDarkRectangleFieldLookFrom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picDarkRectangleFieldLookFrom.TabIndex = 15;
			this.picDarkRectangleFieldLookFrom.TabStop = false;
			// 
			// picDarkRectangleFieldFov
			// 
			this.picDarkRectangleFieldFov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
			this.picDarkRectangleFieldFov.Image = global::GUI.Properties.Resources.darkFieldRectangle;
			this.picDarkRectangleFieldFov.Location = new System.Drawing.Point(253, 168);
			this.picDarkRectangleFieldFov.Name = "picDarkRectangleFieldFov";
			this.picDarkRectangleFieldFov.Size = new System.Drawing.Size(323, 45);
			this.picDarkRectangleFieldFov.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picDarkRectangleFieldFov.TabIndex = 13;
			this.picDarkRectangleFieldFov.TabStop = false;
			// 
			// picCard
			// 
			this.picCard.Image = global::GUI.Properties.Resources.card;
			this.picCard.Location = new System.Drawing.Point(22, 29);
			this.picCard.Name = "picCard";
			this.picCard.Size = new System.Drawing.Size(790, 546);
			this.picCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picCard.TabIndex = 11;
			this.picCard.TabStop = false;
			// 
			// txtInputLookAt
			// 
			this.txtInputLookAt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
			this.txtInputLookAt.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtInputLookAt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtInputLookAt.ForeColor = System.Drawing.Color.DimGray;
			this.txtInputLookAt.Location = new System.Drawing.Point(269, 357);
			this.txtInputLookAt.Name = "txtInputLookAt";
			this.txtInputLookAt.Size = new System.Drawing.Size(278, 24);
			this.txtInputLookAt.TabIndex = 22;
			this.txtInputLookAt.Text = "Look At";
			// 
			// picDarkRectangleFieldLookAt
			// 
			this.picDarkRectangleFieldLookAt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
			this.picDarkRectangleFieldLookAt.Image = global::GUI.Properties.Resources.darkFieldRectangle;
			this.picDarkRectangleFieldLookAt.Location = new System.Drawing.Point(251, 345);
			this.picDarkRectangleFieldLookAt.Name = "picDarkRectangleFieldLookAt";
			this.picDarkRectangleFieldLookAt.Size = new System.Drawing.Size(323, 45);
			this.picDarkRectangleFieldLookAt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picDarkRectangleFieldLookAt.TabIndex = 21;
			this.picDarkRectangleFieldLookAt.TabStop = false;
			// 
			// lblFOV
			// 
			this.lblFOV.AutoSize = true;
			this.lblFOV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
			this.lblFOV.Font = new System.Drawing.Font("Century Gothic", 13.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFOV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.lblFOV.Location = new System.Drawing.Point(387, 143);
			this.lblFOV.Name = "lblFOV";
			this.lblFOV.Size = new System.Drawing.Size(46, 22);
			this.lblFOV.TabIndex = 23;
			this.lblFOV.Text = "FOV";
			// 
			// lblLookFrom
			// 
			this.lblLookFrom.AutoSize = true;
			this.lblLookFrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
			this.lblLookFrom.Font = new System.Drawing.Font("Century Gothic", 13.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLookFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.lblLookFrom.Location = new System.Drawing.Point(361, 232);
			this.lblLookFrom.Name = "lblLookFrom";
			this.lblLookFrom.Size = new System.Drawing.Size(96, 22);
			this.lblLookFrom.TabIndex = 24;
			this.lblLookFrom.Text = "LookFrom";
			// 
			// lblLookAt
			// 
			this.lblLookAt.AutoSize = true;
			this.lblLookAt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
			this.lblLookAt.Font = new System.Drawing.Font("Century Gothic", 13.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLookAt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.lblLookAt.Location = new System.Drawing.Point(387, 320);
			this.lblLookAt.Name = "lblLookAt";
			this.lblLookAt.Size = new System.Drawing.Size(70, 22);
			this.lblLookAt.TabIndex = 25;
			this.lblLookAt.Text = "LookAt";
			// 
			// DefaultCam
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
			this.Controls.Add(this.lblLookAt);
			this.Controls.Add(this.lblLookFrom);
			this.Controls.Add(this.lblFOV);
			this.Controls.Add(this.txtInputLookAt);
			this.Controls.Add(this.picDarkRectangleFieldLookAt);
			this.Controls.Add(this.lblSave);
			this.Controls.Add(this.lblCancel);
			this.Controls.Add(this.picRectangleFieldCancel);
			this.Controls.Add(this.picRectangleFieldSave);
			this.Controls.Add(this.txtInputLookFrom);
			this.Controls.Add(this.picDarkRectangleFieldLookFrom);
			this.Controls.Add(this.txtInputFov);
			this.Controls.Add(this.picDarkRectangleFieldFov);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.picCard);
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "DefaultCam";
			this.Size = new System.Drawing.Size(834, 604);
			((System.ComponentModel.ISupportInitialize)(this.picRectangleFieldCancel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picRectangleFieldSave)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picDarkRectangleFieldLookFrom)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picDarkRectangleFieldFov)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picCard)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picDarkRectangleFieldLookAt)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSave;
        private System.Windows.Forms.Label lblCancel;
        private System.Windows.Forms.PictureBox picRectangleFieldCancel;
        private System.Windows.Forms.PictureBox picRectangleFieldSave;
        private System.Windows.Forms.TextBox txtInputLookFrom;
        private System.Windows.Forms.PictureBox picDarkRectangleFieldLookFrom;
        private System.Windows.Forms.TextBox txtInputFov;
        private System.Windows.Forms.PictureBox picDarkRectangleFieldFov;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picCard;
        private System.Windows.Forms.TextBox txtInputLookAt;
        private System.Windows.Forms.PictureBox picDarkRectangleFieldLookAt;
		private System.Windows.Forms.Label lblFOV;
		private System.Windows.Forms.Label lblLookFrom;
		private System.Windows.Forms.Label lblLookAt;
	}
}
