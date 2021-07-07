using System;

namespace encapsulatıon
{
    class Program
    {
        static void Main(string[] args)
        {
            //PROPERT : GET, SET

            Ogrenci ogrenci = new Ogrenci ();
            ogrenci.Isim = "Büşra";
            ogrenci.Soyisim = "Altun";
            ogrenci.OgrenciNO = 293 ;
            ogrenci.Sinif = 3;
            ogrenci.OgrenciBilgileriGetir();

            ogrenci.SinifAtlat();
            ogrenci.OgrenciBilgileriGetir();
            
        }
    }
    public class Ogrenci
    {
        private string isim ;
        private string soyisim ;
        private int ogrenciNO ;
        private int sinif ;

        public string Isim
         {
              get {return isim;}
              set {isim = value;}
         }
        public string Soyisim
         {
             get => soyisim; 
             set => soyisim = value; 
        }
        public int OgrenciNO 
        {
             get => ogrenciNO; 
             set => ogrenciNO = value;
        }
        public int Sinif 
        { 
            get => sinif;
             set
             {
                 if(value <= 1)
                 {
                     Console.WriteLine ("Sınıf en az 1 olmalıdır");
                     sinif = 1;
                 }
                 else
                    sinif = value;
             }
        }

        public Ogrenci(string ısim, string soyisim, int ogrenciNO, int sinif)
        {
            Isim = ısim;
            Soyisim = soyisim;
            OgrenciNO = ogrenciNO;
            Sinif = sinif;
        }
        public Ogrenci ()
        {
            
        }

        public void OgrenciBilgileriGetir ()
        {
            Console.WriteLine("Öğrenci Bilgileri");
            Console.WriteLine("Öğrenci Adı    : {0}",this.Isim);
            Console.WriteLine("Öğrenci Soyadı : {0}",this.Soyisim);
            Console.WriteLine("Öğrenci No     : {0}",this.OgrenciNO);
            Console.WriteLine("Öğrenci Sınıf  : {0}",this.Sinif);
        }

        public void SinifAtlat ()
        {
            this.Sinif = this.Sinif + 1;
        }
        public void SinifDüşür ()
        {
            this.Sinif = this.Sinif - 1;
        }
    }
}
