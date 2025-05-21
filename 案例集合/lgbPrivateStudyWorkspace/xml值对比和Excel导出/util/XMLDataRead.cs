using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace xml值对比.util
{
    public class XMLDataRead
    {
        public static List<decimal[]> ReadXMLData(string xmlFilePath)
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(xmlFilePath);

                //创建存储测试数据的数组
                List<decimal[]> dataList = new List<decimal[]>();

                // 获取所有的 <Cells>下的 Cell* 节点
                XmlNodeList cellNodes = xmlDoc.SelectNodes("xmlRoot/Cells/*[starts-with(name(), 'cell')]");

                // 读取 <cell*> 节点下各子节点的数据（文本内容及属性值情况）
                for (int i=0; i < cellNodes.Count; i++)
                {
                    decimal[] data = new decimal[3];
                    XmlNode cellNode = xmlDoc.SelectSingleNode($"xmlRoot/Cells/cell{i}");
                    if (cellNode != null)
                    {
                        XmlNode cellCenterNode = cellNode.SelectSingleNode("Center");
                        if (cellCenterNode != null)
                        {
                            decimal cellCenterX = Convert.ToDecimal(cellCenterNode.Attributes["x"].Value );
                            decimal cellCenterY = Convert.ToDecimal(cellCenterNode.Attributes["y"].Value );
                            data[0] = cellCenterX;
                            data[1] = cellCenterY;
                        }

                        XmlNode cellDbAngleNode = cellNode.SelectSingleNode("dbAngle");
                        if (cellDbAngleNode != null)
                        {
                            decimal cellDbAngle = Convert.ToDecimal(cellDbAngleNode.InnerText);
                            data[2] = cellDbAngle;
                        }
                        dataList.Add(data);
                    }
                }

                return dataList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("读取XML文件出现错误: " + ex.Message);
                return null;
            }
        }

        public static int[] RowColData(string xmlFilePath)
        {
            int row = 0;
            int col = 0;

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(xmlFilePath);
            #region 获取行列数据
            // 获取<Row> 节点数据
            //XmlNodeList rowNodes = xmlDoc.DocumentElement.SelectNodes("Row");
            XmlNode rowNode = xmlDoc.SelectSingleNode("xmlRoot/Matrix/Row");
            if (rowNode != null)
            {
                row = Convert.ToInt32(rowNode.InnerText);
            }
            // 获取<Col> 节点数据
            XmlNode colNode = xmlDoc.SelectSingleNode("xmlRoot/Matrix/Col");
            if (colNode != null)
            {
                col = Convert.ToInt32(colNode.InnerText);
            }
            #endregion

            int[] data = new int[2]
            {
                row,
                col
            };

            return data;
        }

    }
}
