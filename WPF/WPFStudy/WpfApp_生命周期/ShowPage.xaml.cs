using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp_生命周期
{

    /// <summary>
    /// ShowPage.xaml 的交互逻辑
    /// </summary>
    public partial class ShowPage : Window
    {
        public ShowPage()
        {
            InitializeComponent();

            #region 注册窗口生命周期事件

            //创建窗口时调用，通常在这里可以执行一些初始化操作
            this.SourceInitialized += (sender, args) =>
            {
                Console.WriteLine("showPage_SourceInitialized");
            };
            //窗口加载完成时调用，通常在这里可以执行一些与用户界面相关的操作
            this.Loaded += (sender, args) =>
            {
                Console.WriteLine("showPage_Loaded");
            };
            //窗口内容呈现完成时调用，通常在这里可以执行一些与用户界面相关的操作
            this.ContentRendered += (sender, args) =>
            {
                Console.WriteLine("showPage_ContentRendered");
            };
            //窗口被激活时调用，通常在这里可以执行一些与用户界面相关的操作
            this.Activated += (sender, args) =>
            {
                Console.WriteLine("showPage_Activated");
            };
            //窗口失去焦点时调用，通常在这里可以执行一些与用户界面相关的操作
            this.Deactivated += (sender, args) =>
            {
                Console.WriteLine("showPage_Deactivated");
            };
            //窗口即将关闭时调用，通常在这里可以执行一些清理资源的操作
            this.Closing += (sender, args) =>
            {
                Console.WriteLine("showPage_Closing");
            };
            //窗口已经关闭时调用，通常在这里可以执行一些清理资源的操作
            this.Closed += (sender, args) =>
            {
                Console.WriteLine("showPage_Closed");
            };
            //窗口卸载时调用，通常在这里可以执行一些清理资源的操作，注意这个不是窗口生命周期事件，而是一个普通事件，只有当窗口被卸载时才会触发
            this.Unloaded += (sender, args) =>
            {
                Console.WriteLine("showPage_Unloaded");
            };

            #endregion

        }

        public void showPaggeLab(string s)
        {
            this.lblDisplay.Content = s;
        }

    }
}
