using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lux_Temp_Humid_Logger_HERB114a
{
    public partial class Form1 : Form
    {
        bool my_flag;
        public Form1()
        {
            InitializeComponent();
            day.Text = DateTime.Today.Day.ToString();
            month.Text = DateTime.Today.Month.ToString();
            year.Text = DateTime.Today.Year.ToString();
            comports.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
            if( comports.Items.Count>0 )
            {
                comports.SelectedIndex += 1;
                serialPort1.PortName = comports.SelectedItem.ToString();
            }
            for (int i = 0; i < List1.Items.Count; i++)
            {
                List1.SetItemChecked(i, true);
            }
            for (int i = 0; i < List2.Items.Count; i++)
            {
                List2.SetItemChecked(i, true);
            }
        }

        private void browse_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                data_dir.Text = folderBrowserDialog1.SelectedPath.ToString();
            }
        }

        private void Xzoom_CheckedChanged(object sender, EventArgs e)
        {
            if (Xzoom.Checked)
            {
                chart1.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            }
            else
            {
                chart1.ChartAreas[0].CursorX.IsUserSelectionEnabled = false;
            }
        }

        private void Yzoom_CheckedChanged(object sender, EventArgs e)
        {
            if (Yzoom.Checked)
            {
                chart1.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            }
            else
            {
                chart1.ChartAreas[0].CursorY.IsUserSelectionEnabled = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(streamplot.Checked)
            {
                streamsamples.Enabled = true;
            }
            else
            {
                streamsamples.Enabled = false;
            }
        }

        private void comports_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.PortName = comports.SelectedItem.ToString();
        }

        private void comrefresh_Click(object sender, EventArgs e)
        {
            comports.Items.Clear();
            comports.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
        }

        private void month_Enter(object sender, EventArgs e)
        {
            month.Clear();
        }

        private void day_Enter(object sender, EventArgs e)
        {
            day.Clear();
        }

        private void go_Click(object sender, EventArgs e)
        {
            if (String.Equals(go.Text, "Start"))
            {
                my_flag = true;
                System.Drawing.Color[] colorlist = new System.Drawing.Color[6] { System.Drawing.Color.Crimson, System.Drawing.Color.DarkMagenta, System.Drawing.Color.MidnightBlue, System.Drawing.Color.SeaGreen, System.Drawing.Color.Goldenrod, System.Drawing.Color.Sienna };
                System.Windows.Forms.DataVisualization.Charting.MarkerStyle[] stylelist = new System.Windows.Forms.DataVisualization.Charting.MarkerStyle[3] { System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle, System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square, System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Triangle };
                chart1.ChartAreas[0].CursorX.Interval = 60;
                chart1.Series.Clear();
                textBox1.Clear();
                //add series for each checked room/chamber and data type combination
                if (streamplot.Checked)
                {
                    int i = 0;
                    foreach (object chamber in List2.Items)
                    {
                        int ii = 0;
                        foreach (object datatype in List1.Items)
                        {
                            chart1.Series.Add(String.Concat(chamber.ToString(), " ", datatype.ToString()));
                            chart1.Series[String.Concat(chamber.ToString(), " ", datatype.ToString())].ChartType = SeriesChartType.Line;
                            chart1.Series[String.Concat(chamber.ToString(), " ", datatype.ToString())].MarkerStyle = stylelist[ii];
                            chart1.Series[String.Concat(chamber.ToString(), " ", datatype.ToString())].MarkerSize = 10;
                            chart1.Series[String.Concat(chamber.ToString(), " ", datatype.ToString())].MarkerStep = 60;
                            chart1.Series[String.Concat(chamber.ToString(), " ", datatype.ToString())].Color = colorlist[i];
                            chart1.Series[String.Concat(chamber.ToString(), " ", datatype.ToString())].XValueType = ChartValueType.DateTime;
                            ii += 1;
                        }
                        i += 1;
                    }
                }
                try
                {
                    serialPort1.Open();
                    serialPort1.DiscardInBuffer();
                    serialPort1.WriteLine("go");
                    go.Text = "Stop";
                    go.BackColor = System.Drawing.Color.Crimson;
                    tabPage2.Enabled = false;
                    streamplot.Enabled = false;
                }
                catch
                {
                    textBox1.Text = "connection error";
                    return;
                }
            }
            else
            {
                try
                {
                    serialPort1.DiscardInBuffer();
                    serialPort1.Close();
                    go.Text = "Start";
                    go.BackColor = System.Drawing.Color.SpringGreen;
                    tabPage2.Enabled = true;
                    streamplot.Enabled = true;
                }
                catch
                {
                    textBox1.Text = "disconnect error\n";
                }
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string my_message = "what a crock of ****\n";
            DateTime my_time;
            string dest = data_dir.Text;

            try
            {
                my_message = serialPort1.ReadLine();
                if (my_message.Contains("L:") && my_message.Contains("T:") && my_message.Contains("H:"))
                {
                    my_time = DateTime.Now;
                    dest = String.Concat(dest, "\\chamber", my_message[0], "_", my_time.Year.ToString(), "_", my_time.Month.ToString(), "_", my_time.Day.ToString(), ".txt");
                    if (streamplot.Checked)
                    {
                        SetChart(String.Concat(my_message[0], " Lux"), my_time, Convert.ToDouble(my_message.Substring(my_message.IndexOf("L: ") + 3, 5)));//(Convert.ToDouble(my_message.Substring(my_message.IndexOf("L1: ") + 4, 4)) + Convert.ToDouble(my_message.Substring(my_message.IndexOf("L2: ") + 4, 4))) / 2);
                        SetChart(String.Concat(my_message[0], " Temp"), my_time, Convert.ToDouble(my_message.Substring(my_message.IndexOf("T: ") + 3, 5)));
                        SetChart(String.Concat(my_message[0], " Humid"), my_time, Convert.ToDouble(my_message.Substring(my_message.IndexOf("H: ") + 3, 5)));
                    }
                    my_message = String.Concat(my_time.ToString(), " ", my_message, "\n");
                    //byte[] my_bytes = Encoding.ASCII.GetBytes(my_message);
                    try
                    {
                        System.IO.File.AppendAllText(@dest, my_message);
                    }
                    catch
                    {
                        my_message = "Write to file error\n";
                    }
                }
                else
                {
                    my_message = "message incomplete\n";
                }
            }
            catch
            {
                my_message = "ReadLine error\n";
            }
            SetText(my_message);
            serialPort1.WriteLine("go");
        }

        delegate void SetTextCallback(string text);
        private void SetText(string text)
        {
            if (this.textBox1.InvokeRequired)
            {
                SetTextCallback cb = new SetTextCallback(SetText);
                this.Invoke(cb, new object[] { text });
            }
            else
            {
                if(this.textBox1.Lines.Length>42)
                { this.textBox1.Clear(); }
                this.textBox1.AppendText(text);
            }
        }

        delegate void SetChartCallback(string s, DateTime t, double d);
        private void SetChart(string s, DateTime t, double d)
        {
            if (this.chart1.InvokeRequired)
            {
                SetChartCallback cb = new SetChartCallback(SetChart);
                this.Invoke(cb, new object[] { s, t, d });
            }
            else
            {
                if (my_flag)
                {
                    while (chart1.Series[s].Points.Count > Convert.ToInt16(streamsamples.Text))
                    {
                        chart1.Series[s].Points.RemoveAt(0);
                        //chart1.Series[s].Points[0].Dispose();
                    }
                }
                chart1.Series[s].Points.AddXY(t, d);
                chart1.ResetAutoValues();
            }
        }

        private void graph_Click(object sender, EventArgs e)
        {
            my_flag = false;
            chart1.Series.Clear(); 
            DateTime startDate = new DateTime(Convert.ToInt16(year.Text.ToString()), Convert.ToInt16(month.Text.ToString()), Convert.ToInt16(day.Text.ToString()));
            DateTime endDate = startDate;
            DateTime timestamp;
            string dest = "";
            string[] lines;
            int interval = 0,count = 0,i = 0, ii = 0;
            double lux = 0, tem = 0, hum = 0;
            System.Drawing.Color[] colorlist = new System.Drawing.Color[6] { System.Drawing.Color.Crimson, System.Drawing.Color.DarkMagenta, System.Drawing.Color.MidnightBlue, System.Drawing.Color.SeaGreen, System.Drawing.Color.Goldenrod, System.Drawing.Color.Sienna  };
            System.Windows.Forms.DataVisualization.Charting.MarkerStyle[] stylelist = new System.Windows.Forms.DataVisualization.Charting.MarkerStyle[3] { System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle, System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square, System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Triangle };
            switch (duration.SelectedIndex)
            {
                case 0: endDate = startDate.AddDays(1); interval = 30; SetText("averaging every 30 samples\n"); break;
                case 1: endDate = startDate.AddDays(2); interval = 60; SetText("averaging every 60 samples\n"); break;
                case 2: endDate = startDate.AddDays(7); interval = 300; SetText("averaging every 300 samples\n"); break;
                case 3: endDate = startDate.AddDays(14); interval = 900; SetText("averaging every 900 samples\n"); break;
                case 4: endDate = startDate.AddMonths(1); interval = 1800; SetText("averaging every 1800 samples\n"); break;
                case 5: endDate = startDate.AddMonths(2); interval = 3600; SetText("averaging every 3600 samples\n"); break;
                default: break;
            }
            chart1.ChartAreas[0].CursorX.Interval = 1;

            //add series for each checked room/chamber and data type combination
            i = 0;
            foreach (object chamber in List2.CheckedItems)
            {
                ii = 0;
                foreach (object datatype in List1.CheckedItems)
                {
                    chart1.Series.Add(String.Concat(chamber.ToString(), " ", datatype.ToString()));
                    chart1.Series[String.Concat(chamber.ToString(), " ", datatype.ToString())].ChartType = SeriesChartType.Line;
                    chart1.Series[String.Concat(chamber.ToString(), " ", datatype.ToString())].MarkerStyle = stylelist[ii];
                    chart1.Series[String.Concat(chamber.ToString(), " ", datatype.ToString())].MarkerSize = 10;
                    chart1.Series[String.Concat(chamber.ToString(), " ", datatype.ToString())].MarkerStep = 600;
                    chart1.Series[String.Concat(chamber.ToString(), " ", datatype.ToString())].Color = colorlist[i];
                    chart1.Series[String.Concat(chamber.ToString(), " ", datatype.ToString())].XValueType = ChartValueType.DateTime;
                    ii += 1;
                }
                i += 1;
            }

            //blah blah blah blah comments
            while (startDate != endDate)
            {
                foreach (object chamber in List2.CheckedItems)
                {
                    dest = String.Concat(data_dir.Text, "\\chamber", chamber.ToString(), "_", startDate.Year.ToString(), "_", startDate.Month.ToString(), "_", startDate.Day.ToString(), ".txt");
                    count = 0;
                    try
                    {
                        lines = File.ReadAllLines(dest);
                        foreach (string line in lines)
                        {
                            timestamp = Convert.ToDateTime(line.Substring(0, line.IndexOf('M')+1));
                            lux += Convert.ToDouble(line.Substring(line.IndexOf("L: ") + 3, 5));//(Convert.ToDouble(line.Substring(line.IndexOf("L1: ") + 4, 4)) + Convert.ToDouble(line.Substring(line.IndexOf("L2: ") + 4, 4))) / 2;
                            tem += Convert.ToDouble(line.Substring(line.IndexOf("T: ") + 3, 5));
                            hum += Convert.ToDouble(line.Substring(line.IndexOf("H: ") + 3, 5));
                            count += 1;
                            if(count%interval==0)
                            {
                                lux /= interval;
                                tem /= interval;
                                hum /= interval;
                                if(List1.CheckedItems.Contains("Lux"))
                                {
                                    SetChart(String.Concat(line.Substring(line.IndexOf('M') + 2, 1), " Lux"), timestamp, lux);
                                }
                                if (List1.CheckedItems.Contains("Temp"))
                                {
                                    SetChart(String.Concat(line.Substring(line.IndexOf('M') + 2, 1), " Temp"), timestamp, tem);
                                }
                                if (List1.CheckedItems.Contains("Humid"))
                                {
                                    SetChart(String.Concat(line.Substring(line.IndexOf('M') + 2, 1), " Humid"), timestamp, hum);
                                }
                                lux = 0;
                                tem = 0;
                                hum = 0;
                            }
                        }
                    }
                    catch (FileNotFoundException)
                    {
                        SetText(String.Concat("error: \"",dest,"\" not found\n"));
                    }
                }
                startDate = startDate.AddDays(1);
            }
        }

        private void streamsamples_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar); //limit to numbers only
        }
    }
}
