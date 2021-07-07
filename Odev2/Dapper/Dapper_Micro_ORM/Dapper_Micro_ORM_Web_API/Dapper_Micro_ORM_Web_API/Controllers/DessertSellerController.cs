using Dapper_Micro_ORM_Web_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dapper_Micro_ORM_Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DessertSellerController : ControllerBase
    {
        //Yeni bir denetleyici oluşturdum ve içerisine CRUD(ekleme silme güncelleme vb) işlemlerinin ayağa kaldırıldığı ifadeleri oluşturdum.
        private readonly DessertSellerRepository dessertSellerRepository;
        public DessertSellerController()
        {
            dessertSellerRepository = new DessertSellerRepository();
        }

        //GET ALL 
        [HttpGet]
        [Route("Get")]
        public IEnumerable<DessertSeller> GetAll()
        {
            return dessertSellerRepository.GetAll();
        }

        //GET By Id 
        [HttpGet]
        [Route("Get/{id}")]
        public DessertSeller GetById(int id)
        {
            return dessertSellerRepository.GetById(id);
        }

        //INSERT
        [HttpPost]
        public void Post([FromBody]DessertSeller dessertSeller)
        {
            if (ModelState.IsValid)
                dessertSellerRepository.Add(dessertSeller);
        }

        //UPDATE
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] DessertSeller dessertSeller)
        {
            dessertSeller.SellerId = id;
            if (ModelState.IsValid)
                dessertSellerRepository.Update(dessertSeller);
        }

        //DELETE
        [HttpDelete]
        public void Delete(int id)
        {
            dessertSellerRepository.Delete(id);
        }
    }
}
