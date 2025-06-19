# WinForm笔记

## 1.项目结构规范

### 1.1 命名规范

主窗口要改名，改成和项目相关的名字，如TrayToTrayMainForm。

主窗体对象的创建：在Program类里面：  Application.Run(new FrmMain());

## 2.代码结构简介

Form类通过partial分为两个类。避免混乱，如果觉得还是分的，也可以通过partial在分一个类。

Form.Designer：主要是代码自动生成的一些属性，很少动的。

InitializeComponent就是在Form.Designer中，如果不加partial就会在一个类中很混乱。

Form：主要是事件，经常编辑的

### 2.1 控件对象与窗体容器集合（Controls）

控件对象与窗体容器集合（Controls）

#### 2.1.1 Controls

**每个窗口**都会有一个Controls，里面放着所有控件集合。

可以通过 `Controls.SetChildIndex` 方法来改变控件dock的顺序。

#### 2.1.2 Control

```
在.NET 框架中，大多数 Windows Forms 控件都继承自System.Windows.Forms.Control类

在 C# 的 Windows Forms 编程中，Form 类继承自 Control 类，所以 Form 属于 Control。下面为你详细解释相关内容。
继承关系说明
在 .NET 的 Windows Forms 库中，Control 类是所有用户界面控件的基类，它提供了控件的基本功能，像显示、布局、事件处理等。而 Form 类继承自 ContainerControl，ContainerControl 又继承自 ScrollableControl，ScrollableControl 最终继承自 Control。这种继承关系使得 Form 拥有 Control 的所有特性，同时还具备窗体特有的功能，如标题栏、边框、最大化最小化按钮等。
```

可以通过遍历Controls获取每个控件或者容器

```
//首先判断容器中是否有其他的窗体
foreach (Control item in Controls)
{
    if (item is Button)
    {
  
    }
}
```

#### 【1】控件和组件的区别：控件是在窗体上可见的。组件是在窗体下面不可见的，也就是不占用窗体的空间。也就是没有可视化的界面。

【2】按钮控件的使用与代码分析。控件从拖放到显示，经过的步骤：

第一、创建该对象的成员变量。

第二、初始化这个成员变量的相关属性。（我们可以通过可视化属性窗口完成）

第三、窗体本身是一个容器，所有的控件，都会加到Controls集合中。

当我在窗体上添加一个容器控件的时候（比如GroupBox或者Panel）容器控件和其他的控件一样，也会被添加到Controls集合中。当我在容器中添加相关的控件的时候，这时候，容器中的控件，会添加到当前容器的Controls集合中，而不是窗体的Controls中，请大家务必记住。

2.1.1 窗体的所有控件都是成员变量，在Designer中声明。

2.1.2 InitializeComponent方法里面的代码最好不要改动

#### 2.2.1 控件所需代码

```csharp
第一、创建该对象的成员变量。默认在Designer.cs中创建的
private Button btnMinimize;
第二、初始化这个成员变量的相关属性。（我们可以通过可视化属性窗口完成），当然也不一定都要在InitializeComponent中初始化。
 private void InitializeComponent()
 {
btnMinimize = new Button();
// 
// btnMinimize
// 
btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
btnMinimize.Location = new Point(967, 9);
btnMinimize.Margin = new Padding(2);
btnMinimize.Name = "btnMinimize";
btnMinimize.Size = new Size(22, 24);
btnMinimize.TabIndex = 2;
btnMinimize.Text = "-";
btnMinimize.UseVisualStyleBackColor = true;
btnMinimize.Click += btnMinimize_Click;

}

第三、窗体本身是一个容器，所有的控件，都会加到Controls集合中。这是加入了panel容器下面的Controles中。
panel1.Controls.Add(btnMinimize);

```

#### 2.2.2 事件的基本代码

```csharp
 private void InitializeComponent()
 {
btnMinimize = new Button();
// 
// btnMinimize
// 
btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
btnMinimize.Location = new Point(967, 9);
btnMinimize.Margin = new Padding(2);
btnMinimize.Name = "btnMinimize";
btnMinimize.Size = new Size(22, 24);
btnMinimize.TabIndex = 2;
btnMinimize.Text = "-";
btnMinimize.UseVisualStyleBackColor = true;
btnMinimize.Click += btnMinimize_Click;
//添加当对应的事件触发时，执行的方法
btnToggleMaximize.Click += btnToggleMaximize_Click;
}
//执行的方法
private void btnMinimize_Click(object sender, EventArgs e)
{
    this.WindowState = FormWindowState.Minimized;
}

```

1

#### 事件的sender参数

sender就是当前调用的对象，使用时，只需要转换一下对应的对象类型。

```
private void button1_Click(object sender, EventArgs e)
{
	Button btn = (Button)sender;
}
```

#### EventArgs

EventArgs只是一个类

控件中的都是事件要传递的方法，都是类，里面不是事件和委托，只是用来绑定事件和委托的方法。

#### 事件的统一关联

就是将多个事件都统一成一个，多个事件调用这一个事件处理方法即可。

##### 控件的Tag属性

### 2.2程序对窗体的操作

每个程序都有个管理窗体的类Application，可以获取程序中所有的窗体操作。可以看成程序是一个大窗体，根节点，窗体就是这个程序的泛伸。

## 3. WinForm基本使用

### 绘制机制

在类库中，有个窗口，里面有个label标签，pic_Main是一个pictureBox，想设置label标签为透明的，要加下面的才有用，为什么this.label1.Parent = this.pic_Main;

在 Windows Forms 中，当你将 `Label` 控件的 `Parent` 属性设置为 `PictureBox`（如 `this.label1.Parent = this.pic_Main;`）后，`Label` 控件看起来变为透明，这主要和 Windows Forms 的绘制机制与控件的层次结构有关，下面为你详细解释：

#### 1. 绘制机制

在 Windows Forms 里，每个控件都会在其自身的区域绘制内容。默认情况下，`Label` 控件会绘制一个不透明的背景，将其背后的内容覆盖。当你设置 `Label` 的 `BackColor` 为 `Color.Transparent` 时，本意是想让它显示背后的内容，但这并不意味着它真的 “透明” 了。

#### 2. 控件层次结构与父容器

当你执行 `this.label1.Parent = this.pic_Main;` 时，你改变了 `Label` 控件的父容器，把 `Label` 放在了 `PictureBox` 之上。这时候，`Label` 控件会认为它的背景应该是 `PictureBox` 的内容。

#### 3. 透明效果的实现原理

* **绘制顺序** ：Windows Forms 会按照控件的层次结构依次绘制控件。当 `Label` 的父容器是 `PictureBox` 时，`PictureBox` 会先被绘制，然后再绘制 `Label`。
* **透明背景处理** ：当 `Label` 的 `BackColor` 被设置为 `Color.Transparent` 时，`Label` 不会绘制自己的背景，而是直接显示父容器（即 `PictureBox`）的内容，从而实现了透明效果。

#### 示例代码

以下是一个简单的示例，展示了如何通过设置 `Parent` 属性让 `Label` 控件实现透明效果：

csharp

