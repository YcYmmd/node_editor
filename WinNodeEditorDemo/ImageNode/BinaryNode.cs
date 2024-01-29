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

namespace WinNodeEditorDemo
{
    [STNode("Image", "", "", "", "Image Binary Node")]
    public class MyNode : ImageBaseNode
    {
        private STNodeOption my_op_img_in;
        private STNodeOption my_op_img_out;
        private Bitmap bmpBase;

        private int _Number=100;
        [STNodeProperty("Threshold", "this is input number")]
        public int Number
        {
            get { return _Number; }
            set
            {
                _Number = value;
                if (m_img_draw != null) m_img_draw.Dispose();
                m_img_draw = BinaryMethod(bmpBase, _Number);
                my_op_img_out.TransferData(m_img_draw, true);
                this.Invalidate();
            }
        }
        private BinaryNodeBasicType _BinaryNodeType = new BinaryNodeBasicType();
        [STNodeProperty("二值化类型", "选择一种二值化类型：", DescriptorType = typeof(BinaryParamDescriptor))]
        public BinaryNodeBasicType BinaryNodeType
        {
            get
            {
                return _BinaryNodeType;
            }
            set { _BinaryNodeType = value; }
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
        public static Bitmap BinaryMethod(Bitmap bmp, int threshold)
        {
            // 将 Bitmap 转换为 Mat 对象
            Mat mat = BitmapConverter.ToMat(bmp);

            // 将图像灰度化
            Cv2.CvtColor(mat, mat, ColorConversionCodes.BGR2GRAY);

            // 进行二值化处理
            Cv2.Threshold(mat, mat, threshold, 255, ThresholdTypes.Binary);

            // 将处理后的 Mat 对象转换回 Bitmap
            Bitmap processedBitmap = BitmapConverter.ToBitmap(mat);
            return processedBitmap;
        }

        void my_op_img_inDataTransfer(object sender, STNodeOptionEventArgs e) { 
            if (e.Status != ConnectionStatus.Connected || e.TargetOption.Data == null)
            {
                my_op_img_out.TransferData(null);
                m_img_draw = null;
            } else
            {
                bmpBase = (Bitmap)e.TargetOption.Data;
                Bitmap processedBitmap = BinaryMethod(bmpBase, _Number);
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
    }
}
