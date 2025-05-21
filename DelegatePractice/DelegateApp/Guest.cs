using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateApp
{
    public class Guest
    {
        public int Number { get; set; }//序号
        public string Name { get; set; }
        public int VoteCounter { get; set; } = 0;//得票数
    }
}
