using ST.Library.UI.NodeEditor;
using System.Threading;
using WinNodeEditorDemo.ImageNode;
using System.Drawing;
using System.Drawing.Imaging;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using System.Windows.Forms;
using NodeEditor.BaseType;
using System.Runtime.Remoting.Messaging;
using System;
using System.Runtime.CompilerServices;

namespace WinNodeEditorDemo
{
    [STNode("Image", "", "", "", "Image Binary Node")]
    public class MyNode : ImageBaseNode
    {
        private STNodeOption my_op_img_in;
        private STNodeOption my_op_img_out;
        private Bitmap bmpBase;
        private BinaryNodePropertyTransporter binaryNodePropertyTransporter = new BinaryNodePropertyTransporter();
        public event EventHandler onPropertyChange;

        //private int _Number=100;
        //[STNodeProperty("Threshold", "this is input number")]
        //public int Number
        //{
        //    get { return _Number; }
        //    set
        //    {
        //        _Number = value;
        //        if (m_img_draw != null) m_img_draw.Dispose();
        //        m_img_draw = BinaryMethod(bmpBase, _Number);
        //        my_op_img_out.TransferData(m_img_draw, true);
        //        this.Invalidate();
        //    }
        //}
        private BinaryNodeBasicType _BinaryNodeType = new BinaryNodeBasicType();
        [STNodeProperty("二值化类型", "选择一种二值化类型：", DescriptorType = typeof(BinaryParamDescriptor))]
        public BinaryNodePropertyTransporter BinaryNodePropertyTransporter
        {
            get
            {
                return binaryNodePropertyTransporter;
            }
            set {
                // 如果当前的值修改过，那么触发重新生成图片操作
                if (!binaryNodePropertyTransporter.Equals(value))
                {
                    //Console.WriteLine("changed:" + value.BinaryTypeIndex);
                    // 如果当前选中的是自动二值化
                    if (value.BinaryTypeIndex == 0)
                    {
                        if (m_img_draw != null) m_img_draw.Dispose();
                        if (bmpBase != null)
                        {
                            m_img_draw = AutoBinaryMethod(bmpBase);
                            my_op_img_out.TransferData(m_img_draw, true);
                        }
                        this.Invalidate();
                    }

                    // 如果当前选中的是硬阈值二值化
                    if (value.BinaryTypeIndex == 1)
                    {
                        if (m_img_draw  != null ) m_img_draw.Dispose();
                        if (bmpBase != null )
                        {
                            Console.WriteLine("value lowThres" + value.ThresBinaryCoreLowThres);
                            Console.WriteLine("value highThres" + value.ThresBinaryCoreHighThres);
                            m_img_draw = ThresBinaryMethod(bmpBase, value.ThresBinaryCoreLowThres, value.ThresBinaryCoreHighThres);
                            my_op_img_out.TransferData(m_img_draw, true);
                        }
                        this.Invalidate();
                    }

                    // 如果当前选中的是高斯二值化
                    if(value.BinaryTypeIndex == 2)
                    {
                        if (m_img_draw != null) m_img_draw.Dispose();
                        if (bmpBase != null)
                        {
                            m_img_draw = GSBinaryMethod(bmpBase,value.GsBinaryCoreSize, value.GsBinaryCoreStd, value.GsBinaryCoreCmpType, value.GsBinaryCoreThresOffset);
                            my_op_img_out.TransferData(m_img_draw, true);
                        }
                        this.Invalidate();
                    }

                    // 如果当前选中的是均值二值化
                    if (value.BinaryTypeIndex == 3)
                    {
                        if (m_img_draw != null) m_img_draw.Dispose();
                        if (bmpBase != null)
                        {
                            m_img_draw = AvgBinaryMethod(bmpBase, value.AverBinaryCoreWidth, value.AverBinaryCoreHeight, value.AverCompareType, value.AverCompareThresOffset);
                            my_op_img_out.TransferData(m_img_draw, true);
                        }
                        this.Invalidate();
                    }
                }
                binaryNodePropertyTransporter = (BinaryNodePropertyTransporter)value.Clone();
            }
        }

        protected override void OnCreate()
        {
           base.OnCreate();
            this.Title = "BinaryNode";
            my_op_img_in = this.InputOptions.Add("", typeof(Image), true);
            my_op_img_out = this.OutputOptions.Add("", typeof(Image), true);

            //当输入节点有数据输入时候
            my_op_img_in.DataTransfer += new STNodeOptionEventHandler(my_op_img_inDataTransfer);

        }
        // 图像二值化操作
        //public static Bitmap BinaryMethod(Bitmap bmp, int threshold)
        //{
        //    // 将 Bitmap 转换为 Mat 对象
        //    Mat mat = BitmapConverter.ToMat(bmp);

        //    // 将图像灰度化
        //    Cv2.CvtColor(mat, mat, ColorConversionCodes.BGR2GRAY);

        //    // 进行二值化处理
        //    Cv2.Threshold(mat, mat, threshold, 255, ThresholdTypes.Binary);

        //    // 将处理后的 Mat 对象转换回 Bitmap
        //    Bitmap processedBitmap = BitmapConverter.ToBitmap(mat);
        //    return processedBitmap;
        //}

