using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform常用控件
{
    public partial class PropertyGridExample : Form
    {
        private PropertyGrid propertyGrid;

        public PropertyGridExample()
        {
            InitializeComponent();
            // 创建 PropertyGrid 对象
            propertyGrid = new PropertyGrid();
            // 设置 PropertyGrid 停靠在整个窗体
            propertyGrid.Dock = DockStyle.Fill;
            // 将 PropertyGrid 添加到窗体
            this.Controls.Add(propertyGrid);

            // 关联对象到 PropertyGrid
            AssociateObjectToPropertyGrid();
            // 处理属性值更改事件
            HandlePropertyValueChanged();
        }

        // 定义一个示例类
        public class Person
        {
            [DisplayName("姓名")]
            [Description("人员的姓名")]
            public string Name { get; set; }

            [DisplayName("年龄")]
            [Description("人员的年龄")]
            [ReadOnly(true)] // 设置该属性为只读
            public int Age { get; set; }

            [DisplayName("地址")]
            [Description("人员的居住地址")]
            public string Address { get; set; }

            [Browsable(false)] // 设置该属性不在 PropertyGrid 中显示
            public string HiddenProperty { get; set; }
        }

        private void AssociateObjectToPropertyGrid()
        {
            // 创建一个 Person 对象
            Person person = new Person
            {
                Name = "张三",
                Age = 25,
                Address = "北京市朝阳区"
            };

            // 将 Person 对象关联到 PropertyGrid
            propertyGrid.SelectedObject = person;
        }

        private void HandlePropertyValueChanged()
        {
            propertyGrid.PropertyValueChanged += PropertyGrid_PropertyValueChanged;
        }

        private void PropertyGrid_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            MessageBox.Show($"属性 {e.ChangedItem.Label} 的值已更改为 {e.ChangedItem.Value}");
        }
    }
}