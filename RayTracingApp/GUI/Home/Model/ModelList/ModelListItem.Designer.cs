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
            this.lblFigureName = new System.Windows.Forms.Label();
            this.lblMaterialName = new System.Windows.Forms.Label();
            this.picMaterialColor = new System.Windows.Forms.PictureBox();
            this.picIconSphere = new System.Windows.Forms.PictureBox();
            this.picIconX = new System.Windows.Forms.PictureBox();
            this.picIconPencilTick = new System.Windows.Forms.PictureBox();
            this.picXIcon = new System.Windows.Forms.PictureBox();
            this.txtModelName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMaterialColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIconSphere)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIconX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIconPencilTick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picXIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFigureName
            // 
            this.lblFigureName.AutoSize = true;
            this.lblFigureName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFigureName.ForeColor = System.Drawing.Color.White;
            this.lblFigureName.Location = new System.Drawing.Point(147, 54);
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
            this.lblMaterialName.Location = new System.Drawing.Point(147, 75);
            this.lblMaterialName.Name = "lblMaterialName";
            this.lblMaterialName.Size = new System.Drawing.Size(157, 21);
            this.lblMaterialName.TabIndex = 3;
            this.lblMaterialName.Text = "Material: Material1";
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
            // picIconPencilTick
            // 
            this.picIconPencilTick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picIconPencilTick.Image = global::GUI.Properties.Resources.pencil;
            this.picIconPencilTick.Location = new System.Drawing.Point(110, 25);
            this.picIconPencilTick.Name = "picIconPencilTick";
            this.picIconPencilTick.Size = new System.Drawing.Size(22, 22);
            this.picIconPencilTick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIconPencilTick.TabIndex = 6;
            this.picIconPencilTick.TabStop = false;
            this.picIconPencilTick.Click += new System.EventHandler(this.picIconPencilTick_Click);
            // 
            // picXIcon
            // 
            this.picXIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picXIcon.Image = global::GUI.Properties.Resources.whiteX;
            this.picXIcon.Location = new System.Drawing.Point(110, 67);
            this.picXIcon.Name = "picXIcon";
            this.picXIcon.Size = new System.Drawing.Size(21, 21);
            this.picXIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picXIcon.TabIndex = 7;
            this.picXIcon.TabStop = false;
            this.picXIcon.Visible = false;
            this.picXIcon.Click += new System.EventHandler(this.picXIcon_Click);
            // 
            // txtModelName
            // 
            this.txtModelName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.txtModelName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtModelName.Enabled = false;
            this.txtModelName.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelName.ForeColor = System.Drawing.Color.White;
            this.txtModelName.Location = new System.Drawing.Point(151, 21);
            this.txtModelName.Name = "txtModelName";
            this.txtModelName.Size = new System.Drawing.Size(234, 30);
            this.txtModelName.TabIndex = 8;
            this.txtModelName.Text = "Model";
            // 
            // ModelListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.Controls.Add(this.txtModelName);
            this.Controls.Add(this.picXIcon);
            this.Controls.Add(this.picIconPencilTick);
            this.Controls.Add(this.picMaterialColor);
            this.Controls.Add(this.picIconSphere);
            this.Controls.Add(this.lblMaterialName);
            this.Controls.Add(this.lblFigureName);
            this.Controls.Add(this.picIconX);
            this.Name = "ModelListItem";
            this.Size = new System.Drawing.Size(470, 110);
            ((System.ComponentModel.ISupportInitialize)(this.picMaterialColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIconSphere)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIconX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIconPencilTick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picXIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picIconX;
        private System.Windows.Forms.Label lblFigureName;
        private System.Windows.Forms.Label lblMaterialName;
        private System.Windows.Forms.PictureBox picIconSphere;
        private System.Windows.Forms.PictureBox picMaterialColor;
        private System.Windows.Forms.PictureBox picIconPencilTick;
        private System.Windows.Forms.PictureBox picXIcon;
        private System.Windows.Forms.TextBox txtModelName;
    }
}
