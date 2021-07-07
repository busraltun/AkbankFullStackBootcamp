using System;

namespace tip_donusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
                 /* TİP DÖNÜŞÜMLERİ
            Tip Dönüşümlerine Neden İhtiyaç Duyuyoruz ?
Bir değişken tanımlaması yaptığımızda bellekten o değişkenin tipine bağlı olarak bir alan tesis etmiş oluruz.
Bunu biliyoruz. Fakat tanımladığımız bu değişkene farklı veri tipinde bir değer atanması bellekte işlerin 
karışmasına neden olabilir. Ayrıca çoğu zaman uygulama yazarken farklı veri tipleri ile çalışmak
durumunda kalabiliriz. Bellekte işleri yoluna koyabilmek için bu tip durumlarda tip dönüşümü yapmamız gerekir.
Bunlar; implicit conversion ve explicit conversion' dır. İmplicit conversion da değişkenlerin kapasiteleri, bo-
yutları durumunu göz önünde bulundurmalıyız. 
İmplicit conversion : Bir değişkenin kendinen daha yüksek kapasiteli bir değişkene atanmasıdır. 
!!! Boyut sıralaması ; sbyte = byte < short = ushort < int = uint < long = ulong
                         |      |        |       |      |      |      |       |
                      8 bit   8 bit   16 bit  16 bit  32 bit  32 bit  64 bit 64 bit
                 */    

                   // ÖRNEKLER
        Console.WriteLine(" **** İmplicit Conversion ****") ;
                byte a = 5;
                sbyte b = 30;
                short c = 10;

                int d = a + b + c ;
                Console.WriteLine("d :" + d );

                long h = d;
                Console.WriteLine("h:" + h );

                float i = h;
                Console.WriteLine("i:" + i);

                string s = "busra" ;
                char f   =    'c' ; // Burada şunu fark ettim ; ' c ' yazınca yani boşluk bırakınca tek karakter durumundan çıkıyor yani boşlukları da karakter olarak saydığı için sanki string bir ifade olmuş oluyor bu yüzden de hata veriyor. Dolayısıyla boşluk bırakmadan direkt  'c' yazılmalı.
                object g = s + f;
                Console.WriteLine("g: " + g);

        Console.WriteLine(" **** Explicit Conversion ****");
                
                int x = 4 ;
                // byte y = x ; yazarsak hata alırız
                byte y = (byte)x ;
                Console.WriteLine("y:" + y);

                int z = 100 ;
                byte t = (byte)z;
                Console.WriteLine("t:" + t );

                float w = 10.3f;
                byte v = (byte)w;
                Console.WriteLine("v:" + v );

//çevrimlerde yani dönüşümlerde veri kaybı olabilir.
 
        Console.WriteLine(" **** ToString Metodu ****");

                int xx = 6;
                string yy = xx.ToString();
                Console.WriteLine("yy:" + yy );

                string zz = 12.5f.ToString();
                Console.WriteLine("zz:" + zz );

        Console.WriteLine(" *** System.Convert sınıfı ***");
                
                string s1 = "10", s2 = "20";
                int sayi1, sayi2, toplam;

                sayi1 = Convert.ToInt32(s1);
                sayi2 = Convert.ToInt32(s2);

                toplam = sayi1 + sayi2 ;
                Console.WriteLine("Toplam : " + toplam);

        Console.WriteLine ( "**** Parse Metodu ****");
             //Parse string ifadeleri dönüştürmek için kullanılan bir metottur ve her zaman içerisine string alır.   
                ParseMethod(); // parse ile işlem yapmak için ilk önce fonksiyonumuzu oluşturduk. Daha sonra bu kapsama alanından çıkıp public static kısmını aşağıdaki kapsama alanında oluşturuyorum.

                Console.ReadKey();
        }

        public static void ParseMethod()
        {
            string metin1 = "15";
            int rakam1 ;
            rakam1 = Int32.Parse(metin1);
            Console.WriteLine("Rakam1 : " + rakam1);

            string metin2 = "10,25";
            double double1;
            double1 = Double.Parse(metin2);
            Console.WriteLine("Double1 : " + double1);


        }
    }
}
