using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp进阶部分.继承和多态
{
    public abstract class Person
    {
        public Person() { }

        public Person(string name,string gender)
        {
            Name = name;
            Gender = gender;
        }

        public string IDNo { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }

        //这两个是抽像方法
        public abstract void Dowork();
        public abstract void Rest();

        //虚方法,就是里面有方法的实现，继承的时候可以不用重写。
        public virtual string GetInfo()
        {
            return $"编号：{IDNo}  姓名：{Name}";
        }
    }
}
