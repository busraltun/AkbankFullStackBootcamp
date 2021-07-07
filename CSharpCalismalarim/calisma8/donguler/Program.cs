using System;

namespace donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            // C# da döngü deyimleri ; for, while, foreach
            
            Console.WriteLine("Lütfen bir sayı giriniz : ");
            int value =int.Parse(Console.ReadLine());

            for (int i = 1; i <= value; i++)
            {
                // i 0'dan başlayarak ve 1 arttırarak value'den küçük olduğu müddetçe for döngüsünde yer alan komutları çalıştır.
                //Kullanıcının girmiş olduğu sayı aralığındaki tek sayıları ekrana yazdırma


                if (i %2 == 1)
                   Console.WriteLine(i);
            }
// 1 ile 1000 arasındaki tek sayıların toplamını ve çift sayıların toplamını ekrana yazdırma

            Console.WriteLine("TEK SAYILARIN TOPLAMI İÇİN");
            int singleTotal = 0, evenTotal = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if( i %2 ==1)
                   singleTotal = singleTotal + i; //singleTotal += i ;
                else
                   evenTotal = evenTotal + i;    // evenTotal += i;

            }
            Console.WriteLine("Tek sayıların toplam sonucu : " + singleTotal);
            Console.WriteLine("Çift sayıların toplam sonucu : " + evenTotal);
// Döngülerle kullanabileceğimiz iki tane özel keyword vardır. Bunlar ; break ve continue 'dur.
            
            Console.WriteLine("*** break kullandığımızda oluşan sonuc **** ");           
            for (int i = 1; i < 10; i++)
            {
                if( i == 4)
                    break;
                    Console.WriteLine( i ) ; 
            }
/* Burada kullanmış olduğumuz break ile output olarak 1,2,3 sayılarını görürüz. Bu üç sayı ekrana yazdırılır ve
döngü sonlandırılır. */
             Console.WriteLine("*** continue kullandığımızda oluşan sonuc **** ");
            for (int i = 1; i < 10; i++)
            {
                if( i == 4)
                    continue;
                    Console.WriteLine( i ) ; 
            }
/* continue kullandığımızda ise sadece şartta koşulan durumu atlayıp döngüyü sürdürmeye devam etti. Böylelikle
output olarak 4 haricindeki sayıları yani 1,2,3,5,6,7,8,9 sayılarını görmüş olduk*/

                       /***** while döngüsü *****/
//1 den başlayarak konsoldan girilen sayıya kadar (sayı da dahil) ortalama hesaplayıp ekrana yazdırma işlemi
            Console.WriteLine("Lütfen bir sayı giriniz : ");
            int number = int.Parse(Console.ReadLine());
            int counter1 = 1,total = 0;
            while (counter1 <= number)
            {
                total += counter1;
                counter1 ++ ;
            }
            Console.WriteLine("Ortalama sonucu : " + total/number);

// A dan Z ye kadar tüm harfleri ekrana yazdırma
             char character = 'a';
             while (character <= 'z')
             {
                 Console.Write(character);
                 character ++;
             }

             /* ****** foreach ***** */
             Console.WriteLine(" ****** foreach örnek ****** ");
             string[] arabalar = {"BMW","FORD","TOYOTA","NISSAN"};
             foreach (var araba in arabalar)
             {
                 Console.WriteLine(araba);
             }

            Console.ReadKey();

        }
    }
}
