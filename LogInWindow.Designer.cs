namespace CourseworkApp
{
    partial class LogInWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInWindow));
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.loginBTN = new System.Windows.Forms.Button();
            this.welcome_text = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pwdTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.registerBTN = new System.Windows.Forms.Button();
            this.adminBTN = new System.Windows.Forms.Button();
            this.adminLoginBTN = new System.Windows.Forms.Button();
            this.adminPwd_TB = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // usernameTB
            // 
            this.usernameTB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTB.Location = new System.Drawing.Point(572, 204);
            this.usernameTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Size = new System.Drawing.Size(257, 35);
            this.usernameTB.TabIndex = 0;
            // 
            // loginBTN
            // 
            this.loginBTN.BackColor = System.Drawing.Color.Transparent;
            this.loginBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginBTN.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBTN.Location = new System.Drawing.Point(572, 286);
            this.loginBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginBTN.Name = "loginBTN";
            this.loginBTN.Size = new System.Drawing.Size(114, 42);
            this.loginBTN.TabIndex = 1;
            this.loginBTN.Text = "Login";
            this.loginBTN.UseVisualStyleBackColor = false;
            this.loginBTN.Click += new System.EventHandler(this.loginBTN_Click);
            // 
            // welcome_text
            // 
            this.welcome_text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.welcome_text.AutoSize = true;
            this.welcome_text.BackColor = System.Drawing.Color.Transparent;
            this.welcome_text.Font = new System.Drawing.Font("Stencil", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_text.Location = new System.Drawing.Point(618, 138);
            this.welcome_text.Name = "welcome_text";
            this.welcome_text.Size = new System.Drawing.Size(173, 39);
            this.welcome_text.TabIndex = 2;
            this.welcome_text.Text = "WELCOME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(457, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            // 
            // pwdTB
            // 
            this.pwdTB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwdTB.Location = new System.Drawing.Point(572, 245);
            this.pwdTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pwdTB.Name = "pwdTB";
            this.pwdTB.Size = new System.Drawing.Size(257, 35);
            this.pwdTB.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(457, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // registerBTN
            // 
            this.registerBTN.BackColor = System.Drawing.Color.Transparent;
            this.registerBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.registerBTN.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerBTN.Location = new System.Drawing.Point(716, 286);
            this.registerBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.registerBTN.Name = "registerBTN";
            this.registerBTN.Size = new System.Drawing.Size(113, 42);
            this.registerBTN.TabIndex = 6;
            this.registerBTN.Text = "Register";
            this.registerBTN.UseVisualStyleBackColor = false;
            this.registerBTN.Click += new System.EventHandler(this.registerBTN_Click);
            // 
            // adminBTN
            // 
            this.adminBTN.BackColor = System.Drawing.Color.Transparent;
            this.adminBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.adminBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminBTN.Location = new System.Drawing.Point(12, 11);
            this.adminBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adminBTN.Name = "adminBTN";
            this.adminBTN.Size = new System.Drawing.Size(123, 56);
            this.adminBTN.TabIndex = 7;
            this.adminBTN.Text = "Login as Admin";
            this.adminBTN.UseVisualStyleBackColor = false;
            this.adminBTN.Click += new System.EventHandler(this.adminBTN_Click);
            // 
            // adminLoginBTN
            // 
            this.adminLoginBTN.BackColor = System.Drawing.Color.Transparent;
            this.adminLoginBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.adminLoginBTN.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLoginBTN.Location = new System.Drawing.Point(353, 22);
            this.adminLoginBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adminLoginBTN.Name = "adminLoginBTN";
            this.adminLoginBTN.Size = new System.Drawing.Size(73, 34);
            this.adminLoginBTN.TabIndex = 9;
            this.adminLoginBTN.Text = "Login";
            this.adminLoginBTN.UseVisualStyleBackColor = false;
            this.adminLoginBTN.Click += new System.EventHandler(this.adminLoginBTN_Click);
            // 
            // adminPwd_TB
            // 
            this.adminPwd_TB.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminPwd_TB.Location = new System.Drawing.Point(141, 22);
            this.adminPwd_TB.Name = "adminPwd_TB";
            this.adminPwd_TB.Size = new System.Drawing.Size(206, 34);
            this.adminPwd_TB.TabIndex = 10;
            // 
            // LogInWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1381, 724);
            this.Controls.Add(this.adminPwd_TB);
            this.Controls.Add(this.adminLoginBTN);
            this.Controls.Add(this.adminBTN);
            this.Controls.Add(this.registerBTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pwdTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.welcome_text);
            this.Controls.Add(this.loginBTN);
            this.Controls.Add(this.usernameTB);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LogInWindow";
            this.Text = "LogIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameTB;
        private System.Windows.Forms.Button loginBTN;
        private System.Windows.Forms.Label welcome_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pwdTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button registerBTN;
        private System.Windows.Forms.Button adminBTN;
        private System.Windows.Forms.Button adminLoginBTN;
        private System.Windows.Forms.MaskedTextBox adminPwd_TB;
    }
}

