using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // 订阅 Paint 事件
            this.Paint += MainForm_Paint;
            
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            // 获取 Graphics 对象
            Graphics g = e.Graphics;

            // 设置高质量绘制
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // 创建画笔和画刷，画笔一般包括颜色和宽度，画刷一般就是填充颜色
            Pen redPen = new Pen(Color.Red, 2);
            SolidBrush blueBrush = new SolidBrush(Color.Blue);

            // 绘制矩形,左上角的点位，宽高，矩形是不能旋转的
            g.DrawRectangle(redPen, 0, 0, 200, 100);

            //绘制多边形,1,2,3,4顺序连接的
            g.DrawPolygon(redPen, new Point[]
            {
                new Point(100, 0),
                new Point(200, 20),
                new Point(220, 60),
                new Point(130, 90)
            });

            // 填充椭圆，左上角的点位，宽高
            g.FillEllipse(blueBrush, 300, 50, 150, 100);

            // 创建渐变画刷
            LinearGradientBrush gradientBrush = new LinearGradientBrush(
                new Point(50, 200),
                new Point(300, 200),
                Color.Yellow,
                Color.Green);

            // 填充多边形
            Point[] points = new Point[]
            {
                new Point(50, 200),
                new Point(200, 150),
                new Point(300, 250),
                new Point(100, 300)
            };
            g.FillPolygon(gradientBrush, points);

            // 绘制文本
            Font font = new Font("Arial", 16, FontStyle.Bold);
            g.DrawString("Hello, GDI+!", font, Brushes.Black, 100, 350);

            // 释放资源
            redPen.Dispose();
            blueBrush.Dispose();
            gradientBrush.Dispose();
            font.Dispose();
        }
    }
}
