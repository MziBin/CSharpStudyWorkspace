using MultiLanguageDemo2JSON.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLanguageDemo2JSON.Service
{
    public interface ILanguageService
    {
        void LoadLanguage(string languageCode);
        string GetString(string key);
        /// <summary>
        /// 获取当前语言
        /// </summary>
        /// <returns></returns>
        string GetCurrentLanguage();
        void Subscribe(IMultiLanguageSupport form);
        void Unsubscribe(IMultiLanguageSupport form);
    }
}