```csharp
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TransparentLabelExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // 创建 PictureBox 控件
            PictureBox pic_Main = new PictureBox();
            pic_Main.Image = Image.FromFile("your_image_path.jpg");
            pic_Main.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_Main.Dock = DockStyle.Fill;
            this.Controls.Add(pic_Main);

            // 创建 Label 控件
            Label label1 = new Label();
            label1.Text = "这是一个透明的标签";
            label1.ForeColor = Color.White;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(50, 50);

            // 设置 Label 的父容器为 PictureBox
            label1.Parent = pic_Main;

            // 将 Label 添加到窗体中
            this.Controls.Add(label1);
        }
    }
}
```

#### 总结

通过将 `Label` 控件的 `Parent` 属性设置为 `PictureBox`，并将 `BackColor` 设置为 `Color.Transparent`，可以让 `Label` 控件显示其背后 `PictureBox` 的内容，从而实现透明效果。

**编辑**

### 3.1 事件的关联和移除

就是多播委托事件

### 3.2 窗口关闭按钮的提示框

FormClosing：事件

```csharp
// 窗体关闭前事件
private void 窗口的关闭和事件的添加移除_FormClosing(object sender, FormClosingEventArgs e)
{
    DialogResult result = MessageBox.Show("是否关闭", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
    if (result == DialogResult.Cancel)
    {
        //取消关闭窗体的事件
        e.Cancel = true;
    }
}
```

### 3.3 窗口集合Controls和Control类

窗体中，只要显示画面的的都要加入Controls集合中（动态添加的也是会加入Controls中的），Controls集合中子要Control类，所以所有控件都是继承了Control类的。

```csharp
//这个都是创建控件，自动生成的代码
this.Controls.Add(this.button13);
```

3

### 3.4 获取所有form窗体对象，winform中的application

当前程序所有打开的窗体引用都会在openForms中，类似窗体form中所有的控件都在controllers中。

`Application.OpenForms` 和 `Form.Controls` 在用途和功能上有明显的区别，并不类似，下面为你详细分析：

#### 用途和功能概述

* **`Application.OpenForms`** ：它是 `Application` 类的一个属性，返回一个 `FormCollection` 对象，该对象包含了当前应用程序中所有打开的顶级窗体。主要用于管理和操作应用程序中所有打开的窗体，比如在某个操作中需要对所有打开的窗体进行统一处理，就可以通过 `Application.OpenForms` 来获取这些窗体对象。
* **`Form.Controls`** ：这是 `Form` 类的一个属性，返回一个 `ControlCollection` 对象，该对象包含了该窗体上的所有控件，像按钮（`Button`）、文本框（`TextBox`）、标签（`Label`）等。主要用于管理和操作窗体上的各种控件，例如动态添加、移除控件，或者对控件的属性进行修改等。

### 4.控件刷新

控件是双向绑定的，改变控件属性，会自动刷新页面。

* **文本相关属性** ：除了前面提到的 `Text`属性外，`RichTextBox`的 `Text`属性、`TextBox`的 `Text`属性等，当这些属性值改变时，都会自动刷新显示新的文本内容。
* **可见性属性** ：`Visible`属性用于设置控件是否可见。当更改该属性值时，界面会自动刷新以显示或隐藏控件。例如，`button1.Visible = false;`会隐藏按钮，界面会立即更新显示。
* **位置和大小属性** ：`Location`属性（用于设置控件的坐标位置）和 `Size`属性（用于设置控件的大小）发生改变时，控件会在界面上自动重新定位和调整大小，触发界面刷新。如 `button1.Location = new Point(100, 100);`或 `button1.Size = new Size(150, 50);`。
* **颜色属性** ：改变控件的 `BackColor`（背景颜色）、`ForeColor`（前景颜色，如文本颜色）等颜色相关属性，会使控件以新的颜色显示，界面自动刷新以呈现新的外观。

## 4.UI设计

4.1 外观设计要求

1.主窗体无边框化，扁平化：FormBorderStyle：None

2.textbox：BorderStyle：FixedSingle

3.Button：FlatStyle: Flat

Dock：锚定

## 5.常用控件和组件的属性

### 5.0 通用属性

### 5.1 主窗体

StartPosition：设置窗体第一次出现位置

5.1.1 布局中的属性：

AutoScaleMode：Inherit或者None。

5.1.2 右键菜单

ContextMenuStrip：使用要选择一个窗体菜单

#### 5.1.3 窗体加载关闭触发事件

![1736083986162](image/Winform/1736083986162.png)

#### 5.1.4 双缓冲

在行为分类的DoubleBuffered属性，改为true，就是开启双缓冲。

#### 双缓冲属性

在行为分类的DoubleBuffered属性，改为true，就是开启双缓冲。

#### 窗体刷新

Invalidate()函数，激发一个OnPaint消息

```csharp
 // 刷新窗体
    this.Invalidate();
    // 或者
    // this.Refresh();
```

#### 将子窗体设置成非顶级控件,否则无法嵌入

form.TopLevel = false;

#### 窗口置为顶级窗口,但是还能点击其它窗口

loginForm.TopMost = true;

#### 模态窗体，模态窗体不关闭，无法点击其它页面

* 当调用 `ShowDialog` 方法来显示一个模态对话框时，当前线程会被阻塞，程序的执行流程会暂停在调用 `ShowDialog` 的地方，直到用户对对话框进行操作并关闭它。这意味着在对话框关闭之前，`ShowDialog` 方法后面的代码不会被执行。
* 这种阻塞行为是为了确保程序在处理对话框相关的操作时，不会继续执行其他可能会干扰对话框操作或导致逻辑混乱的代码。例如，在用户完成登录对话框的输入并点击确定按钮之前，不应该继续执行需要登录后才能进行的操作。

//不通过Show,通过ShowDialog显示模态窗体，模态窗体不关闭，无法点击其它页面,DialogResult返回的结果，loginForm创建的窗体对象
DialogResult result = loginForm.ShowDialog();

注意：当你使用 `ShowDialog()` 方法显示一个窗体时，该方法会以模态方式显示窗体。模态窗体意味着在用户关闭这个模态窗体之前，应用程序的控制权会被锁定在这个模态窗体上，调用 `ShowDialog()` 方法之后的代码将不会执行，直到模态窗体关闭。

当一个窗体被显示为模态对话框（例如使用 `ShowDialog` 方法显示）时，设置 `DialogResult` 属性为 `DialogResult.OK` 或其他有效值，会导致窗体自动关闭，并将该结果返回给调用者。

下面的代码会使使用了ShowDialog()的窗体关闭返回DialogResult.OK。可用于登录窗体中的判断

```csharp
// 设置DialogResult为OK
            this.DialogResult = DialogResult.OK;
```

#### 窗口隐藏和关闭

Hide();隐藏

close();关闭。

#### 窗体上的颜色透明

TransparentKey属性，可以设置窗体中对应的颜色变成透明的。

### 5.2 CheckBox复选框

`CheckBox` 是 Windows Forms 中常用的一个控件，用于为用户提供复选功能，即用户可以选择或取消选择某个选项。

5.2.1 外观中的属性

Checked：默认选中还是不选中

### 5.3 ComboBox 下拉框

通过单击事件，就可以获取选取的值

SelectedItem获取选中的项

```
private void button1_Click(object sender, EventArgs e)
        {
            // 使用 SelectedItem 获取选中项的文本
            if (comboBox1.SelectedItem != null)
            {
                string selectedText = comboBox1.SelectedItem.ToString();
                MessageBox.Show($"你选择的是: {selectedText}");
            }
            else
            {
                MessageBox.Show("请选择一个选项。");
            }
        }
```

