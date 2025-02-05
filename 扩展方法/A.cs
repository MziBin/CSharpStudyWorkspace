using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 扩展方法
{
    static class A
    {
        /// <summary>
        /// 对int数据类型的扩展方法
        /// </summary>
        /// <param name="i">调用这个方法的对象</param>
        /// <returns></returns>
        public static int toParse(this int i, string str)
        {
            Console.WriteLine("将字符串{0}解析成功", str);
            return int.Parse(str);
        }
    }
}
