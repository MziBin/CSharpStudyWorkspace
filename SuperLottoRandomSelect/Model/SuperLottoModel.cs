using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperLottoRandomSelect.Model
{
    /// <summary>
    /// 用于存放大乐透号码的模型类，包含红球号码和蓝球号码两个列表
    /// </summary>
    public class SuperLottoModel
    {
        public List<string> RedLotteryNumbers { get; set; } = new List<string>();
        public List<string> BlueLotteryNumbers { get; set; } = new List<string>();
    }
}
