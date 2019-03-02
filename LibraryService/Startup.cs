using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AggregateModel;
using BooksDomain;
using CustomerDomain;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace LibraryService
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddScoped<ICustomerService, CustomerDomain.Service>();
            services.AddScoped<IBookService, BooksDomain.Service>();
            services.AddScoped<ICustomerInfrastructure, CustomerDomain.Infrastructure>();
            services.AddScoped<IBooksInfrastructure, BooksDomain.Infrastructure>();
            services.AddScoped<ICustomerAggregate, LoadCustomerDetailsAggregate>();
            services.AddScoped<IBookAggregate, LoadBooksDetailsAggregate>();
            services.AddCors();
            services.AddAuthentication(auth =>
            {
                auth.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                //auth.DefaultChallengeScheme = OpenIdConnectDefaults.AuthenticationScheme;
                auth.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            })
                    .AddCookie()
                    .AddOpenIdConnect();
            //services.AddAuthentication().AddOpenIdConnect


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            // app.UseCors(CorsOptions.AllowAll);

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseCors(builder =>
               builder.WithOrigins("http://localhost:4200"));

            

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
