using Csharp进阶部分.继承和多态.接口;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp进阶部分.继承和多态.子类_实现类_
{
    public class President : Person, IMeeting
    {
        public President() { }
        public President(string name) { this.Name = name; }


        public override void Dowork()
        {
            Console.WriteLine("校长开始工作...");
        }
        public override void Rest()
        {
            Console.WriteLine("校长下班休息...");
        }

        //实现接口
        public void Speech()
        {
            Console.WriteLine($"{Name}  校长正在演讲...");
        }
        public string Talk(string topic)
        {
            return $"{Name}  校长正在讨论针对 {topic} ...";
        }

        ////显示实现接口：通常是你实现了两个或两个以上的接口类，但是这些接口类中，有相同的方法
        //void IMeeting.Speech()
        //{
        //    throw new NotImplementedException();
        //}

        //string IMeeting.Talk(string topic)
        //{
        //    throw new NotImplementedException();
        //}

    }
}
