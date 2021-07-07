using System;

namespace Abstraction_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ürün tanımı bir abstractır, elle tutulabilir bir şey değildir. Fiziksel olarak ürün diye bir şey yok ama bardak bir üründür 
            fakat bardak deriz ona ürün değil, dolayısıyla ürün soyut bir anlam taşıyor.
            Dolayısıyla fiziksel olarak nesneye dönüşmeyecek fakat başka sınıflara miras vermek zorunda olan class lar yapmak = ABSTRACT
            Mesela döküman kelimesini kullanıyoruz. Döküman da bir abstractır. Çünkü döküman ama hangi döküman diye sorduğumuzda ; Word, Excel vb gibi 
            yanıtlar alabiliyoruz. Yani buradaki dökümanın görevi başka class lara miras vermek, onları çatısı altında gösterebilmek
                       */
        }
    }
            //Döküman Yönetim Sistemi : Word, Excell, Powerpoint .... gibi dökümanların bir arada bulunduğu sistem
        public abstract class Document
        {
            //Her döküman kopyalanabilir, taşınabilir, silinebilir. Bunlar normal class takiler gibi normal metotlardır. Ama kaydetme
            public void Copy(string from, string to)
            {
                Console.WriteLine("Copying...");
            }
        public void ChangeName ()
        {

        }

        public int Size { get; set; }

        /*PDF, Excell, Word : Hepsinin kaydetme streamleri farklıdır. Dökümanı kaydet dediğimizde nereye kaydedeceğimiz belli mi hayır .
        Bu konuda fikir shaibi olan ve bu işlemi gerçekleştirmek için bize yardımcı olacak olan yapı bu dökümanı miras alan class 'tır.

         */

        public abstract void Save();
        public abstract void Load();
       // public abstract void Print(); Aşağıya yetenek(ınterface) oluşturduğumuz için artık bunu kaldırıyoruz.Çünkü print işlevi bir abstract değil yetenektir.
        }

    public interface IPrintable
    {
        void Print();
    }
    public class WordDocument : Document , IPrintable //IPrintable yeteneğini bu şekilde ekleriz. Word dökümanı çıktı alma yeteneğine sahip.
    {
        public override void Load()
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            throw new NotImplementedException();
        }

        public override void Save()
        {
            throw new NotImplementedException();
        }

//Tüm dökümanların kaydet metodu olacak ama nasıl kaydedileceğini o dökümanı miras alan class karar verecek
    }

    public class PdfDocument : Document
    {
        public override void Load()
        {
            throw new NotImplementedException();
        }


        public override void Save()
        {
            throw new NotImplementedException();
        }
    }
    public class ExcellDocument : Document
    {
        public override void Load()
        {
            throw new NotImplementedException();
        }



        public override void Save()
        {
            throw new NotImplementedException();
        }
    }
}

/*Tam bu şekilde projeyi hazırladık bitirdik diyelim. Bu sefer tam bu esnada müşterimiz PDF lerin çıktısını alınmaması gerektiğini
belirtirse bu durumda ne yapmamız gerekir ?
yani  <<<<< public abstract void Print(); >>>> şunu dökümana koyamayacağımız anlamına geliyor bu.

Eğer bunu dökümanımıza koyamıyorsak bu bir yetenektir !!! YANİ INTERFACE ile halletmeliyiz.

Örneğin insan bir abstract classtır. Bu abstract classın çeşitli metotları vardır. Bu abstract class a abstract metot örnekleri vercek 
olursak bunlar; konuş, çalış, sorgula, düşün,eğitim al gibi işlevler olur. Çalış abstract metodumuz var 
çünkü herkes aynı şekilde çalışmıyor.

İnsan abstract classında kodYaz şeklinde bir abstract metot söz konusu değildir. Eğer böyle olsaydı tıpkı konuş abstract metodu gibi (
milyarlarca insana ait bi özellik ve metot olurdu. Yani milyarlarca insan kodYaz metoduna sahip olurdu herkes kod yazabilirdi.

Fakat bu bir yetenektir!!! Bizler bu yeteneği arayüzle-ınterface le . Bir şeyin , bir nesnenin arayüzüne bakarak onun ne yapacağını, onun
vazifesinin ne olduğunu anlarız.

Bu arada abstract classt tan instance olmaz.

Bir class birden fazla ınterface i implemente edebilir. Örneğin insan abstract classında hem kod yazma hem de resim çizme yetenekleri olabilir.
Ama bir class yalnızca tek class tan miras alabilir.
*/