2

### 5.4 dataGridView

    数据展示控件,要想展示数据，每列的属性都要设置3个，name，data，text。

* 具备强大的数据绑定功能，可以直接绑定到数据源（如 `DataTable`、`BindingSource` 等），实现数据的自动更新和同步。当数据源发生变化时，`DataGridView` 会自动更新显示内容。

#### 基本使用：

1.这个一般全部不勾。

![1731208243906](image/Winform/1731208243906.png)

2.美化

2.1改背景色属性：BackgroundColor

2.2

RowHeadersWidthSizeMode:EnableResizing。行的宽高可调。

ColumnHeadersHeightSizeMod:EnableResizing.列的宽高可调。

ColumnHeadersHeight：30.根据变化调节宽高。

ColumnHeadersBorderStyle：single。让用户的设置生效

EnableHeadersVisualStyles：true

GridColor：分割线颜色

ColumnHeadersDefaultCellStyle：可以设置标题的字体大小，居中

AlternatingRowsDefoultCellStyle：设置奇数行的样式。

奇数行展示的样式，通过给某个列设置file属性，自动铺满，来占满整个了列。

![1731210091308](image/Winform/1731210091308.png)

#### 数据展示

AutoGenerateColumns = false;关闭自动生成列。防止根据绑定的数据，自动生成列。

### 5.5 容器

#### 5.5.1 panel

容器里面加入控件页面也是通过Controls.Add加入的，动态展示也会加入Controls管理。

### 5.6 Button

#### 5.6.1 按钮的使能

### 5.7 列表框 ListBox

可以用来展示输出信息，里面的内容一行一行的输出

#### 5.7.1 信息的添加

ListBox.Item.Add();

#### 5.7.2 信息的清空

ListBox.Item.Clear();

#### 5.7.3 水平滚动条

属性：HorizontalScrollbar

### 5.8 Timer 控件

该控件运行在UI主线程的，相当于一个定时器，到了一定的时间，主线程就过来执行，类似单片机中的。定时器执行的过程中，主线程吧是卡着的。

### 5.9 ContextMenStrip窗体右键菜单

`ContextMenuStrip` 是 Windows Forms 中用于创建上下文菜单（即右键菜单）的控件。当用户在某个控件上右键单击时，会弹出一个包含一系列操作选项的菜单。

必须绑定到其它控件上。

### 5.10 ImageList组件

`ImageList` 是 Windows Forms 中一个非常有用的控件，它用于管理一组图像，方便在其他控件（如 `ListView`、`TreeView`、`ToolStrip` 等）中重复使用这些图像。下面从创建、添加图像、关联其他控件等方面详细介绍 `ImageList` 的使用。

#### 1. 创建 `ImageList` 控件

在 Visual Studio 的窗体设计器中，你可以从工具箱里把 `ImageList` 控件拖放到窗体上，或者通过代码来创建 `ImageList` 对象。

```
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ImageListExample
{
    public partial class Form1 : Form
    {
        private ImageList imageList;

        public Form1()
        {
            InitializeComponent();
            // 创建 ImageList 对象
            imageList = new ImageList();
            // 设置图像的尺寸
            imageList.ImageSize = new Size(32, 32); 
        }
    }
}
```

要设置存储的图片大小。

### 5.11 弹窗

#### 显示MessageBox.show()

显示弹框可以自定义图标，文本，标题。

方案一：ok和cancel

```
string okText = _languageService.GetString("OkButtonText");
            string cancelText = _languageService.GetString("CancelButtonText");
            string message = _languageService.GetString("MessageBoxMessage");
            string caption = _languageService.GetString("MessageBoxCaption");

            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            MessageBoxIcon icon = MessageBoxIcon.Information;

            DialogResult result = MessageBox.Show(message, caption, buttons, icon, MessageBoxDefaultButton.Button1, 0, okText, cancelText);

            if (result == DialogResult.OK)
            {
                // 处理确定按钮点击事件
            }
            else if (result == DialogResult.Cancel)
            {
                // 处理取消按钮点击事件
            }
```

方案二：yes和no

```
// 从语言服务中获取对应语言的文本
            string yesText = _languageService.GetString("YesButtonText");
            string noText = _languageService.GetString("NoButtonText");
            string message = _languageService.GetString("MessageBoxMessage");
            string caption = _languageService.GetString("MessageBoxCaption");

            // 使用包含自定义按钮文本的 MessageBox.Show 重载方法
            DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, 0, yesText, noText);

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

#### 打开文件弹窗

```
// 创建OpenFileDialog对象
OpenFileDialog openFileDialog = new OpenFileDialog();
// 设置文件筛选器，这里只允许选择图片文件
openFileDialog.Filter = "图片文件|*.jpg;*.png;*.bmp";
// 显示打开文件对话框，用户选择文件后，DialogResult为OK表示选择了文件
if (openFileDialog.ShowDialog() == DialogResult.OK)
{
string path = openFileDialog.FileName;
//操作
}
```

#### 打开文件夹弹窗

```
// 创建FolderBrowserDialog对象
FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
// 显示打开文件夹对话框，用户选择文件夹后，DialogResult为OK表示选择了文件夹
if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
{
// 获取用户选择的文件夹路径
string folderPath = folderBrowserDialog.SelectedPath;
// 可以在这里对选择的文件夹进行操作，比如显示文件夹路径
 MessageBox.Show($"选择的文件夹路径：{folderPath}");
}
```

#### 保存文件弹窗

```
// 创建SaveFileDialog对象
SaveFileDialog saveFileDialog = savaFileDialog();
// 设置文件筛选器，这里只允许保存为JPEG、PNG或BMP格式
saveFileDialog.Filter = "JPEG图片|*.jpg|PNG图片|*.png|BMP图片|*.bmp";
// 显示保存文件对话框，用户选择保存路径和文件名后，DialogResult为OK表示确认保存
if (saveFileDialog.ShowDialog() == DialogResult.OK)
{
// 获取用户选择的保存文件格式
 string fileExtension = System.IO.Path.GetExtension(saveFileDialog.FileName);
}
```

### 5.12 pictrueBox图片显示

//本地资源图片引用

pictureBox.Image = global::WinformSplash.Properties.Resources.jeteazy_log;

pictruec存储的是Image类型图片

设置显示图片

pictrue.image;

保存图片

pictrue.image.save()

SizeMode属性：

None:不使用

AutoSize：控件适应图片的自动大小

StretchImage:拉伸图片填充控件

CenterImage：图片中间部分填充kongj

ZOOM:比例变大

### 5.13 textBox

多行编辑属性，也可以用于日志展示：

**`Multiline`属性** ：这是控制 `TextBox`是否为多行模式的关键属性。当设置为 `true`时，`TextBox`允许用户输入和显示多行文本；设置为 `false`时（默认值），`TextBox`只能显示和输入一行文本。

**`ScrollBars`属性** ：通常在 `Multiline`属性设置为 `true`后，可以设置 `ScrollBars`属性来为 `TextBox`添加滚动条，方便用户查看和编辑超出显示区域的文本。

**`WordWrap`属性** ：该属性用于指定当文本超出 `TextBox`的宽度时是否自动换行。当 `Multiline`为 `true`时，若 `WordWrap`设置为 `true`（默认值），文本会自动换行；若设置为 `false`，文本将在一行中继续显示，直到遇到用户手动输入的换行符或到达文本的末尾，此时可能需要水平滚动条来查看完整文本。

### 6.RichTextbox

用于log日志的展示，nlog就是用的这个控件。

### 7.progressBar

进度条展示

### 8.PropertyGrid

属性展示控件

`PropertyGrid` 是 Windows Forms 中的一个强大控件，它可以用于显示和编辑对象的属性，为用户提供了一个直观且方便的方式来查看和修改对象的属性值。

### 9.ListView

也是用来展示数据的控件

主要用于以列表形式展示数据。它提供了多种视图模式，可根据不同需求展示和操作数据

### 10.ToolStrip

`ToolStrip` 是 Windows Forms 里一个用于创建工具栏和菜单系统的控件，它具有高度的可定制性和灵活性。下面将从创建、添加项目、事件处理等方面详细介绍 `ToolStrip` 的使用。

ToolStrip可以看成类似软件的顶部的工具栏菜单，比如VS和VSCCode最上面的

### 11.ToolStripContainer

`ToolStripContainer` 是 Windows Forms 中的一个容器控件，它提供了一个用于停靠 `ToolStrip` 控件的区域，并且包含一个中央区域可用于放置其他控件，像 `Form`、`Panel` 等。

ToolStripContainer就相当于VS拖拉顶部的工具栏到左边，右边等停靠。

### 12.MenuStripStatusStripExample

`MenuStrip` 和 `StatusStrip` 是两个常用的控件，分别用于创建菜单栏和状态栏

`MenuStrip`创建VS的主菜单栏容器，如文件，编辑等。

`StatusStrip`用于最下面的状态栏，可以用来显示一些状态信息，比如PLC的链接实时通信，IP地址，中英文等信息。

### 13.ToolTip

`ToolTip` 是 Windows Forms 里的一个控件，其作用是在用户将鼠标指针悬停在某个控件上时，显示一段提示信息。

### 14.RadioButton

* 属于单选控件，在一组 `RadioButton` 中，用户只能选择一个选项。这是因为同一容器内的 `RadioButton` 会自动形成一个单选组，选中一个时，其他的会自动取消选中。
* 适用于在多个互斥的选项中做出单一选择的场景，例如选择性别（男 / 女）、选择支付方式（现金 / 信用卡 / 支付宝）等。

#### 利用继承来实现，通过继承其它已有组件，来进行二次开发。

1.新建库项目

2.添加组件类，更改要二次开发的继承

3.添加融合的控件或者组件

4.添加控件方法，编译，导入工具栏，调用。

#### 通过新建控件开发

新建库项目，添加控件开发。

控件开发其实就是给个画布，里面添加各种组合控件。

##### 属性

在画布代码中添加的属性，也会在使用控件时出现。里面的属性也可以通过属性返回控件中的对象。

##### 事件

控件中，想展示的事件可以写出来，在控件中的事件中调用展示的控件。

##### 在vs设计器中的属性窗口展示自定义控件的属性。

```

