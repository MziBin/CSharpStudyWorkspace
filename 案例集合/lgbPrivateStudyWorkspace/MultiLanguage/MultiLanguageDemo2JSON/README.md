## 多语言切换想法

将多语言切换从项目分离出来，变成一个独立的模块。

这样每个新的项目就能够使用它，而避免2.3年后的代码臃肿。

## 架构搭建

1.每个国家语言一个单独的json文件，这样后期可以通过编写一些小工具，直接翻译输出。



## 多语言接口的使用

### 基本环境搭建

在项目中添加languageService服务。

JSONhelper工具

IMultiLanguageSupport的formUI的基础接口

### 展示的form页面需要添加的

//多语言切换的接口创建，这个是成员变量
private readonly ILanguageService _languageService = LanguageServiceImpl.Instance;

// 订阅语言切换通知，这个在form的构造函数中
_languageService.Subscribe(this);

//订阅更新的接口实现，将form窗口中，所有的控件都写入进去
public void ApplyLanguage()
{
    //根据json的键获取值展示
    this.Text = _languageService.GetString("FormTitle");
    button1.Text = _languageService.GetString("ButtonText");
}

### 语言切换按钮

根据要展示的JSON语言文件进行调用，zh-CN.json文件或者其它语言文件。

_languageService.LoadLanguage("zh-CN");

### 弹窗的多语言化

目前只可以更改弹窗的标题和内容，按钮文本暂时无法更改

```
// 从语言服务中获取对应语言的文本,更改按钮的文本没用
//string yesText = _languageService.GetString("YesButtonText");
//string noText = _languageService.GetString("NoButtonText");
string message = _languageService.GetString("MessageBoxMessage");
string caption = _languageService.GetString("MessageBoxCaption");

// 使用包含自定义按钮文本的 MessageBox.Show 重载方法
//DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, 0, yesText, noText);
DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

if (result == DialogResult.Yes)
{
    // 处理“是”按钮点击事件
    MessageBox.Show("你点击了是");
}
else if (result == DialogResult.No)
{
    // 处理“否”按钮点击事件
    MessageBox.Show("你点击了否");
}
```

1

### 注意事项

要更改LoadLanguage中，调用的json文件路径为自己的。
