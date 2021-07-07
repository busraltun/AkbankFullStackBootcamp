using System;

namespace OOPOverview
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Film ideasından türeyen bir şey yazıyoruz şimdi yani nesnemizi oluşturuyoruz. idea nın instance ı nesnedir. nesne = instance
            Film comedyFilm = new Film(); //Film isimli ideadan comedyFilm adında bir nesne ürettik. Ve bu nesnenin adını, ıd sini, yayın tarihini değiştirebiliriz. comedyFilm nesnemiz bellekte stack de yer alır. Bir nesne bellekteki adresiyle tanımlanır.
            comedyFilm.Name = "Ajan";
            //comedyFilm.price = 500; SetValuePrice metodu sayesinde bunun yerine aşağıdaki satırı kullanırız.
            comedyFilm.SetValuePrice(500); //ARTIK SET İŞLEMİNİ GERÇEKLEŞTİRMİŞ OLDUK. Yani denetimi arkaya bıraktık. İşte buna kapsülleme yani encapsullatıon denir.
            comedyFilm.rating = "So comedy, great !"; //işte bu değerler artık heapte.
            comedyFilm.IsThereMovie = true; //burada set çalıştığı anda ... cümlenin devamı film.cs içerisinden okuyalım

            Film comedyFilm2 = comedyFilm;
            comedyFilm2.Name = "Hayat Güzeldir ";
            // comedyFilm2.price = 600; AssignValuePrice metodu sayesinde bunun yerine aşağıdaki satırı kullanırız.
            comedyFilm2.SetValuePrice(600);
            comedyFilm2.rating = "Thats amazing!";
            Console.WriteLine(comedyFilm.Name);
            Console.ReadLine();

            /* 
            Burada output olarak Hayat Güzeldir çıktısını alırız. Çünkü biz burada comedyFilm nesnesinin bellekteki
            adresine gidip o adresi artık comedyFilm2 ye vermiş oluyoruz. Dolayısıyla o adresin heapte ulaştığı name, 
            rating gibi ifadelerin değerlerini de değiştirdiğimizde çıktımız bu şekilde olmuş oldu.
             */
            //Yazdığım değer atamaların denetlenmesi önemlidir. Örneğin int Yas = -75 ; vermek her ne kadar olabilir gibi görünse de mantıken hatalıdır. Bir insanın yaşı - değer olamaz çünkü. İşte bu esnada devereye validatıon girer.
            /*Console.WriteLine("Lütfen fiyat giriniz : ");
            int priceValue= int.Parse(Console.ReadLine());
            if(priceValue<0)
            {
                throw new Exception("Yaşını neden eksi değer olacak kadar küçük gösteriyorsun, tekrar dene !!");
            }
            comedyFilm2.price = priceValue;*/

            /*Her seferinde bu hata denetimini bu şekilde yapmak güzel gibi görünse de yorucu ve eksik bir yaklaşımdır. Çünkü biz örneğin comedyFilm2 nin
             instance nı alıp başka yerlerde başka fiyatlara atamayacak mıyız acaba sadece burada mı kullanıp denetleyeceğiz. Bu yukarıdaki yaklaşımla gidersek
            bin tane comedyFilm2 instance mız olsa bin tane de if bloğumuz olacak demek olur e böyle bir şey mantıklı mı , değil. Bazı şeyler nesnelerin içerisinden
            kontrol edilmelidir. O zaman fiyata biz bir varidasyon uygulayalım ve Film.cs de public olan belirtecini private olarak değiştirelim ki kimse kafasına göre
            erişim sağlayamasın. private olarak değiştirdiğimizde ise şöyle bir durum ortaya çıkıyor Program.cs içerisinde price kullandığımız her yerde
            price kelimesinin altı kırmızı çizgi ile uyarı veriyor. Dolayısıyla fiyata yani price a değer atamak için bir yöntem kullanmalıyız. Bu yöntemi de
             Film.cs de public void SetValuePrice şeklinde oluşturalım. ARTIK SET İŞLEMİNİ GERÇEKLEŞTİRMİŞ OLDUK. Yani denetimi arkaya bıraktık. 
            İşte buna kapsülleme yani encapsullatıon denir. Şunu da eklemek gerekir price a erişmek için giriş veç ıkışı sınırlandırdık. Metot kendi içerisinde
            denetledi. Ama bizim fiyat (price) değerini dışarıdan okumamız gerekebilir. Mesela bu filmin fiyatı nedir diye sorduğumuzda price private olduğundan
            dolayı erişemeyiz . Dolayısıyla price a erişemediğimize göre bize price 'ı döndüren bir şeye ihtiyacımız var. O zaman da Film.cs içerisine
            public int GetValuePrice. Burada set,get yapısıyla ihtiyaç halinde validasyon uygulayacağımızı öğrenmiş olduk.
             */
            int comedyfilmPrice = comedyFilm2.GetValuePrice();


        }
    }
}
