using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数据结构与算法
{
    public class 拥有最多糖果的孩子_力扣_1431
    {
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            bool[] result = new bool[candies.Length];

            for (int i = 0; i < candies.Length; i++)
            {
                result[i] = true;

                int t = candies[i] + extraCandies;
                for (int j = 0; j < candies.Length; j++)
                {
                    if(t < candies[j])
                    {
                        result[i] = false;
                    }
                }
            }

            return result;
        }
    }
}
