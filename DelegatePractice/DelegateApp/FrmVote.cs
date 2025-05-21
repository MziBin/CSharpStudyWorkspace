using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegateApp
{
    public partial class FrmVote : Form
    {
        //委托方法声明
        public StartVoteDelegate startVoteDelegate;

        public FrmVote()
        {
            InitializeComponent();

            //按钮绑定事件
            //通过new 委托变量名或者直接传递都行，new比较直观看出
            this.btnVote1.Click += this.btnVote_Click;
            this.btnVote2.Click += new System.EventHandler(this.btnVote_Click);
            this.btnVote3.Click += new System.EventHandler(this.btnVote_Click);
        }
        //开始投票
        private void Vote(object sender, EventArgs e)
        {
         
        }

        private void btnVote_Click(object sender, EventArgs e)
        {
            //获得点击的button对象
            Button btnVote = (Button)sender;
            //调用委托，Invoke作用就是方便知道这是调用的委托，不加也能直接使用
            startVoteDelegate.Invoke((Convert.ToInt32(btnVote.Tag) ) );
            //循环将所有按钮变灰
            foreach(Control item in Controls)
            {
                if (item is Button)
                {
                    item.Enabled = false;
                }
            }


        }
    }
}