        // 自动二值化，这里采用自适应阈值二值化
        // 其中 GaussianC 表示使用高斯加权平均值，35 是邻域块的大小，3 是从邻域块中减去的常数。
        public static Bitmap AutoBinaryMethod(Bitmap bmp)
        {
            Mat mat = BitmapConverter.ToMat(bmp);
            // 转换成灰度图像
            Cv2.CvtColor(mat, mat, ColorConversionCodes.BGR2GRAY);
            Cv2.AdaptiveThreshold(mat, mat, 255, AdaptiveThresholdTypes.GaussianC, ThresholdTypes.Binary, 35, 3);
            Bitmap processedBitmap = BitmapConverter.ToBitmap(mat);
            return processedBitmap;
        }

        // 阈值二值化的方法，参数分别是高阈值和低阈值
        public static Bitmap ThresBinaryMethod(Bitmap bmp, int lowThres, int highThres)
        {
            // 将 Bitmap 转换为 Mat 对象
            Mat mat = BitmapConverter.ToMat(bmp);

            // 将图像灰度化
            Cv2.CvtColor(mat, mat, ColorConversionCodes.BGR2GRAY);

            Console.WriteLine("losThres:" + lowThres);
            Console.WriteLine("highThres:" + highThres);
            // 进行二值化处理
            Cv2.Threshold(mat, mat, lowThres, highThres, ThresholdTypes.Binary);

            // 将处理后的 Mat 对象转换回 Bitmap
            Bitmap processedBitmap = BitmapConverter.ToBitmap(mat);
            return processedBitmap;
        }

        public static Bitmap GSBinaryMethod(Bitmap bmp, int gsCoreSize, double gsStd, ThresholdTypes cmpType, double gsOffset)
        {
            Mat mat = BitmapConverter.ToMat(bmp);
            Cv2.CvtColor(mat, mat, ColorConversionCodes.BGR2GRAY);

            gsCoreSize = (gsCoreSize % 2 == 0) ? gsCoreSize + 1 : gsCoreSize;
            // 高斯核处理
            Cv2.GaussianBlur(mat, mat, new OpenCvSharp.Size(gsCoreSize, gsCoreSize), gsStd);

            Cv2.Threshold(mat, mat, 128 - gsOffset, 255, cmpType);

            Bitmap processedBitMap = BitmapConverter.ToBitmap(mat);

            return processedBitMap;
        }


        public static Bitmap AvgBinaryMethod(Bitmap bmp, int avgCoreWidth, int avgCoreHeight, ThresholdTypes cmpType, double avgOffset)
        {
            Mat mat = BitmapConverter.ToMat(bmp);
            Cv2.CvtColor(mat, mat, ColorConversionCodes.BGR2GRAY);

            Cv2.Blur(mat, mat, new OpenCvSharp.Size(avgCoreWidth, avgCoreHeight));

            Scalar meanValue = Cv2.Mean(mat);

            // 均值二值化
            Cv2.Threshold(mat, mat, meanValue.Val0 + avgOffset, 255, cmpType);

            Bitmap processedBitMap = BitmapConverter.ToBitmap(mat);

            return processedBitMap;
        }

        void my_op_img_inDataTransfer(object sender, STNodeOptionEventArgs e) { 
            if (e.Status != ConnectionStatus.Connected || e.TargetOption.Data == null)
            {
                my_op_img_out.TransferData(null);
                m_img_draw = null;
            } else
            {
                bmpBase = (Bitmap)e.TargetOption.Data;
                // 默认调用自动二值化
                Bitmap processedBitmap = AutoBinaryMethod(bmpBase);
                m_img_draw = processedBitmap;
                my_op_img_out.TransferData(processedBitmap);
            }
        }

        protected override void OnDrawBody(DrawingTools dt)
        {
            base.OnDrawBody(dt);
            Graphics g = dt.Graphics;
            Rectangle rect = new Rectangle(this.Left + 10, this.Top + 30, 120, 80);
            g.FillRectangle(Brushes.Gray, rect);
            if (m_img_draw != null) g.DrawImage(this.m_img_draw, rect);
        }
    }

    public class BinaryParamDescriptor : STNodePropertyDescriptor
    {
        private Rectangle mRectOpenParam;
        private StringFormat m_sf;
        private BinaryNodePropertyTransporter binaryNodePropertyTransporter = new BinaryNodePropertyTransporter();
        public BinaryParamDescriptor() {
            m_sf = new StringFormat();
            m_sf.Alignment = StringAlignment.Center;
            m_sf.LineAlignment = StringAlignment.Center;
        }
        protected override void OnSetItemLocation()
        {
            base.OnSetItemLocation();
            mRectOpenParam = new Rectangle(
                this.RectangleR.Right - 220,
                this.RectangleR.Top,
                220,
                this.RectangleR.Height
                ); 
        }

        protected override void OnDrawValueRectangle(DrawingTools dt)
        {
            base.OnDrawValueRectangle(dt);
            dt.Graphics.FillRectangle(Brushes.Gray, mRectOpenParam);
            dt.Graphics.DrawString("点击选择属性", this.Control.Font, Brushes.White, mRectOpenParam, m_sf);
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {   
            new FrmSTNodePropertyTab(this, binaryNodePropertyTransporter).Show(this.Control); 
            return;
        }
    }
}
