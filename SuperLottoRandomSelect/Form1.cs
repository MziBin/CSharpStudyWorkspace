using SuperLottoRandomSelect.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperLottoRandomSelect
{
    public partial class Form1 : Form
    {
        //定义一个模型类
        SuperLottoModel model;
        //定义一个集合
        List<SuperLottoModel> models = new List<SuperLottoModel>();

        public Form1()
        {
            InitializeComponent();
        }

        #region 窗体移动

        private Point mouseOff;//鼠标移动位置变量
        private bool leftFlag;//标签是否为左键
        private void Frm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y); //得到变量的值
                leftFlag = true;                  //点击左键按下时标注为true;
            }
        }
        private void Frm_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);  //设置移动后的位置
                Location = mouseSet;
            }
        }
        private void Frm_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;//释放鼠标后标注为false;
            }
        }

        #endregion

        //窗体关闭事件
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //开始按钮事件
        private void btn_start_Click(object sender, EventArgs e)
        {
            btn_start.Enabled = false;//开始按钮禁用
            btn_select.Enabled = true;//选择按钮启用

            this.timer1.Start();//开始计时器
        }
        //停止按钮事件
        private void btn_select_Click(object sender, EventArgs e)
        {
            btn_select.Enabled = false;//选择按钮禁用
            btn_start.Enabled = true;//开始按钮启用

            this.timer1.Stop();//停止计时器

            //添加到集合中
            models.Add(model);
            //显示到列表框中
            string redAndBlue = "";
            foreach(string item in model.RedLotteryNumbers)
            {
                redAndBlue += item + " ";
            }
            foreach (string item in model.BlueLotteryNumbers)
            {
                redAndBlue += item + " ";
            }
            this.listBox_show.Items.Add(redAndBlue);

            //不够简洁
            //this.listBox_show.Items.Add(models.Last().RedLotteryNumbers[0] + " " + models.Last().RedLotteryNumbers[1] + " " + models.Last().RedLotteryNumbers[2] + " " + models.Last().RedLotteryNumbers[3] + " " + models.Last().RedLotteryNumbers[4] + " " + models.Last().BlueLotteryNumbers[0] + " " + models.Last().BlueLotteryNumbers[1]);
            //会有重复
            //foreach (SuperLottoModel item in models)
            //{
                //this.listBox_show.Items.Add(item.RedLotteryNumbers[0] + " " + item.RedLotteryNumbers[1] + " " + item.RedLotteryNumbers[2] + " " + item.RedLotteryNumbers[3] + " " + item.RedLotteryNumbers[4] + " " + item.BlueLotteryNumbers[0] + " " + item.BlueLotteryNumbers[1] );
            //}

        }
        //计时器事件
        private void timer1_Tick(object sender, EventArgs e)
        {
            Select select = new Select();
            model = select.RandomSelectNumbers();
            this.labRed1.Text = model.RedLotteryNumbers[0];
            this.labRed2.Text = model.RedLotteryNumbers[1];
            this.labRed3.Text = model.RedLotteryNumbers[2];
            this.labRed4.Text = model.RedLotteryNumbers[3];
            this.labRed5.Text = model.RedLotteryNumbers[4];

            this.labBlu1.Text = model.BlueLotteryNumbers[0];
            this.labBlu2.Text = model.BlueLotteryNumbers[1];
        }
        //清空按钮事件
        private void btn_clear_Click(object sender, EventArgs e)
        {
            this.listBox_show.Items.Clear();
            models.Clear();
        }
    }
}
