using System;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /* ******* switch case yapısı ******* */

/* Bir koşul sağlandığında gerekli komutlar çalıştırıldıktan sonta break; ifadesi ile kontrol sonlandırılır. Bu demek oluyor ki her case ifadesi birbirinden farklı olmalıdır. Ve bir switch-case ifadesinde yalnızca bir case çalışmalıdır.

Peki kontrol edilen degisken hiç bir sabit ifadeye eşit değilse ne olacak ? Tam da bu noktada default case'ini görüyoruz. Bu durumda kod default kısmında belirtilen kod bloğunu çalıştırır.

Switch-Case ifadelerinde dikkat edilmesi gereken durumlar aşağıdaki gibidir:

Case ifadelerinin sırası önemli değildir.
Bilinenin aksine default ifadesi en son yazılmak zorunda değildir.
Default ifadesi zorunlu değildir. Yazılmasa da olur. 

*/ 

//DateTime dan yararlanarak şu an hangi ayda bulunduğumuzu string türüyle switch case yapısı sayesinde ekrana yazdırma işlemi

          int month = DateTime.Now.Month;
          switch(month)
          {
              case 1:
                    Console.WriteLine("Ocak");
              break;

              case 2:
                    Console.WriteLine("Şubat");
              break;
              
              case 3:
                    Console.WriteLine("Mart");
              break;
                
              case 4:
                    Console.WriteLine("Nisan");
              break;
              
              case 5:
                    Console.WriteLine("Mayıs");
              break;
                
              case 6:
                    Console.WriteLine("Haziran");
              break;
              
              case 7:
                    Console.WriteLine("Temmuz");
              break;
              
              case 8:
                    Console.WriteLine("Ağustos");
              break;
                            
              case 9:
                    Console.WriteLine("Eylül");
              break;
              
              case 10:
                     Console.WriteLine("Ekim");
              break;
                            
              case 11:
                     Console.WriteLine("Kasım");
              break;
                            
              case 12:
                     Console.WriteLine("Aralık");
              break;
              
              default :
                      Console.WriteLine("İşler yoluna gitmedi ve sana hangi ayda olduğunu söyleyemedim :(");
              break;

          }
          Console.ReadKey();
        }
    }
}
