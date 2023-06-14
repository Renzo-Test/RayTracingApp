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
			this.lblLastModified = new System.Windows.Forms.Label();
			this.lblAvailableModels = new System.Windows.Forms.Label();
			this.lblScene = new System.Windows.Forms.Label();
			this.lblPosisionatedModels = new System.Windows.Forms.Label();
			this.flyModels = new System.Windows.Forms.FlowLayoutPanel();
			this.flyUsedModels = new System.Windows.Forms.FlowLayoutPanel();
			this.txtFov = new System.Windows.Forms.TextBox();
			this.txtLookAt = new System.Windows.Forms.TextBox();
			this.txtLookFrom = new System.Windows.Forms.TextBox();
			this.txtSceneName = new System.Windows.Forms.TextBox();
			this.lblLookFrom = new System.Windows.Forms.Label();
			this.lblLookAt = new System.Windows.Forms.Label();
			this.lblFov = new System.Windows.Forms.Label();
			this.lblRender = new System.Windows.Forms.Label();
			this.pbrRender = new System.Windows.Forms.ProgressBar();
			this.lblImageOutdated = new System.Windows.Forms.Label();
			this.picIconExport = new System.Windows.Forms.PictureBox();
			this.picIconWarning = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.picRender = new System.Windows.Forms.PictureBox();
			this.picFieldLookFrom = new System.Windows.Forms.PictureBox();
			this.picFieldLookAt = new System.Windows.Forms.PictureBox();
			this.picFieldFov = new System.Windows.Forms.PictureBox();
			this.picScene = new System.Windows.Forms.PictureBox();
			this.picIconBack = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtLensAperture = new System.Windows.Forms.TextBox();
			this.picFueldLensAperture = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.rbtnBlur = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.picIconExport)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picIconWarning)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picRender)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picFieldLookFrom)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picFieldLookAt)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picFieldFov)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picScene)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picIconBack)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picFueldLensAperture)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.SuspendLayout();
			// 
			// lblLastModified
			// 
			this.lblLastModified.AutoSize = true;
			this.lblLastModified.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLastModified.ForeColor = System.Drawing.Color.White;
			this.lblLastModified.Location = new System.Drawing.Point(477, 31);
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
			this.lblAvailableModels.Location = new System.Drawing.Point(12, 242);
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
			this.lblScene.Location = new System.Drawing.Point(249, 242);
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
			this.lblPosisionatedModels.Location = new System.Drawing.Point(655, 240);
			this.lblPosisionatedModels.Name = "lblPosisionatedModels";
			this.lblPosisionatedModels.Size = new System.Drawing.Size(170, 30);
			this.lblPosisionatedModels.TabIndex = 5;
			this.lblPosisionatedModels.Text = "Using Models";
			// 
			// flyModels
			// 
			this.flyModels.AutoScroll = true;
			this.flyModels.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
			this.flyModels.Location = new System.Drawing.Point(11, 293);
			this.flyModels.Margin = new System.Windows.Forms.Padding(0);
			this.flyModels.Name = "flyModels";
			this.flyModels.Size = new System.Drawing.Size(230, 270);
			this.flyModels.TabIndex = 18;
			// 
			// flyUsedModels
			// 
			this.flyUsedModels.AutoScroll = true;
			this.flyUsedModels.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
			this.flyUsedModels.Location = new System.Drawing.Point(655, 293);
			this.flyUsedModels.Margin = new System.Windows.Forms.Padding(0);
			this.flyUsedModels.Name = "flyUsedModels";
			this.flyUsedModels.Size = new System.Drawing.Size(170, 270);
			this.flyUsedModels.TabIndex = 19;
			// 
			// txtFov
			// 
			this.txtFov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.txtFov.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtFov.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFov.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.txtFov.Location = new System.Drawing.Point(272, 192);
			this.txtFov.Name = "txtFov";
			this.txtFov.Size = new System.Drawing.Size(158, 24);
			this.txtFov.TabIndex = 27;
			this.txtFov.Text = "Fov";
			// 
			// txtLookAt
			// 
			this.txtLookAt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.txtLookAt.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtLookAt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLookAt.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.txtLookAt.Location = new System.Drawing.Point(42, 192);
			this.txtLookAt.Name = "txtLookAt";
			this.txtLookAt.Size = new System.Drawing.Size(158, 24);
			this.txtLookAt.TabIndex = 29;
			this.txtLookAt.Text = "x, y, z";
			// 
			// txtLookFrom
			// 
			this.txtLookFrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.txtLookFrom.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtLookFrom.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLookFrom.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.txtLookFrom.Location = new System.Drawing.Point(42, 122);
			this.txtLookFrom.Name = "txtLookFrom";
			this.txtLookFrom.Size = new System.Drawing.Size(169, 24);
			this.txtLookFrom.TabIndex = 31;
			this.txtLookFrom.Text = "x, y, z";
			// 
			// txtSceneName
			// 
			this.txtSceneName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
			this.txtSceneName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtSceneName.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSceneName.ForeColor = System.Drawing.Color.White;
			this.txtSceneName.Location = new System.Drawing.Point(91, 23);
			this.txtSceneName.Name = "txtSceneName";
			this.txtSceneName.Size = new System.Drawing.Size(380, 34);
			this.txtSceneName.TabIndex = 32;
			this.txtSceneName.Text = "Scene 1";
			// 
			// lblLookFrom
			// 
			this.lblLookFrom.AutoSize = true;
			this.lblLookFrom.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLookFrom.ForeColor = System.Drawing.Color.White;
			this.lblLookFrom.Location = new System.Drawing.Point(26, 87);
			this.lblLookFrom.Name = "lblLookFrom";
			this.lblLookFrom.Size = new System.Drawing.Size(116, 24);
			this.lblLookFrom.TabIndex = 33;
			this.lblLookFrom.Text = "Look From";
			// 
			// lblLookAt
			// 
			this.lblLookAt.AutoSize = true;
			this.lblLookAt.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLookAt.ForeColor = System.Drawing.Color.White;
			this.lblLookAt.Location = new System.Drawing.Point(21, 157);
			this.lblLookAt.Name = "lblLookAt";
			this.lblLookAt.Size = new System.Drawing.Size(87, 24);
			this.lblLookAt.TabIndex = 34;
			this.lblLookAt.Text = "Look At";
			// 
			// lblFov
			// 
			this.lblFov.AutoSize = true;
			this.lblFov.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFov.ForeColor = System.Drawing.Color.White;
			this.lblFov.Location = new System.Drawing.Point(250, 157);
			this.lblFov.Name = "lblFov";
			this.lblFov.Size = new System.Drawing.Size(47, 24);
			this.lblFov.TabIndex = 35;
			this.lblFov.Text = "Fov";
			// 
			// lblRender
			// 
			this.lblRender.AutoSize = true;
			this.lblRender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(158)))), ((int)(((byte)(140)))));
			this.lblRender.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblRender.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRender.ForeColor = System.Drawing.Color.White;
			this.lblRender.Location = new System.Drawing.Point(711, 191);
			this.lblRender.Name = "lblRender";
			this.lblRender.Size = new System.Drawing.Size(75, 23);
			this.lblRender.TabIndex = 37;
			this.lblRender.Text = "Render";
			this.lblRender.Click += new System.EventHandler(this.lblRender_Click);
			// 
			// pbrRender
			// 
			this.pbrRender.Location = new System.Drawing.Point(254, 571);
			this.pbrRender.Name = "pbrRender";
			this.pbrRender.Size = new System.Drawing.Size(388, 18);
			this.pbrRender.TabIndex = 39;
			this.pbrRender.Visible = false;
			// 
			// lblImageOutdated
			// 
			this.lblImageOutdated.AutoSize = true;
			this.lblImageOutdated.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblImageOutdated.ForeColor = System.Drawing.Color.White;
			this.lblImageOutdated.Location = new System.Drawing.Point(366, 571);
			this.lblImageOutdated.Name = "lblImageOutdated";
			this.lblImageOutdated.Size = new System.Drawing.Size(185, 24);
			this.lblImageOutdated.TabIndex = 41;
			this.lblImageOutdated.Text = "Image Outdated";
			this.lblImageOutdated.Visible = false;
			// 
			// picIconExport
			// 
			this.picIconExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(158)))), ((int)(((byte)(140)))));
			this.picIconExport.Cursor = System.Windows.Forms.Cursors.Hand;
			this.picIconExport.Image = global::GUI.Properties.Resources.export;
			this.picIconExport.Location = new System.Drawing.Point(681, 123);
			this.picIconExport.Name = "picIconExport";
			this.picIconExport.Size = new System.Drawing.Size(24, 24);
			this.picIconExport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picIconExport.TabIndex = 44;
			this.picIconExport.TabStop = false;
			this.picIconExport.Click += new System.EventHandler(this.picIconExport_Click);
			// 
			// picIconWarning
			// 
			this.picIconWarning.Image = global::GUI.Properties.Resources.blackWarning;
			this.picIconWarning.Location = new System.Drawing.Point(336, 571);
			this.picIconWarning.Name = "picIconWarning";
			this.picIconWarning.Size = new System.Drawing.Size(24, 24);
			this.picIconWarning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picIconWarning.TabIndex = 42;
			this.picIconWarning.TabStop = false;
			this.picIconWarning.Visible = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(158)))), ((int)(((byte)(140)))));
			this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox1.Image = global::GUI.Properties.Resources.thunder;
			this.pictureBox1.Location = new System.Drawing.Point(681, 191);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(24, 24);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 38;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// picRender
			// 
			this.picRender.Cursor = System.Windows.Forms.Cursors.Hand;
			this.picRender.Image = global::GUI.Properties.Resources.homeButtonsBackground;
			this.picRender.Location = new System.Drawing.Point(655, 182);
			this.picRender.Name = "picRender";
			this.picRender.Size = new System.Drawing.Size(160, 41);
			this.picRender.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picRender.TabIndex = 36;
			this.picRender.TabStop = false;
			this.picRender.Click += new System.EventHandler(this.picRender_Click);
			// 
			// picFieldLookFrom
			// 
			this.picFieldLookFrom.Image = global::GUI.Properties.Resources.fieldRectangle;
			this.picFieldLookFrom.Location = new System.Drawing.Point(25, 114);
			this.picFieldLookFrom.Name = "picFieldLookFrom";
			this.picFieldLookFrom.Size = new System.Drawing.Size(200, 39);
			this.picFieldLookFrom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picFieldLookFrom.TabIndex = 30;
			this.picFieldLookFrom.TabStop = false;
			// 
			// picFieldLookAt
			// 
			this.picFieldLookAt.Image = global::GUI.Properties.Resources.fieldRectangle;
			this.picFieldLookAt.Location = new System.Drawing.Point(25, 184);
			this.picFieldLookAt.Name = "picFieldLookAt";
			this.picFieldLookAt.Size = new System.Drawing.Size(200, 39);
			this.picFieldLookAt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picFieldLookAt.TabIndex = 28;
			this.picFieldLookAt.TabStop = false;
			// 
			// picFieldFov
			// 
			this.picFieldFov.Image = global::GUI.Properties.Resources.fieldRectangle;
			this.picFieldFov.Location = new System.Drawing.Point(254, 184);
			this.picFieldFov.Name = "picFieldFov";
			this.picFieldFov.Size = new System.Drawing.Size(200, 39);
			this.picFieldFov.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picFieldFov.TabIndex = 26;
			this.picFieldFov.TabStop = false;
			// 
			// picScene
			// 
			this.picScene.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
			this.picScene.Image = global::GUI.Properties.Resources.sceneCompleteImage;
			this.picScene.Location = new System.Drawing.Point(254, 293);
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
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(250, 87);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(150, 24);
			this.label1.TabIndex = 47;
			this.label1.Text = "Lens Aperture";
			// 
			// txtLensAperture
			// 
			this.txtLensAperture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.txtLensAperture.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtLensAperture.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLensAperture.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.txtLensAperture.Location = new System.Drawing.Point(272, 122);
			this.txtLensAperture.Name = "txtLensAperture";
			this.txtLensAperture.Size = new System.Drawing.Size(158, 24);
			this.txtLensAperture.TabIndex = 46;
			this.txtLensAperture.Text = "0.5";
			// 
			// picFueldLensAperture
			// 
			this.picFueldLensAperture.Image = global::GUI.Properties.Resources.fieldRectangle;
			this.picFueldLensAperture.Location = new System.Drawing.Point(254, 114);
			this.picFueldLensAperture.Name = "picFueldLensAperture";
			this.picFueldLensAperture.Size = new System.Drawing.Size(200, 39);
			this.picFueldLensAperture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picFueldLensAperture.TabIndex = 45;
			this.picFueldLensAperture.TabStop = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(158)))), ((int)(((byte)(140)))));
			this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(711, 123);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 23);
			this.label2.TabIndex = 49;
			this.label2.Text = "Export";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// pictureBox3
			// 
			this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox3.Image = global::GUI.Properties.Resources.homeButtonsBackground;
			this.pictureBox3.Location = new System.Drawing.Point(655, 114);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(160, 41);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox3.TabIndex = 48;
			this.pictureBox3.TabStop = false;
			this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
			// 
			// rbtnBlur
			// 
			this.rbtnBlur.AutoSize = true;
			this.rbtnBlur.BackColor = System.Drawing.Color.Transparent;
			this.rbtnBlur.CausesValidation = false;
			this.rbtnBlur.Cursor = System.Windows.Forms.Cursors.Hand;
			this.rbtnBlur.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbtnBlur.ForeColor = System.Drawing.SystemColors.Window;
			this.rbtnBlur.Location = new System.Drawing.Point(470, 120);
			this.rbtnBlur.Name = "rbtnBlur";
			this.rbtnBlur.Size = new System.Drawing.Size(61, 26);
			this.rbtnBlur.TabIndex = 50;
			this.rbtnBlur.Text = "Blur";
			this.rbtnBlur.UseVisualStyleBackColor = false;
			// 
			// ScenePage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
			this.Controls.Add(this.rbtnBlur);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtLensAperture);
			this.Controls.Add(this.picFueldLensAperture);
			this.Controls.Add(this.picIconExport);
			this.Controls.Add(this.picIconWarning);
			this.Controls.Add(this.lblImageOutdated);
			this.Controls.Add(this.pbrRender);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.lblRender);
			this.Controls.Add(this.picRender);
			this.Controls.Add(this.lblFov);
			this.Controls.Add(this.lblLookAt);
			this.Controls.Add(this.lblLookFrom);
			this.Controls.Add(this.txtSceneName);
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
			this.Controls.Add(this.pictureBox3);
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "ScenePage";
			this.Size = new System.Drawing.Size(834, 604);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.ScenePage_Paint);
			((System.ComponentModel.ISupportInitialize)(this.picIconExport)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picIconWarning)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picRender)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picFieldLookFrom)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picFieldLookAt)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picFieldFov)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picScene)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picIconBack)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picFueldLensAperture)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.TextBox txtSceneName;
        private System.Windows.Forms.Label lblLookFrom;
        private System.Windows.Forms.Label lblLookAt;
        private System.Windows.Forms.Label lblFov;
        private System.Windows.Forms.PictureBox picRender;
        private System.Windows.Forms.Label lblRender;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar pbrRender;
        private System.Windows.Forms.Label lblImageOutdated;
        private System.Windows.Forms.PictureBox picIconWarning;
        private System.Windows.Forms.PictureBox picIconExport;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtLensAperture;
		private System.Windows.Forms.PictureBox picFueldLensAperture;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.CheckBox rbtnBlur;
	}
}