using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CustomControlLibrary
{
    public partial class CustomControl : UserControl
    {
        public CustomControl()
        {
            InitializeComponent();
        }

        // 定义一个公共属性来公开 Label 的 Text 属性
        [Category("自定义属性")] // 设置属性在属性窗口中的分类
        [Description("设置 Label 的文本内容")] // 设置属性的描述信息
        public string LabelText
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }
    }
}

```

### 15.checkListBox

* 是复选控件，用户可以同时选择多个选项。每个选项前都有一个复选框，用户可根据需求勾选或取消勾选。
* 适用于需要选择多个选项的场景，例如选择兴趣爱好（阅读、运动、音乐等）、选择要打印的文件列表等。
* 支持直接绑定数据源，如 `List`、`DataTable` 等。绑定后，`CheckedListBox` 会自动显示数据源中的数据，并且可以方便地获取用户的选择结果。

### 自定义控件加入工具栏

1.将库文件的dll文件引用到项目中

1. 创建自定义控件库项目

在开始导入自定义控件库之前，你需要先创建一个自定义控件库项目并完成控件的开发。

* 打开 Visual Studio，选择 “创建新项目”，挑选 “类库（.NET Framework）” 或者 “类库（.NET Core）”，依据开发需求选定合适的 .NET 版本。
* 在项目里，右键点击项目名称，选择 “添加” -> “用户控件”，为控件命名后点击 “添加”。
* 在设计器中设计控件外观布局，同时在代码文件编写控件逻辑。
* 完成控件设计和代码编写后，点击 “生成” -> “生成解决方案”，将项目编译成 DLL 文件，生成的 DLL 文件一般位于项目的 `bin\Debug` 或 `bin\Release` 目录下。

2.通过引用添加

1. **添加项目引用** ：在目标项目的 “解决方案资源管理器” 中，右键点击 “引用”，选择 “添加引用”。
2. **浏览并选择 DLL 文件** ：在 “引用管理器” 对话框中，点击 “浏览” 按钮，找到自定义控件库的 DLL 文件，选中后点击 “确定”。

3.在目标项目中导入和使用自定义控件库

通过工具箱添加

1. **打开目标项目** ：打开你要使用自定义控件的 Windows Forms 项目。
2. **添加自定义控件到工具箱** ：在 “工具箱” 中右键点击，选择 “选择项”。
3. **浏览并添加 DLL 文件** ：在弹出的 “选择工具箱项” 对话框中，点击 “浏览” 按钮，找到之前编译生成的自定义控件库的 DLL 文件，选中后点击 “打开”。
4. **确认添加** ：此时，自定义控件会显示在 “选择工具箱项” 对话框中，勾选要添加的控件，点击 “确定”。自定义控件就会出现在 “工具箱” 中。
5. **使用自定义控件** ：在设计器中，从 “工具箱” 中拖动自定义控件到窗体上，就可以像使用普通控件一样使用它了。在代码中也可以通过控件的名称来访问和操作它

### 问题

#### textBox和ComboBox如何调整高度

**textBOX更改为多行编辑： `Multiline`属性** ：这是控制 `TextBox`是否为多行模式的关键属性。当设置为 `true`时，`TextBox`允许用户输入和显示多行文本；设置为 `false`时（默认值），`TextBox`只能显示和输入一行文本。

#### NuGet的UI框架如何加入工具栏中

方法一：

VS菜单栏中：项目＝》刷新项目工具箱

![1735805342778](image/Winform/1735805342778.png)

方法二：

菜单栏中：工具＝》选项＝》**Windows**窗体设计器＝》常规＝》工具箱=》自动填充工具箱=》True

![1735805381768](image/Winform/1735805381768.png)

#### 项目引用报错

排查一：查看引用中是否有黄色感叹号，有那么移除掉，重新加载进来，黄色感叹号表示引用没有加载进来。

#### 自定义控件里面的子控件如何操作

方法一：在自定义组件中，将子控件对象设置为public

#### 程序中显示的图形如何能够放大缩小操作

#### 重复调用load事件

如果设计器中添加了事件，代码中又添加就会导致重复的调用这个事件，绑定两次。

所以绑定事件的初始化最好自己手写。

## 多国语言切换

1.主窗体设置

* 选中要进行本地化的 WinForm 窗体或控件，在属性窗口中，将 `Localizable`属性设置为 `True`
* 将 `Language`属性设置为默认语言，如 `Chinese (Simplified)`
* 然后设置控件的 `Text`等属性为本地化字符串，如将按钮的 `Text`属性设置为 `确定`，不切换语言时，默认就是本地语言。
* 创建和编写多语言的资源文件，资源文件命名方式基本就是当前主窗体的名称，后面跟上要添加的语言信息代码。因为后面资源管理器做绑定的时候，就是按照这个命名规则查找的。

2.代码实现

* 获取当前的语言字符串
* 设置当前线程的语言
  * 这个一般都会有一个单独的类，对所有的控件和窗体进行遍历切换。
* 通过ComponentResourceManager(资源管理器类)进行资源绑定。
* 刷新页面

### 用到的类

#### 获取在setting中的语言字符串，可以是放在其它地方的文本文件或者数据库中值

```
 //获取上次存储的语言，进行界面的更新
 string language = Properties.Settings.Default.DefaultLanguage;
