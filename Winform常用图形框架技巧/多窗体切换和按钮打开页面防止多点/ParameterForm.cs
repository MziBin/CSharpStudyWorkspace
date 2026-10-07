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
    public partial class ParameterForm : Form
    {
        private static ParameterForm parameter;
        public ParameterForm()
        {
            InitializeComponent();
        }

        public static ParameterForm Instance
        {
            get
            {
                //parameter.IsDisposed一定要判断，否则show关闭后，参数不为null，但是已经释放了。
                if (parameter == null || parameter.IsDisposed)
                {
                    parameter = new ParameterForm();
                }
                return parameter;
            }
        }

    }
}
