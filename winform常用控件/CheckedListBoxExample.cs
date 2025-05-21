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
    public partial class CheckedListBoxExample : Form
    {
        private CheckedListBox checkedListBox;
        private Button button;

        public CheckedListBoxExample()
        {
            InitializeComponent();
            checkedListBox = new CheckedListBox();
            checkedListBox.Items.Add("选项 1");
            checkedListBox.Items.Add("选项 2");
            checkedListBox.Items.Add("选项 3");
            checkedListBox.Location = new System.Drawing.Point(20, 20);

            button = new Button();
            button.Text = "确定";
            button.Location = new System.Drawing.Point(20, 200);
            button.Click += Button_Click;

            this.Controls.Add(checkedListBox);
            this.Controls.Add(button);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            string selectedItems = "";
            foreach (var item in checkedListBox.CheckedItems)
            {
                selectedItems += item.ToString() + " ";
            }
            if (selectedItems != "")
            {
                MessageBox.Show("你选择了：" + selectedItems);
            }
            else
            {
                MessageBox.Show("你没有选择任何选项");
            }
        }
    }
}