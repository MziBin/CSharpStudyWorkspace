namespace CourseManageUI
{
    partial class FrmMain
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
            btnMinimize = new Button();
            btnToggleMaximize = new Button();
            btnClose = new Button();
            panel1 = new Panel();
            label1 = new Label();
            monthCalendar1 = new MonthCalendar();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            btnCousreManage = new Button();
            btnAddCourse = new Button();
            panelleft = new Panel();
            panelRight = new Panel();
            panel1.SuspendLayout();
            panelleft.SuspendLayout();
            SuspendLayout();
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.Location = new Point(967, 9);
            btnMinimize.Margin = new Padding(2);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(22, 24);
            btnMinimize.TabIndex = 2;
            btnMinimize.Text = "-";
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnToggleMaximize
            // 
            btnToggleMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnToggleMaximize.Location = new Point(992, 9);
            btnToggleMaximize.Margin = new Padding(2);
            btnToggleMaximize.Name = "btnToggleMaximize";
            btnToggleMaximize.Size = new Size(22, 24);
            btnToggleMaximize.TabIndex = 3;
            btnToggleMaximize.Text = "口";
            btnToggleMaximize.UseVisualStyleBackColor = true;
            btnToggleMaximize.Click += btnToggleMaximize_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Location = new Point(1017, 9);
            btnClose.Margin = new Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(22, 24);
            btnClose.TabIndex = 4;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSkyBlue;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(btnMinimize);
            panel1.Controls.Add(btnToggleMaximize);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1039, 61);
            panel1.TabIndex = 5;
            panel1.MouseDown += Frm_MouseDown;
            panel1.MouseMove += Frm_MouseMove;
            panel1.MouseUp += Frm_MouseUp;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 22F);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(431, 9);
            label1.Name = "label1";
            label1.Size = new Size(251, 39);
            label1.TabIndex = 5;
            label1.Text = "课 程 管 理 系 统 ";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            monthCalendar1.Location = new Point(9, 9);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 6;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button5.Location = new Point(9, 424);
            button5.Name = "button5";
            button5.Size = new Size(220, 41);
            button5.TabIndex = 7;
            button5.Text = "退出登录";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button4.Location = new Point(12, 370);
            button4.Name = "button4";
            button4.Size = new Size(220, 41);
            button4.TabIndex = 7;
            button4.Text = "修改登录密码";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button3.Location = new Point(12, 316);
            button3.Name = "button3";
            button3.Size = new Size(220, 41);
            button3.TabIndex = 7;
            button3.Text = "讲师信息管理";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btnCousreManage
            // 
            btnCousreManage.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnCousreManage.Location = new Point(9, 208);
            btnCousreManage.Name = "btnCousreManage";
            btnCousreManage.Size = new Size(220, 41);
            btnCousreManage.TabIndex = 7;
            btnCousreManage.Text = "课程信息管理";
            btnCousreManage.UseVisualStyleBackColor = true;
            btnCousreManage.Click += btnCousreManage_Click;
            // 
            // btnAddCourse
            // 
            btnAddCourse.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnAddCourse.Location = new Point(9, 262);
            btnAddCourse.Name = "btnAddCourse";
            btnAddCourse.Size = new Size(220, 41);
            btnAddCourse.TabIndex = 7;
            btnAddCourse.Text = "添加课程信息";
            btnAddCourse.UseVisualStyleBackColor = true;
            btnAddCourse.Click += btnAddCourse_Click;
            // 
            // panelleft
            // 
            panelleft.Controls.Add(monthCalendar1);
            panelleft.Controls.Add(btnCousreManage);
            panelleft.Controls.Add(button3);
            panelleft.Controls.Add(button4);
            panelleft.Controls.Add(btnAddCourse);
            panelleft.Controls.Add(button5);
            panelleft.Dock = DockStyle.Left;
            panelleft.Location = new Point(0, 61);
            panelleft.Name = "panelleft";
            panelleft.Size = new Size(238, 479);
            panelleft.TabIndex = 8;
            // 
            // panelRight
            // 
            panelRight.BackColor = SystemColors.ButtonHighlight;
            panelRight.Dock = DockStyle.Right;
            panelRight.Location = new Point(244, 61);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(795, 479);
            panelRight.TabIndex = 9;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1039, 540);
            Controls.Add(panelRight);
            Controls.Add(panelleft);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMain";
            Text = "FrmMain";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelleft.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnMinimize;
        private Button btnToggleMaximize;
        private Button btnClose;
        private Panel panel1;
        private Label label1;
        private MonthCalendar monthCalendar1;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button btnCousreManage;
        private Button btnAddCourse;
        private Panel panelleft;
        private Panel panelRight;
    }
}