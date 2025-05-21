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
    public partial class MenuStripStatusStripExample : Form
    {
        private MenuStrip menuStrip;
        private StatusStrip statusStrip;

        public MenuStripStatusStripExample()
        {
            InitializeComponent();
            // 创建 MenuStrip
            menuStrip = new MenuStrip();
            menuStrip.Dock = DockStyle.Top;
            this.Controls.Add(menuStrip);
            this.MainMenuStrip = menuStrip;

            // 添加菜单项
            AddMenuItems();

            // 创建 StatusStrip
            statusStrip = new StatusStrip();
            statusStrip.Dock = DockStyle.Bottom;
            this.Controls.Add(statusStrip);

            // 添加状态栏项
            AddStatusStripItems();
        }

        private void AddMenuItems()
        {
            ToolStripMenuItem fileMenuItem = new ToolStripMenuItem("文件");
            ToolStripMenuItem editMenuItem = new ToolStripMenuItem("编辑");

            ToolStripMenuItem newMenuItem = new ToolStripMenuItem("新建");
            newMenuItem.Click += NewMenuItem_Click;
            fileMenuItem.DropDownItems.Add(newMenuItem);

            ToolStripMenuItem openMenuItem = new ToolStripMenuItem("打开");
            openMenuItem.Click += OpenMenuItem_Click;
            fileMenuItem.DropDownItems.Add(openMenuItem);

            menuStrip.Items.Add(fileMenuItem);
            menuStrip.Items.Add(editMenuItem);
        }

        private void NewMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("新建菜单项被点击");
        }

        private void OpenMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("打开菜单项被点击");
        }

        private void AddStatusStripItems()
        {
            ToolStripStatusLabel statusLabel = new ToolStripStatusLabel();
            statusLabel.Text = "就绪";
            statusStrip.Items.Add(statusLabel);
        }
    }
}