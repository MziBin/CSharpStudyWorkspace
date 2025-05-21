using MultiLanguageDemo2JSON.BLL;
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
    public partial class MainForm : Form, IMultiLanguageSupport
    {
        public MainForm()
        {
            InitializeComponent();
            // 订阅语言切换通知
            LanguageService.Instance.Subscribe(this);
        }

        //界面更新和赋值
        public void ApplyLanguage()
        {
            //根据json的键获取值展示
            this.Text = LanguageService.Instance.GetString("FormTitle");
            button1.Text = LanguageService.Instance.GetString("ButtonText");
        }

        /// <summary>
        /// 这个可以改成switch
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSwitchLanguage_Click(object sender, EventArgs e)
        {
            string currentLanguage = LanguageService.Instance.GetCurrentLanguage();
            if (currentLanguage == "en-US")
            {
                LanguageService.Instance.LoadLanguage("zh-CN");
            }
            else
            {
                LanguageService.Instance.LoadLanguage("en-US");
            }
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            // 取消订阅语言切换通知
            LanguageService.Instance.Unsubscribe(this);
        }
    }
}
