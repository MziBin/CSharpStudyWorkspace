using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 双色球项目.Help
{
    public class StartOne
    {
        private Random random = new Random();

        private List<string> RedBall {  get;} = new List<string>()
        {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10",
            "11", "12", "13", "14", "15", "16", "17", "18", "19", "20",
            "21", "22", "23", "24", "25", "26", "27", "28", "29", "30",
            "31", "32", "33"
        };

        private List<string> BuleBall { get;} = new List<string>()
        {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10",
            "11", "12", "13", "14", "15", "16"
        };

        public List<string> GenerateRedBalls()
        {
            List<string> list = new List<string>();
            while (list.Count < 6)
            {
                int i = random.Next(0,33);
                if (list.Contains(RedBall[i] ) )
                {
                    list.Add(RedBall[i]);
                }
            }
            return list;
        }

        public List<string> GenerateBuleBalls()
        {
            List<string> list = new List<string>();
            while (list.Count < 1)
            {
                int i = random.Next(0, 16);
                list.Add(BuleBall[i]);
            }
            return list;
        }
    }
}
