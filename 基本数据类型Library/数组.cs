using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 基本数据类型Library
{
    public class 数组
    {
        public static void ArrayTest()
        {
            //声明数组,并指定个数,并默认初始化为0
            int[] arr = new int[5];
            int a = arr[0] + arr[1] + arr[2] + arr[3] + arr[4];
            Console.WriteLine(a);

            int[] arr1 = new int[5] { 1, 2, 3, 4, 5 };

            int[] arr2 = { 1, 2, 3, 4, 5 };

            int[] arr3;
            //arr3 = { 1, 2, 3, 4, 5 };//错误,不能这样赋值
            arr3 = new int[] { 1, 2, 3, 4, 5 };
        }
    }
}
