namespace GUI
{
    partial class AddModel
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtInputName = new System.Windows.Forms.TextBox();
            this.lblSave = new System.Windows.Forms.Label();
            this.lblCancel = new System.Windows.Forms.Label();
            this.picRectangleFieldCancel = new System.Windows.Forms.PictureBox();
            this.picRectangleFieldSave = new System.Windows.Forms.PictureBox();
            this.picDarkRectangleFieldName = new System.Windows.Forms.PictureBox();
            this.picCard = new System.Windows.Forms.PictureBox();
            this.cmbFigures = new System.Windows.Forms.ComboBox();
            this.picDropDownFigures = new System.Windows.Forms.PictureBox();
            this.lblFiguresList = new System.Windows.Forms.Label();
            this.picDarkRectangleFigureList = new System.Windows.Forms.PictureBox();
            this.cmbMaterials = new System.Windows.Forms.ComboBox();
            this.picDropDownMaterial = new System.Windows.Forms.PictureBox();
            this.lblMaterialsList = new System.Windows.Forms.Label();
            this.picDarkRectangleMaterialList = new System.Windows.Forms.PictureBox();
            this.rbtnCreatePreview = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picRectangleFieldCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRectangleFieldSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDarkRectangleFieldName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDropDownFigures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDarkRectangleFigureList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDropDownMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDarkRectangleMaterialList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblTitle.Location = new System.Drawing.Point(337, 92);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(160, 32);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Add Model";
            // 
            // txtInputName
            // 
            this.txtInputName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.txtInputName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInputName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtInputName.Location = new System.Drawing.Point(274, 179);
            this.txtInputName.Name = "txtInputName";
            this.txtInputName.Size = new System.Drawing.Size(276, 24);
            this.txtInputName.TabIndex = 4;
            this.txtInputName.Text = "Name";
            this.txtInputName.Enter += new System.EventHandler(this.txtInputName_Enter);
            this.txtInputName.Leave += new System.EventHandler(this.txtInputName_Leave);
            // 
            // lblSave
            // 
            this.lblSave.AutoSize = true;
            this.lblSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(158)))), ((int)(((byte)(140)))));
            this.lblSave.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSave.ForeColor = System.Drawing.Color.White;
            this.lblSave.Location = new System.Drawing.Point(510, 442);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(56, 23);
            this.lblSave.TabIndex = 13;
            this.lblSave.Text = "Save";
            // 
            // lblCancel
            // 
            this.lblCancel.AutoSize = true;
            this.lblCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(158)))), ((int)(((byte)(140)))));
            this.lblCancel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancel.ForeColor = System.Drawing.Color.White;
            this.lblCancel.Location = new System.Drawing.Point(270, 442);
            this.lblCancel.Name = "lblCancel";
            this.lblCancel.Size = new System.Drawing.Size(78, 23);
            this.lblCancel.TabIndex = 15;
            this.lblCancel.Text = "Cancel";
            // 
            // picRectangleFieldCancel
            // 
            this.picRectangleFieldCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.picRectangleFieldCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRectangleFieldCancel.Image = global::GUI.Properties.Resources.homeButtonsBackground;
            this.picRectangleFieldCancel.Location = new System.Drawing.Point(225, 432);
            this.picRectangleFieldCancel.Name = "picRectangleFieldCancel";
            this.picRectangleFieldCancel.Size = new System.Drawing.Size(165, 45);
            this.picRectangleFieldCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRectangleFieldCancel.TabIndex = 14;
            this.picRectangleFieldCancel.TabStop = false;
            this.picRectangleFieldCancel.Click += new System.EventHandler(this.picRectangleFieldCancel_Click);
            // 
            // picRectangleFieldSave
            // 
            this.picRectangleFieldSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.picRectangleFieldSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRectangleFieldSave.Image = global::GUI.Properties.Resources.homeButtonsBackground;
            this.picRectangleFieldSave.Location = new System.Drawing.Point(454, 432);
            this.picRectangleFieldSave.Name = "picRectangleFieldSave";
            this.picRectangleFieldSave.Size = new System.Drawing.Size(165, 45);
            this.picRectangleFieldSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRectangleFieldSave.TabIndex = 12;
            this.picRectangleFieldSave.TabStop = false;
            this.picRectangleFieldSave.Click += new System.EventHandler(this.picRectangleFieldSave_Click);
            // 
            // picDarkRectangleFieldName
            // 
            this.picDarkRectangleFieldName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.picDarkRectangleFieldName.Image = global::GUI.Properties.Resources.darkFieldRectangle;
            this.picDarkRectangleFieldName.Location = new System.Drawing.Point(256, 167);
            this.picDarkRectangleFieldName.Name = "picDarkRectangleFieldName";
            this.picDarkRectangleFieldName.Size = new System.Drawing.Size(323, 45);
            this.picDarkRectangleFieldName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDarkRectangleFieldName.TabIndex = 2;
            this.picDarkRectangleFieldName.TabStop = false;
            // 
            // picCard
            // 
            this.picCard.Image = global::GUI.Properties.Resources.card;
            this.picCard.Location = new System.Drawing.Point(25, 24);
            this.picCard.Name = "picCard";
            this.picCard.Size = new System.Drawing.Size(790, 546);
            this.picCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCard.TabIndex = 0;
            this.picCard.TabStop = false;
            this.picCard.Paint += new System.Windows.Forms.PaintEventHandler(this.picCard_Paint);
            // 
            // cmbFigures
            // 
            this.cmbFigures.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFigures.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFigures.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFigures.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cmbFigures.FormattingEnabled = true;
            this.cmbFigures.Location = new System.Drawing.Point(274, 243);
            this.cmbFigures.Name = "cmbFigures";
            this.cmbFigures.Size = new System.Drawing.Size(289, 30);
            this.cmbFigures.TabIndex = 18;
            this.cmbFigures.SelectedIndexChanged += new System.EventHandler(this.cmbFigures_SelectedIndexChanged);
            // 
            // picDropDownFigures
            // 
            this.picDropDownFigures.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.picDropDownFigures.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picDropDownFigures.Image = global::GUI.Properties.Resources.caret_abajo;
            this.picDropDownFigures.Location = new System.Drawing.Point(545, 246);
            this.picDropDownFigures.Name = "picDropDownFigures";
            this.picDropDownFigures.Size = new System.Drawing.Size(18, 18);
            this.picDropDownFigures.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDropDownFigures.TabIndex = 21;
            this.picDropDownFigures.TabStop = false;
            this.picDropDownFigures.Click += new System.EventHandler(this.picDropDownFigures_Click);
            // 
            // lblFiguresList
            // 
            this.lblFiguresList.AutoSize = true;
            this.lblFiguresList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.lblFiguresList.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiguresList.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblFiguresList.Location = new System.Drawing.Point(270, 246);
            this.lblFiguresList.Name = "lblFiguresList";
            this.lblFiguresList.Size = new System.Drawing.Size(72, 22);
            this.lblFiguresList.TabIndex = 20;
            this.lblFiguresList.Text = "Figures";
            // 
            // picDarkRectangleFigureList
            // 
            this.picDarkRectangleFigureList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.picDarkRectangleFigureList.Image = global::GUI.Properties.Resources.darkFieldRectangle;
            this.picDarkRectangleFigureList.Location = new System.Drawing.Point(256, 235);
            this.picDarkRectangleFigureList.Name = "picDarkRectangleFigureList";
            this.picDarkRectangleFigureList.Size = new System.Drawing.Size(323, 45);
            this.picDarkRectangleFigureList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDarkRectangleFigureList.TabIndex = 19;
            this.picDarkRectangleFigureList.TabStop = false;
            // 
            // cmbMaterials
            // 
            this.cmbMaterials.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaterials.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMaterials.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaterials.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cmbMaterials.FormattingEnabled = true;
            this.cmbMaterials.Location = new System.Drawing.Point(274, 311);
            this.cmbMaterials.Name = "cmbMaterials";
            this.cmbMaterials.Size = new System.Drawing.Size(289, 30);
            this.cmbMaterials.TabIndex = 26;
            this.cmbMaterials.SelectedIndexChanged += new System.EventHandler(this.cmbMaterials_SelectedIndexChanged);
            // 
            // picDropDownMaterial
            // 
            this.picDropDownMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.picDropDownMaterial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picDropDownMaterial.Image = global::GUI.Properties.Resources.caret_abajo;
            this.picDropDownMaterial.Location = new System.Drawing.Point(545, 315);
            this.picDropDownMaterial.Name = "picDropDownMaterial";
            this.picDropDownMaterial.Size = new System.Drawing.Size(18, 18);
            this.picDropDownMaterial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDropDownMaterial.TabIndex = 29;
            this.picDropDownMaterial.TabStop = false;
            this.picDropDownMaterial.Click += new System.EventHandler(this.picDropDownMaterial_Click);
            // 
            // lblMaterialsList
            // 
            this.lblMaterialsList.AutoSize = true;
            this.lblMaterialsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.lblMaterialsList.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterialsList.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblMaterialsList.Location = new System.Drawing.Point(270, 315);
            this.lblMaterialsList.Name = "lblMaterialsList";
            this.lblMaterialsList.Size = new System.Drawing.Size(91, 22);
            this.lblMaterialsList.TabIndex = 28;
            this.lblMaterialsList.Text = "Materials";
            // 
            // picDarkRectangleMaterialList
            // 
            this.picDarkRectangleMaterialList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.picDarkRectangleMaterialList.Image = global::GUI.Properties.Resources.darkFieldRectangle;
            this.picDarkRectangleMaterialList.Location = new System.Drawing.Point(256, 303);
            this.picDarkRectangleMaterialList.Name = "picDarkRectangleMaterialList";
            this.picDarkRectangleMaterialList.Size = new System.Drawing.Size(323, 45);
            this.picDarkRectangleMaterialList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDarkRectangleMaterialList.TabIndex = 27;
            this.picDarkRectangleMaterialList.TabStop = false;
            // 
            // rbtnCreatePreview
            // 
            this.rbtnCreatePreview.AutoSize = true;
            this.rbtnCreatePreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.rbtnCreatePreview.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCreatePreview.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.rbtnCreatePreview.Location = new System.Drawing.Point(297, 373);
            this.rbtnCreatePreview.Name = "rbtnCreatePreview";
            this.rbtnCreatePreview.Size = new System.Drawing.Size(253, 26);
            this.rbtnCreatePreview.TabIndex = 30;
            this.rbtnCreatePreview.Text = "Create Preview on Save";
            this.rbtnCreatePreview.UseVisualStyleBackColor = false;
            // 
            // AddModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.Controls.Add(this.rbtnCreatePreview);
            this.Controls.Add(this.picDropDownMaterial);
            this.Controls.Add(this.lblMaterialsList);
            this.Controls.Add(this.picDarkRectangleMaterialList);
            this.Controls.Add(this.cmbMaterials);
            this.Controls.Add(this.picDropDownFigures);
            this.Controls.Add(this.lblFiguresList);
            this.Controls.Add(this.picDarkRectangleFigureList);
            this.Controls.Add(this.cmbFigures);
            this.Controls.Add(this.lblCancel);
            this.Controls.Add(this.picRectangleFieldCancel);
            this.Controls.Add(this.lblSave);
            this.Controls.Add(this.picRectangleFieldSave);
            this.Controls.Add(this.txtInputName);
            this.Controls.Add(this.picDarkRectangleFieldName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.picCard);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "AddModel";
            this.Size = new System.Drawing.Size(834, 604);
            ((System.ComponentModel.ISupportInitialize)(this.picRectangleFieldCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRectangleFieldSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDarkRectangleFieldName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDropDownFigures)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDarkRectangleFigureList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDropDownMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDarkRectangleMaterialList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCard;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picDarkRectangleFieldName;
        private System.Windows.Forms.TextBox txtInputName;
        private System.Windows.Forms.PictureBox picRectangleFieldSave;
        private System.Windows.Forms.Label lblSave;
        private System.Windows.Forms.Label lblCancel;
        private System.Windows.Forms.PictureBox picRectangleFieldCancel;
        private System.Windows.Forms.ComboBox cmbFigures;
        private System.Windows.Forms.PictureBox picDropDownFigures;
        private System.Windows.Forms.Label lblFiguresList;
        private System.Windows.Forms.PictureBox picDarkRectangleFigureList;
        private System.Windows.Forms.ComboBox cmbMaterials;
        private System.Windows.Forms.PictureBox picDropDownMaterial;
        private System.Windows.Forms.Label lblMaterialsList;
        private System.Windows.Forms.PictureBox picDarkRectangleMaterialList;
        private System.Windows.Forms.CheckBox rbtnCreatePreview;
    }
}
