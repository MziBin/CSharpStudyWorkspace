using CourseManageBLL;
using CourseManageModels;
using System.Text.RegularExpressions;


namespace CourseManageUI
{
    public partial class FrmAdminLogin : Form
    {
        public FrmAdminLogin()
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

        #region 当输入框改变有输入时，按钮才有用,还有正则判断
        private void CheckButtonEnabled()
        {
            bool isUserInputEmpty = string.IsNullOrEmpty(tbUser.Text);
            bool isPasswordInputEmpty = string.IsNullOrEmpty(tbPassword.Text);
            btnLogin.Enabled = !isUserInputEmpty && !isPasswordInputEmpty;
        }

        private void CheckTextRegex(TextBox textInput)
        {
            string inputPattern = @"^[a-zA-Z0-9_@.$]+$";
            Regex inputRegex = new Regex(inputPattern);

            if (!inputRegex.IsMatch(textInput.Text))
            {
                MessageBox.Show("输入内容只能包含数字、英文字母、下划线、@、. 和 $。");
                return;
            }
        }

        private void tbUser_TextChanged(object sender, EventArgs e)
        {
            CheckButtonEnabled();
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            CheckButtonEnabled();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //4.2 设置窗体返回值
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        //和上面调换一下
        private void btnLogin_Click1(object sender, EventArgs e)
        {
            CheckTextRegex(tbUser);
            ////输入验证
            //if (this.txtLoginAccount.Text.Trim().Length == 0)
            //{
            //    MessageBox.Show("请输入登录账号！", "提示信息");
            //    this.txtLoginAccount.Focus();
            //    return;
            //}
            //if (this.txtLoginPwd.Text.Trim().Length == 0)
            //{
            //    MessageBox.Show("请输入登录密码！", "提示信息");
            //    this.txtLoginPwd.Focus();
            //    return;
            //}
            //PS：在实际开发中，还可以进一步验证邮箱格式、密码长度、非法字符等...

            //【2】封装登录实体信息
            Teacher teacher = new Teacher()
            {
                LoginAccount = this.tbUser.Text.Trim(),
                LoginPWD = this.tbPassword.Text.Trim()
            };

            //【3】调用后台登录逻辑(在这个地方，可以加一个异常处理)
            teacher = new TeacherController().TeacherLogin(teacher);

            //【4】验证登录是否成功
            if (teacher != null)
            {
                //4.1 如果登录成功，我们首先要保存登录信息（保存到全局变量中，以备后续使用）
                //Program.currentTeacher = teacher;
                GlobalData.longinTeacher = teacher;

                //在实际开发项目中，还应该考虑下面的内容：
                //（1）账号有效性
                //（2）用户的权限
                //（3）登录日志保存
                //（4）是否保存一定时间登录信息（可以通过序列化方式完成）

                //4.2 设置窗体返回值
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("登录账号或密码错误！", "登录提示");
            }
        }
        #endregion

    }
}
