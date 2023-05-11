namespace GUI
{
    partial class Home
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
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.flyHome = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCurrentClient = new System.Windows.Forms.Label();
            this.picIconUser = new System.Windows.Forms.PictureBox();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.btnScenes = new System.Windows.Forms.Button();
            this.btnModel = new System.Windows.Forms.Button();
            this.btnMaterial = new System.Windows.Forms.Button();
            this.btnFigure = new System.Windows.Forms.Button();
            this.pnlUser = new System.Windows.Forms.PictureBox();
            this.pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIconUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlUser)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.pnlSidebar.Controls.Add(this.picIconUser);
            this.pnlSidebar.Controls.Add(this.lblCurrentClient);
            this.pnlSidebar.Controls.Add(this.btnSignOut);
            this.pnlSidebar.Controls.Add(this.btnScenes);
            this.pnlSidebar.Controls.Add(this.btnModel);
            this.pnlSidebar.Controls.Add(this.btnMaterial);
            this.pnlSidebar.Controls.Add(this.btnFigure);
            this.pnlSidebar.Controls.Add(this.pnlUser);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(176, 604);
            this.pnlSidebar.TabIndex = 0;
            // 
            // flyHome
            // 
            this.flyHome.Location = new System.Drawing.Point(175, 0);
            this.flyHome.Margin = new System.Windows.Forms.Padding(0);
            this.flyHome.Name = "flyHome";
            this.flyHome.Size = new System.Drawing.Size(834, 604);
            this.flyHome.TabIndex = 1;
            // 
            // lblCurrentClient
            // 
            this.lblCurrentClient.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentClient.ForeColor = System.Drawing.Color.White;
            this.lblCurrentClient.Location = new System.Drawing.Point(3, 55);
            this.lblCurrentClient.Name = "lblCurrentClient";
            this.lblCurrentClient.Size = new System.Drawing.Size(170, 42);
            this.lblCurrentClient.TabIndex = 6;
            this.lblCurrentClient.Text = "Username";
            this.lblCurrentClient.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picIconUser
            // 
            this.picIconUser.Image = global::GUI.Properties.Resources.userIcon1;
            this.picIconUser.Location = new System.Drawing.Point(76, 16);
            this.picIconUser.Name = "picIconUser";
            this.picIconUser.Size = new System.Drawing.Size(24, 24);
            this.picIconUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picIconUser.TabIndex = 7;
            this.picIconUser.TabStop = false;
            // 
            // btnSignOut
            // 
            this.btnSignOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSignOut.FlatAppearance.BorderSize = 0;
            this.btnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignOut.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOut.ForeColor = System.Drawing.Color.White;
            this.btnSignOut.Image = global::GUI.Properties.Resources.signoutIcon;
            this.btnSignOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSignOut.Location = new System.Drawing.Point(0, 539);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Padding = new System.Windows.Forms.Padding(15, 0, 0, 10);
            this.btnSignOut.Size = new System.Drawing.Size(176, 65);
            this.btnSignOut.TabIndex = 5;
            this.btnSignOut.Text = "   Sign out";
            this.btnSignOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSignOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSignOut.UseMnemonic = false;
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // btnScenes
            // 
            this.btnScenes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScenes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnScenes.FlatAppearance.BorderSize = 0;
            this.btnScenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScenes.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScenes.ForeColor = System.Drawing.Color.White;
            this.btnScenes.Image = global::GUI.Properties.Resources.sceneIcon;
            this.btnScenes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScenes.Location = new System.Drawing.Point(0, 295);
            this.btnScenes.Name = "btnScenes";
            this.btnScenes.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnScenes.Size = new System.Drawing.Size(176, 65);
            this.btnScenes.TabIndex = 4;
            this.btnScenes.Text = "   Scene";
            this.btnScenes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScenes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnScenes.UseMnemonic = false;
            this.btnScenes.UseVisualStyleBackColor = true;
            this.btnScenes.Click += new System.EventHandler(this.btnScenes_Click);
            // 
            // btnModel
            // 
            this.btnModel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModel.FlatAppearance.BorderSize = 0;
            this.btnModel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModel.ForeColor = System.Drawing.Color.White;
            this.btnModel.Image = global::GUI.Properties.Resources.modelIcon;
            this.btnModel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModel.Location = new System.Drawing.Point(0, 230);
            this.btnModel.Name = "btnModel";
            this.btnModel.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnModel.Size = new System.Drawing.Size(176, 65);
            this.btnModel.TabIndex = 3;
            this.btnModel.Text = "  Model";
            this.btnModel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModel.UseMnemonic = false;
            this.btnModel.UseVisualStyleBackColor = true;
            this.btnModel.Click += new System.EventHandler(this.btnModel_Click);
            // 
            // btnMaterial
            // 
            this.btnMaterial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaterial.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMaterial.FlatAppearance.BorderSize = 0;
            this.btnMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaterial.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaterial.ForeColor = System.Drawing.Color.White;
            this.btnMaterial.Image = global::GUI.Properties.Resources.materialIcon;
            this.btnMaterial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaterial.Location = new System.Drawing.Point(0, 165);
            this.btnMaterial.Name = "btnMaterial";
            this.btnMaterial.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnMaterial.Size = new System.Drawing.Size(176, 65);
            this.btnMaterial.TabIndex = 2;
            this.btnMaterial.Text = "  Material";
            this.btnMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaterial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMaterial.UseMnemonic = false;
            this.btnMaterial.UseVisualStyleBackColor = true;
            this.btnMaterial.Click += new System.EventHandler(this.btnMaterial_Click);
            // 
            // btnFigure
            // 
            this.btnFigure.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFigure.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFigure.FlatAppearance.BorderSize = 0;
            this.btnFigure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFigure.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFigure.ForeColor = System.Drawing.Color.White;
            this.btnFigure.Image = global::GUI.Properties.Resources.sphereIcon;
            this.btnFigure.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFigure.Location = new System.Drawing.Point(0, 100);
            this.btnFigure.Name = "btnFigure";
            this.btnFigure.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnFigure.Size = new System.Drawing.Size(176, 65);
            this.btnFigure.TabIndex = 1;
            this.btnFigure.Text = "   Figure";
            this.btnFigure.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFigure.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFigure.UseMnemonic = false;
            this.btnFigure.UseVisualStyleBackColor = true;
            this.btnFigure.Click += new System.EventHandler(this.btnFigure_Click);
            // 
            // pnlUser
            // 
            this.pnlUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUser.Location = new System.Drawing.Point(0, 0);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(176, 100);
            this.pnlUser.TabIndex = 0;
            this.pnlUser.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flyHome);
            this.Controls.Add(this.pnlSidebar);
            this.MaximumSize = new System.Drawing.Size(1009, 604);
            this.MinimumSize = new System.Drawing.Size(1009, 604);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(1009, 604);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIconUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Button btnFigure;
        private System.Windows.Forms.PictureBox pnlUser;
        private System.Windows.Forms.Button btnScenes;
        private System.Windows.Forms.Button btnModel;
        private System.Windows.Forms.Button btnMaterial;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.FlowLayoutPanel flyHome;
        private System.Windows.Forms.Label lblCurrentClient;
        private System.Windows.Forms.PictureBox picIconUser;
    }
}
