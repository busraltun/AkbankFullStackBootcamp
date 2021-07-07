using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TranslationForeignCurrency
{
    public class UpdateExchangeRatesJob
    { 
        public void Process()
        {
            ExchangeRatesDataSource.GetRates();
        }
       
    }
}
