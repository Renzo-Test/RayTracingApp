namespace GUI
{
    partial class ExportPage
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
            this.lblSelectPath = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnChoosePath = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.lblJPG = new System.Windows.Forms.Label();
            this.picBGJPG = new System.Windows.Forms.PictureBox();
            this.lblPNG = new System.Windows.Forms.Label();
            this.picBGPNG = new System.Windows.Forms.PictureBox();
            this.lblPPM = new System.Windows.Forms.Label();
            this.picBGPPM = new System.Windows.Forms.PictureBox();
            this.lblExportTitle = new System.Windows.Forms.Label();
            this.picIconBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBGJPG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBGPNG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBGPPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIconBack)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSelectPath
            // 
            this.lblSelectPath.AutoSize = true;
            this.lblSelectPath.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectPath.ForeColor = System.Drawing.Color.White;
            this.lblSelectPath.Location = new System.Drawing.Point(107, 188);
            this.lblSelectPath.Name = "lblSelectPath";
            this.lblSelectPath.Size = new System.Drawing.Size(126, 24);
            this.lblSelectPath.TabIndex = 34;
            this.lblSelectPath.Text = "Select Path";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(325, 66);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(189, 32);
            this.lblTitle.TabIndex = 35;
            this.lblTitle.Text = "Export Image";
            // 
            // btnChoosePath
            // 
            this.btnChoosePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoosePath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnChoosePath.Location = new System.Drawing.Point(702, 247);
            this.btnChoosePath.Name = "btnChoosePath";
            this.btnChoosePath.Size = new System.Drawing.Size(38, 20);
            this.btnChoosePath.TabIndex = 36;
            this.btnChoosePath.Text = "●●●";
            this.btnChoosePath.UseVisualStyleBackColor = true;
            this.btnChoosePath.Click += new System.EventHandler(this.btnChoosePath_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(111, 247);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(585, 20);
            this.txtPath.TabIndex = 37;
            // 
            // lblJPG
            // 
            this.lblJPG.AutoSize = true;
            this.lblJPG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(158)))), ((int)(((byte)(140)))));
            this.lblJPG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblJPG.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJPG.ForeColor = System.Drawing.Color.White;
            this.lblJPG.Location = new System.Drawing.Point(167, 440);
            this.lblJPG.Name = "lblJPG";
            this.lblJPG.Size = new System.Drawing.Size(46, 23);
            this.lblJPG.TabIndex = 40;
            this.lblJPG.Text = "JPG";
            this.lblJPG.Click += new System.EventHandler(this.lblJPG_Click);
            // 
            // picBGJPG
            // 
            this.picBGJPG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBGJPG.Image = global::GUI.Properties.Resources.homeButtonsBackground;
            this.picBGJPG.Location = new System.Drawing.Point(113, 432);
            this.picBGJPG.Name = "picBGJPG";
            this.picBGJPG.Size = new System.Drawing.Size(160, 41);
            this.picBGJPG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBGJPG.TabIndex = 39;
            this.picBGJPG.TabStop = false;
            this.picBGJPG.Click += new System.EventHandler(this.picBGJPG_Click);
            // 
            // lblPNG
            // 
            this.lblPNG.AutoSize = true;
            this.lblPNG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(158)))), ((int)(((byte)(140)))));
            this.lblPNG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPNG.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPNG.ForeColor = System.Drawing.Color.White;
            this.lblPNG.Location = new System.Drawing.Point(397, 440);
            this.lblPNG.Name = "lblPNG";
            this.lblPNG.Size = new System.Drawing.Size(51, 23);
            this.lblPNG.TabIndex = 43;
            this.lblPNG.Text = "PNG";
            this.lblPNG.Click += new System.EventHandler(this.lblPNG_Click);
            // 
            // picBGPNG
            // 
            this.picBGPNG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBGPNG.Image = global::GUI.Properties.Resources.homeButtonsBackground;
            this.picBGPNG.Location = new System.Drawing.Point(342, 432);
            this.picBGPNG.Name = "picBGPNG";
            this.picBGPNG.Size = new System.Drawing.Size(160, 41);
            this.picBGPNG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBGPNG.TabIndex = 42;
            this.picBGPNG.TabStop = false;
            this.picBGPNG.Click += new System.EventHandler(this.picBGPNG_Click);
            // 
            // lblPPM
            // 
            this.lblPPM.AutoSize = true;
            this.lblPPM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(158)))), ((int)(((byte)(140)))));
            this.lblPPM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPPM.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPPM.ForeColor = System.Drawing.Color.White;
            this.lblPPM.Location = new System.Drawing.Point(638, 440);
            this.lblPPM.Name = "lblPPM";
            this.lblPPM.Size = new System.Drawing.Size(49, 23);
            this.lblPPM.TabIndex = 46;
            this.lblPPM.Text = "PPM";
            this.lblPPM.Click += new System.EventHandler(this.lblPPM_Click);
            // 
            // picBGPPM
            // 
            this.picBGPPM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBGPPM.Image = global::GUI.Properties.Resources.homeButtonsBackground;
            this.picBGPPM.Location = new System.Drawing.Point(580, 432);
            this.picBGPPM.Name = "picBGPPM";
            this.picBGPPM.Size = new System.Drawing.Size(160, 41);
            this.picBGPPM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBGPPM.TabIndex = 45;
            this.picBGPPM.TabStop = false;
            this.picBGPPM.Click += new System.EventHandler(this.picBGPPM_Click);
            // 
            // lblExportTitle
            // 
            this.lblExportTitle.AutoSize = true;
            this.lblExportTitle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExportTitle.ForeColor = System.Drawing.Color.White;
            this.lblExportTitle.Location = new System.Drawing.Point(109, 368);
            this.lblExportTitle.Name = "lblExportTitle";
            this.lblExportTitle.Size = new System.Drawing.Size(173, 24);
            this.lblExportTitle.TabIndex = 48;
            this.lblExportTitle.Text = "Export image As";
            // 
            // picIconBack
            // 
            this.picIconBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picIconBack.Image = global::GUI.Properties.Resources.leftArrow;
            this.picIconBack.Location = new System.Drawing.Point(57, 34);
            this.picIconBack.Name = "picIconBack";
            this.picIconBack.Size = new System.Drawing.Size(32, 32);
            this.picIconBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picIconBack.TabIndex = 49;
            this.picIconBack.TabStop = false;
            this.picIconBack.Click += new System.EventHandler(this.picIconBack_Click);
            // 
            // ExportPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.Controls.Add(this.picIconBack);
            this.Controls.Add(this.lblExportTitle);
            this.Controls.Add(this.lblPPM);
            this.Controls.Add(this.picBGPPM);
            this.Controls.Add(this.lblPNG);
            this.Controls.Add(this.picBGPNG);
            this.Controls.Add(this.lblJPG);
            this.Controls.Add(this.picBGJPG);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnChoosePath);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSelectPath);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ExportPage";
            this.Size = new System.Drawing.Size(834, 604);
            ((System.ComponentModel.ISupportInitialize)(this.picBGJPG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBGPNG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBGPPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIconBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSelectPath;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnChoosePath;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label lblJPG;
        private System.Windows.Forms.PictureBox picBGJPG;
        private System.Windows.Forms.Label lblPNG;
        private System.Windows.Forms.PictureBox picBGPNG;
        private System.Windows.Forms.Label lblPPM;
        private System.Windows.Forms.PictureBox picBGPPM;
        private System.Windows.Forms.Label lblExportTitle;
        private System.Windows.Forms.PictureBox picIconBack;
    }
}
