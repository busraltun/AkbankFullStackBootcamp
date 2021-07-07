using System;
using System.Linq;

namespace TelefonRehberUygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteStartScreen();
        }




        static void WriteStartScreen()
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) ");
            Console.WriteLine(" *******************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak");

            int processType = int.Parse(Console.ReadLine());
            RouteProcess(processType);
        }



        static void RouteProcess(int processType) //KULLANICININ GİRDİĞİ DEĞER
        {
            switch (processType)
            {
                case 1: AddPerson(); break;
                case 2: DeletePerson(); break;
                case 3: UpdatePerson(); break;
                case 4: ListPersons(); break;
                case 5: FindPerson(); break;

            }
        }




        static void AddPerson()
        {
            Person person = new Person();
            Console.WriteLine("Lütfen isim giriniz.");
            person.Name = Console.ReadLine();
            Console.WriteLine("Lütfen Soyisim Giriniz.");
            person.LastName = Console.ReadLine();
            Console.WriteLine("Telefon Numarası Giriniz.");
            person.PhoneNumber = Console.ReadLine();

            //İŞLEMİ YAP
            PersonManager _pm = new PersonManager();
            bool result = _pm.AddPerson(person);

            //SONUCUNU EKRANA YAZDIR
            if (result == true)
                Console.WriteLine("Kişi Başarıyla Eklendi.");
            else
                Console.WriteLine("Kişi Eklenirken Bir Hata Oluştu.");

            //ANAASAYAYA DÖN
            WriteStartScreen();


        }




        static void DeletePerson()
        {
            Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
            string nameOrLastName = Console.ReadLine();

            PersonManager _pm = new PersonManager();
            Person findPerson = _pm.FindPerson(nameOrLastName);

            //KİŞİ BULUNAMADIYSA
            if (findPerson == null)
            {
                Console.WriteLine("Aradığınız krtiterlere uygun kişi rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Anasayfaya Dön : (1)");
                Console.WriteLine("* Yeniden denemek için : (2)");

                int value = int.Parse(Console.ReadLine());

                if (value == 1)
                    WriteStartScreen();
                else if (value == 2)
                    DeletePerson();

            }

            else
            {
                Console.WriteLine($"{findPerson.Name} {findPerson.LastName} İsimli Kişi Rehberden Silinmek Üzere.Onaylıyor musunuz? (y/n)");
                string confirmDelete = Console.ReadLine();

                if (confirmDelete == "y")
                {
                    bool result = _pm.DeletePerson(findPerson);
                    if (result == true)
                        Console.WriteLine("Kullanıcı Başarıyla Silindi.");
                    else
                        Console.WriteLine("Kullanıcı Silinirken Bir Hata Oluştu");

                    WriteStartScreen();
                }
                else if (confirmDelete == "n")
                {
                    Console.WriteLine("Silme İşlemi İptal Edildi.");
                    WriteStartScreen();
                }
            }
        }


        static void UpdatePerson()
        {
            Console.WriteLine("Lütfen numarasını güncelleme istediğiniz kişinin adını ya da soyadını giriniz:");
            string nameOrLastName = Console.ReadLine();

            PersonManager _pm = new PersonManager();
            Person findPerson = _pm.FindPerson(nameOrLastName); //101

            if (findPerson == null)
            {
                Console.WriteLine("Aradığınız krtiterlere uygun kişi rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Anasayfaya Dön : (1)");
                Console.WriteLine("* Yeniden denemek için : (2)");

                int value = int.Parse(Console.ReadLine());

                if (value == 1)
                    WriteStartScreen();
                else if (value == 2)
                    UpdatePerson();
            }

            else
            {
                Console.WriteLine("Güncellenecek Telefon Numarasını Giriniz.");
                string newPhoneNumber = Console.ReadLine();
                findPerson.PhoneNumber = newPhoneNumber;
                Console.WriteLine("Telefon Numarası Güncellendi.");
                var persons = PersonList.persons;
                WriteStartScreen();
            }
        }


        static void ListPersons()
        {
            var persons = PersonList.persons.ToList();

            Console.WriteLine("A-Z Listele (1)");
            Console.WriteLine("Z-A Listele (2)");

            int value = int.Parse(Console.ReadLine());

            Console.WriteLine("*****************************************");
            if (value == 1)
            {
                foreach (var person in persons.OrderBy(x => x.Name))
                {
                    Console.WriteLine("İsim " + person.Name);
                    Console.WriteLine("Soyisim " + person.LastName);
                    Console.WriteLine("Telefon " + person.PhoneNumber);
                    Console.WriteLine("-");
                }
            }

            else if (value == 2)
            {
                foreach (var person in persons.OrderByDescending(x => x.Name))
                {
                    Console.WriteLine("İsim " + person.Name);
                    Console.WriteLine("Soyisim " + person.LastName);
                    Console.WriteLine("Telefon " + person.PhoneNumber);
                    Console.WriteLine("-");
                }
            }


        }


        static void FindPerson()
        {
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("**********************************************");
            Console.WriteLine(" İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine(" Telefon numarasına göre arama yapmak için: (2)");

            PersonManager _pm = new PersonManager();
            int value = int.Parse(Console.ReadLine());

            if (value == 1)
            {
                Console.WriteLine("Arama Yapacağınız İsmi veya Soyisimi Giriniz : ");
                var persons = _pm.FindPersonsByName(Console.ReadLine());

                foreach (var person in persons)
                {
                    Console.WriteLine("İsim : " + person.Name);
                    Console.WriteLine("Soyisim : " + person.LastName);
                    Console.WriteLine("Telefon : " + person.PhoneNumber);
                }
            }

            else if (value == 2)
            {
                Console.WriteLine("Arama Yapacağınız Telefon Numarasını Giriniz : ");
                var persons = _pm.FindPersonByPhoneNumber(Console.ReadLine());

                foreach (var person in persons)
                {
                    Console.WriteLine("İsim : " + person.Name);
                    Console.WriteLine("Soyisim : " + person.LastName);
                    Console.WriteLine("Telefon : " + person.PhoneNumber);
                }
            }

            WriteStartScreen();
        }


    }
}
