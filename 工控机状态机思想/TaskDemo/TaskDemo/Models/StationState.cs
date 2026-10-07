using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskDemo.Models
{
    /// <summary>
    /// 工位全局状态
    /// </summary>
    public enum StationState
    {
        Idle,      // 待机
        Ready,     // 准备
        Run,       // 运行
        StepWait,  // 单步等待
        Finish,    // 完成
        Alarm      // 报警
    }
}
