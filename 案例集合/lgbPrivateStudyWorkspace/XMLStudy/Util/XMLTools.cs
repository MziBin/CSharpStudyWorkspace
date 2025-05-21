using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using XMLStudy.Models;

namespace XMLStudy.Util
{
    /// <summary>
    /// 泛型T方便后续不同的XML对象类型
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class XMLTools<T>
    {
        #region
        public XmlRootObject GetXmlData(string XmlFile)
        {
            string xmlFilePath = XmlFile;
            XmlRootObject xmlRootObject = new XmlRootObject();

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(xmlFilePath);

            // 读取 <Matrix> 元素相关数据并填充到对象
            XmlNode matrixNode = xmlDoc.DocumentElement.SelectSingleNode("Matrix");
            if (matrixNode != null)
            {
                Matrix matrix = new Matrix();

                XmlNode centerNode = matrixNode.SelectSingleNode("Center");
                if (centerNode != null)
                {
                    matrix.Center = new Center
                    {
                        X = double.Parse(centerNode.Attributes["x"].Value),
                        Y = double.Parse(centerNode.Attributes["y"].Value)
                    };
                }

                XmlNode angleNode = matrixNode.SelectSingleNode("Angle");
                if (angleNode != null)
                {
                    matrix.Angle = double.Parse(angleNode.InnerText);
                }

                XmlNode rowNode = matrixNode.SelectSingleNode("Row");
                if (rowNode != null)
                {
                    matrix.Row = int.Parse(rowNode.InnerText);
                }

                XmlNode colNode = matrixNode.SelectSingleNode("Col");
                if (colNode != null)
                {
                    matrix.Col = int.Parse(colNode.InnerText);
                }

                xmlRootObject.Matrix = matrix;
            }

            // 读取 <Cells> 元素相关数据并填充到对象
            XmlNode cellsNode = xmlDoc.DocumentElement.SelectSingleNode("Cells");
            if (cellsNode != null)
            {
                Cells cells = new Cells();
                cells.CellList = new List<Cell>();

                // 获取所有的 <Cells>下的 Cell* 节点
                XmlNodeList cellNodes = xmlDoc.SelectNodes("xmlRoot/Cells/*[starts-with(name(), 'cell')]");
                foreach (XmlNode cellNode in cellNodes)
                {
                    Cell cell = new Cell();

                    XmlNode cellCenterNode = cellNode.SelectSingleNode("Center");
                    if (cellCenterNode != null)
                    {
                        cell.Center = new Center
                        {
                            X = double.Parse(cellCenterNode.Attributes["x"].Value),
                            Y = double.Parse(cellCenterNode.Attributes["y"].Value)
                        };
                    }

                    XmlNode dbAngleNode = cellNode.SelectSingleNode("dbAngle");
                    if (dbAngleNode != null)
                    {
                        cell.DbAngle = double.Parse(dbAngleNode.InnerText);
                    }

                    XmlNode nTypeNode = cellNode.SelectSingleNode("nType");
                    if (nTypeNode != null)
                    {
                        cell.NType = int.Parse(nTypeNode.InnerText);
                    }

                    cells.CellList.Add(cell);
                }

                xmlRootObject.Cells = cells;
            }

            return xmlRootObject;
        }
        #endregion
        #region 序列化的方式
        // 从XML文件反序列化获取数据的方法,暂时有问题
        public T GetXmlDataSerialization(string xmlFile)
        {
            string xmlFilePath = xmlFile;
            T xmlObject;

            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (FileStream fileStream = new FileStream(xmlFilePath, FileMode.Open))
            {
                xmlObject = (T)serializer.Deserialize(fileStream);
            }
            return xmlObject;
        }
        #endregion

        //序列化导出，暂时有问题
        public int ExportXMLSerialization(XmlRootObject xmlRootObject, string output)
        {
                string xmlFilePath = output;
                XmlSerializer serializer = new XmlSerializer(typeof(XmlRootObject));
                using (FileStream fileStream = new FileStream(xmlFilePath, FileMode.Create))
                {
                    serializer.Serialize(fileStream, xmlRootObject);
                }

                return 1;
        }

        public int ExportXML(XmlRootObject xmlRootObject, string output)
        {
            string xmlFilePath = output;
            StringBuilder xmlContent = new StringBuilder();

            // 构建XML声明部分
            xmlContent.Append("<?xml version=\"1.0\" encoding=\"UTF-8\"?>\n");

            // 构建根元素开始标签
            xmlContent.Append("<xmlRoot>\n");

            // 构建 <Matrix> 元素及其子元素内容
            xmlContent.Append("<Matrix>\n");
            xmlContent.Append($"<Center x=\"{xmlRootObject.Matrix.Center.X}\" y=\"{xmlRootObject.Matrix.Center.Y}\"/>\n");
            xmlContent.Append($"<Angle>{xmlRootObject.Matrix.Angle}</Angle>\n");
            xmlContent.Append($"<Row>{xmlRootObject.Matrix.Row}</Row>\n");
            xmlContent.Append($"<Col>{xmlRootObject.Matrix.Col}</Col>\n");
            xmlContent.Append("</Matrix>\n");

            // 构建 <Cells> 元素及其包含的 <cellX> 元素内容
            xmlContent.Append("<Cells>\n");
            for (int i = 0; i < xmlRootObject.Cells.CellList.Count; i++)
            {
                var cell = xmlRootObject.Cells.CellList[i];
                xmlContent.Append($"<cell{i}>\n");
                xmlContent.Append($"<Center x=\"{cell.Center.X}\" y=\"{cell.Center.Y}\"/>\n");
                xmlContent.Append($"<dbAngle>{cell.DbAngle}</dbAngle>\n");
                xmlContent.Append($"<nType>{cell.NType}</nType>\n");
                xmlContent.Append($"</cell{i}>\n");
            }
            xmlContent.Append("</Cells>\n");

            // 构建根元素结束标签
            xmlContent.Append("</xmlRoot>\n");

            File.WriteAllText(xmlFilePath, xmlContent.ToString(), Encoding.UTF8);

            return 1;
        }

    }
}
