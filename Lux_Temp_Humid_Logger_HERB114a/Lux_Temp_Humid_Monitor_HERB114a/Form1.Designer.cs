namespace Lux_Temp_Humid_Logger_HERB114a
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.LegendItem legendItem3 = new System.Windows.Forms.DataVisualization.Charting.LegendItem();
            System.Windows.Forms.DataVisualization.Charting.LegendCell legendCell3 = new System.Windows.Forms.DataVisualization.Charting.LegendCell();
            this.browse = new System.Windows.Forms.Button();
            this.data_dir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.go = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.Yzoom = new System.Windows.Forms.CheckBox();
            this.Xzoom = new System.Windows.Forms.CheckBox();
            this.comrefresh = new System.Windows.Forms.Button();
            this.comports = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.List2 = new System.Windows.Forms.CheckedListBox();
            this.graph = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.duration = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.TextBox();
            this.day = new System.Windows.Forms.TextBox();
            this.month = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.List1 = new System.Windows.Forms.CheckedListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label9 = new System.Windows.Forms.Label();
            this.streamplot = new System.Windows.Forms.CheckBox();
            this.streamsamples = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // browse
            // 
            this.browse.Location = new System.Drawing.Point(255, 80);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(54, 20);
            this.browse.TabIndex = 2;
            this.browse.Text = "Browse";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // data_dir
            // 
            this.data_dir.Location = new System.Drawing.Point(15, 80);
            this.data_dir.Name = "data_dir";
            this.data_dir.Size = new System.Drawing.Size(234, 20);
            this.data_dir.TabIndex = 1;
            this.data_dir.Text = "C:\\Lux_Temp_Humid_Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Directory";
            // 
            // chart1
            // 
            chartArea3.AxisX.LabelStyle.Format = "MM/dd HH:mm:ss";
            chartArea3.AxisX.Title = "Time";
            chartArea3.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea3.CursorX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds;
            chartArea3.CursorX.IsUserEnabled = true;
            chartArea3.CursorX.IsUserSelectionEnabled = true;
            chartArea3.CursorX.LineColor = System.Drawing.Color.DarkGray;
            chartArea3.CursorY.IsUserEnabled = true;
            chartArea3.CursorY.IsUserSelectionEnabled = true;
            chartArea3.CursorY.LineColor = System.Drawing.Color.LightGray;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legendCell3.Name = "A";
            legendItem3.Cells.Add(legendCell3);
            legend3.CustomItems.Add(legendItem3);
            legend3.Name = "Legend";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(180, 0);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(612, 445);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // go
            // 
            this.go.BackColor = System.Drawing.Color.SpringGreen;
            this.go.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.go.Location = new System.Drawing.Point(276, 70);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(75, 23);
            this.go.TabIndex = 3;
            this.go.Text = "Start";
            this.go.UseVisualStyleBackColor = false;
            this.go.Click += new System.EventHandler(this.go_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.ReadTimeout = 2000;
            this.serialPort1.ReceivedBytesThreshold = 42;
            this.serialPort1.WriteTimeout = 2000;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // Yzoom
            // 
            this.Yzoom.AutoSize = true;
            this.Yzoom.Location = new System.Drawing.Point(15, 40);
            this.Yzoom.Name = "Yzoom";
            this.Yzoom.Size = new System.Drawing.Size(97, 17);
            this.Yzoom.TabIndex = 18;
            this.Yzoom.Text = "Enable Y zoom";
            this.Yzoom.UseVisualStyleBackColor = true;
            this.Yzoom.CheckedChanged += new System.EventHandler(this.Yzoom_CheckedChanged);
            // 
            // Xzoom
            // 
            this.Xzoom.AutoSize = true;
            this.Xzoom.Checked = true;
            this.Xzoom.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Xzoom.Location = new System.Drawing.Point(15, 17);
            this.Xzoom.Name = "Xzoom";
            this.Xzoom.Size = new System.Drawing.Size(97, 17);
            this.Xzoom.TabIndex = 17;
            this.Xzoom.Text = "Enable X zoom";
            this.Xzoom.UseVisualStyleBackColor = true;
            this.Xzoom.CheckedChanged += new System.EventHandler(this.Xzoom_CheckedChanged);
            // 
            // comrefresh
            // 
            this.comrefresh.Location = new System.Drawing.Point(156, 9);
            this.comrefresh.Name = "comrefresh";
            this.comrefresh.Size = new System.Drawing.Size(53, 21);
            this.comrefresh.TabIndex = 6;
            this.comrefresh.Text = "Refresh";
            this.comrefresh.UseVisualStyleBackColor = true;
            this.comrefresh.Click += new System.EventHandler(this.comrefresh_Click);
            // 
            // comports
            // 
            this.comports.FormattingEnabled = true;
            this.comports.Location = new System.Drawing.Point(62, 9);
            this.comports.Name = "comports";
            this.comports.Size = new System.Drawing.Size(88, 21);
            this.comports.TabIndex = 5;
            this.comports.SelectedIndexChanged += new System.EventHandler(this.comports_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(105, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Chamber";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Com Port";
            // 
            // List2
            // 
            this.List2.CheckOnClick = true;
            this.List2.ColumnWidth = 42;
            this.List2.FormattingEnabled = true;
            this.List2.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "R"});
            this.List2.Location = new System.Drawing.Point(108, 12);
            this.List2.MultiColumn = true;
            this.List2.Name = "List2";
            this.List2.Size = new System.Drawing.Size(36, 94);
            this.List2.TabIndex = 28;
            // 
            // graph
            // 
            this.graph.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.graph.Location = new System.Drawing.Point(276, 70);
            this.graph.Name = "graph";
            this.graph.Size = new System.Drawing.Size(75, 23);
            this.graph.TabIndex = 27;
            this.graph.Text = "Plot";
            this.graph.UseVisualStyleBackColor = true;
            this.graph.Click += new System.EventHandler(this.graph_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(160, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Duration";
            // 
            // duration
            // 
            this.duration.FormattingEnabled = true;
            this.duration.Items.AddRange(new object[] {
            "One Day",
            "Two Days",
            "One Week",
            "Two Weeks",
            "One Month",
            "Two Months"});
            this.duration.Location = new System.Drawing.Point(221, 40);
            this.duration.Name = "duration";
            this.duration.Size = new System.Drawing.Size(125, 21);
            this.duration.TabIndex = 25;
            this.duration.Text = "One Day";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Start Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "/";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "/";
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(315, 14);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(31, 20);
            this.year.TabIndex = 21;
            // 
            // day
            // 
            this.day.Location = new System.Drawing.Point(268, 14);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(23, 20);
            this.day.TabIndex = 20;
            this.day.Enter += new System.EventHandler(this.day_Enter);
            // 
            // month
            // 
            this.month.Location = new System.Drawing.Point(221, 14);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(23, 20);
            this.month.TabIndex = 19;
            this.month.Enter += new System.EventHandler(this.month_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Data Type";
            // 
            // List1
            // 
            this.List1.CheckOnClick = true;
            this.List1.FormattingEnabled = true;
            this.List1.Items.AddRange(new object[] {
            "Lux",
            "Temp",
            "Humid"});
            this.List1.Location = new System.Drawing.Point(9, 19);
            this.List1.Name = "List1";
            this.List1.Size = new System.Drawing.Size(93, 49);
            this.List1.TabIndex = 15;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox1.Size = new System.Drawing.Size(180, 445);
            this.textBox1.TabIndex = 3;
            this.textBox1.TabStop = false;
            this.textBox1.WordWrap = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(3, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(792, 134);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.streamsamples);
            this.tabPage1.Controls.Add(this.streamplot);
            this.tabPage1.Controls.Add(this.comrefresh);
            this.tabPage1.Controls.Add(this.go);
            this.tabPage1.Controls.Add(this.comports);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(784, 108);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Log Data";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.List1);
            this.tabPage2.Controls.Add(this.List2);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.month);
            this.tabPage2.Controls.Add(this.graph);
            this.tabPage2.Controls.Add(this.day);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.year);
            this.tabPage2.Controls.Add(this.duration);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(784, 108);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Offline Data Plot";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer1.Location = new System.Drawing.Point(0, 445);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Xzoom);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.Yzoom);
            this.splitContainer1.Panel1.Controls.Add(this.data_dir);
            this.splitContainer1.Panel1.Controls.Add(this.browse);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(792, 128);
            this.splitContainer1.SplitterDistance = 372;
            this.splitContainer1.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(180, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Click and Drag on chart to zoom";
            // 
            // streamplot
            // 
            this.streamplot.AutoSize = true;
            this.streamplot.Checked = true;
            this.streamplot.CheckState = System.Windows.Forms.CheckState.Checked;
            this.streamplot.Location = new System.Drawing.Point(9, 36);
            this.streamplot.Name = "streamplot";
            this.streamplot.Size = new System.Drawing.Size(108, 17);
            this.streamplot.TabIndex = 7;
            this.streamplot.Text = "Plot while logging";
            this.streamplot.UseVisualStyleBackColor = true;
            this.streamplot.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // streamsamples
            // 
            this.streamsamples.Location = new System.Drawing.Point(102, 58);
            this.streamsamples.Name = "streamsamples";
            this.streamsamples.Size = new System.Drawing.Size(48, 20);
            this.streamsamples.TabIndex = 8;
            this.streamsamples.Text = "600";
            this.streamsamples.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.streamsamples.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.streamsamples_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "# Samples to Plot";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox data_dir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button go;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button graph;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox duration;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox year;
        private System.Windows.Forms.TextBox day;
        private System.Windows.Forms.TextBox month;
        private System.Windows.Forms.CheckBox Yzoom;
        private System.Windows.Forms.CheckBox Xzoom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox List1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comports;
        private System.Windows.Forms.Button comrefresh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckedListBox List2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox streamplot;
        private System.Windows.Forms.TextBox streamsamples;
        private System.Windows.Forms.Label label10;
    }
}

