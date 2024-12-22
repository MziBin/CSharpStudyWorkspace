using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpStudyStudyWorkspace
{
    public partial class 事件的统一关联 : Form
    {
        public 事件的统一关联()
        {
            InitializeComponent();
            //关联事件
            //this.button1.Click += new System.EventHandler(this.button_Click);
            //this.button2.Click += new System.EventHandler(this.button_Click);
            //this.button3.Click += new System.EventHandler(this.button_Click);
            //this.button4.Click += new System.EventHandler(this.button_Click);
            //this.button5.Click += new System.EventHandler(this.button_Click);
            //this.button6.Click += new System.EventHandler(this.button_Click);
            //this.button7.Click += new System.EventHandler(this.button_Click);
            //this.button8.Click += new System.EventHandler(this.button_Click);
            //this.button9.Click += new System.EventHandler(this.button_Click);
            //this.button10.Click += new System.EventHandler(this.button_Click);
            //this.button11.Click += new System.EventHandler(this.button_Click);
            //this.button12.Click += new System.EventHandler(this.button_Click);
            //this.button13.Click += new System.EventHandler(this.button_Click);
            
            //上面重复代码可以简化
            //Controls属性可以获取到窗体的所有控件，因为窗体上所有控件都要Add到Controls集合中
            //所有控件都继承自Control类,所以可以用foreach遍历
            foreach(Control ctr in this.Controls)
            {
                if(ctr is Button)
                {
                    //Tag属性可以存放自定义数据，可以用来区分不同控件，没有时，Tag属性为null
                    if(ctr.Tag == null)
                    {
                        ctr.Click += new System.EventHandler(this.button_Click);
                    }
                }
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("按钮被点击了");
        }
    }
}
