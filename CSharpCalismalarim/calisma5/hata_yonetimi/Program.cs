using System;

namespace hata_yonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
/*Hataları iki farklı gruba ayırabiliriz; compiler time ce run time şeklinde. Compiler error derleyicinin
döndürdüğü hatalardır, henüz biz kod yazarken dönen hatalar diye düşünebiliriz. runtime daki hataları handle 
etmek yani yakalamak gerekiyor ki başka bir probleme yol açmasın.*/
            try
            {
                //Hataya neden olabilecek, hata vermesi muhtemel kod burada yer alır
            Console.WriteLine("Bir sayi giriniz : ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Girmiş olduğunuz sayi : " + number );
/* Bu kod çalıştığında hata fırlatacaktır. Dolayısıyla hata fırlatıldığında catch bloğuna gidip exception
yakala diye bir ifade belirtmemiz lazım Exception sınıfından

            */
            }
            catch(Exception ex) // gelecek olan hatanın adını ex diye adlandırdık. Ayrıca ex bir obje konumundadır.
            {
                //Burada da hatayı yakaladığımızda nasıl, ne tür bir işlem yapmak istersek belirtebiliyoruz.
                Console.WriteLine("Hata : " + ex.Message.ToString());

/*Bazı özel exception türleri vardır. Hatanın yakalanması durumunda tipi anlayan hangi koşulda hata fırlattığını bilen özel exeception'lardır
 bunlar. Her seferinde bir hata oluştu yerine örneğin ; null kaynaklı bir hatanın neticesinde boş değer girdiniz şeklinde hataların dönmesini sağlayabiliriz. 
 Bu special exceptions messages için user friend olduklarını söylemek de mümkündür.     
*/          }
            finally
            {
                //Hata var veya yok ben bu kodun muhakkak çalışmasını istiyorsam kullanıcıya göstermek istiyorsam bu kapsamda yazmalıyım.
                //Bu kısım isteğe bağlı olarak yazılabilir, finally bloğu yani, zorunlu değildir.
                Console.WriteLine("Completed!");
            }

               //User Friend Exception Örnekleri

               try
               {
                   int a = int.Parse(null); //Parse metodu string ifadeleri int 'e çevirmek için kullanılır.

               }
               catch (ArgumentNullException ex)
               {
                   
                   Console.WriteLine("BOŞ DEĞER GİRDİNİZ !!! ");
                   Console.WriteLine(ex);
                   //Output :BOŞ DEĞER GİRİNİZ System.ArgumentNullException: Value cannot be null. (Parameter 's') at System.Int32.Parse(String s at hata_yonetimi.Program.Main(String[] args)
               }

               try
               {
                   int b = int.Parse("test");
                   //integer' a parse edilemeyen bir string girdik
               }
               catch (FormatException ex) // FormatException bu durumun uygun olmadığı hatasını döner
               {
                   Console.WriteLine("veri tipi uygun değil !!!");
                   Console.WriteLine(ex);
                   //Output: veri tipi uygun değil !!! System.FormatException: Input string was not in a correct format. at System.Number.ThrowOverflowOrFormatException(ParsingStatus status, TypeCode type) at System.Number.ParseInt32(ReadOnlySpan`1 value, NumberStyles styles, NumberFormatInfo info) at System.Int32.Parse(String s) at hata_yonetimi.Program.Main(String[] args) in line 56
               }
            
            try
            {
                int c = int.Parse("-20000000000"); //burada int' in değer aralığını aşmış olduk 
            }
            catch (OverflowException ex)
            {
                
                Console.WriteLine("Çok küçük veya çok büyük deger girdiniz...");
                Console.WriteLine(ex);
/*Output : Çok küçük veya çok büyük deger girdiniz. System.OverflowException: Value was either too large or too small for an Int32.
at System.Number.ThrowOverflowOrFormatException(ParsingStatus status, TypeCode type) at System.Number.ParseInt32(ReadOnlySpan`1 value, NumberStyles styles, NumberFormatInfo info)
at System.Int32.Parse(String s) at hata_yonetimi.Program.Main(String[] args) in Program.cs:line 68 */
            }

            Console.ReadKey();
        }
    }
}
