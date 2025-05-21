using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 基本数据类型Library
{
    public class 数值类型
    {
        public void Printf()
        {
            Console.WriteLine("byte最小值：{0} byte最大值：{1}",byte.MinValue, byte.MaxValue);
            Console.WriteLine("sbyte最小值：{0} sbyte最大值：{1}", sbyte.MinValue, sbyte.MaxValue);
            Console.WriteLine("short最小值：{0} short最大值：{1}", short.MinValue, short.MaxValue);
            Console.WriteLine("ushort最小值：{0} ushort最大值：{1}", ushort.MinValue, ushort.MaxValue);
            Console.WriteLine("int最小值：{0} int最大值：{1}", int.MinValue, int.MaxValue);
            Console.WriteLine("uint最小值：{0} uint最大值：{1}", uint.MinValue, uint.MaxValue);
            Console.WriteLine("long最小值：{0} long最大值：{1}", long.MinValue, long.MaxValue);
            Console.WriteLine("ulong最小值：{0} ulong最大值：{1}", ulong.MinValue, ulong.MaxValue);
            Console.WriteLine("float最小值：{0} float最大值：{1}", float.MinValue, float.MaxValue);
            Console.WriteLine("double最小值：{0} double最大值：{1}", double.MinValue, double.MaxValue);
            //decimail的作用是用来表示货币金额，128 位精确的十进制值，28-29 有效位数
            Console.WriteLine("decimal最小值：{0} decimal最大值：{1}", decimal.MinValue, decimal.MaxValue);
        }
    }
}
