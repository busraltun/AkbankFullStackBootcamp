using System;

namespace soru4
{
    class Program
    {
        /*
        Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin.
         Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
        */
        static void Main(string[] args)
        {
            var letterNum = 0;
            var wordNum = 0;
            bool newWord = true;

            Console.WriteLine("Lütfen bir cümle yazın : ");
            string sentence = Console.ReadLine();
            for (int i = 0; i < sentence.Length; i++)
            {
                if (char.IsLetter(sentence[i]))
                {
                    letterNum++;
                    if (newWord)
                    {
                        wordNum++;
                        newWord = false;
                    }
                }
                else if (char.IsSeparator(sentence[i]))
                {
                    newWord = true;
                }
            }

 Console.WriteLine($"Toplam {letterNum} harf, {wordNum} kelime");
        }

    }
}
