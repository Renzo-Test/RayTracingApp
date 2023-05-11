namespace GUI
{
    partial class SignUp
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
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblSignUp = new System.Windows.Forms.Label();
            this.lblAlreadyHaveAnAccount = new System.Windows.Forms.Label();
            this.lblSignIn = new System.Windows.Forms.Label();
            this.picSignUpBackground = new System.Windows.Forms.PictureBox();
            this.txtIconLockConfirmPassword = new System.Windows.Forms.PictureBox();
            this.txtFieldRectangleConfirmPassword = new System.Windows.Forms.PictureBox();
            this.picIconLock = new System.Windows.Forms.PictureBox();
            this.picFieldRectanglePassword = new System.Windows.Forms.PictureBox();
            this.picIconUser = new System.Windows.Forms.PictureBox();
            this.picFieldRectangleUsername = new System.Windows.Forms.PictureBox();
            this.picUserBackground = new System.Windows.Forms.PictureBox();
            this.picSphereBackground = new System.Windows.Forms.PictureBox();
            this.lblWarning = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picSignUpBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIconLockConfirmPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFieldRectangleConfirmPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIconLock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFieldRectanglePassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIconUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFieldRectangleUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSphereBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.DimGray;
            this.txtUsername.Location = new System.Drawing.Point(728, 249);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(136, 20);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.Text = "Username";
            this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
            this.txtUsername.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtUsername_KeyUp);
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.DimGray;
            this.txtPassword.Location = new System.Drawing.Point(728, 314);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(136, 20);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "Password";
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyUp);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.DimGray;
            this.txtConfirmPassword.Location = new System.Drawing.Point(728, 383);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(136, 20);
            this.txtConfirmPassword.TabIndex = 2;
            this.txtConfirmPassword.Text = "Confirm Password";
            this.txtConfirmPassword.Enter += new System.EventHandler(this.txtConfirmPassword_Enter);
            this.txtConfirmPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtConfirmPassword_KeyUp);
            this.txtConfirmPassword.Leave += new System.EventHandler(this.txtConfirmPassword_Leave);
            // 
            // lblSignUp
            // 
            this.lblSignUp.AutoSize = true;
            this.lblSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(158)))), ((int)(((byte)(140)))));
            this.lblSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSignUp.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignUp.ForeColor = System.Drawing.Color.White;
            this.lblSignUp.Location = new System.Drawing.Point(723, 451);
            this.lblSignUp.Name = "lblSignUp";
            this.lblSignUp.Size = new System.Drawing.Size(98, 28);
            this.lblSignUp.TabIndex = 12;
            this.lblSignUp.Text = "Sign Up";
            this.lblSignUp.Click += new System.EventHandler(this.lblSignUp_Click);
            // 
            // lblAlreadyHaveAnAccount
            // 
            this.lblAlreadyHaveAnAccount.AutoSize = true;
            this.lblAlreadyHaveAnAccount.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlreadyHaveAnAccount.ForeColor = System.Drawing.Color.White;
            this.lblAlreadyHaveAnAccount.Location = new System.Drawing.Point(678, 514);
            this.lblAlreadyHaveAnAccount.Name = "lblAlreadyHaveAnAccount";
            this.lblAlreadyHaveAnAccount.Size = new System.Drawing.Size(164, 16);
            this.lblAlreadyHaveAnAccount.TabIndex = 13;
            this.lblAlreadyHaveAnAccount.Text = "Already have an account?";
            // 
            // lblSignIn
            // 
            this.lblSignIn.AutoSize = true;
            this.lblSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSignIn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(158)))), ((int)(((byte)(140)))));
            this.lblSignIn.Location = new System.Drawing.Point(840, 514);
            this.lblSignIn.Name = "lblSignIn";
            this.lblSignIn.Size = new System.Drawing.Size(48, 16);
            this.lblSignIn.TabIndex = 14;
            this.lblSignIn.Text = "Sign In!";
            this.lblSignIn.Click += new System.EventHandler(this.lblSignIn_Click);
            // 
            // picSignUpBackground
            // 
            this.picSignUpBackground.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSignUpBackground.Image = global::GUI.Properties.Resources.loginBackground;
            this.picSignUpBackground.Location = new System.Drawing.Point(672, 432);
            this.picSignUpBackground.Name = "picSignUpBackground";
            this.picSignUpBackground.Size = new System.Drawing.Size(216, 65);
            this.picSignUpBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSignUpBackground.TabIndex = 11;
            this.picSignUpBackground.TabStop = false;
            this.picSignUpBackground.Click += new System.EventHandler(this.picSignUpBackground_Click);
            // 
            // txtIconLockConfirmPassword
            // 
            this.txtIconLockConfirmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtIconLockConfirmPassword.Image = global::GUI.Properties.Resources.padlockIcon;
            this.txtIconLockConfirmPassword.Location = new System.Drawing.Point(691, 379);
            this.txtIconLockConfirmPassword.Name = "txtIconLockConfirmPassword";
            this.txtIconLockConfirmPassword.Size = new System.Drawing.Size(24, 24);
            this.txtIconLockConfirmPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.txtIconLockConfirmPassword.TabIndex = 10;
            this.txtIconLockConfirmPassword.TabStop = false;
            // 
            // txtFieldRectangleConfirmPassword
            // 
            this.txtFieldRectangleConfirmPassword.Image = global::GUI.Properties.Resources.fieldRectangle;
            this.txtFieldRectangleConfirmPassword.Location = new System.Drawing.Point(672, 369);
            this.txtFieldRectangleConfirmPassword.Name = "txtFieldRectangleConfirmPassword";
            this.txtFieldRectangleConfirmPassword.Size = new System.Drawing.Size(211, 48);
            this.txtFieldRectangleConfirmPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.txtFieldRectangleConfirmPassword.TabIndex = 8;
            this.txtFieldRectangleConfirmPassword.TabStop = false;
            // 
            // picIconLock
            // 
            this.picIconLock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.picIconLock.Image = global::GUI.Properties.Resources.padlockIcon;
            this.picIconLock.Location = new System.Drawing.Point(691, 314);
            this.picIconLock.Name = "picIconLock";
            this.picIconLock.Size = new System.Drawing.Size(24, 24);
            this.picIconLock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIconLock.TabIndex = 7;
            this.picIconLock.TabStop = false;
            // 
            // picFieldRectanglePassword
            // 
            this.picFieldRectanglePassword.Image = global::GUI.Properties.Resources.fieldRectangle;
            this.picFieldRectanglePassword.Location = new System.Drawing.Point(672, 303);
            this.picFieldRectanglePassword.Name = "picFieldRectanglePassword";
            this.picFieldRectanglePassword.Size = new System.Drawing.Size(211, 48);
            this.picFieldRectanglePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFieldRectanglePassword.TabIndex = 5;
            this.picFieldRectanglePassword.TabStop = false;
            // 
            // picIconUser
            // 
            this.picIconUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
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
            // lblWarning
            // 
            this.lblWarning.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(158)))), ((int)(((byte)(140)))));
            this.lblWarning.Location = new System.Drawing.Point(596, 555);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(390, 16);
            this.lblWarning.TabIndex = 17;
            this.lblWarning.Text = "Warning";
            this.lblWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWarning.Visible = false;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.lblSignIn);
            this.Controls.Add(this.lblAlreadyHaveAnAccount);
            this.Controls.Add(this.lblSignUp);
            this.Controls.Add(this.picSignUpBackground);
            this.Controls.Add(this.txtIconLockConfirmPassword);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtFieldRectangleConfirmPassword);
            this.Controls.Add(this.picIconLock);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.picFieldRectanglePassword);
            this.Controls.Add(this.picIconUser);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.picFieldRectangleUsername);
            this.Controls.Add(this.picUserBackground);
            this.Controls.Add(this.picSphereBackground);
            this.MaximumSize = new System.Drawing.Size(1009, 604);
            this.MinimumSize = new System.Drawing.Size(1009, 604);
            this.Name = "SignUp";
            this.Size = new System.Drawing.Size(1009, 604);
            ((System.ComponentModel.ISupportInitialize)(this.picSignUpBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIconLockConfirmPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFieldRectangleConfirmPassword)).EndInit();
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
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.PictureBox picIconUser;
        private System.Windows.Forms.PictureBox picIconLock;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox picFieldRectanglePassword;
        private System.Windows.Forms.PictureBox txtIconLockConfirmPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.PictureBox txtFieldRectangleConfirmPassword;
        private System.Windows.Forms.PictureBox picSignUpBackground;
        private System.Windows.Forms.Label lblSignUp;
        private System.Windows.Forms.Label lblAlreadyHaveAnAccount;
        private System.Windows.Forms.Label lblSignIn;
        private System.Windows.Forms.Label lblWarning;
    }
}
