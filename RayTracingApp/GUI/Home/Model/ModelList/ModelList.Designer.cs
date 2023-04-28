namespace GUI
{
    partial class picAddModel
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAddFigure = new System.Windows.Forms.Label();
            this.picIconPlus = new System.Windows.Forms.PictureBox();
            this.flyModelList = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIconPlus)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::GUI.Properties.Resources.homeButtonsBackground;
            this.pictureBox1.Location = new System.Drawing.Point(310, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblAddFigure
            // 
            this.lblAddFigure.AutoSize = true;
            this.lblAddFigure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(158)))), ((int)(((byte)(140)))));
            this.lblAddFigure.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAddFigure.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddFigure.ForeColor = System.Drawing.Color.White;
            this.lblAddFigure.Location = new System.Drawing.Point(370, 69);
            this.lblAddFigure.Name = "lblAddFigure";
            this.lblAddFigure.Size = new System.Drawing.Size(114, 23);
            this.lblAddFigure.TabIndex = 1;
            this.lblAddFigure.Text = "Add Model";
            // 
            // picIconPlus
            // 
            this.picIconPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(158)))), ((int)(((byte)(140)))));
            this.picIconPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picIconPlus.Image = global::GUI.Properties.Resources.plus;
            this.picIconPlus.Location = new System.Drawing.Point(342, 69);
            this.picIconPlus.Name = "picIconPlus";
            this.picIconPlus.Size = new System.Drawing.Size(22, 22);
            this.picIconPlus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIconPlus.TabIndex = 2;
            this.picIconPlus.TabStop = false;
            // 
            // flyModelList
            // 
            this.flyModelList.Location = new System.Drawing.Point(167, 148);
            this.flyModelList.Name = "flyModelList";
            this.flyModelList.Size = new System.Drawing.Size(500, 434);
            this.flyModelList.TabIndex = 3;
            // 
            // picAddModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.Controls.Add(this.flyModelList);
            this.Controls.Add(this.picIconPlus);
            this.Controls.Add(this.lblAddFigure);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "picAddModel";
            this.Size = new System.Drawing.Size(834, 604);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIconPlus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAddFigure;
        private System.Windows.Forms.PictureBox picIconPlus;
        private System.Windows.Forms.FlowLayoutPanel flyModelList;
    }
}
