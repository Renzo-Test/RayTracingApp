namespace GUI
{
    partial class SceneListItem
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
			this.picIconX = new System.Windows.Forms.PictureBox();
			this.lblSceneName = new System.Windows.Forms.Label();
			this.picIconScene = new System.Windows.Forms.PictureBox();
			this.lblLastModified = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.picIconX)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picIconScene)).BeginInit();
			this.SuspendLayout();
			// 
			// picIconX
			// 
			this.picIconX.Cursor = System.Windows.Forms.Cursors.Hand;
			this.picIconX.Image = global::GUI.Properties.Resources.mX;
			this.picIconX.Location = new System.Drawing.Point(414, 43);
			this.picIconX.Name = "picIconX";
			this.picIconX.Size = new System.Drawing.Size(32, 32);
			this.picIconX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picIconX.TabIndex = 0;
			this.picIconX.TabStop = false;
			this.picIconX.Click += new System.EventHandler(this.picIconX_Click);
			// 
			// lblSceneName
			// 
			this.lblSceneName.AutoSize = true;
			this.lblSceneName.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSceneName.ForeColor = System.Drawing.Color.White;
			this.lblSceneName.Location = new System.Drawing.Point(116, 19);
			this.lblSceneName.Name = "lblSceneName";
			this.lblSceneName.Size = new System.Drawing.Size(165, 28);
			this.lblSceneName.TabIndex = 1;
			this.lblSceneName.Text = "DefaultScene";
			this.lblSceneName.Click += new System.EventHandler(this.lblSceneName_Click);
			// 
			// picIconScene
			// 
			this.picIconScene.Image = global::GUI.Properties.Resources.lSphereIcon;
			this.picIconScene.Location = new System.Drawing.Point(22, 23);
			this.picIconScene.Name = "picIconScene";
			this.picIconScene.Size = new System.Drawing.Size(65, 65);
			this.picIconScene.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picIconScene.TabIndex = 2;
			this.picIconScene.TabStop = false;
			this.picIconScene.Click += new System.EventHandler(this.picIconScene_Click);
			// 
			// lblLastModified
			// 
			this.lblLastModified.AutoSize = true;
			this.lblLastModified.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLastModified.ForeColor = System.Drawing.Color.White;
			this.lblLastModified.Location = new System.Drawing.Point(117, 63);
			this.lblLastModified.Name = "lblLastModified";
			this.lblLastModified.Size = new System.Drawing.Size(264, 21);
			this.lblLastModified.TabIndex = 3;
			this.lblLastModified.Text = "Last Modified: 14:32 - 01/01/2023 ";
			this.lblLastModified.Click += new System.EventHandler(this.lblLastModified_Click);
			// 
			// SceneListItem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
			this.Controls.Add(this.lblLastModified);
			this.Controls.Add(this.picIconScene);
			this.Controls.Add(this.lblSceneName);
			this.Controls.Add(this.picIconX);
			this.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Name = "SceneListItem";
			this.Size = new System.Drawing.Size(470, 110);
			this.Click += new System.EventHandler(this.SceneListItem_Click);
			((System.ComponentModel.ISupportInitialize)(this.picIconX)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picIconScene)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picIconX;
        private System.Windows.Forms.Label lblSceneName;
        private System.Windows.Forms.PictureBox picIconScene;
        private System.Windows.Forms.Label lblLastModified;
    }
}
