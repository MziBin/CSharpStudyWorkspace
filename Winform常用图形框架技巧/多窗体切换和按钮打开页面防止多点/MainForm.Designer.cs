namespace 多窗体切换和按钮打开页面防止多点
{
    partial class MainForm
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
            this.btn_MainForm = new System.Windows.Forms.Button();
            this.btn_setting = new System.Windows.Forms.Button();
            this.btn_account = new System.Windows.Forms.Button();
            this.btn_data = new System.Windows.Forms.Button();
            this.btn_parameter = new System.Windows.Forms.Button();
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btn_MainForm
            // 
            this.btn_MainForm.BackColor = System.Drawing.SystemColors.Window;
            this.btn_MainForm.Location = new System.Drawing.Point(22, 12);
            this.btn_MainForm.Name = "btn_MainForm";
            this.btn_MainForm.Size = new System.Drawing.Size(90, 90);
            this.btn_MainForm.TabIndex = 0;
            this.btn_MainForm.Tag = "HomeForm";
            this.btn_MainForm.Text = "主页";
            this.btn_MainForm.UseVisualStyleBackColor = false;
            this.btn_MainForm.Click += new System.EventHandler(this.btn_MainForm_Click);
            // 
            // btn_setting
            // 
            this.btn_setting.BackColor = System.Drawing.SystemColors.Window;
            this.btn_setting.Location = new System.Drawing.Point(310, 12);
            this.btn_setting.Name = "btn_setting";
            this.btn_setting.Size = new System.Drawing.Size(90, 90);
            this.btn_setting.TabIndex = 0;
            this.btn_setting.Tag = "SettingForm";
            this.btn_setting.Text = "设置";
            this.btn_setting.UseVisualStyleBackColor = false;
            this.btn_setting.Click += new System.EventHandler(this.btn_setting_Click);
            // 
            // btn_account
            // 
            this.btn_account.BackColor = System.Drawing.SystemColors.Window;
            this.btn_account.Location = new System.Drawing.Point(118, 12);
            this.btn_account.Name = "btn_account";
            this.btn_account.Size = new System.Drawing.Size(90, 90);
            this.btn_account.TabIndex = 0;
            this.btn_account.Tag = "AccountForm";
            this.btn_account.Text = "账号";
            this.btn_account.UseVisualStyleBackColor = false;
            this.btn_account.Click += new System.EventHandler(this.btn_account_Click);
            // 
            // btn_data
            // 
            this.btn_data.BackColor = System.Drawing.SystemColors.Window;
            this.btn_data.Location = new System.Drawing.Point(214, 12);
            this.btn_data.Name = "btn_data";
            this.btn_data.Size = new System.Drawing.Size(90, 90);
            this.btn_data.TabIndex = 0;
            this.btn_data.Tag = "DataForm";
            this.btn_data.Text = "数据";
            this.btn_data.UseVisualStyleBackColor = false;
            this.btn_data.Click += new System.EventHandler(this.btn_data_Click);
            // 
            // btn_parameter
            // 
            this.btn_parameter.BackColor = System.Drawing.SystemColors.Window;
            this.btn_parameter.Location = new System.Drawing.Point(1156, 12);
            this.btn_parameter.Name = "btn_parameter";
            this.btn_parameter.Size = new System.Drawing.Size(90, 90);
            this.btn_parameter.TabIndex = 0;
            this.btn_parameter.Text = "参数";
            this.btn_parameter.UseVisualStyleBackColor = false;
            this.btn_parameter.Click += new System.EventHandler(this.btn_parameter_Click);
            // 
            // pnl_Main
            // 
            this.pnl_Main.Location = new System.Drawing.Point(22, 108);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(1224, 624);
            this.pnl_Main.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1258, 744);
            this.Controls.Add(this.pnl_Main);
            this.Controls.Add(this.btn_parameter);
            this.Controls.Add(this.btn_data);
            this.Controls.Add(this.btn_account);
            this.Controls.Add(this.btn_setting);
            this.Controls.Add(this.btn_MainForm);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_MainForm;
        private System.Windows.Forms.Button btn_setting;
        private System.Windows.Forms.Button btn_account;
        private System.Windows.Forms.Button btn_data;
        private System.Windows.Forms.Button btn_parameter;
        private System.Windows.Forms.Panel pnl_Main;
    }
}

