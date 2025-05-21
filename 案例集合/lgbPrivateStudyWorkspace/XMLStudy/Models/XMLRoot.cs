using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLStudy.Models
/*
{
// 对应根元素 <xmlRoot>
public class XmlRootObject
{
    public Matrix Matrix { get; set; }
    public Cells Cells { get; set; }
}

// 对应 <Matrix> 元素
public class Matrix
{
    public Center Center { get; set; }
    public double Angle { get; set; }
    public int Row { get; set; }
    public int Col { get; set; }
}

// 对应 <Center> 元素（<Matrix> 下和 <cellX> 下都有）
public class Center
{
    public double X { get; set; }
    public double Y { get; set; }
}

// 对应 <Cells> 元素
public class Cells
{
    public List<Cell> CellList { get; set; }
}

// 对应 <cellX> 类型的元素（以 <cell0>、<cell1> 等为例）
public class Cell
{
    public Center Center { get; set; }
    public double DbAngle { get; set; }
    public int NType { get; set; }
}
}
*/
{
    //序列化的方式
    [XmlRoot("xmlRoot")]
    public class XmlRootObject
    {
        public Matrix Matrix { get; set; }
        public Cells Cells { get; set; }
    }

    // 对应 <Matrix> 元素
    public class Matrix
    {
        public Center Center { get; set; }
        public double Angle { get; set; }
        public int Row { get; set; }
        public int Col { get; set; }
    }

    // 对应 <Center> 元素（<Matrix> 下和 <cellX> 下都有）
    public class Center
    {
        [XmlAttribute("x")]
        public double X { get; set; }
        [XmlAttribute("y")]
        public double Y { get; set; }
    }

    // 对应 <Cells> 元素
    public class Cells
    {
        public List<Cell> CellList { get; set; }
    }

    // 对应 <cellX> 类型的元素（以 <cell0>、<cell1> 等为例）
    public class Cell
    {
        public Center Center { get; set; }
        public double DbAngle { get; set; }
        public int NType { get; set; }
    }
}
