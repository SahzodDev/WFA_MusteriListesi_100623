namespace WFA_MusteriListesi_100623
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        List<Musteri> musterList = new List<Musteri>();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri();

            musteri.AdSoyad = txtAd.Text;

            try
            {
                musteri.Telefon = txtTelefon.Text;
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            musteri.Yas = int.Parse(nudYas.Text);
            musteri.Adres = txtAdres.Text;

            musterList.Add(musteri);

            txtAd.Clear();
            txtTelefon.Clear();
            txtAdres.Clear();
            nudYas.Value = 0;

            //MessageBox.Show($"Ad-Soyad : {musteri.AdSoyad}, Telefon : {musteri.Telefon}, Yaþ : {musteri.Yas}, Adres : {musteri.Adres}");
        }
        
        private void btnListe_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2(this);
            frm.Show();
        }

        public List<Musteri> ListeyeEris()
        {
            List<Musteri> list = new List<Musteri>();
            foreach (Musteri m in musterList)
            {
                list.Add(m);
            }
            return list;    
        }
        
    }
}