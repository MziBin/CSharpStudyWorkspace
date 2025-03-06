using MultiLanguageDemo2JSON.BLL;
using MultiLanguageDemo2JSON.Common;
using MultiLanguageDemo2JSON.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLanguageDemo2JSON.Service
{
    public class LanguageServiceImpl : ILanguageService
    {
        private static readonly LanguageServiceImpl _instance = new LanguageServiceImpl();
        public static LanguageServiceImpl Instance => _instance;

        private Dictionary<string, string> _currentLanguageResources;
        private string _currentLanguage;
        private readonly List<IMultiLanguageSupport> _subscribedForms = new List<IMultiLanguageSupport>();
        //private readonly string _languageFilePath = Path.Combine(
        //    Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
        //    "YourProject",
        //    "language.settings"
        //);
        //本地持久化的字符串存放路劲,放到debug下面的
        private readonly string _languageFilePath = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "language.settings");

        private LanguageServiceImpl()
        {
            _currentLanguageResources = new Dictionary<string, string>();
            // 创建存储文件夹（如果不存在）
            Directory.CreateDirectory(Path.GetDirectoryName(_languageFilePath));
            // 读取保存的语言设置
            _currentLanguage = ReadSavedLanguage();
            if (!string.IsNullOrEmpty(_currentLanguage))
            {
                LoadLanguage(_currentLanguage);
            }
            else
            {
                // 默认语言
                LoadLanguage("en-US");
            }
        }

        public void LoadLanguage(string languageCode)
        {
            _currentLanguage = languageCode;
            var filePath = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "Resources", "Languages", $"{languageCode}.json");
            _currentLanguageResources = JsonHelper.ReadJsonFile<Dictionary<string, string>>(filePath);
            // 保存当前语言设置
            SaveLanguage(languageCode);
            // 通知所有订阅的窗口更新语言
            NotifySubscribers();
        }

        public string GetString(string key)
        {
            if (_currentLanguageResources.TryGetValue(key, out var value))
            {
                return value;
            }
            return key;
        }

        public string GetCurrentLanguage()
        {
            return _currentLanguage;
        }

        private string ReadSavedLanguage()
        {
            try
            {
                if (File.Exists(_languageFilePath))
                {
                    return File.ReadAllText(_languageFilePath);
                }
            }
            catch (Exception ex)
            {
                // 记录日志或进行其他处理
                Console.WriteLine($"读取语言设置文件时出错: {ex.Message}");
            }
            return null;
        }

        private void SaveLanguage(string languageCode)
        {
            try
            {
                File.WriteAllText(_languageFilePath, languageCode);
            }
            catch (Exception ex)
            {
                // 记录日志或进行其他处理
                Console.WriteLine($"保存语言设置文件时出错: {ex.Message}");
            }
        }
        /// <summary>
        /// 加入订阅
        /// </summary>
        /// <param name="form"></param>
        public void Subscribe(IMultiLanguageSupport form)
        {
            if (!_subscribedForms.Contains(form))
            {
                _subscribedForms.Add(form);
                form.ApplyLanguage();
            }
        }
        /// <summary>
        /// 移除订阅
        /// </summary>
        /// <param name="form"></param>
        public void Unsubscribe(IMultiLanguageSupport form)
        {
            _subscribedForms.Remove(form);
        }
        /// <summary>
        /// 执行
        /// </summary>
        private void NotifySubscribers()
        {
            foreach (var form in _subscribedForms)
            {
                form.ApplyLanguage();
            }
        }
    }
}
