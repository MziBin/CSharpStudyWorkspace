using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageList控件
{
    public partial class Form1 : Form
    {
        private ImageList imageList;
        private ListView listView;
        private TreeView treeView;
        private ToolStrip toolStrip;

        public Form1()
        {
            InitializeComponent();
            // 创建 ImageList 并设置图像大小
            imageList = new ImageList();
            imageList.ImageSize = new Size(32, 32);

            // 创建 Bitmap 图像并添加到 ImageList
            CreateBitmapsAndAddToImageList();

            // 创建并配置 ListView
            SetupListView();
            // 创建并配置 TreeView
            SetupTreeView();
            // 创建并配置 ToolStrip
            SetupToolStrip();
        }

        private void CreateBitmapsAndAddToImageList()
        {
            // 创建红色矩形的 Bitmap
            Bitmap redBitmap = new Bitmap(32, 32);
            using (Graphics g = Graphics.FromImage(redBitmap))
            {
                g.FillRectangle(Brushes.Red, 0, 0, 32, 32);
            }
            imageList.Images.Add(redBitmap);

            // 创建蓝色矩形的 Bitmap
            Bitmap blueBitmap = new Bitmap(32, 32);
            using (Graphics g = Graphics.FromImage(blueBitmap))
            {
                g.FillRectangle(Brushes.Blue, 0, 0, 32, 32);
            }
            imageList.Images.Add(blueBitmap);
        }

        private void SetupListView()
        {
            listView = new ListView();
            listView.Dock = DockStyle.Top;
            listView.Height = 150;
            listView.SmallImageList = imageList;

            // 添加 ListView 项并指定图像索引
            ListViewItem item1 = new ListViewItem("Red Item", 0);
            ListViewItem item2 = new ListViewItem("Blue Item", 1);
            listView.Items.Add(item1);
            listView.Items.Add(item2);

            this.Controls.Add(listView);
        }

        private void SetupTreeView()
        {
            treeView = new TreeView();
            treeView.Dock = DockStyle.Top;
            treeView.Height = 150;
            treeView.ImageList = imageList;

            // 添加 TreeNode 并指定图像索引
            TreeNode node1 = new TreeNode("Red Node", 0, 0);
            TreeNode node2 = new TreeNode("Blue Node", 1, 1);
            treeView.Nodes.Add(node1);
            treeView.Nodes.Add(node2);

            this.Controls.Add(treeView);
        }

        private void SetupToolStrip()
        {
            toolStrip = new ToolStrip();
            toolStrip.Dock = DockStyle.Top;

            // 添加 ToolStripButton 并指定图像索引
            ToolStripButton redButton = new ToolStripButton("Red", imageList.Images[0]);
            ToolStripButton blueButton = new ToolStripButton("Blue", imageList.Images[1]);
            toolStrip.Items.Add(redButton);
            toolStrip.Items.Add(blueButton);

            this.Controls.Add(toolStrip);
        }
    }
}
