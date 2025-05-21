using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 类和对象
{
    public class 方法的创建和调用
    {
        public void GetVoidStudent()
        {
            Console.WriteLine($"无返回值的方法");
        }
        //带默认值的参数，调用时可以不传值
        public int GetIntStudent(int id, string name = "tom")
        {
            //GetStringStudent(18,name);
            //命名参数，可以不按顺序传参
            GetStringStudent(age:18, name:name);
            return id;
        }

        public string GetStringStudent(string name, int age)
        {
            //调用带默认值的参数
            GetIntStudent(18);
            return name + " " + age.ToString();
        }

    }
}
