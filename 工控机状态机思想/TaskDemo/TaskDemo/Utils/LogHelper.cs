using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskDemo.Utils
{
    /// <summary>
    /// 全局日志工具
    /// </summary>
    public static class LogHelper
    {
        public static TextBox LogTextBox { get; set; }

        public static void Write(string content)
        {
            if (LogTextBox == null) return;

            if (LogTextBox.InvokeRequired)
            {
                LogTextBox.Invoke(new Action(() => Write(content)));
                return;
            }

            string log = $"{DateTime.Now:HH:mm:ss}  {content}\r\n";
            LogTextBox.AppendText(log);
            LogTextBox.ScrollToCaret();
        }
    }
}
