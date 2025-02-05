using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyUiControl
{
    public partial class userTextBox : TextBox
    {
        public userTextBox()
        {
            InitializeComponent();
        }

        public userTextBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public int BeginCheckEmpty()
        {
            if (this.Text.Trim() == "")
            {
                this.errorProvider.SetError(this, "必填项不能为空！");
                return 0;
            }
            else
            {
                this.errorProvider.SetError(this, string.Empty);
                return 1;
            }
        }

        /// <summary>
        /// 使用正则表达式验证复杂数据
        /// </summary>
        /// <param name="regularExpress">正则表达式</param>
        /// <param name="errorMsg">错误提示</param>
        /// <returns></returns>
        public int BeginCheckData(string regularExpress, string errorMsg)
        {
            if (BeginCheckEmpty() == 0) return 0;//如果为空，则直接返回
            //正则表达式验证（忽略大小写）
            Regex objRegex = new Regex(regularExpress, RegexOptions.IgnoreCase);
            if (!objRegex.IsMatch(this.Text.Trim()))
            {
                this.errorProvider.SetError(this, errorMsg);
                return 0;
            }
            else
            {
                this.errorProvider.SetError(this, string.Empty);//清除小圆点的错误提示
                return 1;
            }
        }

        //根据需要把常用的正则表达式验证封装到这里...

    }
}