```

#### 切换当前UI文化(就是当前线程的语言)

```
private void SetCulture(string language)
        {
            // 创建 CultureInfo 对象
            CultureInfo culture = new CultureInfo(language);
            // 设置当前线程的 UI 文化
            Thread.CurrentThread.CurrentUICulture = culture;
            // 设置当前线程的文化
            Thread.CurrentThread.CurrentCulture = culture;
            // 重新加载资源和更新 UI 元素
            LoadLanguage();
        }
```

#### 资源类 ComponentResourceManager

从技术上讲，你可以将 `MainForm.zh-CN.resx` 命名为 `zh-CN.resx`，但这可能会带来一些潜在的问题和不便，以下是详细解释：

##### 命名约定和最佳实践

- **常规命名约定**：
  - 在 Windows 窗体应用程序中，通常将资源文件命名为 `[FormName].[CultureName].resx` 的形式，例如 `MainForm.zh-CN.resx`，这样可以清晰地表示该资源文件是与 `MainForm` 相关联的，并且适用于 `zh-CN`（中文-中国大陆）文化。
  - 这种命名方式有助于组织和管理资源文件，尤其是当你有多个窗体和多种语言时，方便你快速找到与特定窗体和文化对应的资源文件。

##### 可能的问题

- **资源文件的关联问题**：

  - 如果你将 `MainForm.zh-CN.resx` 改为 `zh-CN.resx`，在使用 `ComponentResourceManager` 时，可能会导致资源查找和应用的混淆。因为 `ComponentResourceManager` 通常会根据资源文件的名称来查找与窗体相关的资源。
  - 例如，以下代码可能无法正确找到 `zh-CN.resx` 中的资源：

  ```csharp
  Type formType = typeof(MainForm);
  ComponentResourceManager resources = new ComponentResourceManager(formType);
  ```

  - 因为 `ComponentResourceManager` 会期望资源文件的名称与 `formType` 的名称关联，即 `MainForm.zh-CN.resx`。

##### 替代方案和解决方法

- **使用 Neutral Resources Language**：

  - 如果你想简化资源文件的命名，可以使用中性资源语言（Neutral Resources Language）。例如，你可以将默认语言的资源文件命名为 `MainForm.resx`，并在项目属性中设置中性资源语言为默认语言（如英语）。
  - 对于其他语言，你可以使用 `[CultureName].resx` 的形式，例如 `zh-CN.resx`。
  - 在 `AssemblyInfo.cs` 文件中，添加以下代码来设置中性资源语言：

  ```csharp
  [assembly: NeutralResourcesLanguage("en-US")]
  ```

  - 当使用 `ComponentResourceManager` 时，它会先查找特定文化的资源文件（如 `zh-CN.resx`），如果找不到，会使用中性资源语言的资源文件（`MainForm.resx`）。

##### 示例代码

以下是一个使用中性资源语言的示例：

```csharp
using System;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;
using System.ComponentModel;

namespace LanguageSwitchExample
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            // 初始加载默认语言
            LoadLanguage();
        }

        private void LoadLanguage()
        {
            // 获取当前线程的 UI 文化
            CultureInfo culture = Thread.CurrentThread.CurrentUICulture;
            Type formType = typeof(MainForm);
            ComponentResourceManager resources = new ComponentResourceManager(formType);
            // 应用资源到窗体及其子控件
            ApplyResources(this, resources);
        }

        private void ApplyResources(Control control, ComponentResourceManager resources)
        {
            resources.ApplyResources(control, control.Name);
            // 递归应用资源到子控件
            foreach (Control subControl in control.Controls)
            {
                ApplyResources(subControl, resources);
            }
        }

        private void btnSwitchToChinese_Click(object sender, EventArgs e)
        {
            // 切换到中文（中国大陆）
            ChangeLanguage("zh-CN");
        }

        private void ChangeLanguage(string language)
        {
            // 创建 CultureInfo 对象
            CultureInfo culture = new CultureInfo(language);
            // 设置当前线程的 UI 文化
            Thread.CurrentThread.CurrentUICulture = culture;
            // 设置当前线程的文化
            Thread.CurrentThread.CurrentCulture = culture;
            // 重新加载语言资源
            LoadLanguage();
        }
    }
}
```

##### 总结

- 虽然可以将 `MainForm.zh-CN.resx` 改为 `zh-CN.resx`，但遵循 `[FormName].[CultureName].resx` 的命名约定可以更好地组织和管理资源文件，避免资源查找和应用的混淆。
- 如果你确实想简化命名，可以考虑使用中性资源语言，并在 `AssemblyInfo.cs` 中设置中性资源语言，同时使用 `[CultureName].resx` 的形式命名其他语言的资源文件。

##### 注意事项

- 无论采用哪种命名方式，都要确保资源文件中的资源键与控件的名称和属性相匹配，以便正确应用资源。
- 在进行语言切换时，确保资源文件包含所需的资源，并且资源键准确无误。

### 使用JSON多语言化

控件等都可以用JSON进行多语言化。弹窗等按钮可以使用简单的英语，如OK,Cancel等来作为通用不变的。

## dll类库，控件的导入

在工具栏中，右键选择项，找到对应的dll文件，添加进来就行。

## 好用的UI工具库

### Emgu.CV.UI

NuGet 包管理器搜索并安装 `Emgu.CV`和 `Emgu.CV.UI`包来实现

Emgu.CV.UI.ImageBox

## 6.通用代码

### 6.1无边框窗体移动代码

使用方法：

将代码复制到添加事件的类中，然后在窗体的事件中选择对应的方法绑定即可。

```
#region 窗体移动

        private Point mouseOff;//鼠标移动位置变量
        private bool leftFlag;//标签是否为左键
        private void Frm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y); //得到变量的值
                leftFlag = true;                  //点击左键按下时标注为true;
            }
        }
        private void Frm_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);  //设置移动后的位置
                Location = mouseSet;
            }
        }
        private void Frm_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;//释放鼠标后标注为false;
            }
        }

        #endregion
```

### 6.2 窗体的放大缩小和关闭

```
 #region 窗体的大小切换和关闭
 private void btnClose_Click(object sender, EventArgs e)
 {
     this.Close();
 }

 private void btnToggleMaximize_Click(object sender, EventArgs e)
 {
     //窗体放大或者缩小
     if (this.WindowState == FormWindowState.Maximized)
     {
         this.WindowState = FormWindowState.Normal;
     }
     else if (this.WindowState == FormWindowState.Normal)
     {
         this.WindowState = FormWindowState.Maximized;
     }
 }

 private void btnMinimize_Click(object sender, EventArgs e)
 {
     this.WindowState = FormWindowState.Minimized;
 }
 #endregion
