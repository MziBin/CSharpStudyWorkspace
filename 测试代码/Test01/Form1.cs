using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test01
{
    public partial class Form1 : Form
    {
        System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
        Thread thread;
        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "计时器1：";
            btn01.Text = "启动计时器1";
            txt01.Text = "0";

            label2.Text = "计时器2";
            btn02.Text = "启动计时器2";
            txt02.Text = "0";

            label4.Text = "计时器3";
            btn03.Text = "启动计时器3";
            txt03.Text = "0";

            label6.Text = "计时器4";
            btn04.Text = "启动计时器4";
            txt04.Text = "0";

            timer1.Interval = 1000;
            timer1.Tick += Timer1_Tick;

            thread = new Thread(new ThreadStart(Timer4Worker));
            thread.IsBackground = true;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            txt01.Text = (Convert.ToInt32(txt01.Text) + 1).ToString();
        }

        private void btn01_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
                btn01.Text = "启动计时器";
            }
            else
            {
                timer1.Start();
                btn01.Text = "停止计时器";
            }
        }

        private void btn02_Click(object sender, EventArgs e)
        {
            //Task.Factory.StartNew(() => { });

            Task task = new Task(() =>
            {
                while (true)
                {
                    if (txt02.InvokeRequired)
                    {
                        //txt02.Invoke(new Action(() =>
                        //{
                        //    txt02.Text = (Convert.ToInt32(txt02.Text) + 1).ToString();
                        //}));
                        //txt02.Invoke(new Action(UpdateTxt02));
                        txt02.Invoke(new Action<string>(UpdateTxt02), (Convert.ToInt32(txt02.Text) + 1).ToString());
                        System.Threading.Thread.Sleep(1000);
                    }

                }
            });
            task.Start();
        }

        private void UpdateTxt02()
        {
            txt02.Text = (Convert.ToInt32(txt02.Text) + 1).ToString();
        }

        private void UpdateTxt02(string count)
        {
            txt02.Text = count;
        }


        // 不要用静态cts，改为局部变量或实例变量，每次启动时新建
        private CancellationTokenSource cts;
        private bool isRunning = false; // 用更清晰的变量名表示“是否正在运行”
        private Task currentTask; // 保存当前运行的Task，便于等待或处理
        private void btn03_Click(object sender, EventArgs e)
        {
            if (!isRunning)
            {
                // 1. 每次启动时创建新的取消令牌源
                cts = new CancellationTokenSource();
                CancellationToken token = cts.Token;

                // 2. 启动Task，保存到currentTask
                currentTask = Task.Run(async () =>
                {
                    try
                    {
                        while (true)
                        {
                            // 【关键】先检查取消，优先响应取消请求
                            token.ThrowIfCancellationRequested();

                            // 更新UI（确保在UI线程）
                            if (txt03.InvokeRequired)
                            {
                                txt03.Invoke(new Action(() =>
                                {
                                    // 简化逻辑：直接在Invoke中处理数值累加
                                    if (int.TryParse(txt03.Text, out int num))
                                        txt03.Text = (num + 1).ToString();
                                    else
                                        txt03.Text = "1";
                                }));
                            }

                            // 【关键】Delay传入token，允许中途被取消
                            await Task.Delay(1000, token);
                        }
                    }
                    catch (OperationCanceledException)
                    {
                        // 捕获取消异常，正常退出，不做处理（或记录日志）
                        Console.WriteLine("Task已被取消");
                    }
                }, token);

                isRunning = true;
                btn03.Text = "取消"; // 按钮文本提示当前状态
            }
            else
            {
                // 3. 取消Task
                if (cts != null)
                {
                    cts.Cancel(); // 发送取消请求
                    cts.Dispose(); // 释放资源
                    cts = null;
                }
                isRunning = false;
                btn03.Text = "启动";
            }
        }

        bool isTimer4Running = false;

        private void btn04_Click(object sender, EventArgs e)
        {
            if (!isTimer4Running)
            {
                //Thread thread = new Thread(() =>
                //{
                //    while (true)
                //    {
                //        if (txt04.InvokeRequired)
                //        {
                //            txt04.Invoke(new Action(() =>
                //            {
                //                if (int.TryParse(txt04.Text, out int num))
                //                    txt04.Text = (num + 1).ToString();
                //                else
                //                    txt04.Text = "1";
                //            }));
                //        }
                //        Thread.Sleep(1000);
                //    }
                //});
                isTimer4Running = true;
                if(thread.ThreadState == ThreadState.Aborted)
                {
                    thread = new Thread(new ThreadStart(Timer4Worker));
                }
                thread.Start();
            }
            else
            {
                isTimer4Running = false;
                thread.Abort();
            }
        }

        private void Timer4Worker()
        {
            while (true)
            {
                if (txt04.InvokeRequired)
                {
                    txt04.Invoke(new Action(() =>
                    {
                        if (int.TryParse(txt04.Text, out int num))
                            txt04.Text = (num + 1).ToString();
                        else
                            txt04.Text = "1";
                    }));
                }
                Thread.Sleep(1000);
            }
        }
    }
}
