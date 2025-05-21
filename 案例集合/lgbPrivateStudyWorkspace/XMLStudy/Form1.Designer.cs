namespace XMLStudy
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
            this.btnXMLImport = new System.Windows.Forms.Button();
            this.btnXMLExport = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXMLImport
            // 
            this.btnXMLImport.Location = new System.Drawing.Point(12, 378);
            this.btnXMLImport.Name = "btnXMLImport";
            this.btnXMLImport.Size = new System.Drawing.Size(181, 60);
            this.btnXMLImport.TabIndex = 0;
            this.btnXMLImport.Text = "XML导入";
            this.btnXMLImport.UseVisualStyleBackColor = true;
            this.btnXMLImport.Click += new System.EventHandler(this.btnXMLImport_Click);
            // 
            // btnXMLExport
            // 
            this.btnXMLExport.Location = new System.Drawing.Point(635, 378);
            this.btnXMLExport.Name = "btnXMLExport";
            this.btnXMLExport.Size = new System.Drawing.Size(136, 60);
            this.btnXMLExport.TabIndex = 0;
            this.btnXMLExport.Text = "XML导出";
            this.btnXMLExport.UseVisualStyleBackColor = true;
            this.btnXMLExport.Click += new System.EventHandler(this.btnXMLExport_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(776, 360);
            this.dataGridView1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnXMLExport);
            this.Controls.Add(this.btnXMLImport);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnXMLImport;
        private System.Windows.Forms.Button btnXMLExport;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