```

s

6.2.1

## 7.架构，程序的设计

其实开发语法哪些不是最难的，多记下就好了，还是程序的设计，这个搞明白了，其实就差不多很厉害了。

设计模式和编程思想，数据结构与算法

### 7.1 项目的分析

一、项目类型

1.没有数据的项目：要求使用OOP思想和方法设计，完全各个类的设计过程，确定类之间的关系。

2.有数据库的项目：项目的框架和思路相对固定，在框架的约束下开发相对容易。

  常见的框架：三层架构、MVC、或者两者结合使用...

二、核心的问题

1.一个项目中怎么样确定多少个类？

（1）名词分析法：我们根据项目的名称或者项目中的关键词，进行筛选，往往项目的名称就能给我们提供

    非常重要的类名称。实际情况中，我们可能会找到挺多的名称。我们筛选需要的名词是有一个标准的。

    我们筛选的名称将来一定要设计成类，也就是看看这个类有没有属性、方法等。

    初步找到：双色球、选号器  （随机，无法找到属性、和方法）

    双色球：红色球、蓝色球

    选号器：红色球池、蓝色球池、存储所选双色球的属性

    随机数生成方法、（打印、远程保存）

    按照对象职责明确原则，把属性和方法分配给对应的对象（类），同时你还要考虑，这个属性或者

    你找的方法，是不是我们需要的（与项目是否相关的）

（2）头脑风暴法：大家一起商量，各抒己见，按照少数服从多数的方法进行筛选。

    最后结果，不同人，不同的团队设计出来是有差别的。只要设计合理，就好。

---

2. 找到的这些类（对象）如何确定他们之间的关系？

（1）一对一的关系：一个类的对象作为另一个类的属性。数据库中数据表也会有一对一的关系。

（2）一对多的关系：一个类的多个对象作为另一个类的属性，通常这个属性是集合类型（List `<T>`）

    Dictionary<k,v>  如果是数据表这种关系体现为“主外键关系”。

### 7.2 实体类和数据库

实体类：是存储模型

数据库：是存储这些实体的数据。

![1728176242707](image/Winform/1728176242707.png)

![1728176250957](image/Winform/1728176250957.png)

### 7.3 项目的生成

在项目中，所有的dll库都会在最终执行的bin文件中存在。

## 8.前后端分离

### 8.1现在项目中

现在都流行将要展示的UI给布局好，画出来，什么都不该，控件名字也不改，在后面使用时，直接代码调用其属性。

前提是我们要画出来，布局好。后面使用时做数据填充和展示隐藏。

## 9.页面设计

### 9.1 什么时候用控件和form

当要展示一个新的窗口时候，就用form。当只是在页面中展示的内容，就用创建控件。

### 9.2页面布局设计，提高性能

#### 1. 选择合适的布局容器

* **FlowLayoutPanel** ：当控件需要按水平或垂直方向依次排列时，此容器很适用。它会依据控件添加顺序进行排列，且能在空间不足时自动换行。
* **TableLayoutPanel** ：适用于表格形式的布局。你可以定义行和列的数量、大小，把控件放置在相应单元格中，便于创建整齐的布局。
* **Panel** ：简单的容器控件，可用于对相关控件进行分组。不过，使用时要注意避免嵌套过深，因为这会增加布局计算的复杂度。

#### 2. 减少嵌套层次

嵌套过多的布局容器会增加布局计算的复杂度，从而降低性能。所以，应尽量减少布局容器的嵌套层次。例如，若能用一个 `TableLayoutPanel`实现布局，就不要使用多个嵌套的 `Panel`。

#### 3. 避免动态布局的频繁更新

频繁的动态布局更新会消耗大量性能。若需要动态添加或移除控件，可考虑批量操作，而非每次操作都触发布局更新。你可以使用 `SuspendLayout`和 `ResumeLayout`方法来暂停和恢复布局更新。

#### 4. 优化控件的绘制

* **双缓冲技术** ：启用双缓冲可减少闪烁，提高绘制性能。对于频繁重绘的控件，可设置 `DoubleBuffered`属性为 `true`。
* **按需重绘** ：仅在必要时重绘控件。可通过重写 `OnPaint`方法，只更新需要更新的部分。

#### 5. 合理使用锚定和停靠

* **锚定（Anchor）** ：把控件的位置与父容器的边缘关联起来，当父容器大小改变时，控件会依据锚定设置自动调整位置。
* **停靠（Dock）** ：把控件停靠在父容器的边缘或填充整个父容器。合理运用锚定和停靠能确保布局在不同窗口大小下保持一致，减少手动调整布局的需求。

#### 示例代码

以下是一个使用 `SuspendLayout`和 `ResumeLayout`方法批量添加控件的示例：

csharp

```csharp
using System;
using System.Windows.Forms;

