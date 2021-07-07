using Hangfire;
using Hangfire.SqlServer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TranslationForeignCurrency
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            services.AddSingleton<CurrencyConverter>();
            services.AddHangfire(
                config =>
                {
                    var option = new SqlServerStorageOptions
                    {
                        PrepareSchemaIfNecessary = true,
                        QueuePollInterval = TimeSpan.FromMinutes(5),
                        CommandBatchMaxTimeout = TimeSpan.FromMinutes(5),
                        SlidingInvisibilityTimeout = TimeSpan.FromMinutes(5),
                        UseRecommendedIsolationLevel = true,
                        DisableGlobalLocks = true

                    };
                    config.UseSqlServerStorage(@"Server=DESKTOP-377D1BB;Database=Hangfire;Trusted_Connection=True;MultipleActiveResultSets=True", option)
                    .WithJobExpirationTimeout(TimeSpan.FromHours(6));
                });
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "TranslationForeignCurrency", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "TranslationForeignCurrency v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseHangfireDashboard("/BackgroundJobs", new DashboardOptions
            {
                DashboardTitle = " Büþra Altun Hangfire Dashboard",  //TITLE
                AppPath = "/weatherforecast"   //BACK TO SITE
            });
            app.UseHangfireServer(new BackgroundJobServerOptions()
            {
                //5 SANiYEDE BÝR KONTROL ET
                SchedulePollingInterval = TimeSpan.FromSeconds(5)
            });
            

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });


            HangfireRecurringJob.UpdateExchangesRatesAt10();
            HangfireRecurringJob2.UpdateExchangesRatesAt15();

        }

    }
}
