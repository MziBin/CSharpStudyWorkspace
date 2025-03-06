using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiLanguageDemo
{
    /// <summary>
    /// 用于遍历切换窗体语言的公共类
    /// </summary>
    public class MultiLanguageUtil
    {
        public static string DefaultLanguage = "zh-CN";

        /// <summary>
        /// 修改项目中的默认语言，会保存在本地的Properties中
        /// </summary>
        /// <param name="lang">待设置默认语言</param>
        public static void SetDefaultLanguage(string lang)
        {
            //Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(lang);
            // 设置当前线程的 UI 文化，用于后面资源查找，lang就是 语言资源文件的名称，入zh-CN,这里设置了，
            // 后面资源查找就会查找这个名称的资源文件进行。
            CultureInfo culture = new CultureInfo(lang);
            Thread.CurrentThread.CurrentUICulture = culture;
            Thread.CurrentThread.CurrentCulture = culture;

            //保存到本地持久化
            DefaultLanguage = lang;
            Properties.Settings.Default.DefaultLanguage = lang;
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// 加载语言
        /// </summary>
        /// <param name="form">加载语言的窗口</param>
        /// <param name="formType">窗口的类型</param>
        public static void LoadLanguage(Form form, Type formType)
        {
            if (form != null)
            {
                ComponentResourceManager resources = new ComponentResourceManager(formType);
                resources.ApplyResources(form, "$this");
                Loading(form, resources);
            }
        }

        /// <summary>
        /// 加载语言
        /// </summary>
        /// <param name="control">控件</param>
        /// <param name="resources">语言资源</param>
        private static void Loading(Control control, ComponentResourceManager resources)
        {
            if (control is MenuStrip)
            {
                //将资源与控件对应
                resources.ApplyResources(control, control.Name);
                MenuStrip ms = (MenuStrip)control;
                if (ms.Items.Count > 0)
                {
                    foreach (ToolStripMenuItem c in ms.Items)
                    {
                        //遍历菜单
                        Loading(c, resources);
                    }
                }
            }

            if (control is StatusStrip)
            {
                //将资源与控件对应
                resources.ApplyResources(control, control.Name);
                StatusStrip ts = (StatusStrip)control;

                foreach (ToolStripItem c in ts.Items)
                {
                    //遍历菜单
                    resources.ApplyResources(c, c.Name);
                }
            }

            //需要大家去完善


            foreach (Control c in control.Controls)
            {
                resources.ApplyResources(c, c.Name);
                Loading(c, resources);
            }
        }

        /// <summary>
        /// 遍历菜单
        /// </summary>
        /// <param name="item">菜单项</param>
        /// <param name="resources">语言资源</param>
        private static void Loading(ToolStripMenuItem item, ComponentResourceManager resources)
        {
            if (item is ToolStripMenuItem)
            {
                resources.ApplyResources(item, item.Name);
                ToolStripMenuItem tsmi = (ToolStripMenuItem)item;
                if (tsmi.DropDownItems.Count > 0)
                {
                    foreach (ToolStripMenuItem c in tsmi.DropDownItems)
                    {
                        Loading(c, resources);
                    }
                }
            }
        }
    }
}
