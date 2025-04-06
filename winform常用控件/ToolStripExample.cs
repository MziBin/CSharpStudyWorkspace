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
    public partial class ToolStripExample : Form
    {
        private ToolStrip toolStrip;

        public ToolStripExample()
        {
            InitializeComponent();
            // 创建 ToolStrip 对象
            toolStrip = new ToolStrip();
            // 设置 ToolStrip 停靠在窗体顶部
            toolStrip.Dock = DockStyle.Top;
            this.Controls.Add(toolStrip);

            // 添加按钮
            AddToolStripButton();
            // 添加分隔符
            AddToolStripSeparator();
            // 添加下拉菜单
            AddToolStripDropDownButton();
            // 定制 ToolStrip 外观
            CustomizeToolStrip();
        }

        private void AddToolStripButton()
        {
            // 创建 ToolStripButton
            ToolStripButton button = new ToolStripButton("按钮");
            // 为按钮的点击事件添加处理程序
            button.Click += Button_Click;
            // 将按钮添加到 ToolStrip 中
            toolStrip.Items.Add(button);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("按钮被点击了！");
        }

        private void AddToolStripDropDownButton()
        {
            // 创建 ToolStripDropDownButton
            ToolStripDropDownButton dropDownButton = new ToolStripDropDownButton("下拉菜单");

            // 创建菜单项
            ToolStripMenuItem item1 = new ToolStripMenuItem("菜单项 1");
            item1.Click += Item1_Click;
            dropDownButton.DropDownItems.Add(item1);

            ToolStripMenuItem item2 = new ToolStripMenuItem("菜单项 2");
            item2.Click += Item2_Click;
            dropDownButton.DropDownItems.Add(item2);

            // 将下拉菜单添加到 ToolStrip 中
            toolStrip.Items.Add(dropDownButton);
        }

        private void Item1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("菜单项 1 被点击了！");
        }

        private void Item2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("菜单项 2 被点击了！");
        }

        private void AddToolStripSeparator()
        {
            // 创建 ToolStripSeparator
            ToolStripSeparator separator = new ToolStripSeparator();
            // 将分隔符添加到 ToolStrip 中
            toolStrip.Items.Add(separator);
        }

        private void CustomizeToolStrip()
        {
            // 设置背景颜色
            toolStrip.BackColor = Color.LightGray;
            // 设置字体
            toolStrip.Font = new Font("Arial", 10);
            // 设置显示样式
            toolStrip.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
        }
    }
}