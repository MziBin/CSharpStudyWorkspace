using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform常用控件
{
    public partial class ToolTipExample : Form
    {
        private ToolTip toolTip;

        public ToolTipExample()
        {
            InitializeComponent();
            // 创建 ToolTip 对象
            toolTip = new ToolTip();
            // 设置 ToolTip 为手动绘制模式
            toolTip.OwnerDraw = true;
            // 订阅 Draw 事件
            toolTip.Draw += ToolTip_Draw;

            // 关联 ToolTip 到控件
            AssociateToolTipToControl();
            // 定制 ToolTip 的外观和行为
            CustomizeToolTip();
        }

        private void AssociateToolTipToControl()
        {
            // 创建一个按钮
            Button button = new Button();
            button.Text = "点击我";
            button.Location = new Point(50, 50);
            this.Controls.Add(button);

            // 为按钮设置 ToolTip 提示信息,其实只要这一个就可以了，其它的都是toolTip的样式设置
            toolTip.SetToolTip(button, "这是一个按钮，点击它可以执行相应操作。");
        }

        private void ToolTip_Draw(object sender, DrawToolTipEventArgs e)
        {
            // 创建自定义字体
            Font customFont = new Font("Arial", 10);
            // 设置背景颜色
            e.DrawBackground();
            // 设置边框
            e.DrawBorder();
            // 使用自定义字体绘制提示信息
            e.Graphics.DrawString(e.ToolTipText, customFont, Brushes.Black, e.Bounds.Location);
        }

        private void CustomizeToolTip()
        {
            // 设置 ToolTip 显示前的延迟时间（毫秒）
            toolTip.AutoPopDelay = 5000;
            // 设置鼠标悬停多久后显示 ToolTip（毫秒）
            toolTip.InitialDelay = 1000;
            // 设置鼠标从一个控件移到另一个控件时显示 ToolTip 的延迟时间（毫秒）
            toolTip.ReshowDelay = 500;
            // 设置是否在 ToolTip 显示时发出提示音
            toolTip.ShowAlways = true;
            // 设置 ToolTip 的字体
            toolTip.ToolTipTitle = "提示信息";
            //toolTip.Font = new Font("Arial", 10);
            // 设置 ToolTip 的背景颜色
            toolTip.BackColor = Color.LightYellow;
            // 设置 ToolTip 的文本颜色
            toolTip.ForeColor = Color.Black;
        }
    }
}