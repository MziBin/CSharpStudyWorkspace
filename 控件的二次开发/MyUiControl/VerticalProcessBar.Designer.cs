namespace MyUiControl
{
    partial class VerticalProcessBar
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.labButton = new System.Windows.Forms.Label();
            this.labTop = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labButton
            // 
            this.labButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labButton.Location = new System.Drawing.Point(0, 0);
            this.labButton.Name = "labButton";
            this.labButton.Size = new System.Drawing.Size(15, 200);
            this.labButton.TabIndex = 0;
            // 
            // labTop
            // 
            this.labTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labTop.BackColor = System.Drawing.Color.SpringGreen;
            this.labTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labTop.Location = new System.Drawing.Point(-2, 130);
            this.labTop.Name = "labTop";
            this.labTop.Size = new System.Drawing.Size(17, 70);
            this.labTop.TabIndex = 0;
            // 
            // VerticalProcessBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labTop);
            this.Controls.Add(this.labButton);
            this.Name = "VerticalProcessBar";
            this.Size = new System.Drawing.Size(15, 200);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labButton;
        private System.Windows.Forms.Label labTop;
    }
}
