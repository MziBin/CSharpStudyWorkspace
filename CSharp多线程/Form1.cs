using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp多线程
{
    public partial class Form1 : Form
    {
        //用于存放所有线程。
        Dictionary<string,Thread> keyValueThread = new Dictionary<string,Thread>();

        public Form1()
        {
            InitializeComponent();
        }

        public void ThreadTest()
        {
            Thread thread = new Thread(() =>
            {
                for (int j = 0; j < 10; j++) { 
                
                }
            });
            thread.Name = "thread";
            //后台线程，表示当程序被关闭时，线程自动释放
            thread.IsBackground = true;
            //开始一个线程
            thread.Start();
            //终止一个线程。
            thread.Abort();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread thread1 = new Thread(() =>
            {
                int i = 0;
                while (true)
                {
                    Thread.Sleep(1000);
                    if(this.labNum2.InvokeRequired)
                    {
                        this.labNum2.Invoke(new Action<string>(data => { this.labNum2.Text = data; }),$"{++i}");
                    }
                }
            });
            thread1.Name = "thread1";
            label2.Text = thread1.Name;
            thread1.IsBackground = true;
            keyValueThread.Add(thread1.Name, thread1);
            thread1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread value;
            bool exists = keyValueThread.TryGetValue("thread1", out value);
            value.Abort();
            //这个也可以获取指定的键值
            //value = keyValueThread["thread"];
        }
    }
}
