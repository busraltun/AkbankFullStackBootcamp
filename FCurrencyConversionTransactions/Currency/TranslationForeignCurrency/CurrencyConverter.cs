using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace TranslationForeignCurrency
{

    public class CurrencyConverter
    {
        public decimal Get(string from, string to, decimal value)
        {
            if (from.ToLower() != "usd")
            {
                decimal usdBaseValue, valueUsdRate, usdTargetRate ;
                ExchangeRatesDataSource.ExchangeRates.TryGetValue(from.ToUpper(), out valueUsdRate);
                 usdBaseValue = value / valueUsdRate;

                ExchangeRatesDataSource.ExchangeRates.TryGetValue(to.ToUpper(), out usdTargetRate);
                return usdBaseValue * usdTargetRate;
            }

            decimal usdTargetRate2;
            ExchangeRatesDataSource.ExchangeRates.TryGetValue(to.ToUpper(), out usdTargetRate2);
            return usdTargetRate2 * value;

        }
    }
}
