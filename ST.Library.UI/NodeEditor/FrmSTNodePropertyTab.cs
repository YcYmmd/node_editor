using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ST.Library.UI.NodeEditor
{
    public partial class FrmSTNodePropertyTab : Form
    {
        private STNodePropertyDescriptor m_descriptor;
        // 用于保存当前panel的显示状态，默认显示自动二值化
        private bool[] paramPagePanelCurrent = new bool[4] { true, false, false, false};
        private BinaryNodePropertyTransporter binaryNodePropertyTransporter;

        public FrmSTNodePropertyTab(STNodePropertyDescriptor descriptor, BinaryNodePropertyTransporter binaryNodePropertyTransporter)
        {
            m_descriptor = descriptor;
            this.binaryNodePropertyTransporter = binaryNodePropertyTransporter;
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            // 获取在控件内描述符的左上角在屏幕上的位置
            System.Drawing.Point pt = m_descriptor.Control.PointToScreen(m_descriptor.RectangleR.Location);

            // 考虑控件的滚动偏移
            pt.Y += m_descriptor.Control.ScrollOffset;

            // 设置弹出窗口的位置为描述符在屏幕上的位置
            int leftShiftAmount = 70; // 设置左移的距离
            int upShiftAmount = 5;
            pt.X -= leftShiftAmount;
            pt.Y -= upShiftAmount;
            this.Location = pt;

            // 初始化panel的位置
            this.autoBinaryPanel.Visible = true;
            this.averBinaryPanel.Visible = false;
            this.gsBinaryPanel.Visible = false;
            this.hardThresBinaryPanel.Visible = false;
            this.autoBinaryPanel.Location = new System.Drawing.Point(20, 110);

            // 设置初始值，根据传过来的binaryNodePropertyTransporter的值进行传输
            this.comboBox1.SelectedIndex = this.binaryNodePropertyTransporter.BinaryTypeIndex;
            // 设置阈值二值化的文本框初始值
            this.lowThresTextBox.Text = this.binaryNodePropertyTransporter.ThresBinaryCoreLowThres.ToString();
            this.highThresTextBox.Text = this.binaryNodePropertyTransporter.ThresBinaryCoreHighThres.ToString();

            // 设置高斯二值化的文本框，下拉框初始值
            this.gsBinaryCoreSizeBox.Text = this.binaryNodePropertyTransporter.GsBinaryCoreSize.ToString(); 
            this.gsBinaryCoreStdBox.Text = this.binaryNodePropertyTransporter.GsBinaryCoreStd.ToString();
            this.gsBinaryCoreCmpTypeBox.SelectedIndex = getIndex(this.binaryNodePropertyTransporter.GsBinaryCoreCmpType);
            this.gsBinaryCoreThresOffsetBox.Text = this.binaryNodePropertyTransporter.GsBinaryCoreThresOffset.ToString();

            // 设置均值二值化的文本框，下拉框初始值
            this.averBinaryCoreWidthBox.Text = this.binaryNodePropertyTransporter.AverBinaryCoreWidth.ToString();
            this.averBinaryCoreHigthBox.Text = this.binaryNodePropertyTransporter.AverBinaryCoreHeight.ToString();
            this.avgCmpTypeBox.SelectedIndex = getIndex(this.binaryNodePropertyTransporter.AverCompareType);
            this.avgBinaryCoreThresOffsetBox.Text = this.binaryNodePropertyTransporter.AverCompareThresOffset.ToString();
        }

        private int getIndex(ThresholdTypes thresholdType)
        {
            if (thresholdType.Equals(ThresholdTypes.Binary))
            {
                return 0;
            } else if (thresholdType.Equals(ThresholdTypes.BinaryInv))
            {
                return 1;
            } else if (thresholdType.Equals(ThresholdTypes.Tozero))
            {
                return 2;
            } else
            {
                return 3;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    this.autoBinaryPanel.Visible = true;
                    this.hardThresBinaryPanel.Visible = false;
                    this.gsBinaryPanel.Visible = false;
                    this.averBinaryPanel.Visible = false;
                    this.autoBinaryPanel.Location = new System.Drawing.Point(20, 110);
                    this.binaryNodePropertyTransporter.BinaryTypeIndex = 0;
                    m_descriptor.SetValue(binaryNodePropertyTransporter);
                    break;
                case 1:
                    this.autoBinaryPanel.Visible = false;
                    this.hardThresBinaryPanel.Visible = true;
                    this.gsBinaryPanel.Visible = false;
                    this.averBinaryPanel.Visible = false;
                    this.hardThresBinaryPanel.Location = new System.Drawing.Point(20, 110);
                    this.binaryNodePropertyTransporter.BinaryTypeIndex = 1;
                    m_descriptor.SetValue(binaryNodePropertyTransporter);
                    break;
                case 2:
                    this.autoBinaryPanel.Visible = false;
                    this.hardThresBinaryPanel.Visible = false;
                    this.gsBinaryPanel.Visible = true;
                    this.averBinaryPanel.Visible = false;
                    this.gsBinaryPanel.Location = new System.Drawing.Point(20, 110);
                    this.binaryNodePropertyTransporter.BinaryTypeIndex = 2;
                    m_descriptor.SetValue(binaryNodePropertyTransporter);
                    break;
                case 3:
                    this.autoBinaryPanel.Visible = false;
                    this.hardThresBinaryPanel.Visible = false; 
                    this.gsBinaryPanel.Visible = false;
                    this.averBinaryPanel.Visible = true;
                    this.averBinaryPanel.Location = new System.Drawing.Point(20, 110);
                    this.binaryNodePropertyTransporter.BinaryTypeIndex = 3;
                    m_descriptor.SetValue(binaryNodePropertyTransporter);
                    break;
                default:
                    this.autoBinaryPanel.Visible = true;
                    this.hardThresBinaryPanel.Visible = false;
                    this.gsBinaryPanel.Visible = false;
                    this.averBinaryPanel.Visible = false;
                    this.autoBinaryPanel.Location = new System.Drawing.Point(20, 110);
                    this.binaryNodePropertyTransporter.BinaryTypeIndex = 0;
                    break;
            }
            // 保存当前显示状态
            paramPagePanelCurrent[0] = this.autoBinaryPanel.Visible;
            paramPagePanelCurrent[1] = this.hardThresBinaryPanel.Visible;
            paramPagePanelCurrent[2] = this.gsBinaryPanel.Visible;
            paramPagePanelCurrent[3] = this.averBinaryPanel.Visible;
        }


        private void materialTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.materialTabControl1.SelectedIndex;
            // 如果切换回参数页
            if (index == 0)
            {
                // 读取之前保存的显示状态
                this.autoBinaryPanel.Visible = paramPagePanelCurrent[0];
                this.hardThresBinaryPanel.Visible = paramPagePanelCurrent[1];
                this.gsBinaryPanel.Visible = paramPagePanelCurrent[2];
                this.averBinaryPanel.Visible = paramPagePanelCurrent[3];
            } else
            {
                // 如果是其它选项卡，那么关于参数的panel直接全部不显示
                this.autoBinaryPanel.Visible = false;
                this.hardThresBinaryPanel.Visible = false;
                this.gsBinaryPanel.Visible = false;
                this.averBinaryPanel.Visible = false;
            }

        }

        private void FrmSTNodePropertyTab_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }

        // 阈值二值化的参数发生变化，触发修改
        private void lowThresTextChanged(object sender, EventArgs e)
        {
            if (this.lowThresTextBox.Text != "")
            {
                binaryNodePropertyTransporter.ThresBinaryCoreLowThres = int.Parse(this.lowThresTextBox.Text);
                m_descriptor.SetValue(binaryNodePropertyTransporter);
            }
        }

        private void highThresTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.highThresTextBox.Text != "")
            {
                binaryNodePropertyTransporter.ThresBinaryCoreHighThres = int.Parse(this.highThresTextBox.Text);
                m_descriptor.SetValue(binaryNodePropertyTransporter);
            }
        }

        // 高斯二值化的参数发生变化，触发修改
        private void gsBinaryCoreSizeBox_TextChanged(object sender, EventArgs e)
        {
            if (this.gsBinaryCoreSizeBox.Text != "")
            {
                binaryNodePropertyTransporter.GsBinaryCoreSize = int.Parse(this.gsBinaryCoreSizeBox.Text);
                m_descriptor.SetValue(binaryNodePropertyTransporter);
            }
        }

        private void gsBinaryCoreStdBox_TextChanged(object sender, EventArgs e)
        {
            if (this.gsBinaryCoreStdBox.Text != "")
            {
                binaryNodePropertyTransporter.GsBinaryCoreStd = double.Parse(this.gsBinaryCoreStdBox.Text);
                m_descriptor.SetValue(binaryNodePropertyTransporter);
            }
        }

        private void gsBinaryCoreCmpTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.gsBinaryCoreCmpTypeBox.SelectedIndex;
            ThresholdTypes cmpType = new ThresholdTypes();
            if (index == 0)
            {
                cmpType = ThresholdTypes.Binary;
            }
            else if (index == 1)
            {
                cmpType= ThresholdTypes.BinaryInv;
            }
            else if (index == 2)
            {
                cmpType = ThresholdTypes.Tozero;
            } else
            {
                cmpType = ThresholdTypes.TozeroInv;
            }
            binaryNodePropertyTransporter.GsBinaryCoreCmpType = cmpType;
            m_descriptor.SetValue(binaryNodePropertyTransporter);
        }

        private void gsBinaryCoreThresOffsetBox_TextChanged(object sender, EventArgs e)
        {
            if (this.gsBinaryCoreThresOffsetBox.Text != "")
            {
                binaryNodePropertyTransporter.GsBinaryCoreThresOffset = double.Parse(this.gsBinaryCoreThresOffsetBox.Text);
                m_descriptor.SetValue(binaryNodePropertyTransporter);
            }
        }


        // 只能输入数字
        private void lowThresTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')//这是允许输入退格键
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))//这是允许输入0-9数字
                {
                    e.Handled = true;
                }
            }
        }
        // 只能输入数字和使用退格键
        private void highThresTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')//这是允许输入退格键
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))//这是允许输入0-9数字
                {
                    e.Handled = true;
                }
            }
        }

        // 高斯二值化输入框格式控制
        private void gsBinaryCoreSizeBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')//这是允许输入退格键
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))//这是允许输入0-9数字
                {
                    e.Handled = true;
                }
            }
        }

        private void gsBinaryCoreStdBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 允许退格键
            if (e.KeyChar == '\b')
            {
                return;
            }

            // 检查输入字符是否是数字或小数点
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                // 非数字或小数点字符，阻止输入
                e.Handled = true;
            }

            // 验证小数点的位置
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                // 已经存在一个小数点，阻止输入
                e.Handled = true;
            }
        }

        private void gsBinaryCoreThresOffsetBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 允许退格键
            if (e.KeyChar == '\b')
            {
                return;
            }

            // 检查输入字符是否是数字或小数点
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                // 非数字或小数点字符，阻止输入
                e.Handled = true;
            }

            // 验证小数点的位置
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                // 已经存在一个小数点，阻止输入
                e.Handled = true;
            }
        }

        // 均值二值化的相关参数
        private void averBinaryCoreWidthBox_TextChanged(object sender, EventArgs e)
        {
            if (this.averBinaryCoreWidthBox.Text != "")
            {
                this.binaryNodePropertyTransporter.AverBinaryCoreWidth = int.Parse(this.averBinaryCoreWidthBox.Text);
                m_descriptor.SetValue(binaryNodePropertyTransporter);
            }
        }

        private void averBinaryCoreHigthBox_TextChanged(object sender, EventArgs e)
        {
            if (this.averBinaryCoreHigthBox.Text != "")
            {
                this.binaryNodePropertyTransporter.AverBinaryCoreHeight = int.Parse(this.averBinaryCoreHigthBox.Text);
                m_descriptor.SetValue(binaryNodePropertyTransporter);
            }
        }

        private void avgCmpBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.avgCmpTypeBox.SelectedIndex;
            ThresholdTypes cmpType = new ThresholdTypes();
            if (index == 0)
            {
                cmpType = ThresholdTypes.Binary;
            }
            else if (index == 1)
            {
                cmpType = ThresholdTypes.BinaryInv;
            }
            else if (index == 2)
            {
                cmpType = ThresholdTypes.Tozero;
            }
            else
            {
                cmpType = ThresholdTypes.TozeroInv;
            }
            binaryNodePropertyTransporter.AverCompareType = cmpType;
            m_descriptor.SetValue(binaryNodePropertyTransporter);
        }

        private void avgBinaryCoreThresOffsetBox_TextChanged(object sender, EventArgs e)
        {
            if (this.avgBinaryCoreThresOffsetBox.Text != "")
            {
                this.binaryNodePropertyTransporter.AverCompareThresOffset = double.Parse(this.avgBinaryCoreThresOffsetBox.Text);
                m_descriptor.SetValue(binaryNodePropertyTransporter);
            }
        }

        private void averBinaryCoreWidthBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')//这是允许输入退格键
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))//这是允许输入0-9数字
                {
                    e.Handled = true;
                }
            }
        }

        private void averBinaryCoreHigthBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')//这是允许输入退格键
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))//这是允许输入0-9数字
                {
                    e.Handled = true;
                }
            }
        }

        private void avgBinaryCoreThresOffsetBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 允许退格键
            if (e.KeyChar == '\b')
            {
                return;
            }

            // 检查输入字符是否是数字或小数点
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                // 非数字或小数点字符，阻止输入
                e.Handled = true;
            }

            // 验证小数点的位置
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                // 已经存在一个小数点，阻止输入
                e.Handled = true;
            }
        }
    }
}
