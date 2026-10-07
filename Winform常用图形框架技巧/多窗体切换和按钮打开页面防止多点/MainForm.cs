using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 多窗体切换和按钮打开页面防止多点
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            
            InitializeComponent();
        }

        private void btn_MainForm_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            IsPanelClose();
            OpenForm(btn.Tag.ToString());
            ButtnStateChange(btn);
        }

        private void btn_account_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            IsPanelClose();
            OpenForm(btn.Tag.ToString());
            ButtnStateChange(btn);
        }

        private void btn_data_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            IsPanelClose();
            OpenForm(btn.Tag.ToString());
            ButtnStateChange(btn);
        }

        private void btn_setting_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            IsPanelClose();
            OpenForm(btn.Tag.ToString());
            ButtnStateChange(btn);
        }

        //判断页面关闭，如果是现有界面就不关闭
        /// <summary>
        /// 关闭容器中的窗体
        /// </summary>
        private bool IsPanelClose()
        {
            bool isCloss = false;
            foreach (Control item in pnl_Main.Controls)
            {
                if (item is Form form)
                {
                    if (form.Name != "HomeForm")
                    {
                        form.Close();
                    }
                    else
                    {
                        form.Hide();
                        isCloss = true;
                    }
                }
            }
            return isCloss;
        }

        //显示页面
        private void OpenForm(string formNname)
        {
            switch (formNname)
            {
                case "HomeForm":
                    foreach (var item in pnl_Main.Controls)
                    {
                        if (item is Form form)
                        {
                            if (form.Name == formNname)
                            {
                                form.Show();
                                return;
                            }
                        }
                    }
                    break;
                case "AccountForm":
                    AccountForm accountForm = new AccountForm();
                    accountForm.TopLevel = false;
                    accountForm.FormBorderStyle = FormBorderStyle.None;//去掉边框,显示在父窗体中
                    accountForm.Dock = DockStyle.Fill;//填充满容器
                    accountForm.Parent = this.pnl_Main;//设置父容器  //或者pnl_Main.Controls.Add(homeForm);
                    accountForm.Show();
                    break;
                case "DataForm":
                    DataForm dataForm = new DataForm();
                    dataForm.TopLevel = false;
                    dataForm.FormBorderStyle = FormBorderStyle.None;//去掉边框,显示在父窗体中
                    dataForm.Dock = DockStyle.Fill;//填充满容器
                    dataForm.Parent = this.pnl_Main;//设置父容器  //或者pnl_Main.Controls.Add(homeForm);
                    dataForm.Show();
                    break;
                case "SettingForm":
                    SettingForm settingForm = new SettingForm();
                    settingForm.TopLevel = false;
                    settingForm.FormBorderStyle = FormBorderStyle.None;//去掉边框,显示在父窗体中
                    settingForm.Dock = DockStyle.Fill;//填充满容器
                    settingForm.Parent = this.pnl_Main;//设置父容器  //或者pnl_Main.Controls.Add(homeForm);
                    settingForm.Show();
                    break;
            }
        }

        //按钮禁用和颜色改变
        Button beforBtn = null;
        private void ButtnStateChange(Button btn)
        {
            if (beforBtn != null)
            {
                beforBtn.BackColor = Color.White;
                beforBtn.Enabled = true;
            }
            beforBtn = btn;
            btn.BackColor = Color.Lime;
            btn.Enabled = false;
        }

        //启动显示主界面
        private void StartMain()
        {
            HomeForm homeForm = new HomeForm();
            homeForm.TopLevel = false;
            homeForm.FormBorderStyle = FormBorderStyle.None;//去掉边框,显示在父窗体中
            homeForm.Dock = DockStyle.Fill;//填充满容器
            homeForm.Parent = this.pnl_Main;//设置父容器  //或者pnl_Main.Controls.Add(homeForm);
            homeForm.Show();
            ButtnStateChange(btn_MainForm);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.MaximizeBox = false;
            StartMain();
        }

        private void btn_parameter_Click(object sender, EventArgs e)
        {
            ParameterForm p = ParameterForm.Instance;
            p.StartPosition = FormStartPosition.CenterScreen;
            p.Show();
        }
    }
}
