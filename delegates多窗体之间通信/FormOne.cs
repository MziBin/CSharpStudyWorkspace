using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace delegates多窗体之间通信
{
    //委托的定义
    public delegate void ShowNum(string count);
    public partial class FormOne : Form
    {
        //
        public ShowNum show;
        int num = 0;

        public FormOne()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (show != null)
            {
                num++;
                //执行委托
                show(num.ToString() );
            }
        }
    }
}
