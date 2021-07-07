namespace TelefonRehberUygulaması
{
    public class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }


        public Person(string name, string lastName, string phoneNumber)
        {
            this.Name = name;
            this.LastName = lastName;
            this.PhoneNumber = phoneNumber;
        }


        public Person()
        {

        }
    }
}