using NPOI.SS.Formula.Functions;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace xml值对比.util
{
    public class ExcelUtil
    {

        /// <summary>
        /// 保存单个XML文件
        /// </summary>
        /// <param name="dataList"></param>
        public static void XMLToExcel(List<decimal[]> dataList)
        {
            //保存文件弹框
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx";
            saveFileDialog.Title = "选择Excel文件保存位置";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    IWorkbook workbook = new XSSFWorkbook();
                    ISheet sheet = workbook.CreateSheet("Sheet1");

                    IRow excelRow = sheet.CreateRow(0);
                    excelRow.CreateCell(0).SetCellValue("X");
                    excelRow.CreateCell(1).SetCellValue("Y");
                    excelRow.CreateCell(2).SetCellValue("Angle");

                    // 填充数据到工作表
                    for (int row = 0; row < dataList.Count; row++)
                    {
                        decimal[] currentArray = dataList[row];
                        excelRow = sheet.CreateRow(row + 1);
                        for (int col = 0; col < currentArray.Length; col++)
                        {
                            excelRow.CreateCell(col).SetCellValue((double)currentArray[col]);
                        }
                    }

                    using (FileStream file = new FileStream(saveFileDialog.FileName, FileMode.Create))
                    {
                        workbook.Write(file);
                    }

                    MessageBox.Show("Excel文件保存成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"保存Excel文件时出现错误：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("已取消保存Excel文件操作。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// 保存多个个XML文件
        /// 循环总个数，内循环几个XML，输入列，创建3个数组，每次循环保存X,Y,Z,的值，并计算最大值，最小值，差值
        /// </summary>
        /// <param name="dataList"></param>
        public static void XMLToExcelAll(List<List<decimal[]>> XMLDataList)
        {
            //保存文件弹框
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx";
            saveFileDialog.Title = "选择Excel文件保存位置";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //创建表格
                    IWorkbook workbook = new XSSFWorkbook();
                    ISheet sheet = workbook.CreateSheet("Sheet1");

                    IRow excelRow = sheet.CreateRow(0);
                    //表头
                    for (int i = 0; i < XMLDataList.Count + 3; i++)
                    {
                        if (i < XMLDataList.Count)
                        {
                            excelRow.CreateCell((i * 4) + 0).SetCellValue($"X{i}");
                            excelRow.CreateCell((i * 4) + 1).SetCellValue($"Y{i}");
                            excelRow.CreateCell((i * 4) + 2).SetCellValue($"Angle{i}");
                        }
                        else if (i == XMLDataList.Count)
                        {
                            excelRow.CreateCell((i * 4) + 0).SetCellValue($"X_Max");
                            excelRow.CreateCell((i * 4) + 1).SetCellValue($"X_Min");
                            excelRow.CreateCell((i * 4) + 2).SetCellValue($"X_difference");
                        }
                        else if (i == XMLDataList.Count + 1)
                        {
                            excelRow.CreateCell((i * 4) + 0).SetCellValue($"Y_Max");
                            excelRow.CreateCell((i * 4) + 1).SetCellValue($"Y_Min");
                            excelRow.CreateCell((i * 4) + 2).SetCellValue($"Y_difference");
                        }
                        else if (i == XMLDataList.Count + 2)
                        {
                            excelRow.CreateCell((i * 4) + 0).SetCellValue($"Angle_Max");
                            excelRow.CreateCell((i * 4) + 1).SetCellValue($"Angle_Min");
                            excelRow.CreateCell((i * 4) + 2).SetCellValue($"Angle_difference");
                        }
                    }

                    // 填充数据到工作表
                    for (int row = 0; row < XMLDataList[0].Count; row++)
                    {
                        excelRow = sheet.CreateRow(row + 1);

                        decimal[] X = new decimal[XMLDataList.Count];
                        decimal[] Y = new decimal[XMLDataList.Count];
                        decimal[] Angle = new decimal[XMLDataList.Count];

                        for (int i = 0; i < XMLDataList.Count; i++)
                        {
                            X[i] = XMLDataList[i][row][0];
                            Y[i] = XMLDataList[i][row][1];
                            Angle[i] = XMLDataList[i][row][2];

                            excelRow.CreateCell((i * 4) + 0).SetCellValue((double)X[i]);
                            excelRow.CreateCell((i * 4) + 1).SetCellValue((double)Y[i]);
                            excelRow.CreateCell((i * 4) + 2).SetCellValue((double)Angle[i]);
                        }

                        for (int i = XMLDataList.Count; i < XMLDataList.Count + 3; i++)
                        {
                            if (i == XMLDataList.Count)
                            {
                                excelRow.CreateCell((i * 4) + 0).SetCellValue((double)X.Max());
                                excelRow.CreateCell((i * 4) + 1).SetCellValue((double)X.Min());
                                excelRow.CreateCell((i * 4) + 2).SetCellValue(Convert.ToDouble($"{X.Max() - X.Min()}"));
                            }
                            else if (i == XMLDataList.Count + 1)
                            {
                                excelRow.CreateCell((i * 4) + 0).SetCellValue((double)Y.Max());
                                excelRow.CreateCell((i * 4) + 1).SetCellValue((double)Y.Min());
                                excelRow.CreateCell((i * 4) + 2).SetCellValue(Convert.ToDouble($"{Y.Max() - Y.Min()}"));
                            }
                            else if (i == XMLDataList.Count + 2)
                            {
                                excelRow.CreateCell((i * 4) + 0).SetCellValue((double)Angle.Max());
                                excelRow.CreateCell((i * 4) + 1).SetCellValue((double)Angle.Min());
                                excelRow.CreateCell((i * 4) + 2).SetCellValue(Convert.ToDouble($"{Angle.Max() - Angle.Min()}"));
                            }
                        }
                    }

                    using (FileStream file = new FileStream(saveFileDialog.FileName, FileMode.Create))
                    {
                        workbook.Write(file);
                    }

                    MessageBox.Show("Excel文件保存成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"保存Excel文件时出现错误：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("已取消保存Excel文件操作。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public static void CheckPointExcel(decimal pointX, decimal pointY, int row, int col, int difference, List<decimal[]> dataList)
        {
            //存储标准镭雕数据
            List<decimal[]> laserDataList = new List<decimal[]>();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    decimal[] laserDataArray = new decimal[3];

                    laserDataArray[0] = pointX + (decimal)(difference * j);
                    laserDataArray[1] = pointY - (decimal)(difference * i);
                    laserDataArray[2] = 0;

                    laserDataList.Add(laserDataArray);
                }
            }

            //存储差值
            decimal[][] differenceDataArrar = new decimal[3][];
            for (int i = 0; i < 3; i++)
            {
                differenceDataArrar[i] = new decimal[col * row];
            }

            //保存文件弹框
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx";
            saveFileDialog.Title = "选择Excel文件保存位置";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    IWorkbook workbook = new XSSFWorkbook();
                    ISheet sheet = workbook.CreateSheet("Sheet1");

                    IRow[] excelRowArrar = new IRow[row * col + 1];
                    for (int i = 0; i < (row * col + 1); i++)
                    {
                        excelRowArrar[i] = sheet.CreateRow(i);
                    }
                    IRow excelRow = excelRowArrar[0];
                    //IRow excelRow = sheet.CreateRow(0);
                    excelRowArrar[0].CreateCell(0).SetCellValue("X");
                    excelRowArrar[0].CreateCell(1).SetCellValue("Y");
                    excelRowArrar[0].CreateCell(2).SetCellValue("Angle");

                    excelRowArrar[0].CreateCell(4).SetCellValue("laserX");
                    excelRowArrar[0].CreateCell(5).SetCellValue("laserY");
                    excelRowArrar[0].CreateCell(6).SetCellValue("laserAngle");

                    excelRowArrar[0].CreateCell(8).SetCellValue("differenceX");
                    excelRowArrar[0].CreateCell(9).SetCellValue("differenceY");
                    excelRowArrar[0].CreateCell(10).SetCellValue("differenceAngle");

                    excelRowArrar[0].CreateCell(12).SetCellValue("MaxX");
                    excelRowArrar[0].CreateCell(13).SetCellValue("MaxY");
                    excelRowArrar[0].CreateCell(14).SetCellValue("MaxAngle");

                    //excelRow = sheet.CreateRow(2);

                    excelRowArrar[2].CreateCell(12).SetCellValue("MinX");
                    excelRowArrar[2].CreateCell(13).SetCellValue("MinY");
                    excelRowArrar[2].CreateCell(14).SetCellValue("MinAngle");

                    // 填充数据到工作表
                    for (int i = 0; i < dataList.Count; i++)
                    {
                        decimal[] currentArray = dataList[i];
                        //IRow excelRow = sheet.CreateRow(i + 1);
                        excelRow = excelRowArrar[i + 1];
                        for (int j = 0; j < currentArray.Length; j++)
                        {
                            excelRow.CreateCell(j).SetCellValue((double)currentArray[j]);
                            excelRow.CreateCell(j + 4).SetCellValue((double)laserDataList[i][j]);
                            if (j == 0)
                            {
                                differenceDataArrar[0][i] = Math.Abs(currentArray[j] - laserDataList[i][j]);
                                excelRow.CreateCell(j + 8).SetCellValue((double)differenceDataArrar[0][i]);
                            }
                            else if (j == 1)
                            {
                                differenceDataArrar[1][i] = Math.Abs(currentArray[j] - laserDataList[i][j]);
                                excelRow.CreateCell(j + 8).SetCellValue((double)differenceDataArrar[1][i]);
                            }
                            else if (j == 2)
                            {
                                differenceDataArrar[2][i] = Math.Abs(currentArray[j] - laserDataList[i][j]);
                                excelRow.CreateCell(j + 8).SetCellValue((double)differenceDataArrar[2][i]);
                            }

                        }
                    }
                    excelRow = excelRowArrar[1];
                    excelRow.CreateCell(12).SetCellValue((double)differenceDataArrar[0].Max());
                    excelRow.CreateCell(13).SetCellValue((double)differenceDataArrar[1].Max());
                    excelRow.CreateCell(14).SetCellValue((double)differenceDataArrar[2].Max());

                    excelRow = excelRowArrar[3];

                    excelRow.CreateCell(12).SetCellValue((double)differenceDataArrar[0].Min());
                    excelRow.CreateCell(13).SetCellValue((double)differenceDataArrar[1].Min());
                    excelRow.CreateCell(14).SetCellValue((double)differenceDataArrar[2].Min());


                    using (FileStream file = new FileStream(saveFileDialog.FileName, FileMode.Create))
                    {
                        workbook.Write(file);
                    }

                    MessageBox.Show("Excel文件保存成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"保存Excel文件时出现错误：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("已取消保存Excel文件操作。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        public static string[] CheckPoint(decimal pointX, decimal pointY, int row, int col, int difference, List<decimal[]> dataList)
        {
            //存储标准镭雕数据
            List<decimal[]> laserDataList = new List<decimal[]>();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    decimal[] laserDataArray = new decimal[3];

                    laserDataArray[0] = pointX + (decimal)(difference * j);
                    laserDataArray[1] = pointY - (decimal)(difference * i);
                    laserDataArray[2] = 0;

                    laserDataList.Add(laserDataArray);
                }
            }

            //存储差值
            decimal[][] differenceDataArrar = new decimal[3][];
            for (int i = 0; i < 3; i++)
            {
                differenceDataArrar[i] = new decimal[col * row];
            }
            for (int i = 0; i < dataList.Count; i++)
            {
                decimal[] currentArray = dataList[i];
                for (int j = 0; j < currentArray.Length; j++)
                {
                    if (j == 0)
                    {
                        differenceDataArrar[0][i] = Math.Abs(currentArray[j] - laserDataList[i][j]);
                    }
                    else if (j == 1)
                    {
                        differenceDataArrar[1][i] = Math.Abs(currentArray[j] - laserDataList[i][j]);
                    }
                    else if (j == 2)
                    {
                        differenceDataArrar[2][i] = Math.Abs(currentArray[j] - laserDataList[i][j]);
                    }

                }
            }

            string[] data = new string[6];
            data[0] = differenceDataArrar[0].Max() + "";
            data[1] = differenceDataArrar[1].Max() + "";
            data[2] = differenceDataArrar[2].Max() + "";

            data[3] = differenceDataArrar[0].Min() + "";
            data[4] = differenceDataArrar[1].Min() + "";
            data[5] = differenceDataArrar[2].Min() + "";

            return data;
        }
    }
}
