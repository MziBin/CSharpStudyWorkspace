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

        #region �����ƶ�����Ҫ����󶨶�Ӧ������¼�

        private Point mouseOff;//����ƶ�λ�ñ���
        private bool leftFlag;//��ǩ�Ƿ�Ϊ���
        private void Frm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y); //�õ�������ֵ
                leftFlag = true;                  //����������ʱ��עΪtrue;
            }
        }
        private void Frm_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);  //�����ƶ����λ��
                Location = mouseSet;
            }
        }
        private void Frm_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;//�ͷ������עΪfalse;
            }
        }

        #endregion

        #region ����Ĵ�С�л��͹ر�
        private void btnClose_Click(object sender, EventArgs e)
        {
            // ѯ���û��Ƿ�Ҫ�ر�
            DialogResult result = MessageBox.Show("��ȷ��Ҫ�رմ�����", "ȷ�Ϲر�", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                //todo Ӧ����������Դ���ͷ��˲��˳����и����򣬴��ڹر��С�
                this.Close();
            }
        }

        private void btnToggleMaximize_Click(object sender, EventArgs e)
        {
            //����Ŵ������С
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

        #region �������ı�������ʱ����ť������,���������ж�
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
                MessageBox.Show("��������ֻ�ܰ������֡�Ӣ����ĸ���»��ߡ�@��. �� $��");
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
            //4.2 ���ô��巵��ֵ
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        //���������һ��
        private void btnLogin_Click1(object sender, EventArgs e)
        {
            CheckTextRegex(tbUser);
            ////������֤
            //if (this.txtLoginAccount.Text.Trim().Length == 0)
            //{
            //    MessageBox.Show("�������¼�˺ţ�", "��ʾ��Ϣ");
            //    this.txtLoginAccount.Focus();
            //    return;
            //}
            //if (this.txtLoginPwd.Text.Trim().Length == 0)
            //{
            //    MessageBox.Show("�������¼���룡", "��ʾ��Ϣ");
            //    this.txtLoginPwd.Focus();
            //    return;
            //}
            //PS����ʵ�ʿ����У������Խ�һ����֤�����ʽ�����볤�ȡ��Ƿ��ַ���...

            //��2����װ��¼ʵ����Ϣ
            Teacher teacher = new Teacher()
            {
                LoginAccount = this.tbUser.Text.Trim(),
                LoginPWD = this.tbPassword.Text.Trim()
            };

            //��3�����ú�̨��¼�߼�(������ط������Լ�һ���쳣����)
            teacher = new TeacherController().TeacherLogin(teacher);

            //��4����֤��¼�Ƿ�ɹ�
            if (teacher != null)
            {
                //4.1 �����¼�ɹ�����������Ҫ�����¼��Ϣ�����浽ȫ�ֱ����У��Ա�����ʹ�ã�
                //Program.currentTeacher = teacher;
                GlobalData.longinTeacher = teacher;

                //��ʵ�ʿ�����Ŀ�У���Ӧ�ÿ�����������ݣ�
                //��1���˺���Ч��
                //��2���û���Ȩ��
                //��3����¼��־����
                //��4���Ƿ񱣴�һ��ʱ���¼��Ϣ������ͨ�����л���ʽ��ɣ�

                //4.2 ���ô��巵��ֵ
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("��¼�˺Ż��������", "��¼��ʾ");
            }
        }
        #endregion

    }
}
