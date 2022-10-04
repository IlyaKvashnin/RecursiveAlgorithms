﻿namespace RecursiveAlgorithmsForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpPyramid = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbHiz = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tpFractal = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.BtnStopDraw = new System.Windows.Forms.Button();
            this.btnStartDraw = new System.Windows.Forms.Button();
            this.lblOffsetY = new System.Windows.Forms.Label();
            this.lblOffsetX = new System.Windows.Forms.Label();
            this.lblAngle = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.nudOffsetY = new System.Windows.Forms.NumericUpDown();
            this.nudOffsetX = new System.Windows.Forms.NumericUpDown();
            this.nudAngle = new System.Windows.Forms.NumericUpDown();
            this.nudSize = new System.Windows.Forms.NumericUpDown();
            this.cmbSelectTemplate = new System.Windows.Forms.ComboBox();
            this.drawingPanel = new System.Windows.Forms.Panel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.tcMain.SuspendLayout();
            this.tpPyramid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tpFractal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffsetY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffsetX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).BeginInit();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpPyramid);
            this.tcMain.Controls.Add(this.tpFractal);
            this.tcMain.Location = new System.Drawing.Point(5, 26);
            this.tcMain.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(1607, 765);
            this.tcMain.TabIndex = 0;
            this.tcMain.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // tpPyramid
            // 
            this.tpPyramid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpPyramid.Controls.Add(this.label4);
            this.tpPyramid.Controls.Add(this.label3);
            this.tpPyramid.Controls.Add(this.label2);
            this.tpPyramid.Controls.Add(this.pictureBox3);
            this.tpPyramid.Controls.Add(this.pictureBox2);
            this.tpPyramid.Controls.Add(this.pictureBox1);
            this.tpPyramid.Controls.Add(this.cmbHiz);
            this.tpPyramid.Controls.Add(this.button3);
            this.tpPyramid.Controls.Add(this.button1);
            this.tpPyramid.Controls.Add(this.listBox1);
            this.tpPyramid.Controls.Add(this.label1);
            this.tpPyramid.Location = new System.Drawing.Point(8, 46);
            this.tpPyramid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpPyramid.Name = "tpPyramid";
            this.tpPyramid.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpPyramid.Size = new System.Drawing.Size(1591, 711);
            this.tpPyramid.TabIndex = 1;
            this.tpPyramid.Text = "Pyramid";
            this.tpPyramid.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1250, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 32);
            this.label4.TabIndex = 19;
            this.label4.Text = "3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(991, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 32);
            this.label3.TabIndex = 17;
            this.label3.Text = "2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(731, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 32);
            this.label2.TabIndex = 15;
            this.label2.Text = "1";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1139, 5);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(247, 647);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(879, 5);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(247, 647);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(619, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 647);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // cmbHiz
            // 
            this.cmbHiz.FormattingEnabled = true;
            this.cmbHiz.Items.AddRange(new object[] {
            "медленнее - 0.5 в сек",
            "медленно - 1 в сек",
            "нормально - 2 в сек",
            "быстро - 4 в сек",
            "быстрее - 5 в сек"});
            this.cmbHiz.Location = new System.Drawing.Point(257, 11);
            this.cmbHiz.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cmbHiz.Name = "cmbHiz";
            this.cmbHiz.Size = new System.Drawing.Size(253, 40);
            this.cmbHiz.TabIndex = 13;
            this.cmbHiz.Text = "Скорость";
            this.cmbHiz.SelectedIndexChanged += new System.EventHandler(this.cmbHiz_IndexChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(143, 8);
            this.button3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 50);
            this.button3.TabIndex = 11;
            this.button3.Text = "старт";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnStartHanoiTowers_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 8);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 50);
            this.button1.TabIndex = 9;
            this.button1.Text = "новый";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 32;
            this.listBox1.Location = new System.Drawing.Point(11, 110);
            this.listBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(264, 516);
            this.listBox1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Шаги для решения";
            // 
            // tpFractal
            // 
            this.tpFractal.Controls.Add(this.splitContainer1);
            this.tpFractal.Location = new System.Drawing.Point(8, 46);
            this.tpFractal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpFractal.Name = "tpFractal";
            this.tpFractal.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpFractal.Size = new System.Drawing.Size(1591, 711);
            this.tpFractal.TabIndex = 1;
            this.tpFractal.Text = "Fractal";
            this.tpFractal.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 2);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.BtnStopDraw);
            this.splitContainer1.Panel1.Controls.Add(this.btnStartDraw);
            this.splitContainer1.Panel1.Controls.Add(this.lblOffsetY);
            this.splitContainer1.Panel1.Controls.Add(this.lblOffsetX);
            this.splitContainer1.Panel1.Controls.Add(this.lblAngle);
            this.splitContainer1.Panel1.Controls.Add(this.lblSize);
            this.splitContainer1.Panel1.Controls.Add(this.nudOffsetY);
            this.splitContainer1.Panel1.Controls.Add(this.nudOffsetX);
            this.splitContainer1.Panel1.Controls.Add(this.nudAngle);
            this.splitContainer1.Panel1.Controls.Add(this.nudSize);
            this.splitContainer1.Panel1.Controls.Add(this.cmbSelectTemplate);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.drawingPanel);
            this.splitContainer1.Size = new System.Drawing.Size(1585, 707);
            this.splitContainer1.SplitterDistance = 517;
            this.splitContainer1.SplitterWidth = 8;
            this.splitContainer1.TabIndex = 0;
            // 
            // BtnStopDraw
            // 
            this.BtnStopDraw.Location = new System.Drawing.Point(361, 658);
            this.BtnStopDraw.Margin = new System.Windows.Forms.Padding(5);
            this.BtnStopDraw.Name = "BtnStopDraw";
            this.BtnStopDraw.Size = new System.Drawing.Size(153, 46);
            this.BtnStopDraw.TabIndex = 10;
            this.BtnStopDraw.Text = "Stop";
            this.BtnStopDraw.UseVisualStyleBackColor = true;
            this.BtnStopDraw.Click += new System.EventHandler(this.BtnStopDraw_Click);
            // 
            // btnStartDraw
            // 
            this.btnStartDraw.Location = new System.Drawing.Point(0, 658);
            this.btnStartDraw.Margin = new System.Windows.Forms.Padding(5);
            this.btnStartDraw.Name = "btnStartDraw";
            this.btnStartDraw.Size = new System.Drawing.Size(153, 46);
            this.btnStartDraw.TabIndex = 9;
            this.btnStartDraw.Text = "Start";
            this.btnStartDraw.UseVisualStyleBackColor = true;
            this.btnStartDraw.Click += new System.EventHandler(this.btnStartDraw_Click);
            // 
            // lblOffsetY
            // 
            this.lblOffsetY.AutoSize = true;
            this.lblOffsetY.Location = new System.Drawing.Point(117, 322);
            this.lblOffsetY.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblOffsetY.Name = "lblOffsetY";
            this.lblOffsetY.Size = new System.Drawing.Size(111, 32);
            this.lblOffsetY.TabIndex = 8;
            this.lblOffsetY.Text = "Offset Y :";
            // 
            // lblOffsetX
            // 
            this.lblOffsetX.AutoSize = true;
            this.lblOffsetX.Location = new System.Drawing.Point(117, 248);
            this.lblOffsetX.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblOffsetX.Name = "lblOffsetX";
            this.lblOffsetX.Size = new System.Drawing.Size(112, 32);
            this.lblOffsetX.TabIndex = 7;
            this.lblOffsetX.Text = "Offset X :";
            // 
            // lblAngle
            // 
            this.lblAngle.AutoSize = true;
            this.lblAngle.Location = new System.Drawing.Point(117, 173);
            this.lblAngle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAngle.Name = "lblAngle";
            this.lblAngle.Size = new System.Drawing.Size(88, 32);
            this.lblAngle.TabIndex = 6;
            this.lblAngle.Text = "Angle :";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(117, 101);
            this.lblSize.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(69, 32);
            this.lblSize.TabIndex = 5;
            this.lblSize.Text = "Size :";
            // 
            // nudOffsetY
            // 
            this.nudOffsetY.Location = new System.Drawing.Point(245, 318);
            this.nudOffsetY.Margin = new System.Windows.Forms.Padding(5);
            this.nudOffsetY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudOffsetY.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.nudOffsetY.Name = "nudOffsetY";
            this.nudOffsetY.Size = new System.Drawing.Size(244, 39);
            this.nudOffsetY.TabIndex = 4;
            // 
            // nudOffsetX
            // 
            this.nudOffsetX.Location = new System.Drawing.Point(245, 245);
            this.nudOffsetX.Margin = new System.Windows.Forms.Padding(5);
            this.nudOffsetX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudOffsetX.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.nudOffsetX.Name = "nudOffsetX";
            this.nudOffsetX.Size = new System.Drawing.Size(244, 39);
            this.nudOffsetX.TabIndex = 3;
            // 
            // nudAngle
            // 
            this.nudAngle.Location = new System.Drawing.Point(245, 170);
            this.nudAngle.Margin = new System.Windows.Forms.Padding(5);
            this.nudAngle.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nudAngle.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.nudAngle.Name = "nudAngle";
            this.nudAngle.Size = new System.Drawing.Size(244, 39);
            this.nudAngle.TabIndex = 2;
            // 
            // nudSize
            // 
            this.nudSize.Location = new System.Drawing.Point(245, 98);
            this.nudSize.Margin = new System.Windows.Forms.Padding(5);
            this.nudSize.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudSize.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.nudSize.Name = "nudSize";
            this.nudSize.Size = new System.Drawing.Size(244, 39);
            this.nudSize.TabIndex = 1;
            // 
            // cmbSelectTemplate
            // 
            this.cmbSelectTemplate.FormattingEnabled = true;
            this.cmbSelectTemplate.Items.AddRange(new object[] {
            "Custom",
            "Tree 1",
            "Tree 2",
            "Tree 3"});
            this.cmbSelectTemplate.Location = new System.Drawing.Point(36, 22);
            this.cmbSelectTemplate.Margin = new System.Windows.Forms.Padding(5);
            this.cmbSelectTemplate.Name = "cmbSelectTemplate";
            this.cmbSelectTemplate.Size = new System.Drawing.Size(451, 40);
            this.cmbSelectTemplate.TabIndex = 0;
            this.cmbSelectTemplate.Text = "Select template of tree";
            // 
            // drawingPanel
            // 
            this.drawingPanel.Location = new System.Drawing.Point(5, 5);
            this.drawingPanel.Margin = new System.Windows.Forms.Padding(5);
            this.drawingPanel.Name = "drawingPanel";
            this.drawingPanel.Size = new System.Drawing.Size(1056, 701);
            this.drawingPanel.TabIndex = 0;
            this.drawingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.drawingPanel_Paint);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1611, 791);
            this.Controls.Add(this.tcMain);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tcMain.ResumeLayout(false);
            this.tpPyramid.ResumeLayout(false);
            this.tpPyramid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tpFractal.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudOffsetY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffsetX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).EndInit();
            this.ResumeLayout(false);

        }

       

        #endregion

        private TabControl tcMain;
        private TabPage tpPyramid;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private ListBox listBox1;
        private Label label1;
        private ComboBox cmbHiz;
        private Button button3;
        private Button button1;
        private System.Windows.Forms.Timer timer2;
        private Label label4;
        private Label label3;
        private Label label2;
        private TabPage tpFractal;
        private SplitContainer splitContainer1;
        private Label lblSize;
        private NumericUpDown nudOffsetY;
        private NumericUpDown nudOffsetX;
        private NumericUpDown nudAngle;
        private NumericUpDown nudSize;
        private ComboBox cmbSelectTemplate;
        private Panel drawingPanel;
        private Label lblAngle;
        private Label lblOffsetY;
        private Label lblOffsetX;
        private Button BtnStopDraw;
        private Button btnStartDraw;
    }
}