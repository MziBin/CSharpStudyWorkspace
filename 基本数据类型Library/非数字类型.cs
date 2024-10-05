using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 基本数据类型Library
{
    /// <summary>
    /// 非数字类型基本使用
    /// </summary>
    public class 非数字类型
    {
        //readonly修饰符声明的变量只能在声明时赋值，不能修改
        readonly bool boolDefault;
        readonly char charDefault;
        readonly string stringDefault;
        readonly DateTime dateTimeDefault;

        #region 显示方法
        /// <summary>
        /// 展示基本的非数字类型使用
        /// </summary>
        public void Show()
        {
            Console.WriteLine("bool类型的值有：{0}和{1} 默认是：{2}", false, true, boolDefault);

            Console.WriteLine("char类型的值大小为：{0} 默认是：{1}", 255, charDefault);

            Console.WriteLine("string类型的占用字节数是不定的 默认是：{0}", stringDefault);

            DateTime now = DateTime.Now;
            DateTime now1 = new DateTime(2024, 09, 30, 16, 16, 23);
            //Convert.ToDateTime方法可以将字符串转换为日期类型
            DateTime now2 = Convert.ToDateTime("2021-12-25");

            Console.WriteLine("DataTime是日期类型。当前日期时间是：{0}", now);

            //object类型可以存储任意类型的值,包括数字类型、字符类型、布尔类型、日期类型等
            object obj = "Hello World";
            Console.WriteLine(obj.GetType());
            obj = 123;
            Console.WriteLine(obj.GetType());
            obj = 3.14;
            Console.WriteLine(obj.GetType());
            obj = true;
            Console.WriteLine(obj.GetType());
            obj = new DateTime(2021, 12, 25);
            Console.WriteLine(obj.GetType());
        }
        #endregion

    }
}
