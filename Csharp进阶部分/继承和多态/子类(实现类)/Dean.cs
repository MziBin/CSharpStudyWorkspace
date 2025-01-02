using Csharp进阶部分.继承和多态.接口;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp进阶部分.继承和多态.子类_实现类_
{
    public class Dean : IMeeting
    {
        public void Speech()
        {
            Console.WriteLine($"主任正在演讲...");
        }
        public string Talk(string topic)
        {
            return $"主任正在讨论针对 {topic} ...";
        }
    }
}
