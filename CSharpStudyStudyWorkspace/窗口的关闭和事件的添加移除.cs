using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpStudyStudyWorkspace
{
    public partial class 窗口的关闭和事件的添加移除 : Form
    {
        public 窗口的关闭和事件的添加移除()
        {
            InitializeComponent();
        }

        // 窗体关闭事件,关闭后显示提示框
        private void 窗口的关闭和事件的添加移除_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
        // 窗体关闭前事件
        private void 窗口的关闭和事件的添加移除_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("是否关闭", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Cancel)
            {
                //取消关闭窗体的事件
                e.Cancel = true;
            }
        }

        private void button1_Click_BreakANDContinue(object sender, EventArgs e)
        {
            //Button btn = (Button)sender;
            Button btn = sender as Button;
            if(btn.Tag.ToString() == "true")
            {
                this.button2.Click -= new System.EventHandler(this.button1_Click);
                btn.Tag = "false";
            } else
            {
                this.button2.Click += new System.EventHandler(this.button1_Click);
                btn.Tag = "true";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                textBox3.Text = (int.Parse(textBox1.Text) + Convert.ToInt32(textBox2.Text)).ToString();
            } else
            {
                MessageBox.Show("请输入数字");
            }
        }
    }
}
