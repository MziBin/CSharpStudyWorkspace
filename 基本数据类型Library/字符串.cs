using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 基本数据类型Library
{
    public class 字符串
    {
        #region 字符串的简单使用
        public void Show()
        {
            //字符串格式化拼接
            string str1 = "Hello";
            string str2 = "World";
            string str3 = string.Format("{0} {1}", str1, str2);
            Console.WriteLine(str3);

            //字符串连接
            string str4 = "Hello" + "World";
            Console.WriteLine(str4);

            //$符号的用法，类似于C#的字符串模板
            string str11 = "Hello";
            string str12 = "World";
            string str13 = $"Hello {str11} {str12}";
            Console.WriteLine(str13);

            //字符串比较
            string str5 = "Hello";
            string str6 = "World";
            bool result = string.Compare(str5, str6) > 0;
            Console.WriteLine(result);

            //字符串查找
            string str7 = "Hello World";
            int index = str7.IndexOf("World");
            Console.WriteLine(index);

            //字符串分割
            string str8 = "Hello,World";
            string[] strArray = str8.Split(',');
            Console.WriteLine(strArray[0]);
            Console.WriteLine(strArray[1]);

            //字符串替换
            string str9 = "Hello World";
            string str10 = str9.Replace("World", "Universe");
            Console.WriteLine(str10);
        }
        #endregion

        public static void 字符串输出格式化()
        {
            //字符串格式化输出，带有浮点数
            double pi = 3.1415926;
            //输出保留两位小数
            string str3 = string.Format("The value of pi is {0:F2}.", pi);
            Console.WriteLine(str3);
            //字符串格式化输出，带有货币符号
            decimal price = 1234.56m;
            string str4 = string.Format("The price is {0:C}.", price);
            Console.WriteLine(str4);
            //字符串格式化输出，带有日期时间
            DateTime dt = DateTime.Now;
            string str5 = string.Format("The date and time is {0:D}.", dt);
            Console.WriteLine(str5);
            //字符串格式化输出，前面空2格
            string str6 = string.Format("The value of pi is {0,10}.", pi);
            Console.WriteLine(str6);
            //字符串格式化输出，后面空2格
            string str7 = string.Format("The value of pi is {0,-10:F2}.", pi);
            Console.WriteLine(str7);
        }
    }
}
