using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;

namespace JSONStudy
{
    partial class JsonForm
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
            this.btnJSONImport = new System.Windows.Forms.Button();
            this.btnJSONExport = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnJSONImport
            // 
            this.btnJSONImport.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnJSONImport.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnJSONImport.FlatAppearance.BorderSize = 0;
            this.btnJSONImport.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnJSONImport.Location = new System.Drawing.Point(10, 10);
            this.btnJSONImport.Margin = new System.Windows.Forms.Padding(2);
            this.btnJSONImport.Name = "btnJSONImport";
            this.btnJSONImport.Size = new System.Drawing.Size(130, 39);
            this.btnJSONImport.TabIndex = 0;
            this.btnJSONImport.Text = "JSON导入";
            this.btnJSONImport.UseVisualStyleBackColor = false;
            this.btnJSONImport.Click += new System.EventHandler(this.btnJSONImport_Click);
            // 
            // btnJSONExport
            // 
            this.btnJSONExport.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnJSONExport.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnJSONExport.FlatAppearance.BorderSize = 0;
            this.btnJSONExport.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnJSONExport.Location = new System.Drawing.Point(572, 10);
            this.btnJSONExport.Margin = new System.Windows.Forms.Padding(2);
            this.btnJSONExport.Name = "btnJSONExport";
            this.btnJSONExport.Size = new System.Drawing.Size(130, 39);
            this.btnJSONExport.TabIndex = 0;
            this.btnJSONExport.Text = "JSON导出";
            this.btnJSONExport.UseVisualStyleBackColor = false;
            this.btnJSONExport.Click += new System.EventHandler(this.btnJSONExport_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 36);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(710, 364);
            this.dataGridView1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.btnJSONExport);
            this.panel1.Controls.Add(this.btnJSONImport);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 405);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(712, 59);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(712, 34);
            this.panel2.TabIndex = 3;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Frm_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Frm_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Frm_MouseUp);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClose.Location = new System.Drawing.Point(75, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 28);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.Location = new System.Drawing.Point(39, 3);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(30, 28);
            this.btnMax.TabIndex = 1;
            this.btnMax.Text = "口";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Location = new System.Drawing.Point(3, 3);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(30, 28);
            this.btnMin.TabIndex = 1;
            this.btnMin.Text = "-";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JSONStudy.Properties.Resources.jeteazy_log;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnMin);
            this.flowLayoutPanel1.Controls.Add(this.btnMax);
            this.flowLayoutPanel1.Controls.Add(this.btnClose);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(600, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(112, 34);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // JsonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 464);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "JsonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JsonForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        //圆角,第一次画面不生效，移动一下就生效了。
        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    GraphicsPath graphicsPath = new GraphicsPath();
        //    int radius = 10; // 圆角半径，可以根据需要调整
        //    graphicsPath.AddArc(0, 0, radius * 2, radius * 2, 180, 90);
        //    graphicsPath.AddArc(this.ClientSize.Width - radius * 2, 0, radius * 2, radius * 2, 270, 90);
        //    graphicsPath.AddArc(this.ClientSize.Width - radius * 2, this.ClientSize.Height - radius * 2, radius * 2, radius * 2, 0, 90);
        //    graphicsPath.AddArc(0, this.ClientSize.Height - radius * 2, radius * 2, radius * 2, 90, 90);
        //    graphicsPath.CloseFigure();
        //    this.Region = new Region(graphicsPath);
        //    base.OnPaint(e);
        //}
        #endregion

        private System.Windows.Forms.Button btnJSONImport;
        private System.Windows.Forms.Button btnJSONExport;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Button btnMax;
        private Button btnMin;
        private Button btnClose;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}

