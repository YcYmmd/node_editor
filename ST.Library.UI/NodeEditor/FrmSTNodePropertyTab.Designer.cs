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
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.averBinaryCoreHigthBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.averBinaryCoreWidthBox = new System.Windows.Forms.TextBox();
            this.gsBinaryPanel = new System.Windows.Forms.Panel();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
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
            this.textBoxContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxContextMenuStrip1.Name = "textBoxContextMenuStrip1";
            this.textBoxContextMenuStrip1.Size = new System.Drawing.Size(129, 170);
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.FirstTabPadding = 10;
            this.materialTabSelector1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector1.Location = new System.Drawing.Point(-6, 1);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(285, 29);
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
            this.materialTabControl1.Location = new System.Drawing.Point(3, 36);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(276, 326);
            this.materialTabControl1.TabIndex = 3;
            this.materialTabControl1.SelectedIndexChanged += new System.EventHandler(this.materialTabControl1_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.autoBinaryPanel);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(268, 300);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "运行参数";
            // 
            // autoBinaryPanel
            // 
            this.autoBinaryPanel.Controls.Add(this.label2);
            this.autoBinaryPanel.Location = new System.Drawing.Point(15, 66);
            this.autoBinaryPanel.Name = "autoBinaryPanel";
            this.autoBinaryPanel.Size = new System.Drawing.Size(226, 228);
            this.autoBinaryPanel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("苹方-简", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(35, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 68);
            this.label2.TabIndex = 0;
            this.label2.Text = "自动二值化，\r\n无需设置参数\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("苹方-简", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 27);
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
            this.comboBox1.Location = new System.Drawing.Point(32, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(181, 20);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(268, 300);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "结果显示";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(268, 300);
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
            this.hardThresBinaryPanel.Location = new System.Drawing.Point(380, 329);
            this.hardThresBinaryPanel.Name = "hardThresBinaryPanel";
            this.hardThresBinaryPanel.Size = new System.Drawing.Size(226, 231);
            this.hardThresBinaryPanel.TabIndex = 3;
            // 
            // highThresTextBox
            // 
            this.highThresTextBox.Location = new System.Drawing.Point(59, 74);
            this.highThresTextBox.Name = "highThresTextBox";
            this.highThresTextBox.Size = new System.Drawing.Size(143, 21);
            this.highThresTextBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "高阈值";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "低阈值";
            // 
            // lowThresTextBox
            // 
            this.lowThresTextBox.Location = new System.Drawing.Point(59, 29);
            this.lowThresTextBox.Name = "lowThresTextBox";
            this.lowThresTextBox.Size = new System.Drawing.Size(143, 21);
            this.lowThresTextBox.TabIndex = 0;
            // 
            // averBinaryPanel
            // 
            this.averBinaryPanel.BackColor = System.Drawing.Color.Transparent;
            this.averBinaryPanel.Controls.Add(this.comboBox2);
            this.averBinaryPanel.Controls.Add(this.textBox4);
            this.averBinaryPanel.Controls.Add(this.label8);
            this.averBinaryPanel.Controls.Add(this.label7);
            this.averBinaryPanel.Controls.Add(this.averBinaryCoreHigthBox);
            this.averBinaryPanel.Controls.Add(this.label5);
            this.averBinaryPanel.Controls.Add(this.label6);
            this.averBinaryPanel.Controls.Add(this.averBinaryCoreWidthBox);
            this.averBinaryPanel.Location = new System.Drawing.Point(10, 368);
            this.averBinaryPanel.Name = "averBinaryPanel";
            this.averBinaryPanel.Size = new System.Drawing.Size(226, 231);
            this.averBinaryPanel.TabIndex = 4;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "大于等于",
            "小于等于",
            "等于",
            "不等于"});
            this.comboBox2.Location = new System.Drawing.Point(68, 128);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(143, 20);
            this.comboBox2.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(68, 171);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(143, 21);
            this.textBox4.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 6;
            this.label8.Text = "阈值偏移量";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "比较类型";
            // 
            // averBinaryCoreHigthBox
            // 
            this.averBinaryCoreHigthBox.Location = new System.Drawing.Point(68, 74);
            this.averBinaryCoreHigthBox.Name = "averBinaryCoreHigthBox";
            this.averBinaryCoreHigthBox.Size = new System.Drawing.Size(143, 21);
            this.averBinaryCoreHigthBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "滤波盒高度";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "滤波核宽度";
            // 
            // averBinaryCoreWidthBox
            // 
            this.averBinaryCoreWidthBox.Location = new System.Drawing.Point(68, 29);
            this.averBinaryCoreWidthBox.Name = "averBinaryCoreWidthBox";
            this.averBinaryCoreWidthBox.Size = new System.Drawing.Size(143, 21);
            this.averBinaryCoreWidthBox.TabIndex = 0;
            // 
            // gsBinaryPanel
            // 
            this.gsBinaryPanel.BackColor = System.Drawing.Color.Transparent;
            this.gsBinaryPanel.Controls.Add(this.comboBox3);
            this.gsBinaryPanel.Controls.Add(this.textBox1);
            this.gsBinaryPanel.Controls.Add(this.label9);
            this.gsBinaryPanel.Controls.Add(this.label10);
            this.gsBinaryPanel.Controls.Add(this.textBox2);
            this.gsBinaryPanel.Controls.Add(this.label11);
            this.gsBinaryPanel.Controls.Add(this.label12);
            this.gsBinaryPanel.Controls.Add(this.textBox3);
            this.gsBinaryPanel.Location = new System.Drawing.Point(370, 61);
            this.gsBinaryPanel.Name = "gsBinaryPanel";
            this.gsBinaryPanel.Size = new System.Drawing.Size(228, 228);
            this.gsBinaryPanel.TabIndex = 9;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "大于等于",
            "小于等于",
            "等于",
            "不等于"});
            this.comboBox3.Location = new System.Drawing.Point(68, 128);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(143, 20);
            this.comboBox3.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(68, 171);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 21);
            this.textBox1.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 6;
            this.label9.Text = "阈值偏移量";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 4;
            this.label10.Text = "比较类型";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(68, 74);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(143, 21);
            this.textBox2.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 2;
            this.label11.Text = "高斯标准差";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 1;
            this.label12.Text = "高斯滤波核";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(68, 29);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(143, 21);
            this.textBox3.TabIndex = 0;
            // 
            // FrmSTNodePropertyTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(277, 359);
            this.ControlBox = false;
            this.Controls.Add(this.averBinaryPanel);
            this.Controls.Add(this.hardThresBinaryPanel);
            this.Controls.Add(this.gsBinaryPanel);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialTabSelector1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private TextBox textBox4;
        private Label label8;
        private Label label7;
        private ComboBox comboBox2;
        private Panel gsBinaryPanel;
        private ComboBox comboBox3;
        private TextBox textBox1;
        private Label label9;
        private Label label10;
        private TextBox textBox2;
        private Label label11;
        private Label label12;
        private TextBox textBox3;
    }
}