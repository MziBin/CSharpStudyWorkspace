using MultiLanguageDemo2JSON.BLL;
using MultiLanguageDemo2JSON.Service;
using MultiLanguageDemo2JSON.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiLanguageDemo2JSON
{
    public partial class MainForm02 : Form, IMultiLanguageSupport
    {
        //多语言切换的接口
        private readonly ILanguageService _languageService = LanguageServiceImpl.Instance;

        public MainForm02()
        {
            InitializeComponent();
            // 订阅语言切换通知
            _languageService.Subscribe(this);
        }

        //界面更新和赋值
        public void ApplyLanguage()
        {
            //根据json的键获取值展示
            this.Text = _languageService.GetString("FormTitle");
            button1.Text = _languageService.GetString("ButtonText");
        }

        /// <summary>
        /// 这个可以改成switch
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSwitchLanguage_Click(object sender, EventArgs e)
        {
            string currentLanguage = _languageService.GetCurrentLanguage();
            if (currentLanguage == "en-US")
            {
                _languageService.LoadLanguage("zh-CN");
            }
            else
            {
                _languageService.LoadLanguage("en-US");
            }
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            // 取消订阅语言切换通知
            LanguageService.Instance.Unsubscribe(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 从语言服务中获取对应语言的文本,更改按钮的文本没用
            //string yesText = _languageService.GetString("YesButtonText");
            //string noText = _languageService.GetString("NoButtonText");
            string message = _languageService.GetString("MessageBoxMessage");
            string caption = _languageService.GetString("MessageBoxCaption");

            // 使用包含自定义按钮文本的 MessageBox.Show 重载方法
            //DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, 0, yesText, noText);
            DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // 处理“是”按钮点击事件
                MessageBox.Show("你点击了是");
            }
            else if (result == DialogResult.No)
            {
                // 处理“否”按钮点击事件
                MessageBox.Show("你点击了否");
            }
        }
    }
}
