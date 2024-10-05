using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 类和对象
{

    class Program
    {
        //对象初始化器，这样可以快速初始化对象。
        构造函数的使用 test = new 构造函数的使用()
        {
            Id = 2,
            Name = "李",
            Age = 2,
        };
    }

    public class 构造函数的使用
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public 构造函数的使用()
        {
            this.Id = 1;
            this.Name = "张三";
        }
        public 构造函数的使用(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        /// <summary>
        /// 构造函数重载,可以通过this调用其他构造函数。如果有继承可以通过base()调用基类的构造函数。
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="age"></param>
        public 构造函数的使用(int id, string name, int age) : this(id, name)
        {
            this.Age = age;
        }

        ~构造函数的使用()
        {
            Console.WriteLine("析构函数被调用");
        }
    }
}
