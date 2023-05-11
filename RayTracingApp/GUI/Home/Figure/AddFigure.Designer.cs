namespace GUI
{
    partial class AddFigure
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
            this.txtInputRadius = new System.Windows.Forms.TextBox();
            this.picRectangleFieldCancel = new System.Windows.Forms.PictureBox();
            this.picRectangleFieldSave = new System.Windows.Forms.PictureBox();
            this.picDarkRectangleFieldRadius = new System.Windows.Forms.PictureBox();
            this.picDarkRectangleFieldName = new System.Windows.Forms.PictureBox();
            this.picCard = new System.Windows.Forms.PictureBox();
            this.lblCancel = new System.Windows.Forms.Label();
            this.lblSave = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picRectangleFieldCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRectangleFieldSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDarkRectangleFieldRadius)).BeginInit();
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
            this.lblTitle.Size = new System.Drawing.Size(157, 32);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Add Figure";
            // 
            // txtInputName
            // 
            this.txtInputName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.txtInputName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInputName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtInputName.Location = new System.Drawing.Point(276, 208);
            this.txtInputName.Name = "txtInputName";
            this.txtInputName.Size = new System.Drawing.Size(276, 24);
            this.txtInputName.TabIndex = 3;
            this.txtInputName.Text = "Name";
            this.txtInputName.Enter += new System.EventHandler(this.txtInputName_Enter);
            this.txtInputName.Leave += new System.EventHandler(this.txtInputName_Leave);
            // 
            // txtInputRadius
            // 
            this.txtInputRadius.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.txtInputRadius.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInputRadius.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputRadius.ForeColor = System.Drawing.Color.DimGray;
            this.txtInputRadius.Location = new System.Drawing.Point(274, 292);
            this.txtInputRadius.Name = "txtInputRadius";
            this.txtInputRadius.Size = new System.Drawing.Size(278, 24);
            this.txtInputRadius.TabIndex = 5;
            this.txtInputRadius.Text = "Radius";
            this.txtInputRadius.Enter += new System.EventHandler(this.txtInputRadius_Enter);
            this.txtInputRadius.Leave += new System.EventHandler(this.txtInputRadius_Leave);
            // 
            // picRectangleFieldCancel
            // 
            this.picRectangleFieldCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.picRectangleFieldCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRectangleFieldCancel.Image = global::GUI.Properties.Resources.homeButtonsBackground;
            this.picRectangleFieldCancel.Location = new System.Drawing.Point(222, 403);
            this.picRectangleFieldCancel.Name = "picRectangleFieldCancel";
            this.picRectangleFieldCancel.Size = new System.Drawing.Size(165, 45);
            this.picRectangleFieldCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRectangleFieldCancel.TabIndex = 8;
            this.picRectangleFieldCancel.TabStop = false;
            this.picRectangleFieldCancel.Click += new System.EventHandler(this.picRectangleFieldCancel_Click);
            // 
            // picRectangleFieldSave
            // 
            this.picRectangleFieldSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.picRectangleFieldSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRectangleFieldSave.Image = global::GUI.Properties.Resources.homeButtonsBackground;
            this.picRectangleFieldSave.Location = new System.Drawing.Point(451, 403);
            this.picRectangleFieldSave.Name = "picRectangleFieldSave";
            this.picRectangleFieldSave.Size = new System.Drawing.Size(165, 45);
            this.picRectangleFieldSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRectangleFieldSave.TabIndex = 6;
            this.picRectangleFieldSave.TabStop = false;
            this.picRectangleFieldSave.Click += new System.EventHandler(this.picRectangleFieldSave_Click);
            // 
            // picDarkRectangleFieldRadius
            // 
            this.picDarkRectangleFieldRadius.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.picDarkRectangleFieldRadius.Image = global::GUI.Properties.Resources.darkFieldRectangle;
            this.picDarkRectangleFieldRadius.Location = new System.Drawing.Point(256, 280);
            this.picDarkRectangleFieldRadius.Name = "picDarkRectangleFieldRadius";
            this.picDarkRectangleFieldRadius.Size = new System.Drawing.Size(323, 45);
            this.picDarkRectangleFieldRadius.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picDarkRectangleFieldRadius.TabIndex = 4;
            this.picDarkRectangleFieldRadius.TabStop = false;
            // 
            // picDarkRectangleFieldName
            // 
            this.picDarkRectangleFieldName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.picDarkRectangleFieldName.Image = global::GUI.Properties.Resources.darkFieldRectangle;
            this.picDarkRectangleFieldName.Location = new System.Drawing.Point(258, 196);
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
            // lblCancel
            // 
            this.lblCancel.AutoSize = true;
            this.lblCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(158)))), ((int)(((byte)(140)))));
            this.lblCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCancel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancel.ForeColor = System.Drawing.Color.White;
            this.lblCancel.Location = new System.Drawing.Point(264, 414);
            this.lblCancel.Name = "lblCancel";
            this.lblCancel.Size = new System.Drawing.Size(78, 23);
            this.lblCancel.TabIndex = 9;
            this.lblCancel.Text = "Cancel";
            this.lblCancel.Click += new System.EventHandler(this.lblCancel_Click);
            // 
            // lblSave
            // 
            this.lblSave.AutoSize = true;
            this.lblSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(158)))), ((int)(((byte)(140)))));
            this.lblSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSave.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSave.ForeColor = System.Drawing.Color.White;
            this.lblSave.Location = new System.Drawing.Point(508, 413);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(56, 23);
            this.lblSave.TabIndex = 10;
            this.lblSave.Text = "Save";
            this.lblSave.Click += new System.EventHandler(this.lblSave_Click);
            // 
            // AddFigure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.Controls.Add(this.lblSave);
            this.Controls.Add(this.lblCancel);
            this.Controls.Add(this.picRectangleFieldCancel);
            this.Controls.Add(this.picRectangleFieldSave);
            this.Controls.Add(this.txtInputRadius);
            this.Controls.Add(this.picDarkRectangleFieldRadius);
            this.Controls.Add(this.txtInputName);
            this.Controls.Add(this.picDarkRectangleFieldName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.picCard);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(834, 604);
            this.MinimumSize = new System.Drawing.Size(834, 604);
            this.Name = "AddFigure";
            this.Size = new System.Drawing.Size(834, 604);
            ((System.ComponentModel.ISupportInitialize)(this.picRectangleFieldCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRectangleFieldSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDarkRectangleFieldRadius)).EndInit();
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
        private System.Windows.Forms.TextBox txtInputRadius;
        private System.Windows.Forms.PictureBox picDarkRectangleFieldRadius;
        private System.Windows.Forms.PictureBox picRectangleFieldSave;
        private System.Windows.Forms.PictureBox picRectangleFieldCancel;
        private System.Windows.Forms.Label lblCancel;
        private System.Windows.Forms.Label lblSave;
    }
}
