namespace GUI
{
    partial class ModelList
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
            this.lblAddModel = new System.Windows.Forms.Label();
            this.flyModelList = new System.Windows.Forms.FlowLayoutPanel();
            this.picIconPlus = new System.Windows.Forms.PictureBox();
            this.picAddModel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picIconPlus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAddModel)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddModel
            // 
            this.lblAddModel.AutoSize = true;
            this.lblAddModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(158)))), ((int)(((byte)(140)))));
            this.lblAddModel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAddModel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddModel.ForeColor = System.Drawing.Color.White;
            this.lblAddModel.Location = new System.Drawing.Point(370, 69);
            this.lblAddModel.Name = "lblAddModel";
            this.lblAddModel.Size = new System.Drawing.Size(114, 23);
            this.lblAddModel.TabIndex = 1;
            this.lblAddModel.Text = "Add Model";
            this.lblAddModel.Click += new System.EventHandler(this.lblAddModel_Click);
            // 
            // flyModelList
            // 
            this.flyModelList.AutoScroll = true;
            this.flyModelList.Location = new System.Drawing.Point(167, 148);
            this.flyModelList.Name = "flyModelList";
            this.flyModelList.Size = new System.Drawing.Size(500, 434);
            this.flyModelList.TabIndex = 3;
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
            // picAddModel
            // 
            this.picAddModel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAddModel.Image = global::GUI.Properties.Resources.homeButtonsBackground;
            this.picAddModel.Location = new System.Drawing.Point(310, 44);
            this.picAddModel.Name = "picAddModel";
            this.picAddModel.Size = new System.Drawing.Size(198, 72);
            this.picAddModel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAddModel.TabIndex = 0;
            this.picAddModel.TabStop = false;
            this.picAddModel.Click += new System.EventHandler(this.picAddModel_Click);
            // 
            // ModelList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.Controls.Add(this.flyModelList);
            this.Controls.Add(this.picIconPlus);
            this.Controls.Add(this.lblAddModel);
            this.Controls.Add(this.picAddModel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ModelList";
            this.Size = new System.Drawing.Size(834, 604);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ModelList_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.picIconPlus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAddModel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picAddModel;
        private System.Windows.Forms.Label lblAddModel;
        private System.Windows.Forms.PictureBox picIconPlus;
        private System.Windows.Forms.FlowLayoutPanel flyModelList;
    }
}
