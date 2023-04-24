namespace GUI
{
    partial class MaterialList
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
            this.picAddMaterial = new System.Windows.Forms.PictureBox();
            this.lblAddMaterial = new System.Windows.Forms.Label();
            this.picIconPlus = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picAddMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIconPlus)).BeginInit();
            this.SuspendLayout();
            // 
            // picAddMaterial
            // 
            this.picAddMaterial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAddMaterial.Image = global::GUI.Properties.Resources.homeButtonsBackground;
            this.picAddMaterial.Location = new System.Drawing.Point(310, 44);
            this.picAddMaterial.Name = "picAddMaterial";
            this.picAddMaterial.Size = new System.Drawing.Size(198, 72);
            this.picAddMaterial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAddMaterial.TabIndex = 0;
            this.picAddMaterial.TabStop = false;
            this.picAddMaterial.Click += new System.EventHandler(this.picAddMaterial_Click);
            // 
            // lblAddMaterial
            // 
            this.lblAddMaterial.AutoSize = true;
            this.lblAddMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(158)))), ((int)(((byte)(140)))));
            this.lblAddMaterial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAddMaterial.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddMaterial.ForeColor = System.Drawing.Color.White;
            this.lblAddMaterial.Location = new System.Drawing.Point(361, 68);
            this.lblAddMaterial.Name = "lblAddMaterial";
            this.lblAddMaterial.Size = new System.Drawing.Size(132, 23);
            this.lblAddMaterial.TabIndex = 1;
            this.lblAddMaterial.Text = "Add Material";
            this.lblAddMaterial.Click += new System.EventHandler(this.lblAddMaterial_Click);
            // 
            // picIconPlus
            // 
            this.picIconPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(158)))), ((int)(((byte)(140)))));
            this.picIconPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picIconPlus.Image = global::GUI.Properties.Resources.plus;
            this.picIconPlus.Location = new System.Drawing.Point(333, 69);
            this.picIconPlus.Name = "picIconPlus";
            this.picIconPlus.Size = new System.Drawing.Size(22, 22);
            this.picIconPlus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIconPlus.TabIndex = 2;
            this.picIconPlus.TabStop = false;
            this.picIconPlus.Click += new System.EventHandler(this.picIconPlus_Click);
            // 
            // MaterialList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.Controls.Add(this.picIconPlus);
            this.Controls.Add(this.lblAddMaterial);
            this.Controls.Add(this.picAddMaterial);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "MaterialList";
            this.Size = new System.Drawing.Size(834, 604);
            ((System.ComponentModel.ISupportInitialize)(this.picAddMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIconPlus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picAddMaterial;
        private System.Windows.Forms.Label lblAddMaterial;
        private System.Windows.Forms.PictureBox picIconPlus;
    }
}
