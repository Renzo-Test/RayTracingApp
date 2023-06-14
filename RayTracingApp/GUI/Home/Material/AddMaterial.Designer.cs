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
            this.lblPickTitle = new System.Windows.Forms.Label();
            this.lblSave = new System.Windows.Forms.Label();
            this.lblCancel = new System.Windows.Forms.Label();
            this.picRectangleFieldCancel = new System.Windows.Forms.PictureBox();
            this.picRectangleFieldSave = new System.Windows.Forms.PictureBox();
            this.picDarkRectangleFieldBlue = new System.Windows.Forms.PictureBox();
            this.picDarkRectangleFieldGreen = new System.Windows.Forms.PictureBox();
            this.picDarkRectangleFieldRed = new System.Windows.Forms.PictureBox();
            this.picDarkRectangleFieldName = new System.Windows.Forms.PictureBox();
            this.picCard = new System.Windows.Forms.PictureBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.rbtnMetalicMaterial = new System.Windows.Forms.CheckBox();
            this.txtBlur = new System.Windows.Forms.TextBox();
            this.picBackBlur = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picRectangleFieldCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRectangleFieldSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDarkRectangleFieldBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDarkRectangleFieldGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDarkRectangleFieldRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDarkRectangleFieldName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBackBlur)).BeginInit();
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
            this.txtInputName.Location = new System.Drawing.Point(274, 174);
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
            this.txtInputRed.Location = new System.Drawing.Point(255, 295);
            this.txtInputRed.Name = "txtInputRed";
            this.txtInputRed.Size = new System.Drawing.Size(74, 24);
            this.txtInputRed.TabIndex = 5;
            this.txtInputRed.Text = "Red";
            this.txtInputRed.TextChanged += new System.EventHandler(this.txtInputRed_TextChanged);
            this.txtInputRed.Enter += new System.EventHandler(this.txtInputRed_Enter);
            this.txtInputRed.Leave += new System.EventHandler(this.txtInputRed_Leave);
            // 
            // txtInputGreen
            // 
            this.txtInputGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.txtInputGreen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInputGreen.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputGreen.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtInputGreen.Location = new System.Drawing.Point(385, 295);
            this.txtInputGreen.Name = "txtInputGreen";
            this.txtInputGreen.Size = new System.Drawing.Size(77, 24);
            this.txtInputGreen.TabIndex = 7;
            this.txtInputGreen.Text = "Green";
            this.txtInputGreen.TextChanged += new System.EventHandler(this.txtInputGreen_TextChanged);
            this.txtInputGreen.Enter += new System.EventHandler(this.txtInputGreen_Enter);
            this.txtInputGreen.Leave += new System.EventHandler(this.txtInputGreen_Leave);
            // 
            // txtInputBlue
            // 
            this.txtInputBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.txtInputBlue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInputBlue.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputBlue.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtInputBlue.Location = new System.Drawing.Point(518, 295);
            this.txtInputBlue.Name = "txtInputBlue";
            this.txtInputBlue.Size = new System.Drawing.Size(72, 24);
            this.txtInputBlue.TabIndex = 9;
            this.txtInputBlue.Text = "Blue";
            this.txtInputBlue.TextChanged += new System.EventHandler(this.txtInputBlue_TextChanged);
            this.txtInputBlue.Enter += new System.EventHandler(this.txtInputBlue_Enter);
            this.txtInputBlue.Leave += new System.EventHandler(this.txtInputBlue_Leave);
            // 
            // lblPickTitle
            // 
            this.lblPickTitle.AutoSize = true;
            this.lblPickTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.lblPickTitle.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPickTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblPickTitle.Location = new System.Drawing.Point(343, 230);
            this.lblPickTitle.Name = "lblPickTitle";
            this.lblPickTitle.Size = new System.Drawing.Size(68, 32);
            this.lblPickTitle.TabIndex = 10;
            this.lblPickTitle.Text = "Pick";
            // 
            // lblSave
            // 
            this.lblSave.AutoSize = true;
            this.lblSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(158)))), ((int)(((byte)(140)))));
            this.lblSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSave.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSave.ForeColor = System.Drawing.Color.White;
            this.lblSave.Location = new System.Drawing.Point(510, 464);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(56, 23);
            this.lblSave.TabIndex = 12;
            this.lblSave.Text = "Save";
            this.lblSave.Click += new System.EventHandler(this.lblSave_Click);
            // 
            // lblCancel
            // 
            this.lblCancel.AutoSize = true;
            this.lblCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(158)))), ((int)(((byte)(140)))));
            this.lblCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCancel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancel.ForeColor = System.Drawing.Color.White;
            this.lblCancel.Location = new System.Drawing.Point(270, 464);
            this.lblCancel.Name = "lblCancel";
            this.lblCancel.Size = new System.Drawing.Size(78, 23);
            this.lblCancel.TabIndex = 14;
            this.lblCancel.Text = "Cancel";
            this.lblCancel.Click += new System.EventHandler(this.lblCancel_Click);
            // 
            // picRectangleFieldCancel
            // 
            this.picRectangleFieldCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.picRectangleFieldCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRectangleFieldCancel.Image = global::GUI.Properties.Resources.loginBackground;
            this.picRectangleFieldCancel.Location = new System.Drawing.Point(225, 454);
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
            this.picRectangleFieldSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRectangleFieldSave.Image = global::GUI.Properties.Resources.loginBackground;
            this.picRectangleFieldSave.Location = new System.Drawing.Point(454, 454);
            this.picRectangleFieldSave.Name = "picRectangleFieldSave";
            this.picRectangleFieldSave.Size = new System.Drawing.Size(165, 45);
            this.picRectangleFieldSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRectangleFieldSave.TabIndex = 11;
            this.picRectangleFieldSave.TabStop = false;
            this.picRectangleFieldSave.Click += new System.EventHandler(this.picRectangleFieldSave_Click);
            // 
            // picDarkRectangleFieldBlue
            // 
            this.picDarkRectangleFieldBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.picDarkRectangleFieldBlue.Image = global::GUI.Properties.Resources.xSmallGrayDarkFieldRectangle;
            this.picDarkRectangleFieldBlue.Location = new System.Drawing.Point(500, 283);
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
            this.picDarkRectangleFieldGreen.Location = new System.Drawing.Point(367, 283);
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
            this.picDarkRectangleFieldRed.Location = new System.Drawing.Point(234, 283);
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
            this.picDarkRectangleFieldName.Location = new System.Drawing.Point(256, 162);
            this.picDarkRectangleFieldName.Name = "picDarkRectangleFieldName";
            this.picDarkRectangleFieldName.Size = new System.Drawing.Size(323, 45);
            this.picDarkRectangleFieldName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picDarkRectangleFieldName.TabIndex = 2;
            this.picDarkRectangleFieldName.TabStop = false;
            // 
            // picCard
            // 
            this.picCard.Image = global::GUI.Properties.Resources.card;
            this.picCard.Location = new System.Drawing.Point(29, 23);
            this.picCard.Name = "picCard";
            this.picCard.Size = new System.Drawing.Size(790, 546);
            this.picCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCard.TabIndex = 0;
            this.picCard.TabStop = false;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.lblColor.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblColor.Location = new System.Drawing.Point(407, 230);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(84, 32);
            this.lblColor.TabIndex = 15;
            this.lblColor.Text = "Color";
            // 
            // rbtnMetalicMaterial
            // 
            this.rbtnMetalicMaterial.AutoSize = true;
            this.rbtnMetalicMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.rbtnMetalicMaterial.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMetalicMaterial.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.rbtnMetalicMaterial.Location = new System.Drawing.Point(273, 375);
            this.rbtnMetalicMaterial.Name = "rbtnMetalicMaterial";
            this.rbtnMetalicMaterial.Size = new System.Drawing.Size(175, 26);
            this.rbtnMetalicMaterial.TabIndex = 31;
            this.rbtnMetalicMaterial.Text = "Metalic Material";
            this.rbtnMetalicMaterial.UseVisualStyleBackColor = false;
            this.rbtnMetalicMaterial.CheckedChanged += new System.EventHandler(this.rbtnMetalicMaterial_CheckedChanged);
            // 
            // txtBlur
            // 
            this.txtBlur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.txtBlur.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBlur.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBlur.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBlur.Location = new System.Drawing.Point(494, 375);
            this.txtBlur.Name = "txtBlur";
            this.txtBlur.Size = new System.Drawing.Size(72, 24);
            this.txtBlur.TabIndex = 33;
            this.txtBlur.Text = "Blur";
            this.txtBlur.Visible = false;
            this.txtBlur.Enter += new System.EventHandler(this.txtBlur_Enter);
            this.txtBlur.Leave += new System.EventHandler(this.txtBlur_Leave);
            // 
            // picBackBlur
            // 
            this.picBackBlur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.picBackBlur.Image = global::GUI.Properties.Resources.xSmallGrayDarkFieldRectangle;
            this.picBackBlur.Location = new System.Drawing.Point(476, 363);
            this.picBackBlur.Name = "picBackBlur";
            this.picBackBlur.Size = new System.Drawing.Size(108, 45);
            this.picBackBlur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBackBlur.TabIndex = 32;
            this.picBackBlur.TabStop = false;
            this.picBackBlur.Visible = false;
            // 
            // AddMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.Controls.Add(this.txtBlur);
            this.Controls.Add(this.picBackBlur);
            this.Controls.Add(this.rbtnMetalicMaterial);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblCancel);
            this.Controls.Add(this.picRectangleFieldCancel);
            this.Controls.Add(this.lblSave);
            this.Controls.Add(this.picRectangleFieldSave);
            this.Controls.Add(this.lblPickTitle);
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
            ((System.ComponentModel.ISupportInitialize)(this.picBackBlur)).EndInit();
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
        private System.Windows.Forms.Label lblPickTitle;
        private System.Windows.Forms.PictureBox picRectangleFieldSave;
        private System.Windows.Forms.Label lblSave;
        private System.Windows.Forms.Label lblCancel;
        private System.Windows.Forms.PictureBox picRectangleFieldCancel;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.CheckBox rbtnMetalicMaterial;
        private System.Windows.Forms.TextBox txtBlur;
        private System.Windows.Forms.PictureBox picBackBlur;
    }
}
