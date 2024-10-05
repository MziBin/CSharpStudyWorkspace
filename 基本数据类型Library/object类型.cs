using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 基本数据类型Library
{
    public class object类型
    {
        public static void Show()
        {
            //object可以存储任意类型的数据。
            object obj = 10.6;
            //obj类型的必须要先转换为本上的数据类型，才能在转换成其它类型。
            //int i = (int)obj + 10;//报错
            int i = (int)(double)obj + 10;//这样先转换成double类型，才转成int类型就不会报错。

            Console.WriteLine(i);
        }
    }
}
