using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_MusteriListesi_100623
{
    public class Musteri
    {
        public string AdSoyad {  get; set; }
        private string telefonNo;

        public  string Telefon
        {
            get 
            { 

                return telefonNo; 
            }
            set 
            {
                long tempTel;
                if (Int64.TryParse(value, out tempTel) && value.ToString().Length == 10)
                {
                    telefonNo = value;
                }
                else
                {
                    throw new Exception("Geçersiz telefon numarası.");
                }
                    
            }
        }

        public int Yas {  get; set; }
        public string Adres {  get; set; }
    }
}
