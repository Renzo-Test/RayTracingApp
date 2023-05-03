namespace GUI
{
    partial class ScenePage
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
            this.lblSceneName = new System.Windows.Forms.Label();
            this.lblLastModified = new System.Windows.Forms.Label();
            this.lblAvailableModels = new System.Windows.Forms.Label();
            this.lblScene = new System.Windows.Forms.Label();
            this.lblPosisionatedModels = new System.Windows.Forms.Label();
            this.flyModels = new System.Windows.Forms.FlowLayoutPanel();
            this.flyUsedModels = new System.Windows.Forms.FlowLayoutPanel();
            this.txtFov = new System.Windows.Forms.TextBox();
            this.txtLookAt = new System.Windows.Forms.TextBox();
            this.txtLookFrom = new System.Windows.Forms.TextBox();
            this.picFieldLookFrom = new System.Windows.Forms.PictureBox();
            this.picFieldLookAt = new System.Windows.Forms.PictureBox();
            this.picFieldFov = new System.Windows.Forms.PictureBox();
            this.picScene = new System.Windows.Forms.PictureBox();
            this.picIconBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picFieldLookFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFieldLookAt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFieldFov)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScene)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIconBack)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSceneName
            // 
            this.lblSceneName.AutoSize = true;
            this.lblSceneName.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSceneName.ForeColor = System.Drawing.Color.White;
            this.lblSceneName.Location = new System.Drawing.Point(73, 24);
            this.lblSceneName.Name = "lblSceneName";
            this.lblSceneName.Size = new System.Drawing.Size(118, 32);
            this.lblSceneName.TabIndex = 0;
            this.lblSceneName.Text = "Scene 1";
            // 
            // lblLastModified
            // 
            this.lblLastModified.AutoSize = true;
            this.lblLastModified.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastModified.ForeColor = System.Drawing.Color.White;
            this.lblLastModified.Location = new System.Drawing.Point(506, 32);
            this.lblLastModified.Name = "lblLastModified";
            this.lblLastModified.Size = new System.Drawing.Size(309, 22);
            this.lblLastModified.TabIndex = 2;
            this.lblLastModified.Text = "Last Modified: 15:32 - 01/01/2023";
            // 
            // lblAvailableModels
            // 
            this.lblAvailableModels.AutoSize = true;
            this.lblAvailableModels.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableModels.ForeColor = System.Drawing.Color.White;
            this.lblAvailableModels.Location = new System.Drawing.Point(11, 199);
            this.lblAvailableModels.Name = "lblAvailableModels";
            this.lblAvailableModels.Size = new System.Drawing.Size(100, 30);
            this.lblAvailableModels.TabIndex = 3;
            this.lblAvailableModels.Text = "Models";
            // 
            // lblScene
            // 
            this.lblScene.AutoSize = true;
            this.lblScene.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScene.ForeColor = System.Drawing.Color.White;
            this.lblScene.Location = new System.Drawing.Point(272, 199);
            this.lblScene.Name = "lblScene";
            this.lblScene.Size = new System.Drawing.Size(88, 30);
            this.lblScene.TabIndex = 4;
            this.lblScene.Text = "Scene";
            // 
            // lblPosisionatedModels
            // 
            this.lblPosisionatedModels.AutoSize = true;
            this.lblPosisionatedModels.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosisionatedModels.ForeColor = System.Drawing.Color.White;
            this.lblPosisionatedModels.Location = new System.Drawing.Point(674, 199);
            this.lblPosisionatedModels.Name = "lblPosisionatedModels";
            this.lblPosisionatedModels.Size = new System.Drawing.Size(76, 30);
            this.lblPosisionatedModels.TabIndex = 5;
            this.lblPosisionatedModels.Text = "Using";
            // 
            // flyModels
            // 
            this.flyModels.AutoScroll = true;
            this.flyModels.Location = new System.Drawing.Point(10, 250);
            this.flyModels.Margin = new System.Windows.Forms.Padding(0);
            this.flyModels.Name = "flyModels";
            this.flyModels.Size = new System.Drawing.Size(256, 270);
            this.flyModels.TabIndex = 18;
            // 
            // flyUsedModels
            // 
            this.flyUsedModels.AutoScroll = true;
            this.flyUsedModels.Location = new System.Drawing.Point(679, 250);
            this.flyUsedModels.Margin = new System.Windows.Forms.Padding(0);
            this.flyUsedModels.Name = "flyUsedModels";
            this.flyUsedModels.Size = new System.Drawing.Size(145, 270);
            this.flyUsedModels.TabIndex = 19;
            // 
            // txtFov
            // 
            this.txtFov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtFov.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFov.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFov.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtFov.Location = new System.Drawing.Point(561, 110);
            this.txtFov.Name = "txtFov";
            this.txtFov.Size = new System.Drawing.Size(158, 24);
            this.txtFov.TabIndex = 27;
            this.txtFov.Text = "Fov";
            this.txtFov.Enter += new System.EventHandler(this.txtFov_Enter);
            this.txtFov.Leave += new System.EventHandler(this.txtFov_Leave);
            // 
            // txtLookAt
            // 
            this.txtLookAt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtLookAt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLookAt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLookAt.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtLookAt.Location = new System.Drawing.Point(334, 110);
            this.txtLookAt.Name = "txtLookAt";
            this.txtLookAt.Size = new System.Drawing.Size(158, 24);
            this.txtLookAt.TabIndex = 29;
            this.txtLookAt.Text = "Look At";
            this.txtLookAt.Enter += new System.EventHandler(this.txtLookAt_Enter);
            this.txtLookAt.Leave += new System.EventHandler(this.txtLookAt_Leave);
            // 
            // txtLookFrom
            // 
            this.txtLookFrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtLookFrom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLookFrom.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLookFrom.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtLookFrom.Location = new System.Drawing.Point(108, 110);
            this.txtLookFrom.Name = "txtLookFrom";
            this.txtLookFrom.Size = new System.Drawing.Size(158, 24);
            this.txtLookFrom.TabIndex = 31;
            this.txtLookFrom.Text = "Look From";
            this.txtLookFrom.Enter += new System.EventHandler(this.txtLookFrom_Enter);
            this.txtLookFrom.Leave += new System.EventHandler(this.txtLookFrom_Leave);
            // 
            // picFieldLookFrom
            // 
            this.picFieldLookFrom.Image = global::GUI.Properties.Resources.fieldRectangle;
            this.picFieldLookFrom.Location = new System.Drawing.Point(91, 102);
            this.picFieldLookFrom.Name = "picFieldLookFrom";
            this.picFieldLookFrom.Size = new System.Drawing.Size(200, 39);
            this.picFieldLookFrom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picFieldLookFrom.TabIndex = 30;
            this.picFieldLookFrom.TabStop = false;
            // 
            // picFieldLookAt
            // 
            this.picFieldLookAt.Image = global::GUI.Properties.Resources.fieldRectangle;
            this.picFieldLookAt.Location = new System.Drawing.Point(317, 102);
            this.picFieldLookAt.Name = "picFieldLookAt";
            this.picFieldLookAt.Size = new System.Drawing.Size(200, 39);
            this.picFieldLookAt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picFieldLookAt.TabIndex = 28;
            this.picFieldLookAt.TabStop = false;
            // 
            // picFieldFov
            // 
            this.picFieldFov.Image = global::GUI.Properties.Resources.fieldRectangle;
            this.picFieldFov.Location = new System.Drawing.Point(543, 102);
            this.picFieldFov.Name = "picFieldFov";
            this.picFieldFov.Size = new System.Drawing.Size(200, 39);
            this.picFieldFov.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picFieldFov.TabIndex = 26;
            this.picFieldFov.TabStop = false;
            // 
            // picScene
            // 
            this.picScene.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.picScene.Image = global::GUI.Properties.Resources.darkBgScene;
            this.picScene.Location = new System.Drawing.Point(277, 250);
            this.picScene.Margin = new System.Windows.Forms.Padding(0);
            this.picScene.Name = "picScene";
            this.picScene.Size = new System.Drawing.Size(388, 270);
            this.picScene.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picScene.TabIndex = 6;
            this.picScene.TabStop = false;
            // 
            // picIconBack
            // 
            this.picIconBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picIconBack.Image = global::GUI.Properties.Resources.leftArrow;
            this.picIconBack.Location = new System.Drawing.Point(25, 25);
            this.picIconBack.Name = "picIconBack";
            this.picIconBack.Size = new System.Drawing.Size(32, 32);
            this.picIconBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picIconBack.TabIndex = 1;
            this.picIconBack.TabStop = false;
            this.picIconBack.Click += new System.EventHandler(this.picIconBack_Click);
            // 
            // ScenePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.Controls.Add(this.txtLookFrom);
            this.Controls.Add(this.picFieldLookFrom);
            this.Controls.Add(this.txtLookAt);
            this.Controls.Add(this.picFieldLookAt);
            this.Controls.Add(this.txtFov);
            this.Controls.Add(this.picFieldFov);
            this.Controls.Add(this.flyUsedModels);
            this.Controls.Add(this.flyModels);
            this.Controls.Add(this.picScene);
            this.Controls.Add(this.lblPosisionatedModels);
            this.Controls.Add(this.lblScene);
            this.Controls.Add(this.lblAvailableModels);
            this.Controls.Add(this.lblLastModified);
            this.Controls.Add(this.picIconBack);
            this.Controls.Add(this.lblSceneName);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ScenePage";
            this.Size = new System.Drawing.Size(834, 604);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ScenePage_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.picFieldLookFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFieldLookAt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFieldFov)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScene)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIconBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSceneName;
        private System.Windows.Forms.PictureBox picIconBack;
        private System.Windows.Forms.Label lblLastModified;
        private System.Windows.Forms.Label lblAvailableModels;
        private System.Windows.Forms.Label lblScene;
        private System.Windows.Forms.Label lblPosisionatedModels;
        private System.Windows.Forms.PictureBox picScene;
        private System.Windows.Forms.FlowLayoutPanel flyModels;
        private System.Windows.Forms.FlowLayoutPanel flyUsedModels;
        private System.Windows.Forms.TextBox txtFov;
        private System.Windows.Forms.PictureBox picFieldFov;
        private System.Windows.Forms.TextBox txtLookAt;
        private System.Windows.Forms.PictureBox picFieldLookAt;
        private System.Windows.Forms.TextBox txtLookFrom;
        private System.Windows.Forms.PictureBox picFieldLookFrom;
    }
}
