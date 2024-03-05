using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST.Library.UI.NodeEditor
{
    // 用于记录当前二值化的类型及各个类型的参数，提前给默认值
    public class BinaryNodePropertyTransporter: ICloneable
    {
        private int binaryTypeIndex = 0;
        private int averBinaryCoreWidth = 3;
        private int averBinaryCoreHeight = 3;
        private ThresholdTypes averCompareType = ThresholdTypes.Binary;
        private double averCompareThresOffset = 0.0;
        private int gsBinaryCoreSize = 3;
        private double gsBinaryCoreStd = 1.0;
        private ThresholdTypes gsBinaryCoreCmpType = ThresholdTypes.Binary;
        private double gsBinaryCoreThresOffset = 0.0;
        private int thresBinaryCoreLowThres =100;
        private int thresBinaryCoreHighThres = 200;

        public int BinaryTypeIndex { get => binaryTypeIndex; set => binaryTypeIndex = value; }
        public int AverBinaryCoreWidth { get => averBinaryCoreWidth; set => averBinaryCoreWidth = value; }
        public int AverBinaryCoreHeight { get => averBinaryCoreHeight; set => averBinaryCoreHeight = value; }
        public ThresholdTypes AverCompareType { get => averCompareType; set => averCompareType = value; }
        public double AverCompareThresOffset { get => averCompareThresOffset; set => averCompareThresOffset = value; }
        public int GsBinaryCoreSize { get => gsBinaryCoreSize; set => gsBinaryCoreSize = value; }
        public double GsBinaryCoreStd { get => gsBinaryCoreStd; set => gsBinaryCoreStd = value; }
        public ThresholdTypes GsBinaryCoreCmpType { get => gsBinaryCoreCmpType; set => gsBinaryCoreCmpType = value; }
        public double GsBinaryCoreThresOffset { get => gsBinaryCoreThresOffset; set => gsBinaryCoreThresOffset = value; }
        public int ThresBinaryCoreLowThres { get => thresBinaryCoreLowThres; set => thresBinaryCoreLowThres = value; }
        public int ThresBinaryCoreHighThres { get => thresBinaryCoreHighThres; set => thresBinaryCoreHighThres = value; }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            BinaryNodePropertyTransporter other = (BinaryNodePropertyTransporter)obj;

            // 比较所有属性，只要有一个属性不相等，就返回false
            return BinaryTypeIndex == other.BinaryTypeIndex &&
                   AverBinaryCoreWidth == other.AverBinaryCoreWidth &&
                   AverBinaryCoreHeight == other.AverBinaryCoreHeight &&
                   AverCompareType == other.AverCompareType &&
                   AverCompareThresOffset == other.AverCompareThresOffset &&
                   GsBinaryCoreSize == other.GsBinaryCoreSize &&
                   GsBinaryCoreStd == other.GsBinaryCoreStd &&
                   GsBinaryCoreCmpType == other.GsBinaryCoreCmpType &&
                   GsBinaryCoreThresOffset == other.GsBinaryCoreThresOffset &&
                   ThresBinaryCoreLowThres == other.ThresBinaryCoreLowThres &&
                   ThresBinaryCoreHighThres == other.ThresBinaryCoreHighThres;
        }

        public override int GetHashCode()
        {
            // 如果重写了Equals方法，也应该重写GetHashCode方法
            // 确保相等的对象具有相同的哈希码
            int hashCode = 17;

            hashCode = hashCode * 23 + BinaryTypeIndex.GetHashCode();
            hashCode = hashCode * 23 + AverBinaryCoreWidth.GetHashCode();
            hashCode = hashCode * 23 + AverBinaryCoreHeight.GetHashCode();
            hashCode = hashCode * 23 + AverCompareType.GetHashCode();
            hashCode = hashCode * 23 + AverCompareThresOffset.GetHashCode();
            hashCode = hashCode * 23 + GsBinaryCoreSize.GetHashCode();
            hashCode = hashCode * 23 + GsBinaryCoreStd.GetHashCode();
            hashCode = hashCode * 23 + GsBinaryCoreCmpType.GetHashCode();
            hashCode = hashCode * 23 + GsBinaryCoreThresOffset.GetHashCode();
            hashCode = hashCode * 23 + ThresBinaryCoreLowThres.GetHashCode();
            hashCode = hashCode * 23 + ThresBinaryCoreHighThres.GetHashCode();

            return hashCode;
        }

        public object Clone()
        {
            BinaryNodePropertyTransporter clone = new BinaryNodePropertyTransporter();
            clone.BinaryTypeIndex = this.BinaryTypeIndex;
            clone.AverBinaryCoreWidth = this.AverBinaryCoreWidth;
            clone.AverBinaryCoreHeight = this.AverBinaryCoreHeight;
            clone.AverCompareType = this.AverCompareType;
            clone.AverCompareThresOffset = this.AverCompareThresOffset;
            clone.GsBinaryCoreSize = this.GsBinaryCoreSize;
            clone.GsBinaryCoreStd = this.GsBinaryCoreStd;
            clone.GsBinaryCoreCmpType = this.GsBinaryCoreCmpType;
            clone.GsBinaryCoreThresOffset = this.GsBinaryCoreThresOffset;
            clone.ThresBinaryCoreLowThres = this.ThresBinaryCoreLowThres;
            clone.ThresBinaryCoreHighThres = this.ThresBinaryCoreHighThres;

            return clone;
        }
    }
}
