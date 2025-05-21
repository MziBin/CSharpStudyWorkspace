namespace CourseManageUI
{
    partial class FrmModifyPWD
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
            panel1 = new Panel();
            btnMinimize = new Button();
            btnToggleMaximize = new Button();
            btnClose = new Button();
            label1 = new Label();
            btnModifyPwdSave = new Button();
            tbPassword = new TextBox();
            tbUser = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            btnCancel = new Button();
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
            panel1.Size = new Size(510, 59);
            panel1.TabIndex = 0;
            panel1.MouseDown += Frm_MouseDown;
            panel1.MouseMove += Frm_MouseMove;
            panel1.MouseUp += Frm_MouseUp;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.Location = new Point(427, 11);
            btnMinimize.Margin = new Padding(2);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(22, 24);
            btnMinimize.TabIndex = 3;
            btnMinimize.Text = "-";
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnToggleMaximize
            // 
            btnToggleMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnToggleMaximize.Location = new Point(452, 11);
            btnToggleMaximize.Margin = new Padding(2);
            btnToggleMaximize.Name = "btnToggleMaximize";
            btnToggleMaximize.Size = new Size(22, 24);
            btnToggleMaximize.TabIndex = 4;
            btnToggleMaximize.Text = "口";
            btnToggleMaximize.UseVisualStyleBackColor = true;
            btnToggleMaximize.Click += btnToggleMaximize_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Location = new Point(477, 11);
            btnClose.Margin = new Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(22, 24);
            btnClose.TabIndex = 5;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 23F);
            label1.Location = new Point(162, 9);
            label1.Name = "label1";
            label1.Size = new Size(203, 40);
            label1.TabIndex = 2;
            label1.Text = "用户修改密码";
            // 
            // btnModifyPwdSave
            // 
            btnModifyPwdSave.Anchor = AnchorStyles.None;
            btnModifyPwdSave.Enabled = false;
            btnModifyPwdSave.Location = new Point(149, 243);
            btnModifyPwdSave.Name = "btnModifyPwdSave";
            btnModifyPwdSave.Size = new Size(92, 29);
            btnModifyPwdSave.TabIndex = 8;
            btnModifyPwdSave.Text = "提交修改";
            btnModifyPwdSave.UseVisualStyleBackColor = true;
            // 
            // tbPassword
            // 
            tbPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tbPassword.Location = new Point(211, 137);
            tbPassword.Margin = new Padding(2);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(132, 23);
            tbPassword.TabIndex = 6;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // tbUser
            // 
            tbUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tbUser.Location = new Point(211, 97);
            tbUser.Margin = new Padding(2);
            tbUser.Name = "tbUser";
            tbUser.Size = new Size(132, 23);
            tbUser.TabIndex = 7;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Location = new Point(151, 143);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(56, 17);
            label3.TabIndex = 4;
            label3.Text = "新密码：";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Location = new Point(151, 103);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(56, 17);
            label2.TabIndex = 5;
            label2.Text = "原密码：";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.Location = new Point(127, 183);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(80, 17);
            label4.TabIndex = 4;
            label4.Text = "新密码确认：";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textBox1.Location = new Point(211, 177);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(132, 23);
            textBox1.TabIndex = 6;
            textBox1.UseSystemPasswordChar = true;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.None;
            btnCancel.Enabled = false;
            btnCancel.Location = new Point(286, 243);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(92, 29);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "取消";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnClose_Click;
            // 
            // FrmModifyPWD
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 319);
            Controls.Add(btnCancel);
            Controls.Add(btnModifyPwdSave);
            Controls.Add(textBox1);
            Controls.Add(tbPassword);
            Controls.Add(label4);
            Controls.Add(tbUser);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmModifyPWD";
            Text = "FrmModifyPWD";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnMinimize;
        private Button btnToggleMaximize;
        private Button btnClose;
        private Label label1;
        private Button btnModifyPwdSave;
        private TextBox tbPassword;
        private TextBox tbUser;
        private Label label3;
        private Label label2;
        private Label label4;
        private TextBox textBox1;
        private Button btnCancel;
    }
}