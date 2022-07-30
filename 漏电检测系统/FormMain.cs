using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace 漏电检测系统
{
    public partial class FormMain : Form
    {
        SIM300 sIM = new SIM300(80);
        public FormMain()
        {
            InitializeComponent();
        }

        private void BtnCon_Click(object sender, EventArgs e)
        {
            sIM.Connect(txtIP.Text, txtPort.Text);
            txtIP.Enabled = false;
            txtPort.Enabled = false;
            if (!txtIP.Enabled && !txtPort.Enabled)
            {
                MessageBox.Show("连接成功");
            }
            else {
                MessageBox.Show("连接失败");
            }
            
        }
        private void OnNotifyUi(object s, _NotifyMessageEventArgs ev)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action<object, _NotifyMessageEventArgs>(OnNotifyUi), new object[] { s, ev });
                return;
            }
            ListViewItem lvi = new ListViewItem();
            lvi.UseItemStyleForSubItems = false;
            lvi.Name = ev.SIM300Param.Index.ToString();
            lvi.SubItems.Add(ev.SIM300Param.Index.ToString());
            lvi.SubItems.Add(ev.SIM300Param.Datetime);
            lvi.SubItems.Add(ev.SIM300Param.Line);
            lvi.SubItems.Add(ev.SIM300Param.Dangwei);
            lvi.SubItems.Add(ev.SIM300Param.Adc.ToString());
            lvi.SubItems.Add(ev.SIM300Param.Imea);
            sIM.TimeIs();
            Drawing(ev.SIM300Param.Adc);
            listView1.Items.Add(lvi);
            listView1.Items[listView1.Items.Count - 1].EnsureVisible();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            sIM.NotifyUi += OnNotifyUi;
            InitChart();
        }

        private void InitChart()
        {
            this.chart1.ChartAreas.Clear();
            ChartArea chartArea1 = new ChartArea("C1");
            this.chart1.ChartAreas.Add(chartArea1);
            //定义存储和显示器的容器
            this.chart1.Series.Clear();
            Series series1 = new Series("ADC");
            Series series2 = new Series("ADC参考");
            series1.ChartArea = "C1";
            series2.ChartArea = "C1";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            //设置图标显示样式
            this.chart1.ChartAreas[0].AxisY.Minimum = 0;
            this.chart1.ChartAreas[0].AxisY.Maximum = 24;
            this.chart1.ChartAreas[0].AxisY.Interval = 2;
            this.chart1.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm:ss";
            this.chart1.ChartAreas[0].AxisX.LabelStyle.IntervalType = DateTimeIntervalType.Minutes;
            this.chart1.ChartAreas[0].AxisX.MajorGrid.IntervalType= DateTimeIntervalType.Minutes;
            this.chart1.ChartAreas[0].AxisX.Interval = 10;
            this.chart1.ChartAreas[0].AxisX.ScrollBar.Enabled = true;
            this.chart1.ChartAreas[0].AxisX.Minimum = DateTime.Now.ToOADate();
            this.chart1.ChartAreas[0].AxisX.Maximum = DateTime.Now.AddMinutes(100).ToOADate();
            this.chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            this.chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            //设置标题
            this.chart1.Series[0].Color = Color.Red;
            this.chart1.Series[0].ChartType = SeriesChartType.FastLine;
            this.chart1.Series[0].Points.Clear();
            this.chart1.Series[1].Color = Color.Green;
            this.chart1.Series[1].ChartType = SeriesChartType.FastLine;
            this.chart1.Series[1].Points.Clear();
        }

        private void Drawing(double value)
        {
            this.chart1.ChartAreas[0].AxisX.ScaleView.Scroll(ScrollType.Last);
            string now = DateTime.Now.ToLongTimeString();
            DateTime time = DateTime.Parse(now);
            this.chart1.Series[0].Points.AddXY(time, value);
            this.chart1.Series[1].Points.AddXY(time, 3.3);
            if(time.ToOADate()> chart1.ChartAreas[0].AxisX.Maximum)
            {
                this.chart1.ChartAreas[0].AxisX.Minimum = DateTime.Now.AddMinutes(-100).ToOADate();
                this.chart1.ChartAreas[0].AxisX.Maximum = DateTime.Now.ToOADate();
            }
        }

        private void Chart1_GetToolTipText(object sender, ToolTipEventArgs e)
        {
            if (e.HitTestResult.ChartElementType==ChartElementType.DataPoint)
            {
                int i = e.HitTestResult.PointIndex;
                DataPoint dp = e.HitTestResult.Series.Points[i];
                e.Text = string.Format("{1:F3}", dp.XValue, dp.YValues[0]);
            }
        }

        private void BtnTime_Click(object sender, EventArgs e)
        {
            sIM.TimeIs();
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            sIM.Close();
            
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            BtnTime_Click(null, null);
        }

		private void txtPort_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtIP_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
