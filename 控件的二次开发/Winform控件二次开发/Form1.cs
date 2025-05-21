using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform控件二次开发
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userTextBox1.BeginCheckData(@"^[1-9]\d*$", "必须为正整数");
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            // 检查是否按下回车键
            if (e.KeyCode == Keys.Enter)
            {
                int value = Convert.ToInt32(this.textBox1.Text);
                if (value >= 0 && value <= 100)
                {
                    this.verticalProcessBar1.LTop = value;
                }
            }
        }
    }
}
