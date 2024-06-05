using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DerslerVeEgitmenler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            int dersID = Convert.ToInt32(txtDersID.Text);
            string dersAdı = txtDErsAdı.Text;
            int egitmenID = Convert.ToInt32(txtEgitmenID.Text);
            string egitmenAdı = txtEgitmenAdı.Text;
            Ders newDers=new Ders(dersID,dersAdı,egitmenID,egitmenAdı);    
            ekleme(newDers);
            txtDErsAdı.Text = "";
            txtDersID.Text = "";
            txtEgitmenAdı.Text = "";
            txtEgitmenID.Text = "";

            
        }
        public void ekleme(Ders ders)
        {
            Egitmen egitmen = new Egitmen();
            int diziBoyutu = egitmen.verilen_dersler.Length;

            // Yeni bir dizi oluştur, boyutu bir artır
            Ders[] yeniDizi = new Ders[diziBoyutu + 1];

            // Mevcut diziyi yeni diziye kopyala
            for (int i = 0; i < diziBoyutu; i++)
            {
                yeniDizi[i] = egitmen.verilen_dersler[i];
            }

            // Yeni dersi yeni dizinin sonuna ekle
            yeniDizi[diziBoyutu] = ders;

            // Egitmen sınıfındaki dizi referansını yeni diziye değiştir
            egitmen.verilen_dersler = yeniDizi;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Egitmen egitmen = new Egitmen();
            label8.Text = egitmen.verilen_dersler[0].egitmenAd;
            // İki sütun ekleme
            dataGridView1.Columns.Add("Column1", "Egitmen ID ");
            dataGridView1.Columns.Add("Column2", "Egitmen ");
            int egitmenID = Convert.ToInt32(txtIdEgitmen.Text); 
            for (int i = 0; i<egitmen.verilen_dersler.Length; i++)
            {
                if (egitmen.verilen_dersler[i].egitmen_ID == egitmenID)
                    txtIdEgitmen.Text = "";
                   dataGridView1.Rows.Add(egitmen.verilen_dersler[i].egitmen_ID, egitmen.verilen_dersler[i].egitmenAd);

            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            // DataGridView'e sütunlar ekliyoruz
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[1].Name = "Ders Adi";

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
