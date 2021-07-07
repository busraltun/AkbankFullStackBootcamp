using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TranslationForeignCurrency.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurencyController : ControllerBase
    {
        private readonly CurrencyConverter _currencyConverter;
        public CurencyController(CurrencyConverter currencyConverter)
        {
            this._currencyConverter = currencyConverter;
        }

        [HttpGet]
        [Route("convert/{value:decimal}/{from}/{to}") ]

        public IActionResult Convert(decimal value, string from, string to)
        {
            decimal convertedValue = _currencyConverter.Get(from, to, value);
            return Ok(convertedValue);

        }
    }
}
