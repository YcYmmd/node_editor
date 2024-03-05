using System.Drawing.Drawing2D;
using System.Drawing;
using ST.Library.UI.NodeEditor.BaseComponent;
using System.Windows.Forms;

namespace ST.Library.UI.NodeEditor
{
    partial class FrmSTNodePropertyTab
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxContextMenuStrip1 = new MaterialSkin.Controls.TextBoxContextMenuStrip();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.autoBinaryPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.hardThresBinaryPanel = new System.Windows.Forms.Panel();
            this.highThresTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lowThresTextBox = new System.Windows.Forms.TextBox();
            this.averBinaryPanel = new System.Windows.Forms.Panel();
            this.avgCmpTypeBox = new System.Windows.Forms.ComboBox();
            this.avgBinaryCoreThresOffsetBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.averBinaryCoreHigthBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.averBinaryCoreWidthBox = new System.Windows.Forms.TextBox();
            this.gsBinaryPanel = new System.Windows.Forms.Panel();
            this.gsBinaryCoreCmpTypeBox = new System.Windows.Forms.ComboBox();
            this.gsBinaryCoreThresOffsetBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gsBinaryCoreStdBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.gsBinaryCoreSizeBox = new System.Windows.Forms.TextBox();
            this.materialTabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.autoBinaryPanel.SuspendLayout();
            this.hardThresBinaryPanel.SuspendLayout();
            this.averBinaryPanel.SuspendLayout();
            this.gsBinaryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxContextMenuStrip1
            // 
            this.textBoxContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBoxContextMenuStrip1.Depth = 0;
            this.textBoxContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.textBoxContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxContextMenuStrip1.Name = "textBoxContextMenuStrip1";
            this.textBoxContextMenuStrip1.Size = new System.Drawing.Size(160, 170);
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.FirstTabPadding = 10;
            this.materialTabSelector1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector1.Location = new System.Drawing.Point(-9, 2);
            this.materialTabSelector1.Margin = new System.Windows.Forms.Padding(4);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(428, 44);
            this.materialTabSelector1.TabHeaderPadding = 10;
            this.materialTabSelector1.TabIndex = 2;
            this.materialTabSelector1.TabWidthMax = 80;
            this.materialTabSelector1.TabWidthMin = 40;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(4, 54);
            this.materialTabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(415, 488);
            this.materialTabControl1.TabIndex = 3;
            this.materialTabControl1.SelectedIndexChanged += new System.EventHandler(this.materialTabControl1_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.autoBinaryPanel);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(407, 456);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "运行参数";
            // 
            // autoBinaryPanel
            // 
            this.autoBinaryPanel.Controls.Add(this.label2);
            this.autoBinaryPanel.Location = new System.Drawing.Point(22, 99);
            this.autoBinaryPanel.Margin = new System.Windows.Forms.Padding(4);
            this.autoBinaryPanel.Name = "autoBinaryPanel";
            this.autoBinaryPanel.Size = new System.Drawing.Size(339, 342);
            this.autoBinaryPanel.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("苹方-简", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(52, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 100);
            this.label2.TabIndex = 0;
            this.label2.Text = "自动二值化，\r\n无需设置参数\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("苹方-简", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(9, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "运行参数";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "自动",
            "硬阈值二值化",
            "高斯二值化",
            "均值二值化"});
            this.comboBox1.Location = new System.Drawing.Point(48, 60);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(270, 26);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(407, 456);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "结果显示";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(407, 456);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "基本参数";
            // 
            // hardThresBinaryPanel
            // 
            this.hardThresBinaryPanel.BackColor = System.Drawing.Color.Transparent;
            this.hardThresBinaryPanel.Controls.Add(this.highThresTextBox);
            this.hardThresBinaryPanel.Controls.Add(this.label4);
            this.hardThresBinaryPanel.Controls.Add(this.label3);
            this.hardThresBinaryPanel.Controls.Add(this.lowThresTextBox);
            this.hardThresBinaryPanel.Location = new System.Drawing.Point(570, 494);
            this.hardThresBinaryPanel.Margin = new System.Windows.Forms.Padding(4);
            this.hardThresBinaryPanel.Name = "hardThresBinaryPanel";
            this.hardThresBinaryPanel.Size = new System.Drawing.Size(339, 346);
            this.hardThresBinaryPanel.TabIndex = 3;
            // 
            // highThresTextBox
            // 
            this.highThresTextBox.Location = new System.Drawing.Point(88, 111);
            this.highThresTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.highThresTextBox.Name = "highThresTextBox";
            this.highThresTextBox.Size = new System.Drawing.Size(212, 28);
            this.highThresTextBox.TabIndex = 3;
            this.highThresTextBox.TextChanged += new System.EventHandler(this.highThresTextBox_TextChanged);
            this.highThresTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.highThresTextBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 116);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "高阈值";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "低阈值";
            // 
            // lowThresTextBox
            // 
            this.lowThresTextBox.Location = new System.Drawing.Point(88, 44);
            this.lowThresTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.lowThresTextBox.Name = "lowThresTextBox";
            this.lowThresTextBox.Size = new System.Drawing.Size(212, 28);
            this.lowThresTextBox.TabIndex = 0;
            this.lowThresTextBox.TextChanged += new System.EventHandler(this.lowThresTextChanged);
            this.lowThresTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lowThresTextBox_KeyPress);
            // 
            // averBinaryPanel
            // 
            this.averBinaryPanel.BackColor = System.Drawing.Color.Transparent;
            this.averBinaryPanel.Controls.Add(this.avgCmpTypeBox);
            this.averBinaryPanel.Controls.Add(this.avgBinaryCoreThresOffsetBox);
            this.averBinaryPanel.Controls.Add(this.label8);
            this.averBinaryPanel.Controls.Add(this.label7);
            this.averBinaryPanel.Controls.Add(this.averBinaryCoreHigthBox);
            this.averBinaryPanel.Controls.Add(this.label5);
            this.averBinaryPanel.Controls.Add(this.label6);
            this.averBinaryPanel.Controls.Add(this.averBinaryCoreWidthBox);
            this.averBinaryPanel.Location = new System.Drawing.Point(15, 552);
            this.averBinaryPanel.Margin = new System.Windows.Forms.Padding(4);
            this.averBinaryPanel.Name = "averBinaryPanel";
            this.averBinaryPanel.Size = new System.Drawing.Size(339, 346);
            this.averBinaryPanel.TabIndex = 4;
            // 
            // avgCmpTypeBox
            // 
            this.avgCmpTypeBox.FormattingEnabled = true;
            this.avgCmpTypeBox.Items.AddRange(new object[] {
            "大于等于",
            "小于等于",
            "等于",
            "不等于"});
            this.avgCmpTypeBox.Location = new System.Drawing.Point(102, 192);
            this.avgCmpTypeBox.Margin = new System.Windows.Forms.Padding(4);
            this.avgCmpTypeBox.Name = "avgCmpTypeBox";
            this.avgCmpTypeBox.Size = new System.Drawing.Size(212, 26);
            this.avgCmpTypeBox.TabIndex = 8;
            this.avgCmpTypeBox.SelectedIndexChanged += new System.EventHandler(this.avgCmpBox_SelectedIndexChanged);
            // 
            // avgBinaryCoreThresOffsetBox
            // 
            this.avgBinaryCoreThresOffsetBox.Location = new System.Drawing.Point(102, 256);
            this.avgBinaryCoreThresOffsetBox.Margin = new System.Windows.Forms.Padding(4);
            this.avgBinaryCoreThresOffsetBox.Name = "avgBinaryCoreThresOffsetBox";
            this.avgBinaryCoreThresOffsetBox.Size = new System.Drawing.Size(212, 28);
            this.avgBinaryCoreThresOffsetBox.TabIndex = 7;
            this.avgBinaryCoreThresOffsetBox.TextChanged += new System.EventHandler(this.avgBinaryCoreThresOffsetBox_TextChanged);
            this.avgBinaryCoreThresOffsetBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.avgBinaryCoreThresOffsetBox_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 261);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 18);
            this.label8.TabIndex = 6;
            this.label8.Text = "阈值偏移量";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 196);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 18);
            this.label7.TabIndex = 4;
            this.label7.Text = "比较类型";
            // 
            // averBinaryCoreHigthBox
            // 
            this.averBinaryCoreHigthBox.Location = new System.Drawing.Point(102, 111);
            this.averBinaryCoreHigthBox.Margin = new System.Windows.Forms.Padding(4);
            this.averBinaryCoreHigthBox.Name = "averBinaryCoreHigthBox";
            this.averBinaryCoreHigthBox.Size = new System.Drawing.Size(212, 28);
            this.averBinaryCoreHigthBox.TabIndex = 3;
            this.averBinaryCoreHigthBox.TextChanged += new System.EventHandler(this.averBinaryCoreHigthBox_TextChanged);
            this.averBinaryCoreHigthBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.averBinaryCoreHigthBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 116);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "滤波盒高度";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 48);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "滤波核宽度";
            // 
            // averBinaryCoreWidthBox
            // 
            this.averBinaryCoreWidthBox.Location = new System.Drawing.Point(102, 44);
            this.averBinaryCoreWidthBox.Margin = new System.Windows.Forms.Padding(4);
            this.averBinaryCoreWidthBox.Name = "averBinaryCoreWidthBox";
            this.averBinaryCoreWidthBox.Size = new System.Drawing.Size(212, 28);
            this.averBinaryCoreWidthBox.TabIndex = 0;
            this.averBinaryCoreWidthBox.TextChanged += new System.EventHandler(this.averBinaryCoreWidthBox_TextChanged);
            this.averBinaryCoreWidthBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.averBinaryCoreWidthBox_KeyPress);
            // 
            // gsBinaryPanel
            // 
            this.gsBinaryPanel.BackColor = System.Drawing.Color.Transparent;
            this.gsBinaryPanel.Controls.Add(this.gsBinaryCoreCmpTypeBox);
            this.gsBinaryPanel.Controls.Add(this.gsBinaryCoreThresOffsetBox);
            this.gsBinaryPanel.Controls.Add(this.label9);
            this.gsBinaryPanel.Controls.Add(this.label10);
            this.gsBinaryPanel.Controls.Add(this.gsBinaryCoreStdBox);
            this.gsBinaryPanel.Controls.Add(this.label11);
            this.gsBinaryPanel.Controls.Add(this.label12);
            this.gsBinaryPanel.Controls.Add(this.gsBinaryCoreSizeBox);
            this.gsBinaryPanel.Location = new System.Drawing.Point(555, 92);
            this.gsBinaryPanel.Margin = new System.Windows.Forms.Padding(4);
            this.gsBinaryPanel.Name = "gsBinaryPanel";
            this.gsBinaryPanel.Size = new System.Drawing.Size(342, 342);
            this.gsBinaryPanel.TabIndex = 9;
            // 
            // gsBinaryCoreCmpTypeBox
            // 
            this.gsBinaryCoreCmpTypeBox.FormattingEnabled = true;
            this.gsBinaryCoreCmpTypeBox.Items.AddRange(new object[] {
            "大于等于",
            "小于等于",
            "等于",
            "不等于"});
            this.gsBinaryCoreCmpTypeBox.Location = new System.Drawing.Point(102, 192);
            this.gsBinaryCoreCmpTypeBox.Margin = new System.Windows.Forms.Padding(4);
            this.gsBinaryCoreCmpTypeBox.Name = "gsBinaryCoreCmpTypeBox";
            this.gsBinaryCoreCmpTypeBox.Size = new System.Drawing.Size(212, 26);
            this.gsBinaryCoreCmpTypeBox.TabIndex = 8;
            this.gsBinaryCoreCmpTypeBox.SelectedIndexChanged += new System.EventHandler(this.gsBinaryCoreCmpTypeBox_SelectedIndexChanged);
            // 
            // gsBinaryCoreThresOffsetBox
            // 
            this.gsBinaryCoreThresOffsetBox.Location = new System.Drawing.Point(102, 256);
            this.gsBinaryCoreThresOffsetBox.Margin = new System.Windows.Forms.Padding(4);
            this.gsBinaryCoreThresOffsetBox.Name = "gsBinaryCoreThresOffsetBox";
            this.gsBinaryCoreThresOffsetBox.Size = new System.Drawing.Size(212, 28);
            this.gsBinaryCoreThresOffsetBox.TabIndex = 7;
            this.gsBinaryCoreThresOffsetBox.TextChanged += new System.EventHandler(this.gsBinaryCoreThresOffsetBox_TextChanged);
            this.gsBinaryCoreThresOffsetBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gsBinaryCoreThresOffsetBox_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 261);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 18);
            this.label9.TabIndex = 6;
            this.label9.Text = "阈值偏移量";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 196);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 18);
            this.label10.TabIndex = 4;
            this.label10.Text = "比较类型";
            // 
            // gsBinaryCoreStdBox
            // 
            this.gsBinaryCoreStdBox.Location = new System.Drawing.Point(102, 111);
            this.gsBinaryCoreStdBox.Margin = new System.Windows.Forms.Padding(4);
            this.gsBinaryCoreStdBox.Name = "gsBinaryCoreStdBox";
            this.gsBinaryCoreStdBox.Size = new System.Drawing.Size(212, 28);
            this.gsBinaryCoreStdBox.TabIndex = 3;
            this.gsBinaryCoreStdBox.TextChanged += new System.EventHandler(this.gsBinaryCoreStdBox_TextChanged);
            this.gsBinaryCoreStdBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gsBinaryCoreStdBox_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 116);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 18);
            this.label11.TabIndex = 2;
            this.label11.Text = "高斯标准差";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 48);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 18);
            this.label12.TabIndex = 1;
            this.label12.Text = "高斯滤波核";
            // 
            // gsBinaryCoreSizeBox
            // 
            this.gsBinaryCoreSizeBox.Location = new System.Drawing.Point(102, 44);
            this.gsBinaryCoreSizeBox.Margin = new System.Windows.Forms.Padding(4);
            this.gsBinaryCoreSizeBox.Name = "gsBinaryCoreSizeBox";
            this.gsBinaryCoreSizeBox.Size = new System.Drawing.Size(212, 28);
            this.gsBinaryCoreSizeBox.TabIndex = 0;
            this.gsBinaryCoreSizeBox.TextChanged += new System.EventHandler(this.gsBinaryCoreSizeBox_TextChanged);
            this.gsBinaryCoreSizeBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gsBinaryCoreSizeBox_KeyPress);
            // 
            // FrmSTNodePropertyTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(421, 548);
            this.ControlBox = false;
            this.Controls.Add(this.averBinaryPanel);
            this.Controls.Add(this.hardThresBinaryPanel);
            this.Controls.Add(this.gsBinaryPanel);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialTabSelector1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSTNodePropertyTab";
            this.Deactivate += new System.EventHandler(this.FrmSTNodePropertyTab_Deactivate);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.autoBinaryPanel.ResumeLayout(false);
            this.autoBinaryPanel.PerformLayout();
            this.hardThresBinaryPanel.ResumeLayout(false);
            this.hardThresBinaryPanel.PerformLayout();
            this.averBinaryPanel.ResumeLayout(false);
            this.averBinaryPanel.PerformLayout();
            this.gsBinaryPanel.ResumeLayout(false);
            this.gsBinaryPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        private void SetFormToSquare()
        {
            // 创建一个正方形的 GraphicsPath
            GraphicsPath squarePath = new GraphicsPath();
            squarePath.AddRectangle(new Rectangle(0, 0, this.Width, this.Height));

            // 将窗体的区域设置为正方形的 GraphicsPath
            this.Region = new Region(squarePath);
        }

        #endregion

        private MaterialSkin.Controls.TextBoxContextMenuStrip textBoxContextMenuStrip1;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private ComboBox comboBox1;
        private Label label1;
        private Panel autoBinaryPanel;
        private Panel hardThresBinaryPanel;
        private Label label2;
        private TextBox lowThresTextBox;
        private TextBox highThresTextBox;
        private Label label4;
        private Label label3;
        private Panel averBinaryPanel;
        private TextBox averBinaryCoreHigthBox;
        private Label label5;
        private Label label6;
        private TextBox averBinaryCoreWidthBox;
        private TextBox avgBinaryCoreThresOffsetBox;
        private Label label8;
        private Label label7;
        private ComboBox avgCmpTypeBox;
        private Panel gsBinaryPanel;
        private ComboBox gsBinaryCoreCmpTypeBox;
        private TextBox gsBinaryCoreThresOffsetBox;
        private Label label9;
        private Label label10;
        private TextBox gsBinaryCoreStdBox;
        private Label label11;
        private Label label12;
        private TextBox gsBinaryCoreSizeBox;
    }
}