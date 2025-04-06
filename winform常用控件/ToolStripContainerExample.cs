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
    public partial class ToolStripContainerExample : Form
    {
        private ToolStripContainer toolStripContainer;

        public ToolStripContainerExample()
        {
            InitializeComponent();
            // 创建 ToolStripContainer 对象
            toolStripContainer = new ToolStripContainer();
            // 设置 ToolStripContainer 停靠在整个窗体
            toolStripContainer.Dock = DockStyle.Fill;
            // 将 ToolStripContainer 添加到窗体
            this.Controls.Add(toolStripContainer);

            // 在顶部面板添加 ToolStrip
            AddToolStripToTop();
            // 在底部面板添加 ToolStrip
            AddToolStripToBottom();
            // 在中央面板添加 TextBox
            AddControlToContentPanel();
        }

        private void AddToolStripToTop()
        {
            // 创建 ToolStrip 对象
            ToolStrip toolStrip = new ToolStrip();
            // 创建一个 ToolStripButton
            ToolStripButton button = new ToolStripButton("顶部按钮");
            // 将按钮添加到 ToolStrip 中
            toolStrip.Items.Add(button);
            // 将 ToolStrip 添加到 ToolStripContainer 的顶部面板
            toolStripContainer.TopToolStripPanel.Controls.Add(toolStrip);
        }

        private void AddToolStripToBottom()
        {
            ToolStrip toolStrip = new ToolStrip();
            ToolStripButton button = new ToolStripButton("底部按钮");
            toolStrip.Items.Add(button);
            // 将 ToolStrip 添加到 ToolStripContainer 的底部面板
            toolStripContainer.BottomToolStripPanel.Controls.Add(toolStrip);
        }

        private void AddControlToContentPanel()
        {
            // 创建 TextBox 对象
            TextBox textBox = new TextBox();
            // 设置 TextBox 停靠在中央面板
            textBox.Dock = DockStyle.Fill;
            // 将 TextBox 添加到 ToolStripContainer 的中央面板
            toolStripContainer.ContentPanel.Controls.Add(textBox);
        }
    }
}