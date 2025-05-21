using MultiLanguageDemo2JSON.Common;
using MultiLanguageDemo2JSON.UI;
using System.Collections.Generic;
using System.IO;
using System.Configuration;
using System;


namespace MultiLanguageDemo2JSON.BLL
{
    public class LanguageService
    {
        //唯一的new对象，单例设计模式，构造函数私有化
        private static readonly LanguageService _instance = new LanguageService();
        //定义了一个静态只读的Instance的属性，返回_instance。=> 可以理解为get的labdma写法
        public static LanguageService Instance => _instance;
        //存储对应的语言json数据
        private Dictionary<string, string> _currentLanguageResources;
        //当前使用的语言
        private string _currentLanguage;
        //
        private readonly List<IMultiLanguageSupport> _subscribedForms = new List<IMultiLanguageSupport>();
        //private readonly string _languageFilePath = Path.Combine(
        //    Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
        //    "TESTProject",
        //    "language.settings"
        //);
        //本地持久化的字符串存放路劲
        private readonly string _languageFilePath = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "language.settings");
        private LanguageService()
        {
            _currentLanguageResources = new Dictionary<string, string>();
            // 创建存储文件夹（如果不存在）
            Directory.CreateDirectory(Path.GetDirectoryName(_languageFilePath));
            // 读取本地保存的语言字符串
            _currentLanguage = ReadSavedLanguage();
            //不为空则设置
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
        /// <summary>
        /// 更新语言
        /// </summary>
        /// <param name="languageCode"></param>
        public void LoadLanguage(string languageCode)
        {
            _currentLanguage = languageCode;
            var filePath = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "Resources", "Languages", $"{languageCode}.json");
            //读取给定的语言字符串的json文件，并保存到字典中
            _currentLanguageResources = JsonHelper.ReadJsonFile<Dictionary<string, string>>(filePath);
            // 保存当前语言设置
            SaveLanguage(languageCode);
            // 通知所有订阅的窗口更新语言
            NotifySubscribers();
        }
        /// <summary>
        /// 根据key获取值
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public string GetString(string key)
        {
            if (_currentLanguageResources.TryGetValue(key, out var value))
            {
                return value;
            }
            return key;
        }
        /// <summary>
        /// 获取当前语言
        /// </summary>
        /// <returns></returns>
        public string GetCurrentLanguage()
        {
            return _currentLanguage;
        }
        /// <summary>
        /// 读取本地保存的语言数据
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// 持久化语言
        /// </summary>
        /// <param name="languageCode"></param>
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
        /// 将所有展示的窗口加入列表，用于统一更新页面
        /// </summary>
        /// <param name="form"></param>
        public void Subscribe(IMultiLanguageSupport form)
        {
            //将没有的加入列表中的窗口更新数据
            if (!_subscribedForms.Contains(form))
            {
                _subscribedForms.Add(form);
                form.ApplyLanguage();
            }
        }
        /// <summary>
        /// 移除关闭的窗口
        /// </summary>
        /// <param name="form"></param>
        public void Unsubscribe(IMultiLanguageSupport form)
        {
            _subscribedForms.Remove(form);
        }
        /// <summary>
        /// 统一更新所有展示的页面
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
