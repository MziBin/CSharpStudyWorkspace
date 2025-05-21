using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 重写OnPaint方法，进行自定义绘制，会一直调用
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            //调用父类的OnPaint方法，以确保之前的控件的正常绘制
            base.OnPaint(e);
            //获取绘图对象，用于在窗体上绘制图形，相当于画布
            Graphics g = e.Graphics;

            // pen相当于画笔，设置颜色和宽度
            Pen pen = new Pen(Color.Red, 2);
            // 绘制线条
            g.DrawLine(pen, 10, 10, 100, 10);

            // 绘制矩形
            g.DrawRectangle(pen, 10, 30, 100, 50);

            // 填充矩形
            SolidBrush brush = new SolidBrush(Color.Blue);
            g.FillRectangle(brush, 120, 30, 100, 50);

            // 绘制文本
            Font font = new Font("Arial", 12);
            SolidBrush textBrush = new SolidBrush(Color.Black);
            g.DrawString("Hello, GDI+!", font, textBrush, 10, 100);

            // 加载并绘制图像
            try
            {
                Image image = Image.FromFile("E:\\00_WorkCodeSpace\\CSharpStudyWorkspace\\代码案例需要的资源\\上帝俯瞰自己.png");
                g.DrawImage(image, 100, 50);
                image.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"加载图像时出错: {ex.Message}");
            }

            // 释放资源
            pen.Dispose();
            brush.Dispose();
            font.Dispose();
            textBrush.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello, GDI+!" + e);
        }
    }
}
