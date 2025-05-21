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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            FormOne formOne = new FormOne();
            //传递方法引用给委托
            formOne.show = this.AddNum;
            formOne.Show();
        }

        private void AddNum(string count)
        {
            this.label2.Text = count;
        }
    }
}
