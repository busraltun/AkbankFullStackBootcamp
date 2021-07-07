using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Dapper_Micro_ORM_Web_API.Models
{
    public class DessertSellerRepository
    {
        private string connect; //veritabanı bağlantısını sağlamak için

        public DessertSellerRepository() //veritabanına bağlantıyı gerçekleştimek için sınıf adında constructor 
        {
            connect = @"Data Source=DESKTOP-377D1BB;Initial Catalog=DessertSellerStore;Integrated Security=True";
        }

        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(connect);
            }
        }

        //.NET te dapper sayesinde veri tabanı bağlantısını gerçekleştirmiş oluyoruz.

        //INSERT İŞLEMİ
        public void Add(DessertSeller dessertSeller)
        {
            using (IDbConnection dbConnection = Connection )
            {
                string sql = @"INSERT INTO DessertStore (SellerName, SellerStoreName, SellerAddress, SellerTel, SellerRating )
                               VALUES( @SellerName, @SellerStoreName, @SellerAddress, @SellerTel, @SellerRating )";

                dbConnection.Open();
                dbConnection.Execute(sql, dessertSeller);
            }
        }

        //GET ALL

        public IEnumerable<DessertSeller> GetAll()
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sql = @" SELECT *FROM DessertStore ";

                dbConnection.Open();
               return dbConnection.Query<DessertSeller>(sql);
            }
        }
        
          //GET BY ID
        public DessertSeller GetById(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sql = @" SELECT *FROM DessertStore WHERE SellerId = @id ";

                dbConnection.Open();
                return dbConnection.Query<DessertSeller>(sql, new {id=id}).FirstOrDefault();
            }
        }

        //UPDATE
        public void Update (DessertSeller dessertSeller)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sql = @" UPDATE DessertStore SET 
                               SellerName = @SellerName,
                               SellerStoreName = @SellerStoreName,
                               SellerAddress = @SellerAddress,
                               SellerTel = @SellerTel,
                               SellerRating = @SellerRating 
                               WHERE SellerId = @SellerId";

                dbConnection.Open();
                dbConnection.Query(sql, dessertSeller);
            }
        }

        //DELETE
        public void Delete(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sql = @" DELETE FROM DessertStore  WHERE SellerId = @id";

                dbConnection.Open();
                dbConnection.Query<DessertSeller>(sql, new {id=id });
            }
        }

        //Burada using Dapper ve using Data namspacelerini oluşturmam gerekti çünkü bu ikisinin içerisinde yer alan bazı yapıları kullandım.
        //Mesela Execute() ifadesi
    }
}
