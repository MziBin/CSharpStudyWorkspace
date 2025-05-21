namespace SuperLottoRandomSelect
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labRed1 = new System.Windows.Forms.Label();
            this.labRed2 = new System.Windows.Forms.Label();
            this.labRed3 = new System.Windows.Forms.Label();
            this.labRed4 = new System.Windows.Forms.Label();
            this.labRed5 = new System.Windows.Forms.Label();
            this.labBlu1 = new System.Windows.Forms.Label();
            this.labBlu2 = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_select = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listBox_show = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(126)))), ((int)(((byte)(125)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(617, 70);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Frm_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Frm_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Frm_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(186, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "大乐透随机选号工具";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(126)))), ((int)(((byte)(125)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(579, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "×";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(28, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(554, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "大 乐 透 随 机 选 号 工 具";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labRed1
            // 
            this.labRed1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labRed1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labRed1.Image = ((System.Drawing.Image)(resources.GetObject("labRed1.Image")));
            this.labRed1.Location = new System.Drawing.Point(97, 165);
            this.labRed1.Name = "labRed1";
            this.labRed1.Size = new System.Drawing.Size(49, 45);
            this.labRed1.TabIndex = 2;
            this.labRed1.Text = "00";
            this.labRed1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labRed2
            // 
            this.labRed2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labRed2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labRed2.Image = ((System.Drawing.Image)(resources.GetObject("labRed2.Image")));
            this.labRed2.Location = new System.Drawing.Point(158, 165);
            this.labRed2.Name = "labRed2";
            this.labRed2.Size = new System.Drawing.Size(49, 45);
            this.labRed2.TabIndex = 2;
            this.labRed2.Text = "00";
            this.labRed2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labRed3
            // 
            this.labRed3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labRed3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labRed3.Image = ((System.Drawing.Image)(resources.GetObject("labRed3.Image")));
            this.labRed3.Location = new System.Drawing.Point(219, 165);
            this.labRed3.Name = "labRed3";
            this.labRed3.Size = new System.Drawing.Size(49, 45);
            this.labRed3.TabIndex = 2;
            this.labRed3.Text = "00";
            this.labRed3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labRed4
            // 
            this.labRed4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labRed4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labRed4.Image = ((System.Drawing.Image)(resources.GetObject("labRed4.Image")));
            this.labRed4.Location = new System.Drawing.Point(280, 165);
            this.labRed4.Name = "labRed4";
            this.labRed4.Size = new System.Drawing.Size(49, 45);
            this.labRed4.TabIndex = 2;
            this.labRed4.Text = "00";
            this.labRed4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labRed5
            // 
            this.labRed5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labRed5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labRed5.Image = ((System.Drawing.Image)(resources.GetObject("labRed5.Image")));
            this.labRed5.Location = new System.Drawing.Point(341, 165);
            this.labRed5.Name = "labRed5";
            this.labRed5.Size = new System.Drawing.Size(49, 45);
            this.labRed5.TabIndex = 2;
            this.labRed5.Text = "00";
            this.labRed5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labBlu1
            // 
            this.labBlu1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labBlu1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labBlu1.Image = ((System.Drawing.Image)(resources.GetObject("labBlu1.Image")));
            this.labBlu1.Location = new System.Drawing.Point(402, 165);
            this.labBlu1.Name = "labBlu1";
            this.labBlu1.Size = new System.Drawing.Size(49, 45);
            this.labBlu1.TabIndex = 2;
            this.labBlu1.Text = "00";
            this.labBlu1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labBlu2
            // 
            this.labBlu2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labBlu2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labBlu2.Image = ((System.Drawing.Image)(resources.GetObject("labBlu2.Image")));
            this.labBlu2.Location = new System.Drawing.Point(463, 165);
            this.labBlu2.Name = "labBlu2";
            this.labBlu2.Size = new System.Drawing.Size(49, 45);
            this.labBlu2.TabIndex = 2;
            this.labBlu2.Text = "00";
            this.labBlu2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(123)))));
            this.btn_start.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(123)))));
            this.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_start.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_start.Location = new System.Drawing.Point(63, 262);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(100, 35);
            this.btn_start.TabIndex = 3;
            this.btn_start.Text = "启动";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_select
            // 
            this.btn_select.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(123)))));
            this.btn_select.Enabled = false;
            this.btn_select.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(123)))));
            this.btn_select.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_select.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_select.Location = new System.Drawing.Point(191, 262);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(100, 35);
            this.btn_select.TabIndex = 3;
            this.btn_select.Text = "选择";
            this.btn_select.UseVisualStyleBackColor = false;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(123)))));
            this.btn_clear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(123)))));
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_clear.Location = new System.Drawing.Point(319, 262);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(100, 35);
            this.btn_clear.TabIndex = 3;
            this.btn_clear.Text = "清除";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(123)))));
            this.btn_ok.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(123)))));
            this.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ok.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ok.Location = new System.Drawing.Point(447, 262);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(100, 35);
            this.btn_ok.TabIndex = 3;
            this.btn_ok.Text = "确认购买";
            this.btn_ok.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // listBox_show
            // 
            this.listBox_show.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(123)))));
            this.listBox_show.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_show.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBox_show.ForeColor = System.Drawing.SystemColors.Window;
            this.listBox_show.FormattingEnabled = true;
            this.listBox_show.ItemHeight = 26;
            this.listBox_show.Location = new System.Drawing.Point(35, 363);
            this.listBox_show.Name = "listBox_show";
            this.listBox_show.Size = new System.Drawing.Size(547, 286);
            this.listBox_show.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(617, 668);
            this.Controls.Add(this.listBox_show);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.labBlu2);
            this.Controls.Add(this.labBlu1);
            this.Controls.Add(this.labRed5);
            this.Controls.Add(this.labRed4);
            this.Controls.Add(this.labRed3);
            this.Controls.Add(this.labRed2);
            this.Controls.Add(this.labRed1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labRed1;
        private System.Windows.Forms.Label labRed2;
        private System.Windows.Forms.Label labRed3;
        private System.Windows.Forms.Label labRed4;
        private System.Windows.Forms.Label labRed5;
        private System.Windows.Forms.Label labBlu1;
        private System.Windows.Forms.Label labBlu2;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox listBox_show;
    }
}

