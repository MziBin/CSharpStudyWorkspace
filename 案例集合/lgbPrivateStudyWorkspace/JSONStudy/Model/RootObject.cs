using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONStudy.Model
{
    // 对应最外层的JSON对象结构
    public class RootObject
    {
        public List<Offset> offsets { get; set; }
        public int Ver { get; set; }
    }

    // 对应 "offsets" 数组中的每个对象元素
    public class Offset
    {
        public List<CountryValue> list { get; set; }
        //使用decimal类型，double有精度问题
        public decimal fY { get; set; }
        public decimal fX { get; set; }
        public string Name { get; set; }
    }

    // 对应 "list" 数组中的每个对象元素
    public class CountryValue
    {
        public string Country { get; set; }
        public decimal fValue { get; set; }
    }
}
