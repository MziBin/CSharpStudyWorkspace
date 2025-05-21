using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp进阶部分.继承和多态.接口
{
    /// <summary>
    /// 定义一个会议接口
    /// </summary>
    public interface IMeeting
    {
        /// <summary>
        /// 演讲
        /// </summary>
        void Speech();

        /// <summary>
        /// 讨论
        /// </summary>
        /// <param name="topic"></param>
        /// <returns></returns>
        string Talk(string topic);

        //根据需要在继续添加...
    }
}
