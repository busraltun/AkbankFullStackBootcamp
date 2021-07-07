using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_App
{
   public class Kisiler
    {
        public int KisiId { get; set; }
        public string Name { get; set; }

        public Kisiler(int kisiid,string name)
        {
            this.KisiId = kisiid;
            this.Name = name;
        }
        //Kişileri, takım üyeleri için list oluşturduk ve orada tutuyoruz
        public static List<Kisiler> Kisilers;
        static Kisiler()
        {
            Kisilers = DefaultKisilers();
        }

        public static List<Kisiler> DefaultKisilers()
        {
            return new List<Kisiler>()
            {
                new Kisiler (1, "Büşra"),
                new Kisiler (2, "Melike"),
                new Kisiler (3, "İlkay"),
                new Kisiler (4, "Asel"),
                new Kisiler (5, "Yusuf"),

            };
        }
    }
}
