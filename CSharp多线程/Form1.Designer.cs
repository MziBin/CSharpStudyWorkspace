﻿namespace CSharp多线程
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labNum1 = new System.Windows.Forms.Label();
            this.labNum2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(147, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 71);
            this.button1.TabIndex = 1;
            this.button1.Text = "开启";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(416, 219);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 71);
            this.button2.TabIndex = 2;
            this.button2.Text = "销毁";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "主线程控制：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "次线程控制：";
            // 
            // labNum1
            // 
            this.labNum1.AutoSize = true;
            this.labNum1.Location = new System.Drawing.Point(228, 88);
            this.labNum1.Name = "labNum1";
            this.labNum1.Size = new System.Drawing.Size(11, 12);
            this.labNum1.TabIndex = 4;
            this.labNum1.Text = "0";
            // 
            // labNum2
            // 
            this.labNum2.AutoSize = true;
            this.labNum2.Location = new System.Drawing.Point(228, 124);
            this.labNum2.Name = "labNum2";
            this.labNum2.Size = new System.Drawing.Size(11, 12);
            this.labNum2.TabIndex = 4;
            this.labNum2.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labNum2);
            this.Controls.Add(this.labNum1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labNum1;
        private System.Windows.Forms.Label labNum2;
    }
}

