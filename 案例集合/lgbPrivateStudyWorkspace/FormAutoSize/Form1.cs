using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test02
{
    /*
     * 四、最后一步就是如何进行调用：
     * 首先在需要进行缩放的窗体中定义一个FormAutoSize对象，然后在构造方法中实例化该对象，
     * 将当前窗体this作为参数传递进去，最后在窗体的SizeChanged事件中调用该对象的ResumeLayout方法。
     * */
    public partial class Form1 : Form
    {
        private FormAutoSize formAutoSize;

        public Form1()
        {
            InitializeComponent();

            formAutoSize = new FormAutoSize(this);
            this.SizeChanged += (sender, e) =>
            {
                formAutoSize.ResumeLayout();
            };
        }
    }
}
