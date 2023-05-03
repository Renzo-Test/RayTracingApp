namespace GUI
{
    partial class SceneList
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
            this.flySceneList = new System.Windows.Forms.FlowLayoutPanel();
            this.picAddScene = new System.Windows.Forms.PictureBox();
            this.lblAddScene = new System.Windows.Forms.Label();
            this.picIconPlus = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picAddScene)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIconPlus)).BeginInit();
            this.SuspendLayout();
            // 
            // flySceneList
            // 
            this.flySceneList.Location = new System.Drawing.Point(167, 148);
            this.flySceneList.Name = "flySceneList";
            this.flySceneList.Size = new System.Drawing.Size(500, 434);
            this.flySceneList.TabIndex = 0;
            // 
            // picAddScene
            // 
            this.picAddScene.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAddScene.Image = global::GUI.Properties.Resources.homeButtonsBackground;
            this.picAddScene.Location = new System.Drawing.Point(310, 44);
            this.picAddScene.Name = "picAddScene";
            this.picAddScene.Size = new System.Drawing.Size(198, 72);
            this.picAddScene.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAddScene.TabIndex = 1;
            this.picAddScene.TabStop = false;
            this.picAddScene.Click += new System.EventHandler(this.picAddScene_Click);
            // 
            // lblAddScene
            // 
            this.lblAddScene.AutoSize = true;
            this.lblAddScene.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(158)))), ((int)(((byte)(140)))));
            this.lblAddScene.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAddScene.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddScene.ForeColor = System.Drawing.Color.White;
            this.lblAddScene.Location = new System.Drawing.Point(370, 69);
            this.lblAddScene.Name = "lblAddScene";
            this.lblAddScene.Size = new System.Drawing.Size(112, 23);
            this.lblAddScene.TabIndex = 2;
            this.lblAddScene.Text = "Add Scene";
            this.lblAddScene.Click += new System.EventHandler(this.lblAddScene_Click);
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
            this.picIconPlus.TabIndex = 3;
            this.picIconPlus.TabStop = false;
            this.picIconPlus.Click += new System.EventHandler(this.picIconPlus_Click);
            // 
            // SceneList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.Controls.Add(this.picIconPlus);
            this.Controls.Add(this.lblAddScene);
            this.Controls.Add(this.picAddScene);
            this.Controls.Add(this.flySceneList);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "SceneList";
            this.Size = new System.Drawing.Size(834, 604);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SceneList_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.picAddScene)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIconPlus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flySceneList;
        private System.Windows.Forms.PictureBox picAddScene;
        private System.Windows.Forms.Label lblAddScene;
        private System.Windows.Forms.PictureBox picIconPlus;
    }
}
