using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskDemo.IO
{
    /// <summary>
    /// 虚拟IO层，后续对接PLC/运动卡只改这里
    /// </summary>
    public class VirtualIO
    {
        // 启动信号
        public bool StartSignal { get; set; }
        // 报警信号
        public bool AlarmSignal { get; set; }
        // 完成信号
        public bool FinishSignal { get; set; }

        /// <summary>
        /// 清空所有信号
        /// </summary>
        public void ResetAllSignal()
        {
            StartSignal = false;
            AlarmSignal = false;
            FinishSignal = false;
        }
    }
}
