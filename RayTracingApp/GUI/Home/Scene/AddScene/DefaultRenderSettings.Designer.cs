namespace GUI
{
    partial class DefaultRenderSettings
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
            this.picCard = new System.Windows.Forms.PictureBox();
            this.lblX = new System.Windows.Forms.Label();
            this.txtResY = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbMaxDepth = new System.Windows.Forms.Label();
            this.lblSamplesPerPixel = new System.Windows.Forms.Label();
            this.lblFOV = new System.Windows.Forms.Label();
            this.txtMaxDepth = new System.Windows.Forms.TextBox();
            this.picDarkRectangleFieldMaxDepth = new System.Windows.Forms.PictureBox();
            this.lblSave = new System.Windows.Forms.Label();
            this.lblCancel = new System.Windows.Forms.Label();
            this.picRectangleFieldCancel = new System.Windows.Forms.PictureBox();
            this.picRectangleFieldSave = new System.Windows.Forms.PictureBox();
            this.txtSamplesPerPixel = new System.Windows.Forms.TextBox();
            this.picDarkRectangleFieldSamplesPerPixel = new System.Windows.Forms.PictureBox();
            this.txtResX = new System.Windows.Forms.TextBox();
            this.picDarkRectangleFieldFov = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDarkRectangleFieldMaxDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRectangleFieldCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRectangleFieldSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDarkRectangleFieldSamplesPerPixel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDarkRectangleFieldFov)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // picCard
            // 
            this.picCard.Image = global::GUI.Properties.Resources.card;
            this.picCard.Location = new System.Drawing.Point(22, 29);
            this.picCard.Name = "picCard";
            this.picCard.Size = new System.Drawing.Size(790, 546);
            this.picCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCard.TabIndex = 0;
            this.picCard.TabStop = false;
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.lblX.Font = new System.Drawing.Font("Century Gothic", 13.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblX.Location = new System.Drawing.Point(397, 188);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(22, 22);
            this.lblX.TabIndex = 46;
            this.lblX.Text = "X";
            // 
            // txtResY
            // 
            this.txtResY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.txtResY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResY.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResY.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtResY.Location = new System.Drawing.Point(441, 188);
            this.txtResY.Name = "txtResY";
            this.txtResY.Size = new System.Drawing.Size(85, 24);
            this.txtResY.TabIndex = 45;
            this.txtResY.Text = "200";
            this.txtResY.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtResY_KeyUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.pictureBox1.Image = global::GUI.Properties.Resources.xSmallGrayDarkFieldRectangle;
            this.pictureBox1.Location = new System.Drawing.Point(429, 176);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // lbMaxDepth
            // 
            this.lbMaxDepth.AutoSize = true;
            this.lbMaxDepth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.lbMaxDepth.Font = new System.Drawing.Font("Century Gothic", 13.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaxDepth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lbMaxDepth.Location = new System.Drawing.Point(351, 342);
            this.lbMaxDepth.Name = "lbMaxDepth";
            this.lbMaxDepth.Size = new System.Drawing.Size(106, 22);
            this.lbMaxDepth.TabIndex = 43;
            this.lbMaxDepth.Text = "Max Depth";
            // 
            // lblSamplesPerPixel
            // 
            this.lblSamplesPerPixel.AutoSize = true;
            this.lblSamplesPerPixel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.lblSamplesPerPixel.Font = new System.Drawing.Font("Century Gothic", 13.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSamplesPerPixel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblSamplesPerPixel.Location = new System.Drawing.Point(325, 244);
            this.lblSamplesPerPixel.Name = "lblSamplesPerPixel";
            this.lblSamplesPerPixel.Size = new System.Drawing.Size(162, 22);
            this.lblSamplesPerPixel.TabIndex = 42;
            this.lblSamplesPerPixel.Text = "Samples Per Pixel";
            // 
            // lblFOV
            // 
            this.lblFOV.AutoSize = true;
            this.lblFOV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.lblFOV.Font = new System.Drawing.Font("Century Gothic", 13.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFOV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblFOV.Location = new System.Drawing.Point(351, 139);
            this.lblFOV.Name = "lblFOV";
            this.lblFOV.Size = new System.Drawing.Size(99, 22);
            this.lblFOV.TabIndex = 41;
            this.lblFOV.Text = "Resolution";
            // 
            // txtMaxDepth
            // 
            this.txtMaxDepth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.txtMaxDepth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaxDepth.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxDepth.ForeColor = System.Drawing.Color.DimGray;
            this.txtMaxDepth.Location = new System.Drawing.Point(264, 387);
            this.txtMaxDepth.Name = "txtMaxDepth";
            this.txtMaxDepth.Size = new System.Drawing.Size(278, 24);
            this.txtMaxDepth.TabIndex = 40;
            this.txtMaxDepth.Text = "20";
            // 
            // picDarkRectangleFieldMaxDepth
            // 
            this.picDarkRectangleFieldMaxDepth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.picDarkRectangleFieldMaxDepth.Image = global::GUI.Properties.Resources.darkFieldRectangle;
            this.picDarkRectangleFieldMaxDepth.Location = new System.Drawing.Point(246, 375);
            this.picDarkRectangleFieldMaxDepth.Name = "picDarkRectangleFieldMaxDepth";
            this.picDarkRectangleFieldMaxDepth.Size = new System.Drawing.Size(323, 45);
            this.picDarkRectangleFieldMaxDepth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picDarkRectangleFieldMaxDepth.TabIndex = 39;
            this.picDarkRectangleFieldMaxDepth.TabStop = false;
            // 
            // lblSave
            // 
            this.lblSave.AutoSize = true;
            this.lblSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(158)))), ((int)(((byte)(140)))));
            this.lblSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSave.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSave.ForeColor = System.Drawing.Color.White;
            this.lblSave.Location = new System.Drawing.Point(498, 462);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(56, 23);
            this.lblSave.TabIndex = 38;
            this.lblSave.Text = "Save";
            this.lblSave.Click += new System.EventHandler(this.LblSave_Click);
            // 
            // lblCancel
            // 
            this.lblCancel.AutoSize = true;
            this.lblCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(158)))), ((int)(((byte)(140)))));
            this.lblCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCancel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancel.ForeColor = System.Drawing.Color.White;
            this.lblCancel.Location = new System.Drawing.Point(254, 463);
            this.lblCancel.Name = "lblCancel";
            this.lblCancel.Size = new System.Drawing.Size(78, 23);
            this.lblCancel.TabIndex = 37;
            this.lblCancel.Text = "Cancel";
            this.lblCancel.Click += new System.EventHandler(this.LblCancel_Click);
            // 
            // picRectangleFieldCancel
            // 
            this.picRectangleFieldCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.picRectangleFieldCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRectangleFieldCancel.Image = global::GUI.Properties.Resources.homeButtonsBackground;
            this.picRectangleFieldCancel.Location = new System.Drawing.Point(212, 452);
            this.picRectangleFieldCancel.Name = "picRectangleFieldCancel";
            this.picRectangleFieldCancel.Size = new System.Drawing.Size(165, 45);
            this.picRectangleFieldCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRectangleFieldCancel.TabIndex = 36;
            this.picRectangleFieldCancel.TabStop = false;
            this.picRectangleFieldCancel.Click += new System.EventHandler(this.PicRectangleFieldCancel_Click);
            // 
            // picRectangleFieldSave
            // 
            this.picRectangleFieldSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.picRectangleFieldSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRectangleFieldSave.Image = global::GUI.Properties.Resources.homeButtonsBackground;
            this.picRectangleFieldSave.Location = new System.Drawing.Point(441, 452);
            this.picRectangleFieldSave.Name = "picRectangleFieldSave";
            this.picRectangleFieldSave.Size = new System.Drawing.Size(165, 45);
            this.picRectangleFieldSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRectangleFieldSave.TabIndex = 35;
            this.picRectangleFieldSave.TabStop = false;
            this.picRectangleFieldSave.Click += new System.EventHandler(this.PicRectangleFieldSave_Click);
            // 
            // txtSamplesPerPixel
            // 
            this.txtSamplesPerPixel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.txtSamplesPerPixel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSamplesPerPixel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSamplesPerPixel.ForeColor = System.Drawing.Color.DimGray;
            this.txtSamplesPerPixel.Location = new System.Drawing.Point(264, 292);
            this.txtSamplesPerPixel.Name = "txtSamplesPerPixel";
            this.txtSamplesPerPixel.Size = new System.Drawing.Size(278, 24);
            this.txtSamplesPerPixel.TabIndex = 34;
            this.txtSamplesPerPixel.Text = "50";
            // 
            // picDarkRectangleFieldSamplesPerPixel
            // 
            this.picDarkRectangleFieldSamplesPerPixel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.picDarkRectangleFieldSamplesPerPixel.Image = global::GUI.Properties.Resources.darkFieldRectangle;
            this.picDarkRectangleFieldSamplesPerPixel.Location = new System.Drawing.Point(246, 280);
            this.picDarkRectangleFieldSamplesPerPixel.Name = "picDarkRectangleFieldSamplesPerPixel";
            this.picDarkRectangleFieldSamplesPerPixel.Size = new System.Drawing.Size(323, 45);
            this.picDarkRectangleFieldSamplesPerPixel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picDarkRectangleFieldSamplesPerPixel.TabIndex = 33;
            this.picDarkRectangleFieldSamplesPerPixel.TabStop = false;
            // 
            // txtResX
            // 
            this.txtResX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.txtResX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResX.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResX.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtResX.Location = new System.Drawing.Point(292, 188);
            this.txtResX.Name = "txtResX";
            this.txtResX.Size = new System.Drawing.Size(85, 24);
            this.txtResX.TabIndex = 32;
            this.txtResX.Text = "300";
            this.txtResX.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtResX_KeyUp);
            // 
            // picDarkRectangleFieldFov
            // 
            this.picDarkRectangleFieldFov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.picDarkRectangleFieldFov.Image = global::GUI.Properties.Resources.xSmallGrayDarkFieldRectangle;
            this.picDarkRectangleFieldFov.Location = new System.Drawing.Point(280, 176);
            this.picDarkRectangleFieldFov.Name = "picDarkRectangleFieldFov";
            this.picDarkRectangleFieldFov.Size = new System.Drawing.Size(108, 45);
            this.picDarkRectangleFieldFov.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picDarkRectangleFieldFov.TabIndex = 31;
            this.picDarkRectangleFieldFov.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblTitle.Location = new System.Drawing.Point(302, 85);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(214, 32);
            this.lblTitle.TabIndex = 30;
            this.lblTitle.Text = "Render Settings";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GUI.Properties.Resources.card;
            this.pictureBox2.Location = new System.Drawing.Point(22, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(790, 546);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // DefaultRenderSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.txtResY);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbMaxDepth);
            this.Controls.Add(this.lblSamplesPerPixel);
            this.Controls.Add(this.lblFOV);
            this.Controls.Add(this.txtMaxDepth);
            this.Controls.Add(this.picDarkRectangleFieldMaxDepth);
            this.Controls.Add(this.lblSave);
            this.Controls.Add(this.lblCancel);
            this.Controls.Add(this.picRectangleFieldCancel);
            this.Controls.Add(this.picRectangleFieldSave);
            this.Controls.Add(this.txtSamplesPerPixel);
            this.Controls.Add(this.picDarkRectangleFieldSamplesPerPixel);
            this.Controls.Add(this.txtResX);
            this.Controls.Add(this.picDarkRectangleFieldFov);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.picCard);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Location = new System.Drawing.Point(258, 87);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "DefaultRenderSettings";
            this.Size = new System.Drawing.Size(834, 604);
            ((System.ComponentModel.ISupportInitialize)(this.picCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDarkRectangleFieldMaxDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRectangleFieldCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRectangleFieldSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDarkRectangleFieldSamplesPerPixel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDarkRectangleFieldFov)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCard;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.TextBox txtResY;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbMaxDepth;
        private System.Windows.Forms.Label lblSamplesPerPixel;
        private System.Windows.Forms.Label lblFOV;
        private System.Windows.Forms.TextBox txtMaxDepth;
        private System.Windows.Forms.PictureBox picDarkRectangleFieldMaxDepth;
        private System.Windows.Forms.Label lblSave;
        private System.Windows.Forms.Label lblCancel;
        private System.Windows.Forms.PictureBox picRectangleFieldCancel;
        private System.Windows.Forms.PictureBox picRectangleFieldSave;
        private System.Windows.Forms.TextBox txtSamplesPerPixel;
        private System.Windows.Forms.PictureBox picDarkRectangleFieldSamplesPerPixel;
        private System.Windows.Forms.TextBox txtResX;
        private System.Windows.Forms.PictureBox picDarkRectangleFieldFov;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
