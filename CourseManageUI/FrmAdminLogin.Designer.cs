namespace CourseManageUI
{
    partial class FrmAdminLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnMinimize = new Button();
            btnToggleMaximize = new Button();
            btnClose = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbUser = new TextBox();
            tbPassword = new TextBox();
            btnLogin = new Button();
            checkBox1 = new CheckBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSkyBlue;
            panel1.Controls.Add(btnMinimize);
            panel1.Controls.Add(btnToggleMaximize);
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(510, 57);
            panel1.TabIndex = 0;
            panel1.MouseDown += Frm_MouseDown;
            panel1.MouseMove += Frm_MouseMove;
            panel1.MouseUp += Frm_MouseUp;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.Location = new Point(430, 6);
            btnMinimize.Margin = new Padding(2);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(22, 24);
            btnMinimize.TabIndex = 1;
            btnMinimize.Text = "-";
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnToggleMaximize
            // 
            btnToggleMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnToggleMaximize.Location = new Point(455, 6);
            btnToggleMaximize.Margin = new Padding(2);
            btnToggleMaximize.Name = "btnToggleMaximize";
            btnToggleMaximize.Size = new Size(22, 24);
            btnToggleMaximize.TabIndex = 1;
            btnToggleMaximize.Text = "口";
            btnToggleMaximize.UseVisualStyleBackColor = true;
            btnToggleMaximize.Click += btnToggleMaximize_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Location = new Point(480, 6);
            btnClose.Margin = new Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(22, 24);
            btnClose.TabIndex = 1;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 23F);
            label1.Location = new Point(160, 6);
            label1.Name = "label1";
            label1.Size = new Size(203, 40);
            label1.TabIndex = 0;
            label1.Text = "课程管理系统";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Location = new Point(138, 136);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(56, 17);
            label2.TabIndex = 1;
            label2.Text = "用户名：";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Location = new Point(150, 175);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(44, 17);
            label3.TabIndex = 1;
            label3.Text = "密码：";
            // 
            // tbUser
            // 
            tbUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tbUser.Location = new Point(206, 130);
            tbUser.Margin = new Padding(2);
            tbUser.Name = "tbUser";
            tbUser.Size = new Size(132, 23);
            tbUser.TabIndex = 2;
            tbUser.TextChanged += tbUser_TextChanged;
            // 
            // tbPassword
            // 
            tbPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tbPassword.Location = new Point(206, 169);
            tbPassword.Margin = new Padding(2);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(132, 23);
            tbPassword.TabIndex = 2;
            tbPassword.UseSystemPasswordChar = true;
            tbPassword.TextChanged += tbPassword_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.None;
            btnLogin.BackColor = Color.LightSkyBlue;
            btnLogin.Enabled = false;
            btnLogin.Location = new Point(206, 228);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(132, 29);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "登录";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(125, 233);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(75, 21);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "记住密码";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // FrmAdminLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 319);
            Controls.Add(checkBox1);
            Controls.Add(btnLogin);
            Controls.Add(tbPassword);
            Controls.Add(tbUser);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(1);
            Name = "FrmAdminLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmAdminLogin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnClose;
        private Button btnMinimize;
        private Button btnToggleMaximize;
        private Label label2;
        private Label label3;
        private TextBox tbUser;
        private TextBox tbPassword;
        private Button btnLogin;
        private CheckBox checkBox1;
    }
}
