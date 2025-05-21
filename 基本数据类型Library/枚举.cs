using Microsoft.Azure.Management.DataFactory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 基本数据类型Library
{

    public enum Sex
    {
        Male,
        Female
    }

    public class 枚举
    {
        //类中也可以定义枚举类型，而且外面也可以调用，把枚举当成一个静态类型就好了，通过类名直接调用。
        public enum Weekdays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        public void 枚举Demo()
        {
            #region 枚举类型DaysOfWeek
            DaysOfWeek day = DaysOfWeek.Monday;
            switch(day)
            {
                case DaysOfWeek.Monday:
                    Console.WriteLine("星期一");
                    break;
                case DaysOfWeek.Tuesday:
                    Console.WriteLine("星期二");
                    break;
                case DaysOfWeek.Wednesday:
                    Console.WriteLine("星期三");
                    break;
                case DaysOfWeek.Thursday:
                    Console.WriteLine("星期四");
                    break;
                case DaysOfWeek.Friday:
                    Console.WriteLine("星期五");
                    break;
                case DaysOfWeek.Saturday:
                    Console.WriteLine("星期六");
                    break;
                case DaysOfWeek.Sunday:
                    Console.WriteLine("星期日");
                    break;
                default:
                    Console.WriteLine("无效的星期");
                    break;
            }
            #endregion

            #region 枚举类型Sex
            Sex sex = Sex.Male;
            switch (sex)
            {
                case Sex.Male:
                    Console.WriteLine("男");
                    break;
                case Sex.Female:
                    Console.WriteLine("女");
                    break;
                default:
                    Console.WriteLine("无效的性别");
                    break;
            }
            #endregion
        }
    }

    public class TestEnum
    {
        public static void EnumDemo()
        {
            枚举 demo = new 枚举();
            枚举.Weekdays weekday = 枚举.Weekdays.Monday;
            switch (weekday)
            {
                case 枚举.Weekdays.Monday:
                    Console.WriteLine("星期一");
                    break;
                case 枚举.Weekdays.Tuesday:
                    Console.WriteLine("星期二");
                    break;
                case 枚举.Weekdays.Wednesday:
                    Console.WriteLine("星期三");
                    break;
                case 枚举.Weekdays.Thursday:
                    Console.WriteLine("星期四");
                    break;
                case 枚举.Weekdays.Friday:
                    Console.WriteLine("星期五");
                    break;
                case 枚举.Weekdays.Saturday:
                    Console.WriteLine("星期六");
                    break;
                case 枚举.Weekdays.Sunday:
                    Console.WriteLine("星期日");
                    break;
                default:
                    Console.WriteLine("无效的星期");
                    break;
            }
        }
    }
}
