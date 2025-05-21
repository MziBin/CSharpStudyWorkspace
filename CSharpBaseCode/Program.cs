using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 基本数据类型Library;
using 数据结构与算法;
using 类和对象;

namespace CSharpBaseCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //第一个程序
            Console.WriteLine("Hello World!");
            //第二个程序,数据类型
            new 数值类型().Printf();
            new 非数字类型().Show();
            字符串.字符串输出格式化();
            //Object类型
            object类型.Show();
            //数组
            数组.ArrayTest();
            //枚举
            TestEnum.EnumDemo();
            //类和对象
            构造函数的使用 tc = new 构造函数的使用();
            //tc对象的引用指向为null
            tc = null;
            //垃圾回收
            GC.Collect();


            //数据结构与算法
            MainTest mainTest = new MainTest();
            mainTest.Maintest();
        }
    }
}
