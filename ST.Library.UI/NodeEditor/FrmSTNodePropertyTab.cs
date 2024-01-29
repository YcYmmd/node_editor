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

        public FrmSTNodePropertyTab(STNodePropertyDescriptor descriptor)
        {
            m_descriptor = descriptor;
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            // 获取在控件内描述符的左上角在屏幕上的位置
            Point pt = m_descriptor.Control.PointToScreen(m_descriptor.RectangleR.Location);

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
            this.autoBinaryPanel.Location = new Point(20, 110);

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
                    this.autoBinaryPanel.Location = new Point(20, 110);
                    break;
                case 1:
                    this.autoBinaryPanel.Visible = false;
                    this.hardThresBinaryPanel.Visible = true;
                    this.gsBinaryPanel.Visible = false;
                    this.averBinaryPanel.Visible = false;
                    this.hardThresBinaryPanel.Location = new Point(20, 110);
                    break;
                case 2:
                    this.autoBinaryPanel.Visible = false;
                    this.hardThresBinaryPanel.Visible = false;
                    this.gsBinaryPanel.Visible = true;
                    this.averBinaryPanel.Visible = false;
                    this.gsBinaryPanel.Location = new Point(20, 110);
                    
                    break;
                case 3:
                    this.autoBinaryPanel.Visible = false;
                    this.hardThresBinaryPanel.Visible = false; 
                    this.gsBinaryPanel.Visible = false;
                    this.averBinaryPanel.Visible = true;
                    this.averBinaryPanel.Location = new Point(20, 110);
                    break;
                default:
                    this.autoBinaryPanel.Visible = true;
                    this.hardThresBinaryPanel.Visible = false;
                    this.gsBinaryPanel.Visible = false;
                    this.averBinaryPanel.Visible = false;
                    this.autoBinaryPanel.Location = new Point(20, 110);
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
    }
}
