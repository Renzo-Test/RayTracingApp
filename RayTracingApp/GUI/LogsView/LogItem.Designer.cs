namespace GUI.LogsView
{
    partial class LogItem
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
            this.lblLogName = new System.Windows.Forms.Label();
            this.lblRenderTime = new System.Windows.Forms.Label();
            this.lblRenderDate = new System.Windows.Forms.Label();
            this.lblRenderedObjects = new System.Windows.Forms.Label();
            this.lblRenderWindow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLogName
            // 
            this.lblLogName.AutoSize = true;
            this.lblLogName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.lblLogName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogName.ForeColor = System.Drawing.Color.White;
            this.lblLogName.Location = new System.Drawing.Point(16, 13);
            this.lblLogName.Name = "lblLogName";
            this.lblLogName.Size = new System.Drawing.Size(317, 23);
            this.lblLogName.TabIndex = 36;
            this.lblLogName.Text = "mategz\'s Preview - Blank Scene 1";
            // 
            // lblRenderTime
            // 
            this.lblRenderTime.AutoSize = true;
            this.lblRenderTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.lblRenderTime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRenderTime.ForeColor = System.Drawing.Color.White;
            this.lblRenderTime.Location = new System.Drawing.Point(16, 52);
            this.lblRenderTime.Name = "lblRenderTime";
            this.lblRenderTime.Size = new System.Drawing.Size(195, 19);
            this.lblRenderTime.TabIndex = 37;
            this.lblRenderTime.Text = "Render time: 30 seconds";
            // 
            // lblRenderDate
            // 
            this.lblRenderDate.AutoSize = true;
            this.lblRenderDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.lblRenderDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRenderDate.ForeColor = System.Drawing.Color.White;
            this.lblRenderDate.Location = new System.Drawing.Point(16, 85);
            this.lblRenderDate.Name = "lblRenderDate";
            this.lblRenderDate.Size = new System.Drawing.Size(198, 19);
            this.lblRenderDate.TabIndex = 38;
            this.lblRenderDate.Text = "Render date: 30/05/2023";
            // 
            // lblRenderedObjects
            // 
            this.lblRenderedObjects.AutoSize = true;
            this.lblRenderedObjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.lblRenderedObjects.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRenderedObjects.ForeColor = System.Drawing.Color.White;
            this.lblRenderedObjects.Location = new System.Drawing.Point(229, 85);
            this.lblRenderedObjects.Name = "lblRenderedObjects";
            this.lblRenderedObjects.Size = new System.Drawing.Size(161, 19);
            this.lblRenderedObjects.TabIndex = 40;
            this.lblRenderedObjects.Text = "Rendered objects: 4";
            // 
            // lblRenderWindow
            // 
            this.lblRenderWindow.AutoSize = true;
            this.lblRenderWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.lblRenderWindow.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRenderWindow.ForeColor = System.Drawing.Color.White;
            this.lblRenderWindow.Location = new System.Drawing.Point(229, 52);
            this.lblRenderWindow.Name = "lblRenderWindow";
            this.lblRenderWindow.Size = new System.Drawing.Size(222, 19);
            this.lblRenderWindow.TabIndex = 39;
            this.lblRenderWindow.Text = "Render window: 30 seconds";
            // 
            // LogItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.Controls.Add(this.lblRenderedObjects);
            this.Controls.Add(this.lblRenderWindow);
            this.Controls.Add(this.lblRenderDate);
            this.Controls.Add(this.lblRenderTime);
            this.Controls.Add(this.lblLogName);
            this.Name = "LogItem";
            this.Size = new System.Drawing.Size(470, 124);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogName;
        private System.Windows.Forms.Label lblRenderTime;
        private System.Windows.Forms.Label lblRenderDate;
        private System.Windows.Forms.Label lblRenderedObjects;
        private System.Windows.Forms.Label lblRenderWindow;
    }
}
