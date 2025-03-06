using MultiLanguageDemo.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiLanguageDemo
{
    public partial class FormLanguage : Form
    {
        //存放当前窗口使用的语言
        private Language CurrentSelectedLanguage = Language.ChineseSimplified;

        public FormLanguage()
        {
            InitializeComponent();

            //获取Properties中settings里面当前本地保存的语言
            string language = Properties.Settings.Default.DefaultLanguage;

            //设置为当前设置的语言
            MultiLanguageUtil.SetDefaultLanguage(language);
            //设置当前窗口的线程的UI语言
            MultiLanguageUtil.LoadLanguage(this,typeof(FormLanguage) );

            //存储到当前语言信息到窗口全局变量中。
            switch(language.ToLower() )
            {
                case "zh-cn": this.CurrentSelectedLanguage = Language.ChineseSimplified; break;
                case "en-us": this.CurrentSelectedLanguage = Language.English; break;
                default: this.CurrentSelectedLanguage = Language.ChineseSimplified; break;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //判断当前窗体使用语言
            if(CurrentSelectedLanguage == Language.ChineseSimplified)
            {
                //切换为汉语
                MultiLanguageUtil.SetDefaultLanguage("en-US");
                this.CurrentSelectedLanguage= Language.English;
            }else if(CurrentSelectedLanguage == Language.English)
            {
                MultiLanguageUtil.SetDefaultLanguage("zh-CN");
                this.CurrentSelectedLanguage= Language.ChineseSimplified;
            }

            //调用方法，将所有打开的页面控件都更新
            foreach (Form form in Application.OpenForms)
            {
                //每个打开的页面都给loadAll
                LoadAll(form);
            }

        }

        private void LoadAll(Form form)
        {
            //更新FormLanguage窗体
            if (form.Name == "FormLanguage")
            {
                MultiLanguageUtil.LoadLanguage(form, typeof(FormLanguage));
            }
            //如果还有别的窗体，这里要完善一下
        }
    }
}