namespace WinFormsLayoutPerformance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddControlsButton_Click(object sender, EventArgs e)
        {
            // 暂停布局更新
            this.SuspendLayout();

            // 批量添加控件
            for (int i = 0; i < 10; i++)
            {
                Button button = new Button();
                button.Text = $"Button {i}";
                button.Location = new System.Drawing.Point(10, 10 + i * 30);
                this.Controls.Add(button);
            }

            // 恢复布局更新
            this.ResumeLayout();
        }
    }
}
```

在这个示例里，使用 `SuspendLayout`方法暂停布局更新，批量添加按钮控件，最后使用 `ResumeLayout`方法恢复布局更新，这样可减少布局计算的次数，提高性能。

## 10.资源文件的导入

直接在资源文件中添加会有问题。错误的，正确的是在当前项目，属性，资源中添加

![1739007120425](image/Winform/1739007120425.png)

### 添加方式

选择要将资源添加的项目，右键点击属性，找到资源，添加资源，现有文件，选择要添加的图片就好了。

### 引用资源图片

global::HIBIRD.Properties.Resources.jeteazy_log;

当资源图片加载到资源类中时，其实就是创建了一个静态字段。上面的其实就是在调用静态字段。

## 11.Nlog日志使用

## 12.winformwork窗体的UI线程

UI线程只是这个线程我们自己取的名字，UI线程也叫主线程。

### 多线程操作UI控件问题：

多线程操控UI需要InvokeRequired来操作控件，不是同一个线程创建的UI，不能直接操作，必须通过InvokeRequired的Invoke操作。如程序打开时的加载页面。

this.txtReceiver.Invoke(new Action `<string>`(s => { this.txtReceiver.Text += "   " + s; }), data);该方法会将data传递给参数s。

一个 WinForms 程序打开时，默认至少有一个主线程，也称为 UI 线程。

主线程主要负责以下工作：

* **界面绘制与更新** ：负责创建和显示 WinForms 应用程序的用户界面，包括窗体、控件等的绘制。当应用程序需要更新界面元素的状态，如更改按钮的文本、显示图片等，都是在主线程中进行的。
* **消息循环处理** ：运行一个消息循环，用于接收和处理 Windows 操作系统发送给应用程序的各种消息，例如鼠标点击、键盘输入、窗口大小改变等事件。通过消息循环，应用程序能够及时响应用户的操作和系统事件。

在一些情况下，WinForms 程序可能会根据需要创建额外的线程，例如当执行一些耗时操作，如文件读取、网络访问或复杂的计算任务时，为了避免阻塞 UI 线程，导致界面卡顿，开发人员可能会手动创建新的线程来执行这些操作。但如果不手动创建额外线程，WinForms 程序默认就只有主线程来处理所有的 UI 相关操作和其他同步任务。

### 主线程是后台线程吗

在 WinForms 程序中， **主线程不是后台线程** ，而是前台线程。

前台线程和后台线程的主要区别在于它们对应用程序生命周期的影响。前台线程会阻止应用程序的进程退出，只要有前台线程在运行，应用程序就会继续运行。而后台线程则不会阻止应用程序的进程退出，当所有前台线程都结束时，不管后台线程是否完成，应用程序都会退出。

WinForms 程序的主线程作为前台线程，负责处理用户界面的交互、消息循环以及各种 UI 相关的操作。它的存在确保了应用程序在有用户交互或其他重要任务进行时不会意外退出，只有当主线程结束或者所有前台线程都执行完毕后，应用程序才会正常退出。

## 13.GDI+

GDI+ 是 Windows 操作系统提供的一个图形设备接口（Graphical Device Interface）的高级版本，用于在 .NET 应用程序中进行 2D 图形的绘制、图像的处理以及文本的渲染。以下从几个方面为你详细介绍：

### 坐标系统

1. GDI+ 使用的是左上角为原点 (0, 0) 的坐标系，X 轴向右为正，Y 轴向下为正。

### 主要功能

* **图形绘制** ：能够绘制各种基本图形，像直线、矩形、椭圆、多边形等。借助不同的画笔（`Pen`）和画刷（`Brush`），可以为图形设置不同的线条样式、颜色和填充效果。
* **图像操作** ：支持多种图像格式的加载、保存和编辑。你可以对图像进行缩放、旋转、裁剪、颜色调整等操作，还能实现图像的透明度处理。
* **文本渲染** ：可以在界面上显示文本，并能设置字体、字号、颜色、对齐方式等文本属性，同时支持文本的抗锯齿渲染，使文本显示更加清晰。

### 核心对象和类

* **`Graphics` 类** ：这是 GDI+ 的核心类，它提供了大量用于绘制图形、图像和文本的方法。通过 `Graphics` 对象，可以在各种绘图表面（如窗体、控件、图像等）上进行绘制操作。
* **`Pen` 类** ：用于定义线条的属性，如线条的宽度、颜色、样式（实线、虚线等）。在绘制直线、矩形边框等图形时会用到 `Pen` 对象。
* **`Brush` 类** ：用于填充图形的内部区域，有不同的子类，如 `SolidBrush`（纯色画刷）、`LinearGradientBrush`（线性渐变画刷）、`TextureBrush`（纹理画刷）等。
* **`Image` 类** ：是处理图像的基类，可用于加载、保存和操作图像。`Bitmap` 类是 `Image` 类的一个子类，专门用于处理位图图像。
* **`Font` 类** ：用于定义文本的字体、字号、样式（粗体、斜体等）。在绘制文本时，需要使用 `Font` 对象来指定文本的显示格式。
* **Color** ：表示颜色，你可以使用预定义的颜色，也可以通过 RGB 值或 ARGB 值来创建自定义颜色。

#### graphice的画布获取

/1.通过订阅Form窗体或者控件的的 Paint 事件
this.Paint += MainForm_Paint;

2.重写OnPaint的方法

protected override void OnPaint(PaintEventArgs e)

3.bitmap画布

```csharp
// 创建一个 800x600 的 Bitmap 对象
        Bitmap bitmap = new Bitmap(800, 600);
  
        // 从 Bitmap 获取 Graphics 对象
        using (Graphics g = Graphics.FromImage(bitmap))
        {
```

1

### 基本使用

```
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PaintExample
{
    public class CustomForm : Form
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            // 调用基类的 OnPaint 方法,以确保之前的控件的正常绘制
            base.OnPaint(e);

            // 在这里添加自定义的绘制代码
            Graphics g = e.Graphics;//画布
            Pen pen = new Pen(Color.Red, 2);//画笔
            g.DrawLine(pen, 10, 10, 100, 10);//绘制
            pen.Dispose();//释放画笔
        }
    }

    class Program
    {
        static void Main()
        {
            Application.Run(new CustomForm());
        }
    }
}
```

1

抗锯齿高质量，但是可能影响性能

```
g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
```

1

### `PaintEventArgs e` 参数

* **含义** ：`PaintEventArgs` 是 `EventArgs` 的派生类，`e` 这个参数封装了与绘制操作相关的信息。`PaintEventArgs` 类包含了两个重要的属性：`Graphics` 和 `ClipRectangle`。
* `Graphics` 属性：提供了用于绘制图形、文本和图像的方法和属性，你可以通过它在控件上进行各种绘制操作。
* `ClipRectangle` 属性：表示需要进行绘制的区域，通常是控件的可见区域。
* **作用** ：`e` 参数主要用于在事件处理方法中进行实际的绘制操作。你可以使用 `e.Graphics` 来调用各种绘制方法，如 `DrawLine`、`DrawRectangle`、`DrawString` 等。

### 作用区域

那个控件重新定义了OnPaint方法，绘制就会在那个控件中生效。

### 重绘 `Invalidate` 和 `Refresh`

在 C# 的 Windows Forms 编程里，`Invalidate` 和 `Refresh` 方法都和控件的重绘操作相关，但它们在功能和使用上存在差异，下面为你详细介绍。

#### 1. 功能概述

- **`Invalidate` 方法**：该方法的作用是把控件的全部或者部分区域标记成无效。被标记为无效的区域会在系统下次消息循环时触发 `Paint` 事件，从而对该区域进行重绘。不过，`Invalidate` 方法不会马上触发重绘操作，它只是设置了重绘的需求。
- **`Refresh` 方法**：`Refresh` 方法会强制控件立即重绘自己。它实际上是先调用 `Invalidate` 方法将整个控件区域标记为无效，接着调用 `Update` 方法强制立即处理重绘请求。

#### 2. 详细区别

##### 重绘时机

- **`Invalidate`**：调用 `Invalidate` 方法后，重绘操作不会立刻执行，而是要等到系统的下一次消息循环才会触发 `Paint` 事件来完成重绘。这种延迟重绘的机制能够提升性能，因为系统可以把多个 `Invalidate` 请求合并处理，减少不必要的重绘操作。

```csharp
using System;
using System.Windows.Forms;

