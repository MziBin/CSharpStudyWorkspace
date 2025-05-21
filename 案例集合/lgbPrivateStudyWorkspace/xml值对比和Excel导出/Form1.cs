using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using xml值对比.util;

namespace xml值对比
{
    public partial class Form1 : Form
    {
        //导入XML文件数据
        List<List<decimal[]>> XMLDataList = new List<List<decimal[]>>();
        string xmlFilePath = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 创建OpenFileDialog对象用于弹出文件选择对话框
            OpenFileDialog openFileDialog = new OpenFileDialog();
            // 设置只允许选择XML文件
            openFileDialog.Filter = "XML文件(*.xml)|*.xml";
            openFileDialog.Title = "选择XML文件";

            // 显示对话框并判断用户是否点击了确定按钮（DialogResult.OK表示确定）
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                xmlFilePath = openFileDialog.FileName;
                //MessageBox.Show(xmlFilePath,"路劲弹窗");
                XMLDataList.Add(XMLDataRead.ReadXMLData(xmlFilePath) );
                XMLCount.Text = XMLDataList.Count.ToString();

                ComparisonSort comparisonSort = new ComparisonSort();
                List<decimal[]> doubles = comparisonSort.DifferenceValue(XMLDataList);

                rowMax.Text = doubles[0][1] + "";
                rowMin.Text = doubles[0][0] + "";
                colMax.Text = doubles[1][1] + "";
                colMin.Text = doubles[1][0] + "";
                angleMax.Text = doubles[2][1] + "";
                angleMin.Text = doubles[2][0] + "";


                int[] XY = XMLDataRead.RowColData(xmlFilePath);
                colCount.Text = XY[1] + "";
                rowCount.Text = XY[0] + "";

                //// 调用方法读取XML文件并创建二维数组
                //string[,] twoDArray = ReadXMLDataTo2DArray(xmlFilePath);
                //// 这里可以根据需求对创建好的二维数组进行后续处理，比如展示数据等
                //if (twoDArray != null)
                //{
                //    // 简单示例：打印二维数组数据（可按需替换为更合适的展示或处理逻辑）
                //    for (int i = 0; i < twoDArray.GetLength(0); i++)
                //    {
                //        for (int j = 0; j < twoDArray.GetLength(1); j++)
                //        {
                //            Console.Write(twoDArray[i, j] + " ");
                //        }
                //        Console.WriteLine();
                //    }
                //}
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            XMLDataList = new List<List<decimal[]>>();
            XMLCount.Text = XMLDataList.Count.ToString();

            rowMax.Text = "0";
            rowMin.Text = "0";
            colMax.Text = "0";
            colMin.Text = "0";
            angleMax.Text = "0";
            angleMin.Text = "0";

            colCount.Text = 0 + "";
            rowCount.Text = 0 + "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 创建OpenFileDialog对象用于弹出文件选择对话框
            OpenFileDialog openFileDialog = new OpenFileDialog();
            // 设置只允许选择XML文件
            openFileDialog.Filter = "XML文件(*.xml)|*.xml";
            openFileDialog.Title = "选择XML文件";

            // 显示对话框并判断用户是否点击了确定按钮（DialogResult.OK表示确定）
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string xmlFilePath = openFileDialog.FileName;
                //MessageBox.Show(xmlFilePath,"路劲弹窗");
                List<decimal[]> list = XMLDataRead.ReadXMLData(xmlFilePath);
                ExcelUtil.XMLToExcel(list);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (XMLDataList.Count != 0)
            {
                ExcelUtil.XMLToExcelAll(XMLDataList);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            //先判断是否有对比数据，是否只有一个
            if (XMLDataList.Count == 1) 
            { 
                if(PointX.Text != "0" && PointY.Text != "0" && PointX.Text != "" && PointY.Text != "" && difference.Text != "")
                {
                    ExcelUtil.CheckPointExcel(Convert.ToDecimal(PointX.Text), Convert.ToDecimal(PointY.Text),
                        Convert.ToInt32(rowCount.Text), Convert.ToInt32(colCount.Text),
                        Convert.ToInt32(difference.Text), XMLDataRead.ReadXMLData(xmlFilePath));
                }
                else
                {
                    MessageBox.Show("请输入对应的点位坐标", "错误");
                }
            }else
            {
                MessageBox.Show("请先选择XML数据文件，或者数据有多个","错误");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //先判断是否有对比数据，是否只有一个
            if (XMLDataList.Count == 1)
            {
                if (PointX.Text != "0" && PointY.Text != "0" && PointX.Text != "" && PointY.Text != "" && difference.Text != "")
                {
                    string[] data = ExcelUtil.CheckPoint(Convert.ToDecimal(PointX.Text), Convert.ToDecimal(PointY.Text),
                        Convert.ToInt32(rowCount.Text), Convert.ToInt32(colCount.Text),
                        Convert.ToInt32(difference.Text), XMLDataRead.ReadXMLData(xmlFilePath));

                    checkRowMax.Text = data[0];
                    checkColMax.Text = data[1];
                    checkAngleMax.Text = data[2];
                    checkRowMin.Text = data[3];
                    checkColMin.Text = data[4];
                    checkAngleMin.Text = data[5];

                }
                else
                {
                    MessageBox.Show("请输入对应的点位坐标", "错误");
                }
            }
            else
            {
                MessageBox.Show("请先选择XML数据文件，或者数据有多个", "错误");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PointX.Text = "";
            PointY.Text = "";
            difference.Text = "";

            checkRowMax.Text = "0";
            checkColMax.Text = "0";
            checkAngleMax.Text = "0";
            checkRowMin.Text = "0";
            checkColMin.Text = "0";
            checkAngleMin.Text = "0";
        }
    }
}
