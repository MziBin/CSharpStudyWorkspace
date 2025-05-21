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
    public partial class listviewDemo : Form
    {
        private ListView listView;

        public listviewDemo()
        {
            InitializeComponent();
            // 创建 ListView 控件
            listView = new ListView();
            listView.Dock = DockStyle.Fill;
            // 设置视图模式为详细信息视图
            listView.View = View.Details;

            // 添加列标题
            listView.Columns.Add("姓名", 100);
            listView.Columns.Add("年龄", 50);
            listView.Columns.Add("性别", 50);

            // 添加数据项
            ListViewItem item1 = new ListViewItem("张三");
            item1.SubItems.Add("20");
            item1.SubItems.Add("男");
            listView.Items.Add(item1);

            ListViewItem item2 = new ListViewItem("李四");
            item2.SubItems.Add("25");
            item2.SubItems.Add("女");
            listView.Items.Add(item2);

            this.Controls.Add(listView);
        }
    }
}