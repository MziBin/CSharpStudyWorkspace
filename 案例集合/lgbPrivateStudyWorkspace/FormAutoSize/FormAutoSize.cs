using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test02
{
    //一、我们创建一个类FormAutoSize，然后创建三个字段，分别是窗体宽度、高度和窗体对象。
    public class FormAutoSize
    {    //窗体对象   
        private Form form;
        //定义当前窗体的宽度   
        private float width;
        //定义当前窗体的高度   
        private float height;

        public FormAutoSize(Form form)
        {
            this.form = form; width = this.form.Width;
            height = this.form.Height; SetDescription(this.form);
        }
        /*
         * 二、在FormAutoSize类的构造方法中，初始化宽度、高度和窗体对象，
         * 同时将各个控件的宽度、高度、左边距、上边距以及字体大小，按照指定的格式（这里使用分号拼接）
         * 存储到AccessibleDescription属性里，因为AccessibleDescription属性很少使用，所以存储到这个属性里。
         */
        private void SetDescription(Control cons)
        {
            foreach (Control ctl in cons.Controls)
            {
                ctl.AccessibleDescription = ctl.Width + ";" + ctl.Height + ";" + ctl.Left + ";" + ctl.Top + ";" + ctl.Font.Size;
                //递归       
                if (ctl.Controls.Count > 0)
                {
                    SetDescription(ctl);
                }
            }
        }

        /*
         * 三、接下来就是如何重置窗体控件布局，这里将当前的宽度高度与初始宽度高度进行相除，
         * 会得到比例系数scaleX/scaleY，然后将这个系数叠加进去，
         * 得到新的宽度高度等属性值，然后重新设置控件属性即可。
         * */
        private void SetControls(float scaleX, float scaleY, Control cons)
        {    //遍历窗体中的控件，重新设置控件的值   
            foreach (Control con in cons.Controls)
            {
                //获取控件的AccessibleDescription属性值，并分割后存储字符串数组       
                if (con.AccessibleDescription != null)
                {
                    var tag = con.AccessibleDescription.ToString().Split(';');
                    //根据窗体缩放的比例确定控件的值           
                    con.Width = Convert.ToInt32(Convert.ToSingle(tag[0]) * scaleX);
                    //宽度           
                    con.Height = Convert.ToInt32(Convert.ToSingle(tag[1]) * scaleY);
                    //高度           
                    con.Left = Convert.ToInt32(Convert.ToSingle(tag[2]) * scaleX);
                    //左边距           
                    con.Top = Convert.ToInt32(Convert.ToSingle(tag[3]) * scaleY);
                    //顶边距           
                    var currentSize = Convert.ToSingle(tag[4]) * scaleY;
                    //字体大小                              
                    if (currentSize > 0)
                    {
                        con.Font = new Font(con.Font.Name, currentSize, con.Font.Style, con.Font.Unit);
                    }
                    con.Focus();
                    if (con.Controls.Count > 0)
                    {
                        SetControls(scaleX, scaleY, con);
                    }
                }
            }
        }

        /// <summary> /// 重置窗体布局 /// </summary> 
        public void ResumeLayout()
        {
            var scaleX = form.Width / width;
            var scaleY = form.Height / height;
            SetControls(scaleX, scaleY, form);
        }
    }
}
