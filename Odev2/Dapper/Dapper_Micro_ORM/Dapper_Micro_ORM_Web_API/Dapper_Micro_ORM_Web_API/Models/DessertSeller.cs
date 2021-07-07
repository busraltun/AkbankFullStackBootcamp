using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dapper_Micro_ORM_Web_API.Models
{
    public class DessertSeller
    {
        [Key] //SellerId nin primary key olduğunu vurguluyoruz.
        public int SellerId { get; set; }
        public string SellerName { get; set; }
        public string SellerStoreName { get; set; }
        public string SellerAddress { get; set; }
        public string SellerTel { get; set; }
        public int SellerRating { get; set; }

        //Burada satıcımızın özelliklerini property çerçevesinde oluşturmuş olduk.
        //Bunları veri tabanında da tablonun kolonlarında yine bu isimlerde oluşturdum. Çünkü böyle gerekiyor dapper ı kullanmam için.
        //Çünkü sonuçta dapper micro orm kullanacağım ve bir eşleme yapılacak.

    }
}
