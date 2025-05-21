using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectUITeach
{
    public partial class FrmMain : Form
    {
        public FrmMain()
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

        //嵌入子窗体,代码提炼
        private void NewForm(Form frm)
        {
            //查看panelRight是否有子窗体，如果有则关闭
            foreach (Control ctr in this.panelRight.Controls)
            {
                if (ctr is Form)
                {
                    (ctr as Form).Close();
                }
            }
            //嵌入子窗体
            frm.TopLevel = false;
            //frm.FormBorderStyle = FormBorderStyle.None;//去掉边框,显示在父窗体中,这里不需要，因为已经去掉了边框
            frm.Dock = DockStyle.Fill;//填充满容器
            frm.Parent = panelRight;//将子窗体添加到panel中
            //panel1.Controls.Add(frm);
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /**  
            //查看panelRight是否有子窗体，如果有则关闭
            foreach (Control ctr in this.panelRight.Controls)
            {
                if (ctr is Form)
                {
                    (ctr as Form).Close();
                }
            }
            //嵌入子窗体
            FrmCourseManage frm = new FrmCourseManage();
            frm.TopLevel = false;
            //frm.FormBorderStyle = FormBorderStyle.None;//去掉边框,显示在父窗体中,这里不需要，因为已经去掉了边框
            frm.Dock = DockStyle.Fill;//填充满容器
            frm.Parent = panelRight;//将子窗体添加到panel中
            //panel1.Controls.Add(frm);
            frm.Show();
            */

            NewForm(new FrmCourseManage() );
        }
        
    }
}
