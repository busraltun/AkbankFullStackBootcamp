using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Miras genelleştirme ve özelleştirmedir. Miras her yerde zorunlu değildir, gerektiğinde kullanılır.
            Gamer gamer = new Gamer();
            gamer.GamersWeapon = new Ak47();

            Chef chef = new Chef();
            chef.Cook(new MeatBallFood());
        }
    }

    public class Chef
    {
        //Mesela düşünelim aşçı ne pişirir yemek, fakat bu çok geneldir. Özele indirgediğimizde tatlı da bir yemektir, çorba da, pirinç de, sebze de bu şekilde de özelleştirmiş oluyoruz.
       public void Cook (Food food)
        {
            food.Cook();
        }
    }
    public class Food 
    {
        public void Cook()
        {

        }
    }
    public class VegetablesFood : Food
    {

    }
    public class MeatFood : Food
    {

    }
    public class DessertsFood : Food
    {

    }
    public class MeatBallFood : MeatFood
    {

    }

    public class Gamer
    {
        public Weapon GamersWeapon { get; set; }
    }
    public class Weapon
    {
        //Her silahın ...... vardır.
        public int Weight { get; set; }
        public int StrikingPower { get; set; }

        public void Attack ()
        {

        }

    }
    //Oyuncunun silahı yukarıdaki ifadelerin değişmesi durumunda her şey olabilir. İşte o zaman miras almamız gerekiyor.

    public class FireArm :Weapon
    {

    }
    public class Gun : FireArm
    {

    }

    public class Knife : Weapon
    {

    }

    public class Rifle : FireArm
    {

    }
    public class Ak47 : Rifle
    {

    }
    //Nesneler birbirlerinin yerine kullanılabilirler.
    /*
      Soru1 - Senaryo1 
    Müşteri gelip bize satış yapabileceği bir uygulama istediğini söyledi. Sadece fiyatı, modeli, markası, satılıp satılmadığı bilgisi 
    lazım şeklinde bir istekte bulunuyor.

    Soru2 - Senaryo2
    Bir oyun firmasıyla anlaştığımızı varsayalım. Arabaları modifiye edebileceğimiz, her arabayı farklı bir değere ve farklı bir hıza
    sahip olabileceği bir oyun yazıyoruz.

    Bu 2 soru ve 2 senaryodan hangisinde miras olmasa da olur ( yoktur değil, tercih meselesi yani) hangisinde miras zorunludur ?

    !!!!CEVAP !!!!!
    SENARYO2 DİR. Görsel değişiklik mirası kullanmamıza mecbur bırakıyor.

    Burada dikkat etmemiz gereken nokta DAVRANIŞTIR. Nesnenin davranışı yazdığımız kodu değiştiriyorsa o başka bir nesnedir.
     */
}
