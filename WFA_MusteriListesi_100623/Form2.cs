using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_MusteriListesi_100623
{
    public partial class Form2 : Form
    {
        private Form1 _form1;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;
        }
        List<Musteri> musteris = new List<Musteri>();
        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {            
            foreach (Musteri musteri in _form1.ListeyeEris())
            {
                lstMusteri.Items.Add(musteri.AdSoyad);
                
            }

            foreach (Musteri musteri1 in _form1.ListeyeEris()) 
            {
                musteris.Add(musteri1);
            }
        }

        

        private void lstMusteri_DoubleClick(object sender, EventArgs e)
        {
            foreach (Musteri musteri in musteris) 
            {
                if (musteri.AdSoyad == lstMusteri.SelectedItem) 
                {
                    MessageBox.Show($"Ad Soyad : {musteri.AdSoyad}\nTelefon : {musteri.Telefon}\nYaş : {musteri.Yas}\nAdres : {musteri.Adres}");
                }
            }
        }
    }
}
