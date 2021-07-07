using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOverview
{
    class Film
    {
        //ideamızı oluşturalım. public bilinen en kolay erişim belirtecidir.Nesneye ait nesneden erişilebilecek her şey public'tir.
        private string name;
        public string rating;
        //public int price; //burada int yerine decimal kullanmak daha doğru olurdu fakat ben int veri tipini kullanmak istedim.
        private int price;

        /*Buraya kadar ideamızı oluşturmuş olduk. Fakat bu ideanın nesneleri Program çalıştığında alınacak. 
        Yani şu kısma kadar henüz bir nesnemiz yok diyebiliriz. Yani filmin nesnesi halen yok. Ayrıca nesne 
        oluştuğunda buradaki bu idealar bellekte heap kısmında yer alacak.
        */

        public void SetValuePrice(int price)
        {
            if (price < 0)
            {
                throw new Exception("Yaşını neden eksi değer olacak kadar küçük gösteriyorsun, tekrar dene !!");
            }
            this.price = price;
        }

        public int GetValuePrice()
        {
            return price;
        }

        //C# ta get set yöntemi bir arada aşağıdaki şekilde oluşturulur
        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Filmin adını boş bıraktınız");
                }
                name = value;
            }
        }
        public bool IsThereMovie { get; set; }
        /* Burada set çalıştığı anda .NET arka planda RAM 'de primitive boolean tanımlıyor hemen o anda. Eğer setlemezsek tanımlamıyor.
         */
        public DateTime ReleaseDate { get; private set; } //sadece birini private yapabiliriz.
                 
      //set ile dışarıdan değer atama , get ile atandığı değer okunabilecek.
                                                          
      //Her Film nesnesinin ................. vardır. 
      // Her film ....... yapar/ ile ............ yapılır. (Bu da fonskiyonlarımızdır)

    }
}
