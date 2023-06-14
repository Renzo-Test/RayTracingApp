namespace GUI
{
    partial class LogList
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
            this.picIconBack = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAvgRenderDate = new System.Windows.Forms.Label();
            this.lblRenderTime = new System.Windows.Forms.Label();
            this.lblTopRenderTime = new System.Windows.Forms.Label();
            this.lblRenderTimeRes = new System.Windows.Forms.Label();
            this.lblTotalRenderTimeRes = new System.Windows.Forms.Label();
            this.lblTopRenderTimeRes = new System.Windows.Forms.Label();
            this.flyLogList = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.picIconBack)).BeginInit();
            this.SuspendLayout();
            // 
            // picIconBack
            // 
            this.picIconBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picIconBack.Image = global::GUI.Properties.Resources.leftArrow;
            this.picIconBack.Location = new System.Drawing.Point(30, 27);
            this.picIconBack.Name = "picIconBack";
            this.picIconBack.Size = new System.Drawing.Size(32, 32);
            this.picIconBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picIconBack.TabIndex = 33;
            this.picIconBack.TabStop = false;
            this.picIconBack.Click += new System.EventHandler(this.picIconBack_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(400, 45);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(173, 32);
            this.lblTitle.TabIndex = 34;
            this.lblTitle.Text = "System Logs";
            // 
            // lblAvgRenderDate
            // 
            this.lblAvgRenderDate.AutoSize = true;
            this.lblAvgRenderDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.lblAvgRenderDate.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgRenderDate.ForeColor = System.Drawing.Color.White;
            this.lblAvgRenderDate.Location = new System.Drawing.Point(87, 149);
            this.lblAvgRenderDate.Name = "lblAvgRenderDate";
            this.lblAvgRenderDate.Size = new System.Drawing.Size(296, 32);
            this.lblAvgRenderDate.TabIndex = 35;
            this.lblAvgRenderDate.Text = "Average Render Time";
            // 
            // lblRenderTime
            // 
            this.lblRenderTime.AutoSize = true;
            this.lblRenderTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.lblRenderTime.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRenderTime.ForeColor = System.Drawing.Color.White;
            this.lblRenderTime.Location = new System.Drawing.Point(87, 269);
            this.lblRenderTime.Name = "lblRenderTime";
            this.lblRenderTime.Size = new System.Drawing.Size(242, 32);
            this.lblRenderTime.TabIndex = 36;
            this.lblRenderTime.Text = "Total Render Time";
            // 
            // lblTopRenderTime
            // 
            this.lblTopRenderTime.AutoSize = true;
            this.lblTopRenderTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.lblTopRenderTime.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopRenderTime.ForeColor = System.Drawing.Color.White;
            this.lblTopRenderTime.Location = new System.Drawing.Point(87, 398);
            this.lblTopRenderTime.Name = "lblTopRenderTime";
            this.lblTopRenderTime.Size = new System.Drawing.Size(228, 32);
            this.lblTopRenderTime.TabIndex = 37;
            this.lblTopRenderTime.Text = "Top Render Time";
            // 
            // lblRenderTimeRes
            // 
            this.lblRenderTimeRes.AutoSize = true;
            this.lblRenderTimeRes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.lblRenderTimeRes.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRenderTimeRes.ForeColor = System.Drawing.Color.White;
            this.lblRenderTimeRes.Location = new System.Drawing.Point(89, 190);
            this.lblRenderTimeRes.Name = "lblRenderTimeRes";
            this.lblRenderTimeRes.Size = new System.Drawing.Size(125, 24);
            this.lblRenderTimeRes.TabIndex = 38;
            this.lblRenderTimeRes.Text = "30 seconds";
            // 
            // lblTotalRenderTimeRes
            // 
            this.lblTotalRenderTimeRes.AutoSize = true;
            this.lblTotalRenderTimeRes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.lblTotalRenderTimeRes.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRenderTimeRes.ForeColor = System.Drawing.Color.White;
            this.lblTotalRenderTimeRes.Location = new System.Drawing.Point(89, 311);
            this.lblTotalRenderTimeRes.Name = "lblTotalRenderTimeRes";
            this.lblTotalRenderTimeRes.Size = new System.Drawing.Size(137, 24);
            this.lblTotalRenderTimeRes.TabIndex = 39;
            this.lblTotalRenderTimeRes.Text = "300 seconds";
            // 
            // lblTopRenderTimeRes
            // 
            this.lblTopRenderTimeRes.AutoSize = true;
            this.lblTopRenderTimeRes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.lblTopRenderTimeRes.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopRenderTimeRes.ForeColor = System.Drawing.Color.White;
            this.lblTopRenderTimeRes.Location = new System.Drawing.Point(89, 444);
            this.lblTopRenderTimeRes.Name = "lblTopRenderTimeRes";
            this.lblTopRenderTimeRes.Size = new System.Drawing.Size(235, 24);
            this.lblTopRenderTimeRes.TabIndex = 40;
            this.lblTopRenderTimeRes.Text = "250 seconds - mategz";
            // 
            // flyLogList
            // 
            this.flyLogList.AutoScroll = true;
            this.flyLogList.Location = new System.Drawing.Point(439, 149);
            this.flyLogList.Name = "flyLogList";
            this.flyLogList.Size = new System.Drawing.Size(500, 402);
            this.flyLogList.TabIndex = 41;
            // 
            // LogList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.Controls.Add(this.flyLogList);
            this.Controls.Add(this.lblTopRenderTimeRes);
            this.Controls.Add(this.lblTotalRenderTimeRes);
            this.Controls.Add(this.lblRenderTimeRes);
            this.Controls.Add(this.lblTopRenderTime);
            this.Controls.Add(this.lblRenderTime);
            this.Controls.Add(this.lblAvgRenderDate);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.picIconBack);
            this.MaximumSize = new System.Drawing.Size(1009, 604);
            this.MinimumSize = new System.Drawing.Size(1009, 604);
            this.Name = "LogList";
            this.Size = new System.Drawing.Size(1009, 604);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.LogList_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.picIconBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picIconBack;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAvgRenderDate;
        private System.Windows.Forms.Label lblRenderTime;
        private System.Windows.Forms.Label lblTopRenderTime;
        private System.Windows.Forms.Label lblRenderTimeRes;
        private System.Windows.Forms.Label lblTotalRenderTimeRes;
        private System.Windows.Forms.Label lblTopRenderTimeRes;
        private System.Windows.Forms.FlowLayoutPanel flyLogList;
    }
}
