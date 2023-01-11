using Guna.Charts.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transactions;
using System.Windows.Forms.DataVisualization;
using System.Windows.Forms.DataVisualization.Charting;

namespace MainDashboard
{
    public partial class UC_AnaSayfa : UserControl
    {
        public int firmaId { get; set; }
        General genel = new General();
        int kalan;
        int satilan;
        int satilikCount;
        int kiralikCount;
        int DevrenKiralikCount;
        int DevrenSatilikCount;

        // SQLAcces ac = new SQLAcces();
        public UC_AnaSayfa()
        {

            InitializeComponent();
        }

        private void UC_AnaSayfa_Load(object sender, EventArgs e)
        {
            satilan = Convert.ToInt32(genel.Veri("SP_EmlakCount @Durum = 1, @FirmaId = " + firmaId, "Deger"));
            kalan = Convert.ToInt32(genel.Veri("SP_EmlakCount @Durum = 0, @FirmaId = " + firmaId, "Deger"));
            satilikCount = Convert.ToInt32(genel.Veri("SP_EmlakSatilikCount @FirmaId =" + firmaId, "Deger"));
            kiralikCount = Convert.ToInt32(genel.Veri("SP_EmlakKiralikCount @FirmaId =" + firmaId, "Deger"));
            DevrenSatilikCount = Convert.ToInt32(genel.Veri("SP_EmlakDevrenSatilikCount @FirmaId =" + firmaId, "Deger"));
            DevrenKiralikCount = Convert.ToInt32(genel.Veri("SP_EmlakDevrenKiralikCount @FirmaId =" + firmaId, "Deger"));
            Emlaklar(chrtEmlaklar);
            EmlakDurumlar(chrtEmlakDurum);
        }

        private void gunaChart1_Load(object sender, EventArgs e)
        {

        }
        public void Emlaklar(Guna.Charts.WinForms.GunaChart chart)
        {

            //Chart configuration  
            chart.Legend.Position = Guna.Charts.WinForms.LegendPosition.Right;
            chart.XAxes.Display = false;
            chart.YAxes.Display = false;

            //Create a new dataset 
            var dataset = new Guna.Charts.WinForms.GunaPieDataset();
            if (satilan != 0 || kalan != 0)
            {
                dataset.DataPoints.Add("Varolan Emlaklar", kalan);
                dataset.DataPoints.Add("Satılan Emlaklar", satilan);
            }

            //Add a new dataset to a chart.Datasets
            chart.Datasets.Add(dataset);

            //An update was made to re-render the chart
            chart.Update();
        }
        public void EmlakDurumlar(Guna.Charts.WinForms.GunaChart chart)
        {

            //Chart configuration
            chart.Misc.BarCornerRadius = 10;
            chart.YAxes.GridLines.Display = false;


            //Create a new dataset 
            var dataset = new Guna.Charts.WinForms.GunaStackedBarDataset();
            if (satilikCount != 0 || kiralikCount != 0 || DevrenKiralikCount != 0 || DevrenSatilikCount != 0)
            {
                dataset.DataPoints.Add("Satılık", satilikCount);
                dataset.DataPoints.Add("Kiralık", kiralikCount);
                dataset.DataPoints.Add("Devren Kiralık", DevrenKiralikCount);
                dataset.DataPoints.Add("Devren Satılık", DevrenSatilikCount);
            }

            //Add a new dataset to a chart.Datasets
            chart.Datasets.Add(dataset);

            //An update was made to re-render the chart
            chart.Update();
        }
    }
}

