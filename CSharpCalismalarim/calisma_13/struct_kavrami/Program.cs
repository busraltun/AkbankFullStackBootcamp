using System;

namespace struct_kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            //referans tipli değişkenler belleğin heap kısmında, değer türlerindeki değişkenler belleğin stack kısmında yer alır.
            // struct değer tipindedir

            Dikdörtgen dikdörtgen = new Dikdörtgen ();
            dikdörtgen.KisaKenar = 3 ;
            dikdörtgen.UzunKenar = 4;

            Console.WriteLine("Class Alan Hesabı:{0}" ,dikdörtgen.Alan());

            Dikdörtgen_Struct dikdörtgen_struct ;
            dikdörtgen_struct.KisaKenar = 3 ;
            dikdörtgen_struct.UzunKenar = 4;

            Console.WriteLine("Class Alan Hesabı:{0}" ,dikdörtgen_struct.Alan());

        }
    }

    class Dikdörtgen
    {
        public int KisaKenar;
        public int UzunKenar;

        public long Alan ()
        {
            return this.KisaKenar * this.UzunKenar;
        }
    }
    struct Dikdörtgen_Struct
    {
        public int KisaKenar;
        public int UzunKenar;
        public long Alan ()
        {
            return this.KisaKenar * this.UzunKenar;
        }
    }
}
