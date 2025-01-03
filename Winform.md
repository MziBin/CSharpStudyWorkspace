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

【1】控件和组件的区别：控件是在窗体上可见的。组件是在窗体下面不可见的，也就是不占用窗体的空间。也就是没有可视化的界面。

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

#### 事件的sender参数

sender就是当前调用的对象，使用时，只需要转换一下。

#### 事件的统一关联

就是将多个事件都统一成一个，多个事件调用这一个事件处理方法即可。

##### 控件的Tag属性

## 3. WinForm基本使用

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

## 4.UI设计

4.1 外观设计要求

1.主窗体无边框化，扁平化：FormBorderStyle：None

2.textbox：BorderStyle：FixedSingle

3.Button：FlatStyle: Flat

Dock：锚定

## 5.常用组件的属性

### 5.0 通用属性

### 5.1 主窗体

StartPosition：设置窗体第一次出现位置

5.1.1 布局中的属性：

AutoScaleMode：Inherit或者None。

5.1.2 右键菜单

ContextMenuStrip：使用要选择一个窗体菜单

### 5.2 CheckBox复选框

5.2.1 外观中的属性

Checked：默认选中还是不选中

### 5.3 ComboBox 下拉框

### 5.4 dataGridView

数据展示控件,要想展示数据，每列的属性都要设置3个，name，data，text。

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

### 5.5 容器

#### 5.5.1 panel

容器里面加入控件页面也是通过Controls.Add加入的，动态展示也会加入Controls管理。

### 5.6 Button

#### 5.6.1 按钮的使能

### 5.7 列表框 ListBox

可以用来展示输出信息

#### 5.7.1 信息的添加

ListBox.Item.Add();

#### 5.7.2 信息的清空

ListBox.Item.Clear();

### 5.8 Time 控件

### 5.9 ContextMenStrip窗体右键菜单

### 5.10 ImageList控件

### 5.11 弹窗MessageBox.show()

5.12 打开

### 问题

textBox如何调整高度

#### NuGet的UI框架如何加入工具栏中

方法一：

VS菜单栏中：项目＝》刷新项目工具箱

![1735805342778](image/Winform/1735805342778.png)

方法二：

菜单栏中：工具＝》选项＝》**Windows**窗体设计器＝》常规＝》工具箱=》自动填充工具箱=》True

![1735805381768](image/Winform/1735805381768.png)

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
