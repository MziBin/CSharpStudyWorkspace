using JSONStudy.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace JSONStudy
{
    public partial class JsonForm : Form
    {

        private RootObject rootObject;  // 用于保存反序列化后的JSON对象，方便后续更新数据
        public JsonForm()
        {
            InitializeComponent();

            // 设置DataGridView可编辑，并添加CellValueChanged事件处理
            dataGridView1.ReadOnly = false;
            dataGridView1.CellValueChanged += DataGridView1_CellValueChanged;
        }

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
        private void btnJSONImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON文件|*.json";  // 设置文件筛选器，只显示json文件类型
            openFileDialog.Title = "选择JSON文件";  // 设置对话框标题

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                string jsonString = File.ReadAllText(selectedFilePath);
                rootObject = JsonSerializer.Deserialize<RootObject>(jsonString);
            }
            LoadDataToDataGriViewTwo();
            //LoadDataToDataGridView();
        }

        private void LoadDataToDataGriViewTwo()
        {
            // 清空DataGridView现有的数据和列
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            // 先添加Name、fY、fX这三列
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("fY", "fY");
            dataGridView1.Columns.Add("fX", "fX");

            // 提取所有的Country作为后续列标题添加到DataGridView
            List<string> countries = new List<string>();
            foreach (var offset in rootObject.offsets)
            {
                foreach (var countryValue in offset.list)
                {
                    if (!countries.Contains(countryValue.Country))
                    {
                        countries.Add(countryValue.Country);
                    }
                }
            }
            foreach (string country in countries)
            {
                dataGridView1.Columns.Add(country, country);
            }

            // 遍历offsets，将每个offset下的数据填充到对应的行中
            foreach (var offset in rootObject.offsets)
            {
                int rowIndex = dataGridView1.Rows.Add();
                DataGridViewRow row = dataGridView1.Rows[rowIndex];

                // 填充Name、fY、fX这三列的值
                row.Cells[0].Value = offset.Name;
                row.Cells[1].Value = offset.fY;
                row.Cells[2].Value = offset.fX;

                int columnIndex = 3;
                foreach (var countryValue in offset.list)
                {
                    row.Cells[columnIndex].Value = countryValue.fValue;
                    columnIndex++;
                }
            }
        }

        #region 不可编辑数据
        private void LoadDataToDataGridView()
        {
            // 清空DataGridView现有的数据和列
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            // 先添加Name、fY、fX这三列
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("fY", "fY");
            dataGridView1.Columns.Add("fX", "fX");

            // 提取所有的Country作为后续列标题添加到DataGridView
            List<string> countries = new List<string>();
            foreach (var offset in rootObject.offsets)
            {
                foreach (var countryValue in offset.list)
                {
                    if (!countries.Contains(countryValue.Country))
                    {
                        countries.Add(countryValue.Country);
                    }
                }
            }
            foreach (string country in countries)
            {
                dataGridView1.Columns.Add(country, country);
            }

            // 遍历offsets，将每个offset下的数据填充到对应的行中
            foreach (var offset in rootObject.offsets)
            {
                int rowIndex = dataGridView1.Rows.Add();
                DataGridViewRow row = dataGridView1.Rows[rowIndex];

                // 填充Name、fY、fX这三列的值
                row.Cells[0].Value = offset.Name;
                row.Cells[1].Value = offset.fY;
                row.Cells[2].Value = offset.fX;

                int columnIndex = 3;
                foreach (var countryValue in offset.list)
                {
                    row.Cells[columnIndex].Value = countryValue.fValue;
                    columnIndex++;
                }
            }
        }
        #endregion

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (rootObject != null)
            {
                int rowIndex = e.RowIndex;
                int columnIndex = e.ColumnIndex;

                // 判断是否是前三列（Name、fY、fX列）
                if (columnIndex < 3)
                {
                    var offset = rootObject.offsets[rowIndex];
                    switch (columnIndex)
                    {
                        case 0:
                            offset.Name = dataGridView1.Rows[rowIndex].Cells[columnIndex].Value.ToString();
                            break;
                        case 1:
                            //将dataGridView1.Rows控件的内容变成decimal格式的
                            if (decimal.TryParse(dataGridView1.Rows[rowIndex].Cells[columnIndex].Value.ToString(), out decimal fYValue) )
                            {
                                offset.fY = fYValue;
                            }
                            break;
                        case 2:
                            if (decimal.TryParse(dataGridView1.Rows[rowIndex].Cells[columnIndex].Value.ToString(), out decimal fXValue))
                            {
                                offset.fX = fXValue;
                            }
                            break;
                    }
                }
                else
                {
                    // 处理Country对应的fValue列
                    var offset = rootObject.offsets[rowIndex];
                    int countryColumnIndex = columnIndex - 3;
                    List<string> countries = new List<string>();
                    foreach (var o in rootObject.offsets)
                    {
                        foreach (var cv in o.list)
                        {
                            if (!countries.Contains(cv.Country))
                            {
                                countries.Add(cv.Country);
                            }
                        }
                    }
                    string country = countries[countryColumnIndex];

                    foreach (var countryValue in offset.list)
                    {
                        if (countryValue.Country == country)
                        {
                            if (decimal.TryParse(dataGridView1.Rows[rowIndex].Cells[columnIndex].Value.ToString(), out decimal fXValue))
                                countryValue.fValue = fXValue;
                            break;
                        }
                    }
                }


            }
        }

        private void btnJSONExport_Click(object sender, EventArgs e)
        {

            // 保存文件弹框
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML文件(*.json)|*.json";
            saveFileDialog.Title = "选择json文件保存位置";

            try
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string jsonFilePath = saveFileDialog.FileName;
                    JsonSerializerOptions options = new JsonSerializerOptions
                    {
                        WriteIndented = true,  // 设置缩进格式，让JSON输出更美观易读
                        //不加这个double精度会出问题，加了还是有问题
                        //NumberHandling = JsonNumberHandling.AllowNamedFloatingPointLiterals | JsonNumberHandling.WriteAsString | JsonNumberHandling.AllowReadingFromString
                        //NumberHandling = JsonNumberHandling.AllowReadingFromString | JsonNumberHandling.WriteAsString  // 允许数字按字符串形式读写
                    };

                    string jsonString = JsonSerializer.Serialize(rootObject, options);
                    File.WriteAllText(jsonFilePath, jsonString);

                    MessageBox.Show("JSON文件保存成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"保存XML文件时出现错误：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要关闭窗口吗？", "关闭确认", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                // 如果当前是最大化状态，恢复到初始大小
                this.WindowState = FormWindowState.Normal;
                this.Bounds = this.RestoreBounds;
                this.btnMax.Text = "口";
            }
            else
            {
                // 如果不是最大化状态，进行最大化
                this.WindowState = FormWindowState.Maximized;
                this.btnMax.Text = "回";
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
