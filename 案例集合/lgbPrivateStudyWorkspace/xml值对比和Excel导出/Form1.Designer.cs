namespace xml值对比
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
            this.label1 = new System.Windows.Forms.Label();
            this.XMLCount = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rowCount = new System.Windows.Forms.Label();
            this.colCount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rowMax = new System.Windows.Forms.Label();
            this.rowMin = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.colMax = new System.Windows.Forms.Label();
            this.colMin = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.angleMax = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.angleMin = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.PointY = new System.Windows.Forms.TextBox();
            this.PointX = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.difference = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.checkRowMax = new System.Windows.Forms.Label();
            this.checkColMax = new System.Windows.Forms.Label();
            this.checkAngleMax = new System.Windows.Forms.Label();
            this.checkAngleMin = new System.Windows.Forms.Label();
            this.checkRowMin = new System.Windows.Forms.Label();
            this.checkColMin = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "对比文件个数：";
            // 
            // XMLCount
            // 
            this.XMLCount.AutoSize = true;
            this.XMLCount.Location = new System.Drawing.Point(168, 22);
            this.XMLCount.Name = "XMLCount";
            this.XMLCount.Size = new System.Drawing.Size(17, 18);
            this.XMLCount.TabIndex = 1;
            this.XMLCount.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(548, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 55);
            this.button1.TabIndex = 2;
            this.button1.Text = "选择XML文件";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "对比行数：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "对比列数：";
            // 
            // rowCount
            // 
            this.rowCount.AutoSize = true;
            this.rowCount.Location = new System.Drawing.Point(168, 115);
            this.rowCount.Name = "rowCount";
            this.rowCount.Size = new System.Drawing.Size(17, 18);
            this.rowCount.TabIndex = 5;
            this.rowCount.Text = "0";
            // 
            // colCount
            // 
            this.colCount.AutoSize = true;
            this.colCount.Location = new System.Drawing.Point(435, 115);
            this.colCount.Name = "colCount";
            this.colCount.Size = new System.Drawing.Size(17, 18);
            this.colCount.TabIndex = 5;
            this.colCount.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "行相差最大值：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(295, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 18);
            this.label7.TabIndex = 4;
            this.label7.Text = "行相差最小值：";
            // 
            // rowMax
            // 
            this.rowMax.AutoSize = true;
            this.rowMax.Location = new System.Drawing.Point(168, 159);
            this.rowMax.Name = "rowMax";
            this.rowMax.Size = new System.Drawing.Size(17, 18);
            this.rowMax.TabIndex = 5;
            this.rowMax.Text = "0";
            // 
            // rowMin
            // 
            this.rowMin.AutoSize = true;
            this.rowMin.Location = new System.Drawing.Point(435, 159);
            this.rowMin.Name = "rowMin";
            this.rowMin.Size = new System.Drawing.Size(17, 18);
            this.rowMin.TabIndex = 5;
            this.rowMin.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 196);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 18);
            this.label10.TabIndex = 3;
            this.label10.Text = "列相差最大值：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(295, 196);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 18);
            this.label11.TabIndex = 4;
            this.label11.Text = "列相差最小值：";
            // 
            // colMax
            // 
            this.colMax.AutoSize = true;
            this.colMax.Location = new System.Drawing.Point(168, 196);
            this.colMax.Name = "colMax";
            this.colMax.Size = new System.Drawing.Size(17, 18);
            this.colMax.TabIndex = 5;
            this.colMax.Text = "0";
            // 
            // colMin
            // 
            this.colMin.AutoSize = true;
            this.colMin.Location = new System.Drawing.Point(435, 196);
            this.colMin.Name = "colMin";
            this.colMin.Size = new System.Drawing.Size(17, 18);
            this.colMin.TabIndex = 5;
            this.colMin.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(28, 236);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(134, 18);
            this.label14.TabIndex = 3;
            this.label14.Text = "角度最大差值：";
            // 
            // angleMax
            // 
            this.angleMax.AutoSize = true;
            this.angleMax.Location = new System.Drawing.Point(168, 236);
            this.angleMax.Name = "angleMax";
            this.angleMax.Size = new System.Drawing.Size(17, 18);
            this.angleMax.TabIndex = 5;
            this.angleMax.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(295, 236);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(134, 18);
            this.label16.TabIndex = 3;
            this.label16.Text = "角度最小差值：";
            // 
            // angleMin
            // 
            this.angleMin.AutoSize = true;
            this.angleMin.Location = new System.Drawing.Point(435, 236);
            this.angleMin.Name = "angleMin";
            this.angleMin.Size = new System.Drawing.Size(17, 18);
            this.angleMin.TabIndex = 5;
            this.angleMin.Text = "0";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(548, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 51);
            this.button2.TabIndex = 6;
            this.button2.Text = "清空数据文件";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(548, 220);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(186, 51);
            this.button3.TabIndex = 7;
            this.button3.Text = "选择XML导出Excel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(548, 163);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(186, 51);
            this.button4.TabIndex = 6;
            this.button4.Text = "导出现有文件为Exel";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 294);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 18);
            this.label8.TabIndex = 10;
            this.label8.Text = "数据校验";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 353);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "左上角X坐标：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(276, 346);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 18);
            this.label12.TabIndex = 8;
            this.label12.Text = "左上角Y坐标：";
            // 
            // PointY
            // 
            this.PointY.Location = new System.Drawing.Point(407, 346);
            this.PointY.Name = "PointY";
            this.PointY.Size = new System.Drawing.Size(105, 28);
            this.PointY.TabIndex = 9;
            // 
            // PointX
            // 
            this.PointX.Location = new System.Drawing.Point(152, 343);
            this.PointX.Name = "PointX";
            this.PointX.Size = new System.Drawing.Size(105, 28);
            this.PointX.TabIndex = 9;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(548, 393);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(187, 42);
            this.button5.TabIndex = 6;
            this.button5.Text = "导出对比数据";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "间隔差值：";
            // 
            // difference
            // 
            this.difference.Location = new System.Drawing.Point(253, 291);
            this.difference.Name = "difference";
            this.difference.Size = new System.Drawing.Size(90, 28);
            this.difference.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 401);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "行相差最大值：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(28, 438);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(134, 18);
            this.label13.TabIndex = 3;
            this.label13.Text = "列相差最大值：";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(28, 478);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(134, 18);
            this.label15.TabIndex = 3;
            this.label15.Text = "角度最大差值：";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(295, 478);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(134, 18);
            this.label17.TabIndex = 3;
            this.label17.Text = "角度最小差值：";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(295, 401);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(134, 18);
            this.label18.TabIndex = 4;
            this.label18.Text = "行相差最小值：";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(295, 438);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(134, 18);
            this.label19.TabIndex = 4;
            this.label19.Text = "列相差最小值：";
            // 
            // checkRowMax
            // 
            this.checkRowMax.AutoSize = true;
            this.checkRowMax.Location = new System.Drawing.Point(168, 401);
            this.checkRowMax.Name = "checkRowMax";
            this.checkRowMax.Size = new System.Drawing.Size(17, 18);
            this.checkRowMax.TabIndex = 5;
            this.checkRowMax.Text = "0";
            // 
            // checkColMax
            // 
            this.checkColMax.AutoSize = true;
            this.checkColMax.Location = new System.Drawing.Point(168, 438);
            this.checkColMax.Name = "checkColMax";
            this.checkColMax.Size = new System.Drawing.Size(17, 18);
            this.checkColMax.TabIndex = 5;
            this.checkColMax.Text = "0";
            // 
            // checkAngleMax
            // 
            this.checkAngleMax.AutoSize = true;
            this.checkAngleMax.Location = new System.Drawing.Point(168, 478);
            this.checkAngleMax.Name = "checkAngleMax";
            this.checkAngleMax.Size = new System.Drawing.Size(17, 18);
            this.checkAngleMax.TabIndex = 5;
            this.checkAngleMax.Text = "0";
            // 
            // checkAngleMin
            // 
            this.checkAngleMin.AutoSize = true;
            this.checkAngleMin.Location = new System.Drawing.Point(435, 478);
            this.checkAngleMin.Name = "checkAngleMin";
            this.checkAngleMin.Size = new System.Drawing.Size(17, 18);
            this.checkAngleMin.TabIndex = 5;
            this.checkAngleMin.Text = "0";
            // 
            // checkRowMin
            // 
            this.checkRowMin.AutoSize = true;
            this.checkRowMin.Location = new System.Drawing.Point(435, 401);
            this.checkRowMin.Name = "checkRowMin";
            this.checkRowMin.Size = new System.Drawing.Size(17, 18);
            this.checkRowMin.TabIndex = 5;
            this.checkRowMin.Text = "0";
            // 
            // checkColMin
            // 
            this.checkColMin.AutoSize = true;
            this.checkColMin.Location = new System.Drawing.Point(435, 438);
            this.checkColMin.Name = "checkColMin";
            this.checkColMin.Size = new System.Drawing.Size(17, 18);
            this.checkColMin.TabIndex = 5;
            this.checkColMin.Text = "0";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(548, 338);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(187, 42);
            this.button6.TabIndex = 11;
            this.button6.Text = "校验";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(548, 454);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(187, 42);
            this.button7.TabIndex = 6;
            this.button7.Text = "清空校验数据";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 629);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.PointY);
            this.Controls.Add(this.difference);
            this.Controls.Add(this.PointX);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkColMin);
            this.Controls.Add(this.colMin);
            this.Controls.Add(this.checkRowMin);
            this.Controls.Add(this.rowMin);
            this.Controls.Add(this.colCount);
            this.Controls.Add(this.checkAngleMin);
            this.Controls.Add(this.angleMin);
            this.Controls.Add(this.checkAngleMax);
            this.Controls.Add(this.angleMax);
            this.Controls.Add(this.checkColMax);
            this.Controls.Add(this.colMax);
            this.Controls.Add(this.checkRowMax);
            this.Controls.Add(this.rowMax);
            this.Controls.Add(this.rowCount);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.XMLCount);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "JetEazy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label XMLCount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label rowCount;
        private System.Windows.Forms.Label colCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label rowMax;
        private System.Windows.Forms.Label rowMin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label colMax;
        private System.Windows.Forms.Label colMin;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label angleMax;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label angleMin;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox PointX;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox PointY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox difference;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label checkRowMax;
        private System.Windows.Forms.Label checkColMax;
        private System.Windows.Forms.Label checkAngleMax;
        private System.Windows.Forms.Label checkAngleMin;
        private System.Windows.Forms.Label checkRowMin;
        private System.Windows.Forms.Label checkColMin;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}

