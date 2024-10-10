using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperLottoRandomSelect.Model
{
    public class Select
    {
        // 红球初始化，使用的list初始化器语法
        public List<string> SelectedRedNumbers { get; set; } = new List<string>
        {
            "01", "02", "03", "04", "05", "06", "07", "08", "09", "10",
            "11", "12", "13", "14", "15", "16", "17", "18", "19", "20",
            "21", "22", "23", "24", "25", "26", "27", "28", "29", "30",
            "31", "32", "33", "34", "35"
        };
        public List<string> SelectedBlueNumbers { get; set; } = new List<string>
        {
            "01", "02", "03", "04", "05", "06", "07", "08", "09", "10",
            "11", "12"
        };
        // 随机数生成器,字段，只在这个类中使用，不需要设置为属性
        private Random random = new Random();

        public SuperLottoModel RandomSelectNumbers()
        {
            SuperLottoModel model = new SuperLottoModel();
            // 红球随机选择
            while (true)
            {
                if (model.RedLotteryNumbers.Count == 5) break;

                string nextNum = SelectedRedNumbers[random.Next(SelectedRedNumbers.Count)];
                if (model.RedLotteryNumbers.Contains(nextNum) )
                {
                    continue;
                } else
                {
                    model.RedLotteryNumbers.Add(nextNum);
                }
            }
            // 蓝球随机选择
            while (true)
            {
                if (model.BlueLotteryNumbers.Count == 2) break;

                string nextNum = SelectedBlueNumbers[random.Next(SelectedBlueNumbers.Count)];
                if (model.BlueLotteryNumbers.Contains(nextNum))
                {
                    continue;
                }
                else
                {
                    model.BlueLotteryNumbers.Add(nextNum);
                }
            }

            return model;
        }

    }
}
