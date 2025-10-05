
namespace QLNhanVien
{
    partial class FrmLogin
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
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lbUserName = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.ckcSavePass = new System.Windows.Forms.CheckBox();
            this.ckcShowPass = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserName.Location = new System.Drawing.Point(190, 45);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(226, 26);
            this.txtUserName.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Location = new System.Drawing.Point(190, 95);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(226, 26);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogin.Location = new System.Drawing.Point(0, 211);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(579, 40);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lbUserName
            // 
            this.lbUserName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbUserName.AutoSize = true;
            this.lbUserName.Location = new System.Drawing.Point(66, 48);
            this.lbUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(116, 20);
            this.lbUserName.TabIndex = 3;
            this.lbUserName.Text = "Tên đăng nhập";
            // 
            // lbPassword
            // 
            this.lbPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(66, 101);
            this.lbPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(75, 20);
            this.lbPassword.TabIndex = 4;
            this.lbPassword.Text = "Mật khẩu";
            // 
            // ckcSavePass
            // 
            this.ckcSavePass.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ckcSavePass.AutoSize = true;
            this.ckcSavePass.Location = new System.Drawing.Point(190, 148);
            this.ckcSavePass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ckcSavePass.Name = "ckcSavePass";
            this.ckcSavePass.Size = new System.Drawing.Size(134, 24);
            this.ckcSavePass.TabIndex = 5;
            this.ckcSavePass.Text = "Lưu mật khẩu?";
            this.ckcSavePass.UseVisualStyleBackColor = true;
            this.ckcSavePass.CheckedChanged += new System.EventHandler(this.ckcSavePass_CheckedChanged);
            // 
            // ckcShowPass
            // 
            this.ckcShowPass.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ckcShowPass.AutoSize = true;
            this.ckcShowPass.Location = new System.Drawing.Point(436, 101);
            this.ckcShowPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ckcShowPass.Name = "ckcShowPass";
            this.ckcShowPass.Size = new System.Drawing.Size(131, 24);
            this.ckcShowPass.TabIndex = 6;
            this.ckcShowPass.Text = "Hiện mật khẩu";
            this.ckcShowPass.UseVisualStyleBackColor = true;
            this.ckcShowPass.CheckedChanged += new System.EventHandler(this.ckcShowPass_CheckedChanged);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 251);
            this.Controls.Add(this.ckcShowPass);
            this.Controls.Add(this.ckcSavePass);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống quản lý nhân sự";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.CheckBox ckcSavePass;
        private System.Windows.Forms.CheckBox ckcShowPass;
    }
}

