namespace GUI
{
    partial class ModelListItem
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
            this.lblModelName = new System.Windows.Forms.Label();
            this.lblFigureName = new System.Windows.Forms.Label();
            this.lblMaterialName = new System.Windows.Forms.Label();
            this.picIconSphere = new System.Windows.Forms.PictureBox();
            this.picMaterialColor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picIconX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIconSphere)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaterialColor)).BeginInit();
            this.SuspendLayout();
            // 
            // picIconX
            // 
            this.picIconX.Image = global::GUI.Properties.Resources.mX;
            this.picIconX.Location = new System.Drawing.Point(414, 43);
            this.picIconX.Name = "picIconX";
            this.picIconX.Size = new System.Drawing.Size(32, 32);
            this.picIconX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picIconX.TabIndex = 0;
            this.picIconX.TabStop = false;
            this.picIconX.Click += new System.EventHandler(this.picIconX_Click);
            // 
            // lblModelName
            // 
            this.lblModelName.AutoSize = true;
            this.lblModelName.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelName.ForeColor = System.Drawing.Color.White;
            this.lblModelName.Location = new System.Drawing.Point(116, 19);
            this.lblModelName.Name = "lblModelName";
            this.lblModelName.Size = new System.Drawing.Size(99, 28);
            this.lblModelName.TabIndex = 1;
            this.lblModelName.Text = "Model1";
            // 
            // lblFigureName
            // 
            this.lblFigureName.AutoSize = true;
            this.lblFigureName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFigureName.ForeColor = System.Drawing.Color.White;
            this.lblFigureName.Location = new System.Drawing.Point(117, 54);
            this.lblFigureName.Name = "lblFigureName";
            this.lblFigureName.Size = new System.Drawing.Size(121, 21);
            this.lblFigureName.TabIndex = 2;
            this.lblFigureName.Text = "Figure: Figure1";
            // 
            // lblMaterialName
            // 
            this.lblMaterialName.AutoSize = true;
            this.lblMaterialName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterialName.ForeColor = System.Drawing.Color.White;
            this.lblMaterialName.Location = new System.Drawing.Point(117, 75);
            this.lblMaterialName.Name = "lblMaterialName";
            this.lblMaterialName.Size = new System.Drawing.Size(157, 21);
            this.lblMaterialName.TabIndex = 3;
            this.lblMaterialName.Text = "Material: Material1";
            // 
            // picIconSphere
            // 
            this.picIconSphere.Image = global::GUI.Properties.Resources.lSphereIcon;
            this.picIconSphere.Location = new System.Drawing.Point(22, 23);
            this.picIconSphere.Name = "picIconSphere";
            this.picIconSphere.Size = new System.Drawing.Size(65, 65);
            this.picIconSphere.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIconSphere.TabIndex = 4;
            this.picIconSphere.TabStop = false;
            // 
            // picMaterialColor
            // 
            this.picMaterialColor.BackColor = System.Drawing.Color.White;
            this.picMaterialColor.Location = new System.Drawing.Point(68, 17);
            this.picMaterialColor.Name = "picMaterialColor";
            this.picMaterialColor.Size = new System.Drawing.Size(30, 30);
            this.picMaterialColor.TabIndex = 5;
            this.picMaterialColor.TabStop = false;
            // 
            // ModelListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.Controls.Add(this.picMaterialColor);
            this.Controls.Add(this.picIconSphere);
            this.Controls.Add(this.lblMaterialName);
            this.Controls.Add(this.lblFigureName);
            this.Controls.Add(this.lblModelName);
            this.Controls.Add(this.picIconX);
            this.Name = "ModelListItem";
            this.Size = new System.Drawing.Size(470, 110);
            ((System.ComponentModel.ISupportInitialize)(this.picIconX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIconSphere)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaterialColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picIconX;
        private System.Windows.Forms.Label lblModelName;
        private System.Windows.Forms.Label lblFigureName;
        private System.Windows.Forms.Label lblMaterialName;
        private System.Windows.Forms.PictureBox picIconSphere;
        private System.Windows.Forms.PictureBox picMaterialColor;
    }
}
