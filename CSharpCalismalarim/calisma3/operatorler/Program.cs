using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
/* Bu çalışma operatörler konusunun örneklerini içermektedir.*/ 
            //Atama ve işlemli atama operatörleri
            int x = 3;
            int y = 3;
            y = y + 2; //Bu ifade ile y += 2; ifadesinin sonucu aynı döner.
            Console.WriteLine(y);
            y /= 1 ;
            x += 5 ;
            Console.WriteLine("X :" + x + " " +  "Y :" + y);
            Console.WriteLine(x + y);

            //Mantıksal operatörler ||░ : veya, && : ve , ! : değil

            bool isSuccess = true;
            bool isCompleted = false;

            if(isSuccess && isCompleted) //burada if bloğunun içerisi true && false = false olduğundan ötürü atlar.
                Console.WriteLine("Perfect!");
            //Output : bu kod bloğu çalışır hata vermez fakat ekranda bir şey göstermez.

            if (isSuccess || isCompleted) //burada if bloğunun içerisi true || false = true olduğundan kod çalışır ve ekrana çıktı verir.
                Console.WriteLine("waaww!");
            //Output : Great !

            if (isSuccess && !isCompleted)//burada if bloğunun içerisi true && true = true olur.Dolayısıyla kod çalışır ve ekrana çıktı verir.
               Console.WriteLine("Fine!");
            //Output : Fine!
            
            //İlişkisel operatörler ; < ,> , <= , >= , == , != :(eşit değildir)

            int number1 = 3 ;
            int number2 = 4 ;

            bool thing = number1 < number2 ;
            Console.WriteLine(thing);
            //Output : true

            thing = number1 > number2 ;
            Console.WriteLine(thing);
            //Output : false

            thing = number1 <= number2 ;
            Console.WriteLine(thing);
            //Output : true

            thing = number1 >= number2 ;
            Console.WriteLine(thing);
            //Output : true

            thing = number1 == number2 ;
            Console.WriteLine(thing);
            //Output : false

            thing = number1 != number2 ;
            Console.WriteLine(thing);
            //Output : true
            
            
            //Aritmetik operatörler : / , * , + , - , % :(mod,kalan)
            int sayi1 = 10;
            int sayi2 = 5;
            int sonuc1 = sayi1/sayi2;
            Console.WriteLine(sonuc1);
            //Output : 10/5 = 2 sonucu döner

            sonuc1 = sayi1 + sayi2;
            Console.WriteLine(sonuc1);
            //Output : 10 + 5 = 15

            sonuc1 = sayi1 - sayi2;
            Console.WriteLine(sonuc1);
            //Output : 10-5 = 5

            sonuc1 = sayi1 * sayi2;
            Console.WriteLine(sonuc1);
            //Output : 10*5 = 50

            sonuc1 = sayi1 % sayi2;
            Console.WriteLine(sonuc1);
            //Output : 10 / 5 'İ n kalanı nedir ? 0 döner

            sonuc1 = sayi1++;
            Console.WriteLine(sonuc1); //Burada şöyle bir şey var , diyoruz ki önce sayi1 i yaz sonra 1 arttır. 
            //Output : 10

            // sonuc1 = ++sayi1;
            // Console.WriteLine(sonuc1);
            // Output : 11
Console.ReadKey();

        }
    }
}
