using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMain1
{
    /// <summary>
    /// 手机类
    /// 字段
    /// 手机序列号：用于初始化以后不能改变的。phoneSN
    /// 属性
    /// 手机品牌：有限个枚举.PhoneBrand
    /// 手机颜色：有限个枚举.PhoneColour
    /// 手机型号：PhoneModel
    /// 手机内存：PhoneMemory
    /// 手机存储：PhoneStorage
    /// 方法
    /// 拨打电话.Dial
    /// 发送短信.SendTextMessage
    /// 拍照.Photograph
    /// 安装app.
    /// 卸载app
    /// 
    /// </summary>
    public class Phone
    {
        private string phoneSN = string.Empty;
        public Brand PhoneBrand { get; set; }
        public Colour PhoneColour { get; set; }
        //只读属性，在类的内部能够正常访问和赋值。
        public string PhoneModel { get; }
        public int PhoneMemory { get; } = 16;
        public int PhoneStorage { get; } = 512;

        public Phone(string phoneSn, Brand PhoneBrand)
        {
            this.phoneSN = phoneSn;
            this.PhoneBrand = PhoneBrand;
        }
        /// <summary>
        /// 构造方法的重载，可以调用前面的构造方法赋值
        /// 可以给形参默认值，调用时就可以不用传值
        /// </summary>
        /// <param name="phoneSn"></param>
        /// <param name="PhoneBrand"></param>
        /// <param name="PhoneColour"></param>
        /// <param name="PhoneModel"></param>
        /// <param name="PhoneMemory"></param>
        /// <param name="PhoneStorage"></param>
        public Phone(string phoneSn, Brand PhoneBrand,string PhoneModel, int PhoneMemory, int PhoneStorage, Colour PhoneColour = Colour.Black) :this(phoneSn, PhoneBrand)
        {
            this.PhoneColour = PhoneColour;
            this.PhoneModel = PhoneModel;
            this.PhoneMemory = PhoneMemory;
            this.PhoneStorage = PhoneStorage;
        }

        public bool Dial()
        {
            Console.WriteLine($"{phoneSN}拨打电话...");
            Console.WriteLine($"{phoneSN}通话中...");
            Console.WriteLine($"{phoneSN}通话结束...");
            return true;
        }

    }

    public enum Brand
    {
        XiaoMi,
        HuaiWei,
        OPPO,
        ViVo,
        RongYao
    }

    public enum Colour
    {
        Red,
        Green,
        Blue,
        Yellow,
        Black
    }

}
