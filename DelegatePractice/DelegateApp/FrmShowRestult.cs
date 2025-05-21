using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Reflection;

namespace DelegateApp
{
    //投票委托，选择对应的嘉宾
    public delegate void StartVoteDelegate(int num);

    public partial class FrmShowRestult : Form
    {
        //3个嘉宾
        private Dictionary<int, Guest> guest = null;
        private List<FrmVote> frmVoteList = new List<FrmVote>();

        public FrmShowRestult()
        {
            InitializeComponent();
            //初始化嘉宾
            guest = new Dictionary<int, Guest>()
            {
                [1] = new Guest() { Number = 1,Name="李", VoteCounter = 0},
                [2] = new Guest() { Number = 2, Name = "李", VoteCounter = 0 },
                [3] = new Guest() { Number = 3, Name = "李", VoteCounter = 0 }
            };

        }

        private void btnStartVote_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(this.txtCounter.Text);
            for (int i = 0; i < num; i++)
            {
                //通过反射创建窗口对象，可以方便后续更改
                FrmVote vote = (FrmVote)Assembly.Load("DelegateApp").CreateInstance("DelegateApp.FrmVote");
                //添加委托引用
                vote.startVoteDelegate = this.SelectVoteNumber;
                vote.Text = "投票器：" + (i+1).ToString();
                vote.Show();
                //将窗体加入集合
                frmVoteList.Add(vote);
            }
        }

        private void btnEndVote_Click(object sender, EventArgs e)
        {
            foreach (FrmVote vote in frmVoteList)
            {
                vote.Close();
            }
            //投票结束，所有按钮都不能使用
            this.btnStartVote.Enabled = false;
            this.btnEndVote.Enabled = false;
        }

        private void SelectVoteNumber(int num)
        {
            guest[num].VoteCounter++;
            this.lblCounter1.Text = guest[1].VoteCounter.ToString();
            this.lblCounter2.Text = guest[2].VoteCounter.ToString();
            this.lblCounter3.Text = guest[3].VoteCounter.ToString();
        }

    }

}
