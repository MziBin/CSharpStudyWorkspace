using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xml值对比.util
{
    public class ComparisonSort
    {
        private double[] cellX;
        private double[] cellY;
        private double[] cellAngle;

        public string[] XMLComparisonSort(List<List<double[]>> ts)
        {
            return new string[3];
        }
        /// <summary>
        /// 通过最大最小值计算每组数据的差值
        /// 确定每个cellx多少个,y多少个
        /// </summary>
        /// <returns></returns>
        public List<decimal[]> DifferenceValue(List<List<decimal[]>> ts)
        {
            List<decimal[]> CellX = new List<decimal[]>();
            List<decimal[]> CellY = new List<decimal[]>();
            List<decimal[]> CellAngle = new List<decimal[]>();

            for (int i=0; i < ts[0].Count; i++)
            {
                decimal[] dataX = new decimal[ts.Count];
                decimal[] dataY = new decimal[ts.Count];
                decimal[] dataAngle = new decimal[ts.Count];
                for (int j=0; j < ts.Count; j++)
                {
                    dataX[j] = ts[j][i][0];
                    dataY[j] = ts[j][i][1];
                    dataAngle[j] = ts[j][i][2];
                }
                CellX.Add(dataX);
                CellY.Add(dataY);
                CellAngle.Add(dataAngle);
            }

            SortData(CellX);
            SortData(CellY);
            SortData(CellAngle);

            List<decimal[]> returnList = new List<decimal[]>();
            returnList.Add(CompareVlaue(CellX));
            returnList.Add(CompareVlaue(CellY));
            returnList.Add(CompareVlaue(CellAngle));

            return returnList;
        }

        public decimal[] CompareVlaue(List<decimal[]> data)
        {
            decimal[] Max = new decimal[data.Count];
            for (int i = 0; i < data.Count; i++)
            {
                Max[i] = data[i][data[0].Length-1];
            }
            decimal[] Min = new decimal[data.Count];
            for (int i = 0; i < data.Count; i++)
            {
                Min[i] = data[i][0];
            }
            decimal[] difference = new decimal[data.Count];
            for(int i = 0;i < data.Count; i++)
            {
                difference[i] = Max[i] - Min[i];
                //difference[i] = double.Parse(difference[i].ToString("F5"));
            }

            decimal[] doubles = new decimal[2] { difference.Min(), difference.Max() };

            return doubles;

        }

        public void SortData(List<decimal[]> doubles)
        {
            for (int i = 0; i < doubles.Count; i++)
            {
                CellSort(doubles[i]);
            }
        }

        /// <summary>
        /// 单个Cell的最小值
        /// </summary>
        /// <returns></returns>
        public List<double[]> XMLCellMinValue(List<List<double[]>> ts)
        {
            return new List<double[]>();
        }

        /// <summary>
        /// 单个Cell的最大值
        /// </summary>
        /// <returns></returns>
        public List<double[]> XMLCellMaxValue()
        {
            return new List<double[]>();
        }

        //排序，重小到大
        public decimal[] CellSort(decimal[] data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                for(int j = i+1; j< data.Length; j++)
                {
                   if (data[j] < data[i])
                    {
                        decimal t = data[j];
                        data[j] = data[i];
                        data[i] = t;
                    }
                }
            }

            return data;
        }
    }
}
