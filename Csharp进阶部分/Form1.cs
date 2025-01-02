using Csharp进阶部分.继承和多态.对象工厂;
using Csharp进阶部分.继承和多态.接口;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp进阶部分
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Test1();
        }

        public void Test1()
        {
            IMeeting meeting = ObjectFactory.StartSpeechAndTalk();
            
            listBox1.Items.Add(meeting.Talk("学习方法") );
           
        }

    }
}
