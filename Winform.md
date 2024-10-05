# WinForm笔记

## 1.项目结构规范

### 1.1 命名规范

主窗口要改名，改成和项目相关的名字，如TrayToTrayMainForm。

## 2.代码结构简介

Form类通过partial分为两个类。避免混乱，如果觉得还是分的，也可以通过partial在分一个类。

Form.Designer：主要是代码自动生成的一些属性，很少动的。

InitializeComponent就是在Form.Designer中，如果不加partial就会在一个类中很混乱。

Form：主要是事件，经常编辑的

### 2.1 控件

2.1.1 窗体的所有控件都是成员变量，在Designer中声明。

2.1.2 InitializeComponent方法里面的代码最好不要改动

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

AutoScaleMode：Inherit或者None

### 5.2 CheckBox复选框

5.2.1 外观中的属性

Checked：默认选中还是不选中


### 5.3 ComboBox 下拉框


### 5.4 dataGridView


### 5.5 容器

#### 5.5.1 panel

容器里面加入控件页面也是通过Controls.Add加入的，动态展示也会加入Controls管理。

### 5.6 Button

#### 5.6.1 按钮的使能



### 问题

textBox如何调整高度


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

6.2 

## 7.架构，程序的设计

其实开发语法哪些不是最难的，多记下就好了，还是程序的设计，这个搞明白了，其实就差不多很厉害了。
