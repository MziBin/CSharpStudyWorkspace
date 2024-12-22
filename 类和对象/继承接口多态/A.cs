using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 类和对象.继承接口多态
{
    public class A : AbstractD
    {
        //必须通过override覆盖方法
        public override void ADtest()
        {
            throw new NotImplementedException();
        }

        public void Atest()
        {
            Console.WriteLine($"这是A类");
        }
    }
}
