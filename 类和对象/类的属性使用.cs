using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp高级
{
    public class 类的属性使用
    {
        private long id;
        private int age;

        //C#2.0 实现属性的get和set标准写法
        public long Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
        //c#3.0 新特性，自动实现属性的get和set方法 可以不写name字段，编译后会自动生成。
        //这样是不需要对Name进行赋值操作和判断就可以这样写。
        public string Name { get; set; }

        //c#4.0 新特性，lamdba表达式简化属性的get和set方法
        public int Age
        {
            get => age;
            set => age = value;
        }

        //设置属性的只读特性，可以赋初始值，但是注意，只有自动生成的属性才赋初始值
        public int birthYear { get; } = 2000;

        //设置属性为只可写特性,不行必须有get方法
        //public string Address {set; }

    }
}
