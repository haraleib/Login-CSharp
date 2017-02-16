namespace WindowsFormsApplication5
{
    partial class Home
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
            this.textPwd = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.btnReg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textPwd
            // 
            this.textPwd.Location = new System.Drawing.Point(409, 140);
            this.textPwd.Name = "textPwd";
            this.textPwd.Size = new System.Drawing.Size(100, 26);
            this.textPwd.TabIndex = 0;
            this.textPwd.Text = "Passwort";
            this.textPwd.TextChanged += new System.EventHandler(this.textPwd_TextChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(277, 200);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(91, 37);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // textUsername
            // 
            this.textUsername.Location = new System.Drawing.Point(125, 140);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(243, 26);
            this.textUsername.TabIndex = 3;
            this.textUsername.Text = "Username";
            this.textUsername.TextChanged += new System.EventHandler(this.textUsername_TextChanged);
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(409, 200);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(100, 37);
            this.btnReg.TabIndex = 5;
            this.btnReg.Text = "Register";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 424);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.textUsername);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.textPwd);
            this.Name = "Home";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textPwd;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox textUsername;
        private System.Windows.Forms.Button btnReg;
    }
}

