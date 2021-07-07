using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberUygulaması
{
    //KİŞİ EKLEME-ÇIKARMA-GÜNCELLEME-LİSTELEME METHOTLARI
    public class PersonManager
    {
        public bool AddPerson(Person person)
        {
            try
            {
                PersonList.persons.Add(person);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }



        public Person FindPerson(string nameOrLastname)
        {
            //BULURSA PERSON DÖNER, BULAMAZSA NULL DÖNER
            return PersonList.persons
                .FirstOrDefault(x => x.Name.ToLower() == nameOrLastname.ToLower() || x.LastName.ToLower() == nameOrLastname.ToLower());
        }



        //İSİM-SOYİSİM ARAMASI
        public List<Person> FindPersonsByName(string nameOrLastname)
        {
            return PersonList.persons.Where(x => x.Name.ToLower() == nameOrLastname.ToLower() || x.LastName.ToLower() == nameOrLastname.ToLower()).ToList();
        }



        //TELEFON NUMARASI ARAMASI
        public List<Person> FindPersonByPhoneNumber(string phoneNumber)
        {
            return PersonList.persons.Where(x => x.PhoneNumber == phoneNumber).ToList();
        }




        public bool DeletePerson(Person deletePerson)
        {
            try
            {
                foreach (var person in PersonList.persons)
                {
                    if (person == deletePerson) //REFERANS TİP
                    {
                        PersonList.persons.Remove(person);
                        break;
                    }
                }

                return true;
            }
            catch (Exception )
            {
                return false;
            }

        }


    }
}
