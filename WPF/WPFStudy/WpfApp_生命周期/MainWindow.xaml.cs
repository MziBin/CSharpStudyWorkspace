using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp_生命周期
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            #region 注册窗口生命周期事件
            this.SourceInitialized += (sender, args) =>
            {
                Console.WriteLine("mainWindow_SourceInitialized");
            };
            this.Loaded += (sender, args) =>
            {
                Console.WriteLine("mainWindow_Loaded");
            };
            this.ContentRendered += (sender, args) =>
            {
                Console.WriteLine("mainWindow_ContentRendered");
            };
            this.Activated += (sender, args) =>
            {
                Console.WriteLine("mainWindow_Activated");
            };
            this.Deactivated += (sender, args) =>
            {
                Console.WriteLine("mainWindow_Deactivated");
            };
            this.Closing += (sender, args) =>
            {
                Console.WriteLine("mainWindow_Closing");
            };
            this.Closed += (sender, args) =>
            {
                Console.WriteLine("mainWindow_Closed");
            };
            this.Unloaded += (sender, args) =>
            {
                Console.WriteLine("mainWindow_Unloaded");
            };
            #endregion
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            ShowPage showPage = new ShowPage();
            showPage.showPaggeLab(txtInput.Text);
            showPage.Show();
        }
    }
}