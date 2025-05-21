using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 类和对象
{
    public class 主动垃圾回收
    {
        public void GCTest(String[] args)
        {
            GC.Collect();
        }
    }
}
