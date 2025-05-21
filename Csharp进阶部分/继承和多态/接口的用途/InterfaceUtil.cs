using Csharp进阶部分.继承和多态.接口;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp进阶部分.继承和多态.接口的用途
{
    public class InterfaceUtil
    {
        /// <summary>
        /// 用途一：通过传入不同的实现类，来实现不同的事情。
        /// </summary>
        /// <param name="meeting"></param>
        public static void StartSpeechAndTalk(IMeeting meeting)
        {
            meeting.Speech();
            string content = meeting.Talk("《学习完毕后的就业问题》");
            Console.WriteLine(content);
        }
        //用途二：通过反射，返回对应的接口实现类。

    }
}
