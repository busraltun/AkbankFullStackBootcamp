using System;

namespace degiskenler_ve_veri_türleri
{
    class Program
    {
        static void Main(string[] args)
        {
/*Bazı veri türleri ; int, string, char, bool, decimal, float, double, datetime, object, short, uint, long....
Veri türleri bize verilerin nasıl işleneceği ve depolanacağı noktasında bilgi verir. Değişkenin depoladığı verinin
yani değerin veri tipi bize veri türünü ifade eder şeklinde de düşünebiliriz.
Değişkenleri veri tutucu yani depolayıcı olarak düşünebiliriz. Bir değişkeni tanımlamada değerin neyi temsil
ettiği manasız kalır, belirsiz olur. C# içerisinde de değişkenleri yazarken belli başlı kurallara dikkat etmemiz
lazım. Bunlardan bazıları; değişken ismi sayı ile başlamamalı, C# a özel olan keyword leri içermemelidir.
*/

/*                                  ÖRNEKLER                                                     */

            //string veri tipini kullanarak konsola isim soyisim yazdırma  
            string name     = "Büşra";
            string surName  = "Altun";
            string fullName = name + " " + surName;
            Console.WriteLine(fullName); 
            // Output : Büşra Altun
            

            //int veri tipini kullanarak çarpma işleminin sonucunu konsola yazdırma
            int number1 = 5, number2 = 10, multiplication;
            multiplication = number1 * number2 ;
            Console.WriteLine(multiplication);
            // Output : 50
            
            
            //bool veri tipi ile bir örnek
            bool small = 10<2;
            Console.WriteLine(small);
            bool big = 10>2;
            Console.WriteLine(big);
            //Output : false-true
           

/*  
Değişkenler konusunda bir de dönüştürme mevzusu vardır. Yani değişken dönüştürme. Örneğin int veri türüyle 
tanımlanmış ve depolanmış olan bir değeri string şekilde yazmamız gerektiğinde toString() metodunu kullanırız.
*/
             int number_int = 20 ;
             string number_string = "22" ;
             string newValue = number_int.ToString() + number_string;
             Console.WriteLine(newValue);
             //Output : 2021

             int new_value = number_int + Convert.ToInt32(number_string);
             Console.WriteLine( new_value );
             //Output : 41

             int conversion = number_int + int.Parse(number_string); // string ifadeyi int veri türüne dönüştürmek için diğer bir seçenek
             Console.WriteLine(conversion);
             //Output : 41

//Şimdi de datetime ı string ifadeye dönüştürmek için bir örnek bırakıyorum.

            string date_time = DateTime.Now.ToString("dd.MM.yyyy") ; // Yalnızca güni ay ve yılı istemiş olduk.
            Console.WriteLine(date_time);
            //Output :  şu an ki tarihi gösterir örneğin : 24.05.2021 gibi
/* 
Burada MM ifadesini küçük harfle yazınca 05 olan ay değeri 50 şeklinde dönüyor. 4 karakterden oluşan yıl ifadesi
(yyyy) yerine yy yazınca da yılın son iki hanesini alıyor örneğin 2021 deki 21 gibi. Gün, ay ve yıl arasına dot(.)
değil de - belirteci görünsün istiyorsak da dd-MM-yyyy şeklinde yazmamız gerekir.
*/
            string dateTime = DateTime.Now.ToString("dd-MM-yyyy") ; 
            Console.WriteLine(dateTime);

            DateTime date_time_now = DateTime.Now;
            Console.WriteLine(date_time_now);
            //Output : Tarih ve saati birlikte gösterir . Örnek çıktı : 24.05.2021 20 : 00 gibi.

            string hour = DateTime.Now.ToString( "HH:mm");
            Console.WriteLine(hour);
            //Output : 20:02 şeklinde bulunduğumuz saati ve dakikayı gösterir.
            
             Console.ReadKey();


        }
    }
}
