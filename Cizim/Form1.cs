using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Cizim
{
    public partial class Form1 : Form
    {
        private List<UretimVerisi> veriler;
        public Form1()
        {
            InitializeComponent();
            LoadData();
            PopulateComboBox();
            DisplayAllData();
        }

        private void LoadData()
        {
            // Dosyadan veri okuma (örnek olarak hardcoded data, bunu dosyadan okuyacak şekilde ayarlayabilirsiniz)
            veriler = new List<UretimVerisi>();

            string[] lines = File.ReadAllLines("C:\\Users\\evind\\source\\repos\\odev3\\Cizim\\veriler.txt");
            foreach (var line in lines)
            {
                var parts = line.Split(',');
                veriler.Add(new UretimVerisi
                {
                    MakineAdi = parts[0],
                    Tarih = DateTime.Parse(parts[1]),
                    HedefMiktar = int.Parse(parts[2]),
                    UretilenMiktar = int.Parse(parts[3])
                });
            }
        }
        private void PopulateComboBox()
        {
            var makineler = veriler.Select(v => v.MakineAdi).Distinct().ToList();
            comboBoxMachines.Items.AddRange(makineler.ToArray());
        }
        private void DisplayAllData()
        {
            var dt = new DataTable();
            dt.Columns.Add("Makine Adı");
            dt.Columns.Add("Tarih");
            dt.Columns.Add("Hedef Miktar");
            dt.Columns.Add("Üretilen Miktar");

            foreach (var veri in veriler)
            {
                dt.Rows.Add(veri.MakineAdi, veri.Tarih.ToShortDateString(), veri.HedefMiktar, veri.UretilenMiktar);
            }

            dataGridView.DataSource = dt;
        }
        private void comboBoxMachines_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayAllData();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            var selectedMachine = comboBoxMachines.SelectedItem.ToString();
            var startDate = dateTimePickerStart.Value;
            var endDate = dateTimePickerEnd.Value;

            var filteredData = veriler.Where(v => v.MakineAdi == selectedMachine && v.Tarih >= startDate && v.Tarih <= endDate).ToList();

            var dt = new DataTable();
            dt.Columns.Add("Tarih");
            dt.Columns.Add("Hedef Miktar");
            dt.Columns.Add("Üretilen Miktar");

            foreach (var veri in filteredData)
            {
                dt.Rows.Add(veri.Tarih.ToShortDateString(), veri.HedefMiktar, veri.UretilenMiktar);
            }

            dataGridView.DataSource = dt;

            DrawChart(filteredData);
        }

        private void comboBoxMachines_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DisplayAllData();
        }

        private void DrawChart(List<UretimVerisi> veriler)
        {
            chart.Series.Clear();

            var hedefSeries = new Series("Hedef Miktar");
            hedefSeries.ChartType = SeriesChartType.Column;
            var uretilenSeries = new Series("Üretilen Miktar");
            uretilenSeries.ChartType = SeriesChartType.Column;

            foreach (var veri in veriler)
            {
                hedefSeries.Points.AddXY(veri.Tarih.ToShortDateString(), veri.HedefMiktar);
                uretilenSeries.Points.AddXY(veri.Tarih.ToShortDateString(), veri.UretilenMiktar);
            }

            chart.Series.Add(hedefSeries);
            chart.Series.Add(uretilenSeries);

            chart.ChartAreas[0].RecalculateAxesScale();
        }

    }
}
