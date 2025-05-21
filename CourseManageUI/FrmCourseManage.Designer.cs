namespace CourseManageUI
{
    partial class FrmCourseManage
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
            button3 = new Button();
            button2 = new Button();
            label5 = new Label();
            label4 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            dgvCourseList = new DataGridView();
            课程名称 = new DataGridViewTextBoxColumn();
            课时 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            课程讲师 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            button7 = new Button();
            button6 = new Button();
            groupBox1 = new GroupBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox5 = new TextBox();
            textBox2 = new TextBox();
            comboBox2 = new ComboBox();
            label10 = new Label();
            label12 = new Label();
            label11 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCourseList).BeginInit();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 115);
            panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(654, 16);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(111, 29);
            btnClose.TabIndex = 7;
            btnClose.Text = "关闭窗口";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // button4
            // 
            button4.Location = new Point(517, 16);
            button4.Name = "button4";
            button4.Size = new Size(111, 29);
            button4.TabIndex = 7;
            button4.Text = "删除课程";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(380, 16);
            button3.Name = "button3";
            button3.Size = new Size(111, 29);
            button3.TabIndex = 7;
            button3.Text = "修改课程";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(243, 16);
            button2.Name = "button2";
            button2.Size = new Size(111, 29);
            button2.TabIndex = 7;
            button2.Text = "添加课程";
            button2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(751, 76);
            label5.Name = "label5";
            label5.Size = new Size(15, 17);
            label5.TabIndex = 6;
            label5.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI", 10F);
            label4.Location = new Point(666, 74);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 5;
            label4.Text = "查询总数：";
            // 
            // button1
            // 
            button1.Location = new Point(517, 70);
            button1.Name = "button1";
            button1.Size = new Size(111, 29);
            button1.TabIndex = 4;
            button1.Text = "提交查询";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(312, 73);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(148, 23);
            textBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(238, 76);
            label3.Name = "label3";
            label3.Size = new Size(68, 17);
            label3.TabIndex = 1;
            label3.Text = "课程名称：";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(84, 72);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(148, 25);
            comboBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 76);
            label2.Name = "label2";
            label2.Size = new Size(68, 17);
            label2.TabIndex = 1;
            label2.Text = "课程分类：";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 12F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(154, 21);
            label1.TabIndex = 0;
            label1.Text = "当前位置：课程管理";
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
            dgvCourseList.Columns.AddRange(new DataGridViewColumn[] { 课程名称, 课时, Column1, Column2, 课程讲师, Column3 });
            dgvCourseList.EnableHeadersVisualStyles = false;
            dgvCourseList.GridColor = SystemColors.ControlLightLight;
            dgvCourseList.Location = new Point(10, 121);
            dgvCourseList.Name = "dgvCourseList";
            dgvCourseList.ReadOnly = true;
            dgvCourseList.Size = new Size(778, 317);
            dgvCourseList.TabIndex = 1;
            // 
            // 课程名称
            // 
            课程名称.HeaderText = "课程名称";
            课程名称.Name = "课程名称";
            课程名称.ReadOnly = true;
            // 
            // 课时
            // 
            课时.HeaderText = "课时";
            课时.Name = "课时";
            课时.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "学分";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "内容概述";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // 课程讲师
            // 
            课程讲师.FillWeight = 200F;
            课程讲师.HeaderText = "课程讲师";
            课程讲师.Name = "课程讲师";
            课程讲师.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "CourseId";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Visible = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(button7);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 263);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 187);
            panel2.TabIndex = 2;
            panel2.Visible = false;
            // 
            // button7
            // 
            button7.Location = new Point(666, 31);
            button7.Name = "button7";
            button7.Size = new Size(111, 29);
            button7.TabIndex = 7;
            button7.Text = "退出修改";
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(529, 31);
            button6.Name = "button6";
            button6.Size = new Size(111, 29);
            button6.TabIndex = 7;
            button6.Text = "提交修改";
            button6.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Location = new Point(12, 66);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 109);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "课程信息";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(594, 30);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(121, 23);
            textBox4.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(358, 27);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(121, 23);
            textBox3.TabIndex = 2;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(113, 78);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(366, 23);
            textBox5.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(113, 27);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(121, 23);
            textBox2.TabIndex = 2;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(594, 76);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(154, 25);
            comboBox2.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(520, 30);
            label10.Name = "label10";
            label10.Size = new Size(68, 17);
            label10.TabIndex = 0;
            label10.Text = "课程学分：";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(520, 79);
            label12.Name = "label12";
            label12.Size = new Size(68, 17);
            label12.TabIndex = 0;
            label12.Text = "课程分类：";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(39, 82);
            label11.Name = "label11";
            label11.Size = new Size(68, 17);
            label11.TabIndex = 0;
            label11.Text = "内容概述：";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(284, 30);
            label9.Name = "label9";
            label9.Size = new Size(68, 17);
            label9.TabIndex = 0;
            label9.Text = "课时总数：";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(39, 30);
            label8.Name = "label8";
            label8.Size = new Size(68, 17);
            label8.TabIndex = 0;
            label8.Text = "课程名称：";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft YaHei UI", 12F);
            label7.Location = new Point(108, 15);
            label7.Name = "label7";
            label7.Size = new Size(64, 21);
            label7.TabIndex = 1;
            label7.Text = "000000";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft YaHei UI", 12F);
            label6.Location = new Point(12, 15);
            label6.Name = "label6";
            label6.Size = new Size(90, 21);
            label6.TabIndex = 0;
            label6.Text = "课程编号：";
            // 
            // FrmCourseManage
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(dgvCourseList);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCourseManage";
            Text = "FrmCourseManage";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCourseList).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label4;
        private Button button1;
        private TextBox textBox1;
        private Label label3;
        private ComboBox comboBox1;
        private Button btnClose;
        private Button button4;
        private Button button3;
        private Button button2;
        private DataGridView dgvCourseList;
        private DataGridViewTextBoxColumn 课程名称;
        private DataGridViewTextBoxColumn 课时;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn 课程讲师;
        private DataGridViewTextBoxColumn Column3;
        private Panel panel2;
        private Label label6;
        private GroupBox groupBox1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox5;
        private TextBox textBox2;
        private ComboBox comboBox2;
        private Label label10;
        private Label label12;
        private Label label11;
        private Label label9;
        private Label label8;
        private Label label7;
        private Button button7;
        private Button button6;
    }
}