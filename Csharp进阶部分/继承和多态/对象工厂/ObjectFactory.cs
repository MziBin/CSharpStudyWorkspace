using Csharp进阶部分.继承和多态.接口;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;

namespace Csharp进阶部分.继承和多态.对象工厂
{
    /// <summary>
    ///对象工厂
    /// </summary>
    public class ObjectFactory
    {
        /// <summary>
        /// ConfigurationManager。要在引用的程序集中添加System.configuration引用
        /// 在App.config中添加节点信息
        /// assName填写bin生成的exe程序名称(就是程序集)，className前面填写反射类的namespce空间名称。
        /// </summary>
        private static string className = ConfigurationManager.AppSettings["className"];
        private static string assName = ConfigurationManager.AppSettings["assName"];
        /// <summary>
        /// 通过反射返回对应的对象给接口使用
        /// </summary>
        /// <returns></returns>
        public static IMeeting StartSpeechAndTalk()
        {

            // return (IMeeting)Assembly.Load("thinger.cn.TeachDemo03").CreateInstance("thinger.cn.TeachDemo03.Teacher");

            // return new Teacher() { Name = "常老师" };
            // return new President { Name = "王校长" };

            //返回的是object的，要转换一下
            return (IMeeting)Assembly.Load(assName).CreateInstance(className);

        }
    }
}
