using Hangfire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TranslationForeignCurrency
{
    public static class HangfireRecurringJob
    {
        public static void UpdateExchangesRatesAt10()
        {
         RecurringJob.AddOrUpdate<UpdateExchangeRatesJob>(nameof(UpdateExchangeRatesJob),
                   job => job.Process(), "00 15 * * *", TimeZoneInfo.Local);
        }


    }
}

