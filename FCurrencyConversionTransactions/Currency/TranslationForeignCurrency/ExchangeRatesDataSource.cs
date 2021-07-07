using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace TranslationForeignCurrency
{

    public static class ExchangeRatesDataSource
    {
        private static HttpClient httpClient;
        public static Dictionary<string, decimal> ExchangeRates;
        static ExchangeRatesDataSource()
        {
            httpClient = new HttpClient();
            GetRates();
            Debug.WriteLine("asdfgh");
        }
        public static async Task GetRates()
        {
            HttpResponseMessage response = await httpClient.GetAsync("https://openexchangerates.org/api/latest.json?app_id=d8b98a988f17484d91bcf48b3a80384d");
            if (response.IsSuccessStatusCode)
            {
                string rates = await response.Content.ReadAsStringAsync();
                var exchangeRates = JsonConvert.DeserializeObject<ExchangeRates>(rates);

                ExchangeRates = exchangeRates.Rates;
               
            }
        }
    }
}
