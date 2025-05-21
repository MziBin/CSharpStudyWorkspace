namespace CourseManageUI
{
    partial class FrmAddCourse
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
            label5 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            checkBox1 = new CheckBox();
            textBox2 = new TextBox();
            label6 = new Label();
            textBox3 = new TextBox();
            label7 = new Label();
            textBox4 = new TextBox();
            label8 = new Label();
            dgvCourseList = new DataGridView();
            课程名称 = new DataGridViewTextBoxColumn();
            课时 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            课程分类 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCourseList).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 62);
            panel1.TabIndex = 1;
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(382, 22);
            label5.Name = "label5";
            label5.Size = new Size(15, 17);
            label5.TabIndex = 6;
            label5.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI", 10F);
            label4.Location = new Point(244, 20);
            label4.Name = "label4";
            label4.Size = new Size(121, 20);
            label4.TabIndex = 5;
            label4.Text = "已添加课程总数：";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(86, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(181, 23);
            textBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 38);
            label3.Name = "label3";
            label3.Size = new Size(68, 17);
            label3.TabIndex = 1;
            label3.Text = "课程名称：";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(604, 70);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(178, 25);
            comboBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(530, 73);
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
            label1.Text = "当前位置：新增课程";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Location = new Point(0, 68);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(800, 122);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "[课程信息]";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(77, 0);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(135, 21);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "添加后自动清除文本";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(373, 32);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(108, 23);
            textBox2.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(299, 35);
            label6.Name = "label6";
            label6.Size = new Size(68, 17);
            label6.TabIndex = 1;
            label6.Text = "课程总时：";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(604, 35);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(178, 23);
            textBox3.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(530, 37);
            label7.Name = "label7";
            label7.Size = new Size(68, 17);
            label7.TabIndex = 1;
            label7.Text = "课程学分：";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(86, 75);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(395, 23);
            textBox4.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 78);
            label8.Name = "label8";
            label8.Size = new Size(68, 17);
            label8.TabIndex = 1;
            label8.Text = "内容概述：";
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
            dgvCourseList.Columns.AddRange(new DataGridViewColumn[] { 课程名称, 课时, Column1, Column2, 课程分类, Column3 });
            dgvCourseList.Dock = DockStyle.Bottom;
            dgvCourseList.EnableHeadersVisualStyles = false;
            dgvCourseList.GridColor = SystemColors.ControlLightLight;
            dgvCourseList.Location = new Point(0, 196);
            dgvCourseList.Name = "dgvCourseList";
            dgvCourseList.ReadOnly = true;
            dgvCourseList.Size = new Size(800, 254);
            dgvCourseList.TabIndex = 3;
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
            // 课程分类
            // 
            课程分类.FillWeight = 200F;
            课程分类.HeaderText = "课程分类";
            课程分类.Name = "课程分类";
            课程分类.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "CourseId";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Visible = false;
            // 
            // FrmAddCourse
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvCourseList);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmAddCourse";
            Text = "FrmAddCourse";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCourseList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnClose;
        private Button button4;
        private Label label5;
        private Label label4;
        private Label label1;
        private TextBox textBox1;
        private Label label3;
        private ComboBox comboBox1;
        private Label label2;
        private GroupBox groupBox1;
        private CheckBox checkBox1;
        private Label label8;
        private TextBox textBox4;
        private Label label7;
        private TextBox textBox3;
        private Label label6;
        private TextBox textBox2;
        private DataGridView dgvCourseList;
        private DataGridViewTextBoxColumn 课程名称;
        private DataGridViewTextBoxColumn 课时;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn 课程分类;
        private DataGridViewTextBoxColumn Column3;
    }
}