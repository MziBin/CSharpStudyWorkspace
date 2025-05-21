using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyUiControl
{
    public partial class VerticalProcessBar : UserControl
    {
        public VerticalProcessBar()
        {
            InitializeComponent();
        }

        //初始进度条总高度.属性
        private int lHeight = 200;
        public int LHeight
        {
            get { return lHeight; }
            set
            {
                if (value > 100 && value < 500)
                {
                    this.lHeight = value;
                    this.labButton.Height = value;
                    this.labTop.Height = 0;
                }
                else
                {
                    MessageBox.Show("value值必须在100－500之间。", "信息提示");
                }
            }
        }

        private int lTop = 200;
        public int LTop
        {
            get { return lTop; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    this.lTop = value;
                    this.labTop.Height = value;
                }
                else
                {
                    MessageBox.Show("value值必须在100－500之间。", "信息提示");
                }
            }
        }
    }
}
