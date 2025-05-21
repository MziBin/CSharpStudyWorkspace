using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMain1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Phone phone = new Phone("123456789", Brand.XiaoMi)
            {
                //对象初始化器，没有set属性的无法这样使用
                PhoneColour = Colour.Black
            };
            phone.Dial();
        }
    }
}
