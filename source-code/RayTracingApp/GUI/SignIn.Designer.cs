namespace GUI
{
    partial class SignIn
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
            this.txtPasswordSignIn = new System.Windows.Forms.TextBox();
            this.lblSignIn = new System.Windows.Forms.Label();
            this.lblAlreadyHaveAnAccount = new System.Windows.Forms.Label();
            this.lblSignUpRef = new System.Windows.Forms.Label();
            this.txtUsernameSignIn = new System.Windows.Forms.TextBox();
            this.picIconLogs = new System.Windows.Forms.PictureBox();
            this.picBackgroundLogs = new System.Windows.Forms.PictureBox();
            this.picSignInButton = new System.Windows.Forms.PictureBox();
            this.picIconLock = new System.Windows.Forms.PictureBox();
            this.picFieldRectanglePassword = new System.Windows.Forms.PictureBox();
            this.picIconUser = new System.Windows.Forms.PictureBox();
            this.picFieldRectangleUsername = new System.Windows.Forms.PictureBox();
            this.picUserBackground = new System.Windows.Forms.PictureBox();
            this.picSphereBackground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picIconLogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBackgroundLogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSignInButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIconLock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFieldRectanglePassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIconUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFieldRectangleUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSphereBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPasswordSignIn
            // 
            this.txtPasswordSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtPasswordSignIn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPasswordSignIn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordSignIn.ForeColor = System.Drawing.Color.DimGray;
            this.txtPasswordSignIn.Location = new System.Drawing.Point(721, 321);
            this.txtPasswordSignIn.Name = "txtPasswordSignIn";
            this.txtPasswordSignIn.Size = new System.Drawing.Size(136, 20);
            this.txtPasswordSignIn.TabIndex = 1;
            this.txtPasswordSignIn.Text = "Password";
            this.txtPasswordSignIn.Enter += new System.EventHandler(this.TxtPasswordSignIn_Enter);
            this.txtPasswordSignIn.Leave += new System.EventHandler(this.TxtPasswordSignIn_Leave);
            // 
            // lblSignIn
            // 
            this.lblSignIn.AutoSize = true;
            this.lblSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(158)))), ((int)(((byte)(140)))));
            this.lblSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSignIn.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignIn.ForeColor = System.Drawing.Color.White;
            this.lblSignIn.Location = new System.Drawing.Point(729, 398);
            this.lblSignIn.Name = "lblSignIn";
            this.lblSignIn.Size = new System.Drawing.Size(87, 28);
            this.lblSignIn.TabIndex = 9;
            this.lblSignIn.Text = "Sign in";
            this.lblSignIn.Click += new System.EventHandler(this.LblSignIn_Click);
            // 
            // lblAlreadyHaveAnAccount
            // 
            this.lblAlreadyHaveAnAccount.AutoSize = true;
            this.lblAlreadyHaveAnAccount.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlreadyHaveAnAccount.ForeColor = System.Drawing.Color.White;
            this.lblAlreadyHaveAnAccount.Location = new System.Drawing.Point(682, 458);
            this.lblAlreadyHaveAnAccount.Name = "lblAlreadyHaveAnAccount";
            this.lblAlreadyHaveAnAccount.Size = new System.Drawing.Size(143, 16);
            this.lblAlreadyHaveAnAccount.TabIndex = 10;
            this.lblAlreadyHaveAnAccount.Text = "Dont have an account?";
            // 
            // lblSignUpRef
            // 
            this.lblSignUpRef.AutoSize = true;
            this.lblSignUpRef.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSignUpRef.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignUpRef.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(158)))), ((int)(((byte)(140)))));
            this.lblSignUpRef.Location = new System.Drawing.Point(822, 458);
            this.lblSignUpRef.Name = "lblSignUpRef";
            this.lblSignUpRef.Size = new System.Drawing.Size(53, 16);
            this.lblSignUpRef.TabIndex = 11;
            this.lblSignUpRef.Text = "Sign Up!";
            this.lblSignUpRef.Click += new System.EventHandler(this.LblSignUpRef_Click);
            // 
            // txtUsernameSignIn
            // 
            this.txtUsernameSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtUsernameSignIn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsernameSignIn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsernameSignIn.ForeColor = System.Drawing.Color.DimGray;
            this.txtUsernameSignIn.Location = new System.Drawing.Point(721, 249);
            this.txtUsernameSignIn.Name = "txtUsernameSignIn";
            this.txtUsernameSignIn.Size = new System.Drawing.Size(136, 20);
            this.txtUsernameSignIn.TabIndex = 0;
            this.txtUsernameSignIn.Text = "Username";
            this.txtUsernameSignIn.Enter += new System.EventHandler(this.TxtUsernameSignIn_Enter);
            this.txtUsernameSignIn.Leave += new System.EventHandler(this.TxtUsernameSignIn_Leave);
            // 
            // picIconLogs
            // 
            this.picIconLogs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(158)))), ((int)(((byte)(140)))));
            this.picIconLogs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picIconLogs.Image = global::GUI.Properties.Resources.logs;
            this.picIconLogs.Location = new System.Drawing.Point(956, 548);
            this.picIconLogs.Name = "picIconLogs";
            this.picIconLogs.Size = new System.Drawing.Size(24, 24);
            this.picIconLogs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picIconLogs.TabIndex = 13;
            this.picIconLogs.TabStop = false;
            this.picIconLogs.Click += new System.EventHandler(this.picIconLogs_Click);
            // 
            // picBackgroundLogs
            // 
            this.picBackgroundLogs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBackgroundLogs.Image = global::GUI.Properties.Resources.circleButton1;
            this.picBackgroundLogs.Location = new System.Drawing.Point(946, 540);
            this.picBackgroundLogs.Name = "picBackgroundLogs";
            this.picBackgroundLogs.Size = new System.Drawing.Size(42, 42);
            this.picBackgroundLogs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBackgroundLogs.TabIndex = 12;
            this.picBackgroundLogs.TabStop = false;
            this.picBackgroundLogs.Click += new System.EventHandler(this.picBackgroundLogs_Click);
            // 
            // picSignInButton
            // 
            this.picSignInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSignInButton.Image = global::GUI.Properties.Resources.loginBackground;
            this.picSignInButton.Location = new System.Drawing.Point(667, 379);
            this.picSignInButton.Name = "picSignInButton";
            this.picSignInButton.Size = new System.Drawing.Size(216, 66);
            this.picSignInButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSignInButton.TabIndex = 8;
            this.picSignInButton.TabStop = false;
            this.picSignInButton.Click += new System.EventHandler(this.PicSignInButton_Click);
            // 
            // picIconLock
            // 
            this.picIconLock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.picIconLock.Enabled = false;
            this.picIconLock.Image = global::GUI.Properties.Resources.padlockIcon;
            this.picIconLock.Location = new System.Drawing.Point(691, 317);
            this.picIconLock.Name = "picIconLock";
            this.picIconLock.Size = new System.Drawing.Size(24, 24);
            this.picIconLock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIconLock.TabIndex = 7;
            this.picIconLock.TabStop = false;
            // 
            // picFieldRectanglePassword
            // 
            this.picFieldRectanglePassword.Image = global::GUI.Properties.Resources.fieldRectangle;
            this.picFieldRectanglePassword.Location = new System.Drawing.Point(672, 307);
            this.picFieldRectanglePassword.Name = "picFieldRectanglePassword";
            this.picFieldRectanglePassword.Size = new System.Drawing.Size(211, 48);
            this.picFieldRectanglePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFieldRectanglePassword.TabIndex = 5;
            this.picFieldRectanglePassword.TabStop = false;
            // 
            // picIconUser
            // 
            this.picIconUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.picIconUser.Enabled = false;
            this.picIconUser.Image = global::GUI.Properties.Resources.userIcon;
            this.picIconUser.Location = new System.Drawing.Point(691, 245);
            this.picIconUser.Name = "picIconUser";
            this.picIconUser.Size = new System.Drawing.Size(24, 24);
            this.picIconUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIconUser.TabIndex = 4;
            this.picIconUser.TabStop = false;
            // 
            // picFieldRectangleUsername
            // 
            this.picFieldRectangleUsername.Image = global::GUI.Properties.Resources.fieldRectangle;
            this.picFieldRectangleUsername.Location = new System.Drawing.Point(672, 236);
            this.picFieldRectangleUsername.Name = "picFieldRectangleUsername";
            this.picFieldRectangleUsername.Size = new System.Drawing.Size(211, 48);
            this.picFieldRectangleUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFieldRectangleUsername.TabIndex = 2;
            this.picFieldRectangleUsername.TabStop = false;
            // 
            // picUserBackground
            // 
            this.picUserBackground.Image = global::GUI.Properties.Resources.userBackground;
            this.picUserBackground.Location = new System.Drawing.Point(710, 93);
            this.picUserBackground.Name = "picUserBackground";
            this.picUserBackground.Size = new System.Drawing.Size(115, 105);
            this.picUserBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUserBackground.TabIndex = 1;
            this.picUserBackground.TabStop = false;
            // 
            // picSphereBackground
            // 
            this.picSphereBackground.Image = global::GUI.Properties.Resources.sphereBackground;
            this.picSphereBackground.Location = new System.Drawing.Point(-289, -69);
            this.picSphereBackground.Name = "picSphereBackground";
            this.picSphereBackground.Size = new System.Drawing.Size(850, 742);
            this.picSphereBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSphereBackground.TabIndex = 0;
            this.picSphereBackground.TabStop = false;
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.Controls.Add(this.picIconLogs);
            this.Controls.Add(this.picBackgroundLogs);
            this.Controls.Add(this.txtUsernameSignIn);
            this.Controls.Add(this.lblSignUpRef);
            this.Controls.Add(this.lblAlreadyHaveAnAccount);
            this.Controls.Add(this.lblSignIn);
            this.Controls.Add(this.picSignInButton);
            this.Controls.Add(this.picIconLock);
            this.Controls.Add(this.txtPasswordSignIn);
            this.Controls.Add(this.picFieldRectanglePassword);
            this.Controls.Add(this.picIconUser);
            this.Controls.Add(this.picFieldRectangleUsername);
            this.Controls.Add(this.picUserBackground);
            this.Controls.Add(this.picSphereBackground);
            this.MaximumSize = new System.Drawing.Size(1009, 604);
            this.MinimumSize = new System.Drawing.Size(1009, 604);
            this.Name = "SignIn";
            this.Size = new System.Drawing.Size(1009, 604);
            ((System.ComponentModel.ISupportInitialize)(this.picIconLogs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBackgroundLogs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSignInButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIconLock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFieldRectanglePassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIconUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFieldRectangleUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSphereBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picSphereBackground;
        private System.Windows.Forms.PictureBox picUserBackground;
        private System.Windows.Forms.PictureBox picFieldRectangleUsername;
        private System.Windows.Forms.PictureBox picIconUser;
        private System.Windows.Forms.PictureBox picIconLock;
        private System.Windows.Forms.TextBox txtPasswordSignIn;
        private System.Windows.Forms.PictureBox picFieldRectanglePassword;
        private System.Windows.Forms.PictureBox picSignInButton;
        private System.Windows.Forms.Label lblSignIn;
        private System.Windows.Forms.Label lblAlreadyHaveAnAccount;
        private System.Windows.Forms.Label lblSignUpRef;
        private System.Windows.Forms.TextBox txtUsernameSignIn;
        private System.Windows.Forms.PictureBox picBackgroundLogs;
        private System.Windows.Forms.PictureBox picIconLogs;
    }
}
