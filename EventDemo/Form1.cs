﻿using System;
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
        //窗体存储
        List<Form> listForm = new List<Form>();

        public Form1()
        {
            InitializeComponent();
        }

        public void SendEvent(Form form, string str)
        {
            this.textBox1.Text = this.textBox1.Text.Insert(this.textBox1.Text.Length,(form.Text + $"的消息：{str}"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listForm.Count; i++)
            {
                ((SonForm)listForm[i]).SendEvent += this.SendEvent;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SonForm sonForm = new SonForm();
            listForm.Add(sonForm);
            sonForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listForm.Count; i++)
            {

                listForm[i].Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listForm.Count; i++)
            {
                ((SonForm)listForm[i]).SendEvent -= this.SendEvent;

            }
        }
    }
}
