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
    public partial class SonForm : Form
    {
        //声明事件
        public event SendEvent SendEvent;

        public SonForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SendEvent == null) {

                MessageBox.Show("请先关联事件！");
                return;
            }
            //激发委托，调用事件
            SendEvent(this,this.textBox1.Text);
            
        }
    }
}
