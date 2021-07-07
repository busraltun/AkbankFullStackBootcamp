using Hangfire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TranslationForeignCurrency
{
    public static class HangfireRecurringJob2
    {
        public static void UpdateExchangesRatesAt15()
        {
            RecurringJob.AddOrUpdate<UpdateExchangeRatesJob2>(nameof(UpdateExchangeRatesJob2),
                      job => job.Process(), "00 10 * * *", TimeZoneInfo.Local);
        }
    }
}
