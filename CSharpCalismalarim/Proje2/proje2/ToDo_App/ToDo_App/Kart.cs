using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_App
{
   public class Kart
    {
        /*
               Kart İçeriği:
         *Baslık
         *Icerik
         *Atanan Kisi (Takım üyelerişnden biri olmalı)
         *Büyüklük (XS, S, M, L, XL)
         */
        public string Baslik { get; set; }
        public string İcerik { get; set; }
        public int Atanan_Kisi { get; set; }
        public int Buyukluk { get; set; }
        
        public Kart(string baslik, string icerik,int atanan_kisi, int buyukluk) //constructor 
        {
            this.Baslik = baslik;
            this.İcerik = icerik;
            this.Atanan_Kisi = atanan_kisi;
            this.Buyukluk = buyukluk;
        }

        public Kart()
        {
        }
    }
}
