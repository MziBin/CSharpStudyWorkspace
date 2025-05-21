using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XMLStudy.Models;
using XMLStudy.Util;

namespace XMLStudy
{
    public partial class Form1 : Form
    {
        // 数据对象,不知道为什么会被清空
        //在下面的赋值中，可以使用深拷贝复制一个独立副本，暂时不会
        //原因，多创建了一个局部变量
        XmlRootObject xmlRootObject = new XmlRootObject();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnXMLImport_Click(object sender, EventArgs e)
        {
            //// 数据对象
            //XmlRootObject xmlRootObject = new XmlRootObject();

            // 创建OpenFileDialog对象用于弹出文件选择对话框
            OpenFileDialog openFileDialog = new OpenFileDialog();
            // 设置只允许选择XML文件
            openFileDialog.Filter = "XML文件(*.xml)|*.xml";
            openFileDialog.Title = "选择XML文件";

            // 显示对话框并判断用户是否点击了确定按钮（DialogResult.OK表示确定）
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //XML文件路径
                string xmlFilePath = openFileDialog.FileName;

                XMLTools<XmlRootObject> xMLTools = new XMLTools<XmlRootObject>();
                //XML数据转成对象
                xmlRootObject = xMLTools.GetXmlData(xmlFilePath);

                //展示数据到页面中
                LoadDataToDataGridView();

            }
        }
        //展示表格数据
        private void LoadDataToDataGridView()
        {
            // 清空DataGridView的现有数据和列
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            // 将Matrix中的元素作为列标题添加到DataGridView
            List<string> columnHeaders = new List<string>
            {
                xmlRootObject.Matrix.Center.X.ToString(),
                xmlRootObject.Matrix.Center.Y.ToString(),
                xmlRootObject.Matrix.Angle.ToString(),
                xmlRootObject.Matrix.Row.ToString(),
                xmlRootObject.Matrix.Col.ToString()
            };
            foreach (string header in columnHeaders)
            {
                dataGridView1.Columns.Add(header, header);
            }

            // 遍历Cells中的每个Cell对象，将其数据填充为行数据添加到DataGridView
            if (xmlRootObject.Cells != null)
            {
                foreach (var cell in xmlRootObject.Cells.CellList)
                {
                    int rowIndex = dataGridView1.Rows.Add();
                    DataGridViewRow row = dataGridView1.Rows[rowIndex];
                    row.Cells[0].Value = cell.Center.X.ToString();
                    row.Cells[1].Value = cell.Center.Y.ToString();
                    row.Cells[2].Value = cell.DbAngle.ToString();
                    row.Cells[3].Value = cell.NType.ToString();
                }
            }
        }

        private void btnXMLExport_Click(object sender, EventArgs e)
        {
            //// 创建OpenFileDialog对象用于弹出文件选择对话框
            //OpenFileDialog openFileDialog = new OpenFileDialog();
            //// 设置只允许选择XML文件
            //openFileDialog.Filter = "XML文件(*.xml)|*.xml";
            //openFileDialog.Title = "选择XML文件";
            //openFileDialog.ShowDialog();

            XMLTools<XmlRootObject> xMLToolss = new XMLTools<XmlRootObject>();
            //XML数据转成对象
            //xmlRootObject = xMLToolss.GetXmlData(openFileDialog.FileName);

            // 保存文件弹框
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML文件(*.xml)|*.xml";
            saveFileDialog.Title = "选择XML文件保存位置";

            try
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string xmlFile = saveFileDialog.FileName;
                    XMLTools<XmlRootObject> xMLTools = new XMLTools<XmlRootObject>();
                    xMLTools.ExportXMLSerialization(xmlRootObject, xmlFile);

                    MessageBox.Show("XML文件保存成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"保存XML文件时出现错误：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
