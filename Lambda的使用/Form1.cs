using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lambda的使用
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //lambda可以理解为是一个快速创建委托的。可以快速创建方法。
            Func<int> func = () => 3 * 5;

            this.textBox1.Text = func().ToString();
        }
    }
}
