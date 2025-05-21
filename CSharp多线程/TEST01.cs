using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp多线程
{
    public partial class TEST01 : Form
    {
        public TEST01()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //会阻塞UI线程，导致界面无响应
            MessageBox.Show("煮饭中...");
            Thread.Sleep(5000); // Simulate cooking time
            MessageBox.Show("炒菜中...");
            Thread.Sleep(5000); // Simulate cooking time
            MessageBox.Show("开饭");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //使用多线程来处理耗时操作，避免阻塞UI线程，但是会导致后面的开饭先弹出
            Thread thread1 = new Thread(() =>
            {
                MessageBox.Show("煮饭中...");
                Thread.Sleep(5000); // Simulate cooking time
                MessageBox.Show("炒菜中...");
                Thread.Sleep(5000); // Simulate cooking time
            });
            thread1.Start();

            MessageBox.Show("开饭");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //使用多线程来处理耗时操作，避免阻塞UI线程，但是会导致后面的开饭先弹出

            //Task和Thread的区别在于Task是基于线程池的，而Thread是直接创建线程，task会更高效
            Task task1 = Task.Run(() =>
            {
                MessageBox.Show("煮饭中...");
                Thread.Sleep(5000); // Simulate cooking time
                MessageBox.Show("炒菜中...");
                Thread.Sleep(5000); // Simulate cooking time
            });

            MessageBox.Show("开饭");
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            //使用多线程来处理耗时操作，避免阻塞UI线程，但是会导致后面的开饭先弹出

            //Task和Thread的区别在于Task是基于线程池的，而Thread是直接创建线程，task会更高效

            //async和await的使用可以让代码看起来是同步的，但是实际上是异步的，await不能在Thread中使用
            await Task.Run(() =>
            {
                MessageBox.Show("煮饭中...");
                Thread.Sleep(5000); // Simulate cooking time
                MessageBox.Show("炒菜中...");
                Thread.Sleep(5000); // Simulate cooking time
            });

            //这里的await会等待上面的任务完成后再执行下面的代码，所以不会导致后面的开饭先弹出
            MessageBox.Show("开饭");
        }

        private async void button5_ClickAsync(object sender, EventArgs e)
        {

            //下面两个await不会并行执行，而是顺序执行，await会等待上面的任务完成后再执行下面的代码，所以会导致后面的炒菜不是并行执行的
            await Task.Run(() =>
            {
                MessageBox.Show("煮饭中...");
                Thread.Sleep(5000); // Simulate cooking time
            });

            await Task.Run(() =>
            {
                MessageBox.Show("炒菜中...");
                Thread.Sleep(5000); // Simulate cooking time
            });

            //这里的await会等待上面的任务完成后再执行下面的代码，所以不会导致后面的开饭先弹出
            MessageBox.Show("开饭");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //创建多个任务并行执行，使用Task.WhenAll来等待所有任务完成
            List<Task> tasks = new List<Task>();
            //加入多个任务到列表中
            tasks.Add(Task.Run(() => {
                MessageBox.Show("煮饭中...");
                Thread.Sleep(5000); // Simulate cooking time
            }));
            //加入多个任务到列表中
            tasks.Add(Task.Run(() => {
                MessageBox.Show("炒菜中...");
                Thread.Sleep(5000); // Simulate cooking time
            }));

            //加入多个任务到列表中执行，ContinueWith会在所有任务完成后执行,t是所有任务的结果
            Task.WhenAll(tasks).ContinueWith(t =>
            {
                //这里的await会等待上面的任务完成后再执行下面的代码，所以不会导致后面的开饭先弹出
                MessageBox.Show("开饭");
            });

        }
    }
}
