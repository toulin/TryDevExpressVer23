using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraCharts;

namespace Rinnbo
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
            //填入假資料
            FillFakeData();
        } 

        private void FillFakeData()
        {
            //X軸 設定時間範圍，在9:00~13:00之間
            XYDiagram diagram = (XYDiagram)chartControl1.Diagram;
            diagram.AxisX.DateTimeScaleOptions.MeasureUnit = DateTimeMeasureUnit.Minute;
            diagram.AxisX.DateTimeScaleOptions.GridAlignment = DateTimeGridAlignment.Hour;
            diagram.AxisX.VisualRange.SetMinMaxValues(new DateTime(2024, 11, 7, 9, 0, 0), new DateTime(2024, 11, 7, 13, 0, 0));

            chartControl1.Series[0].DataSource = Data.GetStocks();
            //綁定資料 資料源的時間欄位為DealTime，價格欄位為Price 
            chartControl1.Series[0].ArgumentDataMember = "DealTime";
            chartControl1.Series[0].ValueDataMembers[0] = "Price";
        }

        private void dockPanel1_Click(object sender, EventArgs e)
        {

        }
    }
}
