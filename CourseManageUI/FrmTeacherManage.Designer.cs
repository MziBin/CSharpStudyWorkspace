namespace CourseManageUI
{
    partial class FrmTeacherManage
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btnClose = new Button();
            button4 = new Button();
            label1 = new Label();
            button1 = new Button();
            dgvCourseList = new DataGridView();
            讲师姓名 = new DataGridViewTextBoxColumn();
            登录账号 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            联系电话 = new DataGridViewTextBoxColumn();
            现在住址 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCourseList).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 62);
            panel1.TabIndex = 2;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(671, 16);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(111, 29);
            btnClose.TabIndex = 7;
            btnClose.Text = "关闭窗口";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // button4
            // 
            button4.Location = new Point(554, 16);
            button4.Name = "button4";
            button4.Size = new Size(111, 29);
            button4.TabIndex = 7;
            button4.Text = "保存到数据库";
            button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 12F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(186, 21);
            label1.TabIndex = 0;
            label1.Text = "当前位置：导入讲师信息";
            // 
            // button1
            // 
            button1.Location = new Point(437, 16);
            button1.Name = "button1";
            button1.Size = new Size(111, 29);
            button1.TabIndex = 7;
            button1.Text = "打开Excel文件";
            button1.UseVisualStyleBackColor = true;
            // 
            // dgvCourseList
            // 
            dgvCourseList.AllowUserToAddRows = false;
            dgvCourseList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(192, 255, 255);
            dgvCourseList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvCourseList.BackgroundColor = SystemColors.ControlLightLight;
            dgvCourseList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Microsoft YaHei UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvCourseList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvCourseList.ColumnHeadersHeight = 39;
            dgvCourseList.Columns.AddRange(new DataGridViewColumn[] { 讲师姓名, 登录账号, Column1, 联系电话, 现在住址 });
            dgvCourseList.Dock = DockStyle.Bottom;
            dgvCourseList.EnableHeadersVisualStyles = false;
            dgvCourseList.GridColor = SystemColors.ControlLightLight;
            dgvCourseList.Location = new Point(0, 68);
            dgvCourseList.Name = "dgvCourseList";
            dgvCourseList.ReadOnly = true;
            dgvCourseList.Size = new Size(800, 382);
            dgvCourseList.TabIndex = 4;
            // 
            // 讲师姓名
            // 
            讲师姓名.HeaderText = "讲师姓名";
            讲师姓名.Name = "讲师姓名";
            讲师姓名.ReadOnly = true;
            // 
            // 登录账号
            // 
            登录账号.HeaderText = "登录账号";
            登录账号.Name = "登录账号";
            登录账号.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "登录密码";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // 联系电话
            // 
            联系电话.HeaderText = "联系电话";
            联系电话.Name = "联系电话";
            联系电话.ReadOnly = true;
            // 
            // 现在住址
            // 
            现在住址.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            现在住址.FillWeight = 200F;
            现在住址.HeaderText = "现在住址";
            现在住址.Name = "现在住址";
            现在住址.ReadOnly = true;
            // 
            // FrmTeacherManage
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvCourseList);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmTeacherManage";
            Text = "FrmTeacherManage";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCourseList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnClose;
        private Button button1;
        private Button button4;
        private Label label1;
        private DataGridView dgvCourseList;
        private DataGridViewTextBoxColumn 讲师姓名;
        private DataGridViewTextBoxColumn 登录账号;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn 联系电话;
        private DataGridViewTextBoxColumn 现在住址;
    }
}