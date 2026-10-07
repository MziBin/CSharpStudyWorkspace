using System.Configuration;
using System.Data;
using System.Windows;
using System.Windows.Threading;

namespace WpfApp_生命周期
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        //应用程序的入口点，通常在这里进行一些全局的初始化操作
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // 在这里可以执行一些应用程序启动时的初始化操作
            //注册全局异常处理程序
            this.DispatcherUnhandledException += App_DispatcherUnhandledException;

            //注册应用程序生命周期事件，也可以通过重写OnActivated、OnDeactivated、OnExit等方法来处理这些事件

            this.Activated += (sender, args) => 
            { 
                Console.WriteLine("app_Activated");
            };

            this.Deactivated += (sender, args) => 
            { 
                Console.WriteLine("app_Deactivated");
            };

            this.Exit += (sender, args) =>
            {
                Console.WriteLine("app_Exit");
            };

            //控制台输出，验证OnStartup方法被调用
            Console.WriteLine("app_onStartup");
        }

        #region 重写应用程序生命周期事件处理方法
        ////应用窗口被激活时调用，通常在这里可以执行一些与用户界面相关的操作
        //protected override void OnActivated(EventArgs e)
        //{
        //    base.OnActivated(e);

        //    Console.WriteLine("app_onActivated");
        //}

        ////应用窗口失去焦点时调用，通常在这里可以执行一些与用户界面相关的操作
        //protected override void OnDeactivated(EventArgs e)
        //{
        //    base.OnDeactivated(e);

        //    Console.WriteLine("app_onDeactivated");
        //}

        ////应用程序即将关闭时调用，通常在这里可以执行一些清理资源的操作
        //protected override void OnExit(ExitEventArgs e)
        //{
        //    base.OnExit(e);
        //    Console.WriteLine("app_onExit");
        //}
        #endregion

        private void App_DispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            MessageBox.Show("发生未处理的异常: " + e.Exception.Message, "错误", MessageBoxButton.OK, MessageBoxImage.Error);
            // 可以选择是否终止应用程序，或者继续运行
            e.Handled = true;
        }
    }

}