namespace InvalidateExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 标记整个窗体区域为无效
            this.Invalidate(); 
            // 这里不会立即重绘，而是等待消息循环
            Console.WriteLine("调用 Invalidate 方法");
        }
    }
}
```

- **`Refresh`**：调用 `Refresh` 方法会马上触发重绘操作，它会强制系统立即处理 `Paint` 事件，更新控件的显示内容。

```csharp
private void button2_Click(object sender, EventArgs e)
{
    // 强制立即重绘整个窗体
    this.Refresh(); 
    Console.WriteLine("调用 Refresh 方法，立即重绘");
}
```

##### 性能影响

- **`Invalidate`**：由于 `Invalidate` 采用延迟重绘的方式，系统有机会合并多个重绘请求，所以在需要多次重绘控件的场景下，使用 `Invalidate` 方法能减少不必要的重绘，从而提高性能。
- **`Refresh`**：`Refresh` 方法会立即触发重绘，频繁调用可能会导致性能下降，特别是在需要进行大量重绘操作时。

##### 重绘区域

- **`Invalidate`**：有多种重载形式，可以指定只重绘控件的部分区域，这样能进一步减少重绘的工作量，提高性能。

```csharp
// 标记指定矩形区域为无效
Rectangle rect = new Rectangle(10, 10, 100, 100);
this.Invalidate(rect); 
```

- **`Refresh`**：总是会重绘整个控件，无法指定只重绘部分区域。

#### 3. 使用场景建议

- **`Invalidate`**：适用于需要多次更新控件状态，但不需要立即看到更新结果的情况。例如，在数据更新时，可以多次调用 `Invalidate` 方法，最后让系统统一处理重绘请求。
- **`Refresh`**：适用于需要立即看到控件更新结果的情况。例如，在用户点击按钮后需要马上更新界面显示时，可以使用 `Refresh` 方法。

## 14.控件

控件：输入或者操作数据的对象。控件有自己的属性、方法、事件。

属性--外观

方法--功能

事件--行为--控件页面上能操作的部分如按钮。

特征：

    可视化，可以与用户进行交互

    暴露出来的属性和方法、事件 可供开发人员使用

    可发布和重用

### 自定义控件开发

一般都是创建一个dll类库，里面存放自定义控件。

#### 什么时候用组件和用户控件。

组件没有设计器的，用户控件有设计器。组件一般用于对winform提供的基础控件进行修改，比如button，通过创建自定义组件，修改继承的类为button，然后添加一些事件和属性等修改，用户控件一般是用于将多个winform的控件组合成一个，然后提供对应的属性和事件方法。

#### 基础代码

一般自定义用户控件初始化时，会添加一些样式代码，如双缓冲等。

```
///设置窗体样式,双缓冲
SetStyle(ControlStyles.Selectable, true);
SetStyle(ControlStyles.AllPaintingInWmPaint, true);//忽略窗口消息，减少闪烁
SetStyle(ControlStyles.OptimizedDoubleBuffer, true);//绘制到缓冲区，减少闪烁
SetStyle(ControlStyles.UserPaint, true);//控件由其自身而不是操作系统绘制
SetStyle(ControlStyles.ResizeRedraw, true);//控件调整其大小时重绘
SetStyle(ControlStyles.SupportsTransparentBackColor, true);//支持透明背景

this.UpdateStyles();// 使设置的样式立即生效
```

#### 通过GDI+绘制

通过创建用户控件，然后通过设置属性，事件等绘制自定义控件，如按钮指示灯。

#### 控件设计思想

1.观察者模式，可以设置一个事件，触发时，调用的使用者提供的方法。

2.设计属性：想清楚一个控件所需要的属性

3.初始化：一个控件初始化需要的参数。

4.默认事件：可以设置自定义控件在使用时，双击添加的默认事件。添加到自定义控件的类前面[DefaultEvent("CheckedChanged")]

## 小技巧

1.窗体关闭按钮：设置字体为webdings，通过输入0，r等字符，就会变成对应的符号。

2.快捷键：
    以下几种情况必须用快捷键操作程序：笔记本电脑没有可能没有外接鼠标，某些用户热衷键使用键盘，专业的操作人员为了提高工作效率不使用键盘。因此菜单和按钮要有快捷键。大部分Winform开发工具中只要设置菜单或按钮的Text属性包含 号“&”+ 字符形式的为本即可。例如：“增加（&A）”在运行期就是“增加(A)”,使用快捷键为“Alt+A”。

3.想要查看页面中有哪些控件，直接通过查看代码中Designer.cs文件就好，里面是vs生成的窗体代码，能够清晰的查看哪些控件，都列出来字段了的。

4.有时候不知道代码如何编写的思路了，可以看看微软代码如何编写的。借鉴一下

## 通讯

## 文件格式

JSON：数据交互文件

XML：数据交互文件

ini：一般用于保存配方或者配置文件

# 项目编写 Allinone

AOI测试

## 学习

这个架构大致分为两部分，util通用工具和allinone主要项目。

util中的项目都是窗体控件类库或者类库项目，直接生成dll给其它地方使用。

这个架构类似于若依模块化，一个类库项目就是一个模块，每个模块下面都可以有下面的功能。

### 架构下面的模块文件夹命名规则

主要功能 + Space

例如：

BasicSpace：基本代码

CCDSpace：相机相关

ControllerSpace：

DBSpace：数据相关

FormSpace：页面空间

GlobalSpace：通用空间

Interface：

OPSpace：操作类通用命名控件

PropertyGridSpace：

UISpace：用于存放自定义控件

#### Universal.cs一个静态类，用于一些项目全局使用的 属性

debug：就是让代码离线使用，不加载PLC和控制逻辑，就只是模拟一些逻辑。

项目图片资源，配置文件等路径。也可以写里面

Universal类可以放置一些程序全局需要的通用代码

### 代码编写

FormSpace放页面跳转，按钮点击触发的事件等等逻辑，获取数据，PLC通讯类的都放在FormSpace外面。

ControllerSpace放具体的功能实现，页面的按钮中，只需要调用Controller写好的方法就行。

变量声明，包括控件都放在最前面

在构造函数中，重声明的控件和拖拉的做绑定，放在InitializeComponent()后面，下面在是 事件的绑定等等。

最后在是多语言化，防止开始没用重命名，导致多语言化的名称不对。

label标签最好关闭自动大小，否则切换多语言时，会自己边大小。

### 项目通用功能

日志记录：会一点点，NLog

报表导入导出：还没做过

多国语言：会一点点

INI文件的读取

通信

登陆，权限管理

参数加解密：

软件加解密

页面实时刷新。

测试时间

全局异常捕获：分为UI线程和普通线程

程序防止多开

#### 全局异常捕获

在 C# 里，你可以借助应用程序域的事件来捕获全局异常，而不必在每个可能出现异常的地方都使用 `try-catch` 块。以下是针对控制台应用程序和 Windows 窗体应用程序的全局异常捕获示例：

在控制台应用程序中，你可以使用 `AppDomain.UnhandledException` 事件来捕获未处理的异常。

##### 控制台应用程序

在控制台应用程序中，你可以使用 `AppDomain.UnhandledException` 事件来捕获未处理的异常。

- `AppDomain.CurrentDomain.UnhandledException`：这是一个事件，当应用程序域中出现未处理的异常时会触发该事件。
- `CurrentDomain_UnhandledException` 方法：该方法是事件处理程序，当 `UnhandledException` 事件触发时会调用此方法。在这个方法中，你可以获取异常对象并进行相应的处理，例如记录日志或显示错误信息。

##### Windows 窗体应用程序

在 Windows 窗体应用程序中，除了 `AppDomain.UnhandledException` 事件外，还可以使用 `Application.ThreadException` 事件来捕获主线程中的异常，使用 `AppDomain.UnhandledException` 事件捕获其他线程中的异常。

通过以上方法，你可以在不使用 `try-catch` 块的情况下捕获全局异常。

## 架构

1.要想看一个行业的规范，可以找网上的优秀开源项目，看看他们的框架怎么写的，就大概知道架构规范了。C#中，主要是事件驱动机制。

2.每个方法和类：原子性，每个方法都尽量独立。
