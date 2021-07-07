using System;

namespace metot
{
    class Program
    {
        static void Main(string[] args)
        {
/*Metotlardan kastımız fonksiyonlardır.Bir programı parçalamak için metotları (fonksiyonları) kullanırız.Böylelikle
kod tekrarını azaltmış oluruz ve aynı zamanda kodun okunabilirliğini de arttırmış oluruz.
Metotlar tek başlarına yazılan, tek başına çağrılan yapılar değildir. Metotları bir class içerisinde yazmamız
gerekmektedir. Metotun adı ile metotun bulunduğu class içerisinden erişim sağlamak mümkündür. Fakat bir metot 
başka bir class içerisinde yazılmışsa ve biz de başka bir class içerisinden bu metota erişmek istiyorsak 
o class ın bir instance nı oluşturmamız gerekiyor. Böylelikle bu ınstance sayesinde erişmek istediğimiz metota
erişim sağlayabiliriz.
public : metoda her yerden erişmek mümkündür
private : metoda sadece tanımlandığı class içerisinden erişilebilir
Her metodun bir geri dönüş tipi (int, var, string vb) olmak zorunda değildir. Geri dönüş olmadığını geri dönüş tipine
void yazarak belirtebiliriz.
Metodun yapısı : erişim_belirteci  geri_dönüş_tipi  metot_adi ( parametreListesi/Argüman)
static olan bir class içerisinden sadece static metotlar erişilebilir
*/
           int number1 = 2, number2 = 3 ;
           Console.WriteLine(number1 + number2);

           int result = Total (number1,number2);
           Console.WriteLine(result);

           Methods instance = new Methods();
           instance.WriteConsole(Convert.ToString(result));  
           
           int result2 = instance.ArttırTopla( number1, number2);
           instance.WriteConsole(Convert.ToString(result2));
           instance.WriteConsole(Convert.ToString(number1 + number2));
           
           Console.ReadKey();

        }

      static int Total (  int value1 ,  int value2)
        {
            return ( value1 + value2);
        }
    }
    class Methods 
    {
      public void  WriteConsole (string data)
        {
            Console.WriteLine(data);
        }
        public int ArttırTopla(int value1, int value2)
        {
            value1 += 1;
            value2 += 1;
            return value1 + value2 ;
        }
    }
}
 //CALLBACK VALUE //değer tipinde parametre ataması