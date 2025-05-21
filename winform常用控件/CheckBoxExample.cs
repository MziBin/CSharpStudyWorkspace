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

    public partial class CheckBoxExample : Form
    {
        private CheckBox checkBox;

        public CheckBoxExample()
        {
            InitializeComponent();
            // 创建 CheckBox 对象
            checkBox = new CheckBox();
            // 设置 CheckBox 的文本
            checkBox.Text = "同意协议";
            // 设置 CheckBox 的位置
            checkBox.Location = new Point(50, 50);
            // 将 CheckBox 添加到窗体
            this.Controls.Add(checkBox);

            // 处理 CheckBox 的事件
            HandleCheckBoxEvent();
            // 设置三态 CheckBox
            SetThreeStateCheckBox();
        }

        private void HandleCheckBoxEvent()
        {
            // 为 CheckBox 的 CheckedChanged 事件添加处理程序
            checkBox.CheckedChanged += CheckBox_CheckedChanged;
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            if (cb.Checked)
            {
                MessageBox.Show("你已同意协议。");
            }
            else
            {
                MessageBox.Show("你已取消同意协议。");
            }
        }

        private void GetCheckBoxStatus()
        {
            if (checkBox.Checked)
            {
                // 执行选中时的操作
            }
            else
            {
                // 执行未选中时的操作
            }
        }

        private void SetThreeStateCheckBox()
        {
            // 启用三态模式
            checkBox.ThreeState = true;
            // 设置为不确定状态
            checkBox.CheckState = CheckState.Indeterminate;

            checkBox.CheckStateChanged += CheckBox_CheckStateChanged;
        }

        private void CheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            switch (cb.CheckState)
            {
                case CheckState.Checked:
                    MessageBox.Show("已选中。");
                    break;
                case CheckState.Unchecked:
                    MessageBox.Show("未选中。");
                    break;
                case CheckState.Indeterminate:
                    MessageBox.Show("不确定状态。");
                    break;
            }
        }
    }
}