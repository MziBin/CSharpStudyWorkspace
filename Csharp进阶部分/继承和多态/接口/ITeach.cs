using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp进阶部分.继承和多态.接口
{
    /// <summary>
    /// 教学相关的接口
    /// </summary>
    public interface ITeach
    {
        /// <summary>
        /// 教学研究
        /// </summary>
        void StudyCourse();

        /// <summary>
        /// 组织考试
        /// </summary>
        /// <param name="term"></param>
        /// <returns></returns>
        bool Exam(string term);

    }
}
