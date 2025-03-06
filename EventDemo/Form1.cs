using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventDemo
{
    //定义委托
    public delegate void SendEvent(Form form, string str);
    
    public partial class Form1 : Form
    {
        //存储的子窗体的对象
        List<Form> listForm = new List<Form>();

        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 激发的事件执行的方法
        /// </summary>
        /// <param name="form"></param>
        /// <param name="str"></param>
        public void SendEvent(Form form, string str)
        {
            this.textBox1.Text = this.textBox1.Text.Insert(this.textBox1.Text.Length,(form.Text + $"的消息：{str}"));
        }
        /// <summary>
        /// 关联事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listForm.Count; i++)
            {
                ((SonForm)listForm[i]).SendEvent += this.SendEvent;

            }
        }
        /// <summary>
        /// 创建子窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            SonForm sonForm = new SonForm();
            listForm.Add(sonForm);
            sonForm.Show();
        }
        /// <summary>
        /// 清空消息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
        }
        /// <summary>
        /// 关闭子窗体窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listForm.Count; i++)
            {

                listForm[i].Close();
            }
        }
        /// <summary>
        /// 移除关联
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listForm.Count; i++)
            {
                ((SonForm)listForm[i]).SendEvent -= this.SendEvent;

            }
        }
    }
}
