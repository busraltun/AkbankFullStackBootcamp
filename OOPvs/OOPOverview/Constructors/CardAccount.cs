using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class CardAccount
    {
        public int Limit { get; set; }
        public string Type { get; set; }
        /* public CardAccount() //varsayılan constructor tam olarak bu . Burada şu an herhangi bir şey döndürmüyor yani tek yaptığı şey instance ı oluşturmak.
         {
             Limit = 5000;
             Type = "Credit Card";

             //yani parametre vermezsek tür kredi kartı limit 50000 tl
         }
         /* 
          Bir sınıftan nesne üretmek için contructor zorunludur.
        Bu ifadeyi this keyword ' ü sayesinde aşağıdaki şekilde yazmak yeterli olacaktır.
         */
        public CardAccount() : this(5000, "Credit Card")
        {
           // Limit = 5000;
           // Type = "Credit Card";
        }

        public CardAccount(int limit) : this (limit,"Credit Card") //Müşteri kart seçerken 10000 tl lik kartı isteyebilir
        {
            //Limit = limit;
           //Type = "Credit Card";

        } 
        public CardAccount(string type) : this(5000,type)//Müşteri kart seçerken kredi kartı yerine banka kartı isteyebilir
        {
            //Limit = 5000;
            //Type = type;

        }
        public CardAccount(int limit, string type) //Müşteri 20000 TL limite sahip ticari kartı isteyebilir.
        {
            Limit = limit;
            Type = type;

        }
    /*Tabi ki her seferinde constructor ları bu şekilde oluşturmayacağız. Burada sadece constructor mantığının oturması açısından
     örnek çalışma yapılmıştır.
 Bir de şöyle bir durum var : Eğer birbirlerini tamamlayabilecek yani birbirlerinden çağrılabilecek constructor varsa bunları 
nasıl birleştiririz.

        Örneğin yukarıda yer alan ifadeler contructor değil de metot olsaydı, ilk yazdığımız metottan (2. ve 3. yazdığımızdan da )
    son yazdığımız metotu çağırırdık. Çünkü en genel ifade o. Peki işin içinde constructor varsa bunu nasıl yapacağız ?
    Bir constructor dan başka bir constructor ı nasıl çağırırız ? this keyword ' ü ile.

        Dependency : Bağımlılık, o olmadan çalışmaması Örneğin pil olmadan mouse çalışmaz ya da elektrik olmadan televizyon çalışmaz
    Demek ki nesnelerin de bu tarz bağımlılıkları var. İşte bazen biz bu bağımlılıkları dışarıdan yönetiyoruz, constructor lar aracılığıyla
    Yani nesneyi üretirken ( mouse'u çalıştır, bu pille çalıştır instance' nı al dediğimizi hayal edelim) 

 */
    }
}
