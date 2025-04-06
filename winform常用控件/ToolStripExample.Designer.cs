namespace winform常用控件
{
    partial class ToolStripExample
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolStripExample));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripSeparator();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.qqqToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qqqToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.qqqToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.qqqqToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qqqqToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.qqqToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(1266, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(36, 740);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(31, 28);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(31, 6);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.AutoSize = false;
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qqqToolStripMenuItem,
            this.qqqToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(241, 97);
            // 
            // qqqToolStripMenuItem
            // 
            this.qqqToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qqqToolStripMenuItem2});
            this.qqqToolStripMenuItem.Name = "qqqToolStripMenuItem";
            this.qqqToolStripMenuItem.Size = new System.Drawing.Size(116, 30);
            this.qqqToolStripMenuItem.Text = "qqq";
            // 
            // qqqToolStripMenuItem1
            // 
            this.qqqToolStripMenuItem1.Name = "qqqToolStripMenuItem1";
            this.qqqToolStripMenuItem1.Size = new System.Drawing.Size(116, 30);
            this.qqqToolStripMenuItem1.Text = "qqq";
            // 
            // qqqToolStripMenuItem2
            // 
            this.qqqToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qqqqToolStripMenuItem});
            this.qqqToolStripMenuItem2.Name = "qqqToolStripMenuItem2";
            this.qqqToolStripMenuItem2.Size = new System.Drawing.Size(270, 34);
            this.qqqToolStripMenuItem2.Text = "qqq";
            // 
            // qqqqToolStripMenuItem
            // 
            this.qqqqToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qqqqToolStripMenuItem1});
            this.qqqqToolStripMenuItem.Name = "qqqqToolStripMenuItem";
            this.qqqqToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.qqqqToolStripMenuItem.Text = "qqqq";
            // 
            // qqqqToolStripMenuItem1
            // 
            this.qqqqToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qqqToolStripMenuItem3});
            this.qqqqToolStripMenuItem1.Name = "qqqqToolStripMenuItem1";
            this.qqqqToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.qqqqToolStripMenuItem1.Text = "qqqq";
            // 
            // qqqToolStripMenuItem3
            // 
            this.qqqToolStripMenuItem3.Name = "qqqToolStripMenuItem3";
            this.qqqToolStripMenuItem3.Size = new System.Drawing.Size(270, 34);
            this.qqqToolStripMenuItem3.Text = "qqq";
            // 
            // button1
            // 
            this.button1.ContextMenuStrip = this.contextMenuStrip1;
            this.button1.Location = new System.Drawing.Point(343, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 52);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ToolStripExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 740);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ToolStripExample";
            this.Text = "ToolStripExample";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripButton2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem qqqToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qqqToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem qqqqToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qqqqToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem qqqToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem qqqToolStripMenuItem1;
        private System.Windows.Forms.Button button1;
    }
}