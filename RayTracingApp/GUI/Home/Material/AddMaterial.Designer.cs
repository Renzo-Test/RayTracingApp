namespace GUI
{
    partial class AddMaterial
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtInputName = new System.Windows.Forms.TextBox();
            this.txtInputRed = new System.Windows.Forms.TextBox();
            this.txtInputGreen = new System.Windows.Forms.TextBox();
            this.txtInputBlue = new System.Windows.Forms.TextBox();
            this.lblColorTitle = new System.Windows.Forms.Label();
            this.lblSave = new System.Windows.Forms.Label();
            this.lblCancel = new System.Windows.Forms.Label();
            this.picRectangleFieldCancel = new System.Windows.Forms.PictureBox();
            this.picRectangleFieldSave = new System.Windows.Forms.PictureBox();
            this.picDarkRectangleFieldBlue = new System.Windows.Forms.PictureBox();
            this.picDarkRectangleFieldGreen = new System.Windows.Forms.PictureBox();
            this.picDarkRectangleFieldRed = new System.Windows.Forms.PictureBox();
            this.picDarkRectangleFieldName = new System.Windows.Forms.PictureBox();
            this.picCard = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picRectangleFieldCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRectangleFieldSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDarkRectangleFieldBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDarkRectangleFieldGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDarkRectangleFieldRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDarkRectangleFieldName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblTitle.Location = new System.Drawing.Point(336, 92);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(184, 32);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Add Material";
            // 
            // txtInputName
            // 
            this.txtInputName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.txtInputName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInputName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtInputName.Location = new System.Drawing.Point(274, 186);
            this.txtInputName.Name = "txtInputName";
            this.txtInputName.Size = new System.Drawing.Size(276, 24);
            this.txtInputName.TabIndex = 3;
            this.txtInputName.Text = "Name";
            this.txtInputName.Enter += new System.EventHandler(this.txtInputName_Enter);
            this.txtInputName.Leave += new System.EventHandler(this.txtInputName_Leave);
            // 
            // txtInputRed
            // 
            this.txtInputRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.txtInputRed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInputRed.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputRed.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtInputRed.Location = new System.Drawing.Point(256, 344);
            this.txtInputRed.Name = "txtInputRed";
            this.txtInputRed.Size = new System.Drawing.Size(74, 24);
            this.txtInputRed.TabIndex = 5;
            this.txtInputRed.Text = "Red";
            this.txtInputRed.Enter += new System.EventHandler(this.txtInputRed_Enter);
            this.txtInputRed.Leave += new System.EventHandler(this.txtInputRed_Leave);
            // 
            // txtInputGreen
            // 
            this.txtInputGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.txtInputGreen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInputGreen.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputGreen.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtInputGreen.Location = new System.Drawing.Point(386, 344);
            this.txtInputGreen.Name = "txtInputGreen";
            this.txtInputGreen.Size = new System.Drawing.Size(77, 24);
            this.txtInputGreen.TabIndex = 7;
            this.txtInputGreen.Text = "Green";
            this.txtInputGreen.Enter += new System.EventHandler(this.txtInputGreen_Enter);
            this.txtInputGreen.Leave += new System.EventHandler(this.txtInputGreen_Leave);
            // 
            // txtInputBlue
            // 
            this.txtInputBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.txtInputBlue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInputBlue.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputBlue.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtInputBlue.Location = new System.Drawing.Point(519, 344);
            this.txtInputBlue.Name = "txtInputBlue";
            this.txtInputBlue.Size = new System.Drawing.Size(72, 24);
            this.txtInputBlue.TabIndex = 9;
            this.txtInputBlue.Text = "Blue";
            this.txtInputBlue.Enter += new System.EventHandler(this.txtInputBlue_Enter);
            this.txtInputBlue.Leave += new System.EventHandler(this.txtInputBlue_Leave);
            // 
            // lblColorTitle
            // 
            this.lblColorTitle.AutoSize = true;
            this.lblColorTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.lblColorTitle.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColorTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblColorTitle.Location = new System.Drawing.Point(353, 258);
            this.lblColorTitle.Name = "lblColorTitle";
            this.lblColorTitle.Size = new System.Drawing.Size(146, 32);
            this.lblColorTitle.TabIndex = 10;
            this.lblColorTitle.Text = "Pick Color";
            // 
            // lblSave
            // 
            this.lblSave.AutoSize = true;
            this.lblSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(158)))), ((int)(((byte)(140)))));
            this.lblSave.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSave.ForeColor = System.Drawing.Color.White;
            this.lblSave.Location = new System.Drawing.Point(277, 442);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(56, 23);
            this.lblSave.TabIndex = 12;
            this.lblSave.Text = "Save";
            // 
            // lblCancel
            // 
            this.lblCancel.AutoSize = true;
            this.lblCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(158)))), ((int)(((byte)(140)))));
            this.lblCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCancel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancel.ForeColor = System.Drawing.Color.White;
            this.lblCancel.Location = new System.Drawing.Point(501, 442);
            this.lblCancel.Name = "lblCancel";
            this.lblCancel.Size = new System.Drawing.Size(78, 23);
            this.lblCancel.TabIndex = 14;
            this.lblCancel.Text = "Cancel";
            this.lblCancel.Click += new System.EventHandler(this.lblCancel_Click);
            // 
            // picRectangleFieldCancel
            // 
            this.picRectangleFieldCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.picRectangleFieldCancel.Image = global::GUI.Properties.Resources.loginBackground;
            this.picRectangleFieldCancel.Location = new System.Drawing.Point(454, 432);
            this.picRectangleFieldCancel.Name = "picRectangleFieldCancel";
            this.picRectangleFieldCancel.Size = new System.Drawing.Size(165, 45);
            this.picRectangleFieldCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRectangleFieldCancel.TabIndex = 13;
            this.picRectangleFieldCancel.TabStop = false;
            this.picRectangleFieldCancel.Click += new System.EventHandler(this.picRectangleFieldCancel_Click);
            // 
            // picRectangleFieldSave
            // 
            this.picRectangleFieldSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.picRectangleFieldSave.Image = global::GUI.Properties.Resources.loginBackground;
            this.picRectangleFieldSave.Location = new System.Drawing.Point(225, 432);
            this.picRectangleFieldSave.Name = "picRectangleFieldSave";
            this.picRectangleFieldSave.Size = new System.Drawing.Size(165, 45);
            this.picRectangleFieldSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRectangleFieldSave.TabIndex = 11;
            this.picRectangleFieldSave.TabStop = false;
            // 
            // picDarkRectangleFieldBlue
            // 
            this.picDarkRectangleFieldBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.picDarkRectangleFieldBlue.Image = global::GUI.Properties.Resources.xSmallGrayDarkFieldRectangle;
            this.picDarkRectangleFieldBlue.Location = new System.Drawing.Point(501, 332);
            this.picDarkRectangleFieldBlue.Name = "picDarkRectangleFieldBlue";
            this.picDarkRectangleFieldBlue.Size = new System.Drawing.Size(108, 45);
            this.picDarkRectangleFieldBlue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picDarkRectangleFieldBlue.TabIndex = 8;
            this.picDarkRectangleFieldBlue.TabStop = false;
            // 
            // picDarkRectangleFieldGreen
            // 
            this.picDarkRectangleFieldGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.picDarkRectangleFieldGreen.Image = global::GUI.Properties.Resources.xSmallGrayDarkFieldRectangle;
            this.picDarkRectangleFieldGreen.Location = new System.Drawing.Point(368, 332);
            this.picDarkRectangleFieldGreen.Name = "picDarkRectangleFieldGreen";
            this.picDarkRectangleFieldGreen.Size = new System.Drawing.Size(108, 45);
            this.picDarkRectangleFieldGreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picDarkRectangleFieldGreen.TabIndex = 6;
            this.picDarkRectangleFieldGreen.TabStop = false;
            // 
            // picDarkRectangleFieldRed
            // 
            this.picDarkRectangleFieldRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.picDarkRectangleFieldRed.Image = global::GUI.Properties.Resources.xSmallGrayDarkFieldRectangle;
            this.picDarkRectangleFieldRed.Location = new System.Drawing.Point(235, 332);
            this.picDarkRectangleFieldRed.Name = "picDarkRectangleFieldRed";
            this.picDarkRectangleFieldRed.Size = new System.Drawing.Size(108, 45);
            this.picDarkRectangleFieldRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picDarkRectangleFieldRed.TabIndex = 4;
            this.picDarkRectangleFieldRed.TabStop = false;
            // 
            // picDarkRectangleFieldName
            // 
            this.picDarkRectangleFieldName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.picDarkRectangleFieldName.Image = global::GUI.Properties.Resources.darkFieldRectangle;
            this.picDarkRectangleFieldName.Location = new System.Drawing.Point(256, 174);
            this.picDarkRectangleFieldName.Name = "picDarkRectangleFieldName";
            this.picDarkRectangleFieldName.Size = new System.Drawing.Size(323, 45);
            this.picDarkRectangleFieldName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picDarkRectangleFieldName.TabIndex = 2;
            this.picDarkRectangleFieldName.TabStop = false;
            // 
            // picCard
            // 
            this.picCard.Image = global::GUI.Properties.Resources.card;
            this.picCard.Location = new System.Drawing.Point(25, 24);
            this.picCard.Name = "picCard";
            this.picCard.Size = new System.Drawing.Size(790, 546);
            this.picCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCard.TabIndex = 0;
            this.picCard.TabStop = false;
            // 
            // AddMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.Controls.Add(this.lblCancel);
            this.Controls.Add(this.picRectangleFieldCancel);
            this.Controls.Add(this.lblSave);
            this.Controls.Add(this.picRectangleFieldSave);
            this.Controls.Add(this.lblColorTitle);
            this.Controls.Add(this.txtInputBlue);
            this.Controls.Add(this.picDarkRectangleFieldBlue);
            this.Controls.Add(this.txtInputGreen);
            this.Controls.Add(this.picDarkRectangleFieldGreen);
            this.Controls.Add(this.txtInputRed);
            this.Controls.Add(this.picDarkRectangleFieldRed);
            this.Controls.Add(this.txtInputName);
            this.Controls.Add(this.picDarkRectangleFieldName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.picCard);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "AddMaterial";
            this.Size = new System.Drawing.Size(834, 604);
            ((System.ComponentModel.ISupportInitialize)(this.picRectangleFieldCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRectangleFieldSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDarkRectangleFieldBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDarkRectangleFieldGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDarkRectangleFieldRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDarkRectangleFieldName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCard;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picDarkRectangleFieldName;
        private System.Windows.Forms.TextBox txtInputName;
        private System.Windows.Forms.TextBox txtInputRed;
        private System.Windows.Forms.PictureBox picDarkRectangleFieldRed;
        private System.Windows.Forms.TextBox txtInputGreen;
        private System.Windows.Forms.PictureBox picDarkRectangleFieldGreen;
        private System.Windows.Forms.TextBox txtInputBlue;
        private System.Windows.Forms.PictureBox picDarkRectangleFieldBlue;
        private System.Windows.Forms.Label lblColorTitle;
        private System.Windows.Forms.PictureBox picRectangleFieldSave;
        private System.Windows.Forms.Label lblSave;
        private System.Windows.Forms.Label lblCancel;
        private System.Windows.Forms.PictureBox picRectangleFieldCancel;
    }
}
