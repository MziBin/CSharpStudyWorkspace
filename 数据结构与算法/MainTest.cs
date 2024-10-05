using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 数据结构与算法;

namespace 数据结构与算法
{
    public class MainTest
    {
        public void Maintest()
        {
            两数之和_力扣_1 and = new 两数之和_力扣_1();
            int[] result = and.TwoSum(new int[] { 3, 2, 4 }, 6);
            foreach (int i in result)
            {
                Console.WriteLine(i);
            }
        }
    }
}
