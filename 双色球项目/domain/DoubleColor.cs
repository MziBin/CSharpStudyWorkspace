using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 双色球项目.domain
{
    public class DoubleColor
    {
        public string[] RedBall {  get; set; } = new string[5];
        public string[] BlueBall { get; set; } = new string[1];

        public List<string> ToStrings()
        {
            List<string> lists = new List<string>(RedBall);
            lists.AddRange(BlueBall);
            return lists;
        }

    }
}
