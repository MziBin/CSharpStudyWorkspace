namespace TaskDemo
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
            this.components = new System.ComponentModel.Container();
            this.rbAuto = new System.Windows.Forms.RadioButton();
            this.rbManual = new System.Windows.Forms.RadioButton();
            this.rbStep = new System.Windows.Forms.RadioButton();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnSetpRun = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnEMO = new System.Windows.Forms.Button();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.lblTask01 = new System.Windows.Forms.Label();
            this.lblTask02 = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // rbAuto
            // 
            this.rbAuto.AutoSize = true;
            this.rbAuto.Location = new System.Drawing.Point(14, 234);
            this.rbAuto.Name = "rbAuto";
            this.rbAuto.Size = new System.Drawing.Size(71, 16);
            this.rbAuto.TabIndex = 0;
            this.rbAuto.TabStop = true;
            this.rbAuto.Text = "自动模式";
            this.rbAuto.UseVisualStyleBackColor = true;
            // 
            // rbManual
            // 
            this.rbManual.AutoSize = true;
            this.rbManual.Location = new System.Drawing.Point(14, 256);
            this.rbManual.Name = "rbManual";
            this.rbManual.Size = new System.Drawing.Size(71, 16);
            this.rbManual.TabIndex = 0;
            this.rbManual.TabStop = true;
            this.rbManual.Text = "手动模式";
            this.rbManual.UseVisualStyleBackColor = true;
            // 
            // rbStep
            // 
            this.rbStep.AutoSize = true;
            this.rbStep.Location = new System.Drawing.Point(14, 278);
            this.rbStep.Name = "rbStep";
            this.rbStep.Size = new System.Drawing.Size(71, 16);
            this.rbStep.TabIndex = 0;
            this.rbStep.TabStop = true;
            this.rbStep.Text = "单步模式";
            this.rbStep.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(596, 213);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "全局启动";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(677, 213);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 1;
            this.btnPause.Text = "暂停运行";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnSetpRun
            // 
            this.btnSetpRun.Location = new System.Drawing.Point(596, 242);
            this.btnSetpRun.Name = "btnSetpRun";
            this.btnSetpRun.Size = new System.Drawing.Size(75, 23);
            this.btnSetpRun.TabIndex = 1;
            this.btnSetpRun.Text = "单步执行";
            this.btnSetpRun.UseVisualStyleBackColor = true;
            this.btnSetpRun.Click += new System.EventHandler(this.btnStepRun_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(677, 242);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "全局复位";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnEMO
            // 
            this.btnEMO.Location = new System.Drawing.Point(596, 271);
            this.btnEMO.Name = "btnEMO";
            this.btnEMO.Size = new System.Drawing.Size(75, 23);
            this.btnEMO.TabIndex = 1;
            this.btnEMO.Text = "紧急停止";
            this.btnEMO.UseVisualStyleBackColor = true;
            this.btnEMO.Click += new System.EventHandler(this.btnEMO_Click);
            // 
            // btnClearLog
            // 
            this.btnClearLog.Location = new System.Drawing.Point(677, 271);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(75, 23);
            this.btnClearLog.TabIndex = 1;
            this.btnClearLog.Text = "清空日志";
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // lblTask01
            // 
            this.lblTask01.AutoSize = true;
            this.lblTask01.Location = new System.Drawing.Point(12, 10);
            this.lblTask01.Name = "lblTask01";
            this.lblTask01.Size = new System.Drawing.Size(53, 12);
            this.lblTask01.TabIndex = 2;
            this.lblTask01.Text = "Task01：";
            // 
            // lblTask02
            // 
            this.lblTask02.AutoSize = true;
            this.lblTask02.Location = new System.Drawing.Point(12, 36);
            this.lblTask02.Name = "lblTask02";
            this.lblTask02.Size = new System.Drawing.Size(53, 12);
            this.lblTask02.TabIndex = 2;
            this.lblTask02.Text = "Task02：";
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(12, 300);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(740, 213);
            this.txtLog.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 525);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.lblTask02);
            this.Controls.Add(this.lblTask01);
            this.Controls.Add(this.btnClearLog);
            this.Controls.Add(this.btnEMO);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSetpRun);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.rbStep);
            this.Controls.Add(this.rbManual);
            this.Controls.Add(this.rbAuto);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbAuto;
        private System.Windows.Forms.RadioButton rbManual;
        private System.Windows.Forms.RadioButton rbStep;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnSetpRun;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnEMO;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.Label lblTask01;
        private System.Windows.Forms.Label lblTask02;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Timer timer1;
    }
}

