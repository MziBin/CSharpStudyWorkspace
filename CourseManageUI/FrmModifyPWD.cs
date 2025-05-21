using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseManageUI
{
    public partial class FrmModifyPWD : Form
    {
        public FrmModifyPWD()
        {
            InitializeComponent();
        }

        #region 窗体移动，需要窗体绑定对应的鼠标事件

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

        #region 窗体的大小切换和关闭
        private void btnClose_Click(object sender, EventArgs e)
        {
            // 询问用户是否要关闭
            DialogResult result = MessageBox.Show("你确定要关闭窗口吗？", "确认关闭", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                //todo 应该在所有资源都释放了才退出，有个弹框，窗口关闭中。
                this.Close();
            }
        }

        private void btnToggleMaximize_Click(object sender, EventArgs e)
        {
            //窗体放大或者缩小
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #endregion

    }
}
