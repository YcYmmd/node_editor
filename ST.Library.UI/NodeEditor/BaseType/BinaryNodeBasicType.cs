using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NodeEditor.BaseType
{
    public class BinaryNodeBasicType
    {
        // 用于保存二值化类型
        private int binaryType = 0;

        // 硬阈值二值化的参数
        private int hardThresLowThresHold = 128;
        private int hardThresHighThresHold = 255;

        // 高斯二值化的参数
        private int gsCoreSize = 3;
        private double gsSD = 1.00;
        private int gsCompareType = 0;
        private int gsThresOffset = 0;

        // 均值二值化的参数
        private int averCoreWidth = 3;
        private int averCoreHeigth = 3;
        private int averCompareType = 0;
        private int averThresOffset = 0;

        
        
        private string _value;
        public BinaryNodeBasicType() {
            this._value = "";
        }

        public BinaryNodeBasicType(string value) {
            this._value = value;
        }

        public string Value
        {
           get { 
                return _value; 
            }  
           set { 
                this._value = value;
            }
        }

        public int BinaryType { get => binaryType; set => binaryType = value; }
        public int HardThresLowThresHold { get => hardThresLowThresHold; set => hardThresLowThresHold = value; }
        public int HardThresHighThresHold { get => hardThresHighThresHold; set => hardThresHighThresHold = value; }
        public int GsCoreSize { get => gsCoreSize; set => gsCoreSize = value; }
        public double GsSD { get => gsSD; set => gsSD = value; }
        public int GsCompareType { get => gsCompareType; set => gsCompareType = value; }
        public int GsThresOffset { get => gsThresOffset; set => gsThresOffset = value; }
        public int AverCoreWidth { get => averCoreWidth; set => averCoreWidth = value; }
        public int AverCoreHeigth { get => averCoreHeigth; set => averCoreHeigth = value; }
        public int AverCompareType { get => averCompareType; set => averCompareType = value; }
        public int AverThresOffset { get => averThresOffset; set => averThresOffset = value; }

        public override string ToString()
        {
            if (_value == null)
            {
                return "";
            }
            return _value.ToString();
        }
    }
}
