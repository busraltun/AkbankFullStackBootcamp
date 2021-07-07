using System;

namespace karar_yapilari
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Saate göre selamlama senaryosu 
            int time = DateTime.Now.Hour;

            if(time >= 6 && time <=11 )
                Console.WriteLine("Günaydın :) ");
                
            else if (time <= 18 )
                Console.WriteLine("İyi Günler");
            else 
                Console.WriteLine("İyi Geceler!");

// Biz bu yukarıdaki ifadeyi daha kısa bir şekilde de ifade edebiliriz.
            string sonuc = time <= 18 ? "İyi Günler" : "İyi Geceler";
            Console.WriteLine(sonuc);

           string selamla = time >=6 && time < 11 ? "Günaydın" : time <= 18 ? "İyi Günler" : "İyi Geceler"; //Yukarıdaki if else bloklarını tek satırda yazmış olduk
            Console.WriteLine(selamla);

            Console.ReadKey();
        }
    }
}
