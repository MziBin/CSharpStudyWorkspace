using Csharp进阶部分.继承和多态.接口;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp进阶部分.继承和多态.子类_实现类_
{
    public class Teacher : Person, IMeeting, ITeach
    {
        //特有的属性
        public string Post { get; set; }
        public string PhoneNumber { get; set; }

        public Teacher()
        { }
        public Teacher(string name)
        {
            this.Name = name;
        }
        public Teacher(string name, string phone)
        {
            this.Name = name;
            this.PhoneNumber = phone;
        }
        //特有的方法
        public void Lecture()
        {
            Console.WriteLine($"【子类】方法输出：{Name} 正在授课... ");
        }

        /// <summary>
        /// 重写父类的方法
        /// </summary>
        public override void Dowork()
        {
            Console.WriteLine("老师开始工作...");
        }
        public override void Rest()
        {
            Console.WriteLine("老师下班休息...");
        }

        /// <summary>
        /// 来自IMeeting接口实现方法1：演讲
        /// </summary>
        public void Speech()
        {
            Console.WriteLine($"{Name}  老师正在演讲...");
        }
        /// <summary>
        /// 来自IMeeting接口实现方法2：讨论
        /// </summary>
        /// <param name="topic"></param>
        /// <returns></returns>
        public string Talk(string topic)
        {
            return $"{Name}  老师正在讨论针对 {topic} ...";
        }

        /// <summary>
        /// 来自ITeach的接口实现方法1：教学研究
        /// </summary>
        public void StudyCourse()
        {
            Console.WriteLine("老师正在研究教学内容...");
        }
        /// <summary>
        ///  来自ITeach的接口实现方法2：组织考试
        /// </summary>
        /// <param name="term"></param>
        /// <returns></returns>
        public bool Exam(string term)
        {

            //其他相关的业务处理。。。。

            return true;
        }
    }
}
