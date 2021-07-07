using System.Collections.Generic;

namespace TelefonRehberUygulaması
{
    public static class PersonList
    {
        public static List<Person> persons;


        static PersonList()
        {
            persons = SetPersons();
        }


        public static List<Person> SetPersons()
        {
            return new List<Person>()
            {
                new Person("Eren","Yılmaz","5464182562"),
                new Person("Aleyna","Zengin","5456124390"),
                new Person("Büşra","Altun","5428007513"),
                new Person("Hümeyra","Benli","5441204050"),
                new Person("İrem","Gülten","5433567215")
            };
        }
    }
}