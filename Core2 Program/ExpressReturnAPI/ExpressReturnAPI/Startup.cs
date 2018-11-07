using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExpressReturnAPI.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace ExpressReturnAPI
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
           // services.AddDbContext<UserDbcontext>(opt => opt.UseInMemoryDatabase());
            services.AddDbContext<ReturnHeadDbContext>(opt => opt.UseInMemoryDatabase());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IServiceProvider serviceProvider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }
            var context = serviceProvider.GetService<ReturnHeadDbContext>();
            AddTestData1(context);
            app.UseMvc();
        }

        private void AddTestData1(ReturnHeadDbContext context)
        {
            var Customer1 = new Customer
            {
                Id="1205",
                CompanyName="Volvo IT AB",
                LastName="Roger",
                MiddleName="",
                FirstName="Federer",
                PersonTitle="Mr",
                Gender="Male",
                CareOfName="Melka",
                AddressLine1="Lexington Avenue",
                AddressLine2 = "Street212",
                AddressLine3 = "",
                PostCode="SWI1234",
                CityName="Paris",
                County = "",
                State = "Paris",
                Province = "",
                Country = "France",
                CustomerType = "Business",
                IkeaFamilyNumber = "8749484",
                TaxRegNo = "",
                TaxIdType = "",
                OrganisationNumber = "54000-12343",
                PassportNumber = "FRA3524244",
                TelephoneHome="8987555321",
                TelephoneWork = "",
                TelephoneMobile = "0000005888",
                Fax = "",
                Email="roger@volvo.com",
                IdentityType="1205",
                IdentityNumber="",
                PreferedLanguage="FR",
                ContactType=""
            };
            context.CustomerDTOs.Add(Customer1);
            var lines = new List<Line>();
            lines.Add(new Line(){Id = "2345242",ItemId = "895554488",Quantity = 1,ReasonCode = "08",SubReasonCode = "05"});
            context.LineDTOs.Add(lines[0]);
            var returnHead = new ReturnHead
            {
                Id="EXPSE123456677",
                BuCode="703",
                TillNumber="12",
                Customer=Customer1,
                TransactionNumber = "1205",
                Lines=lines,
                Date = "21112018",
                OrderNumber = "7897653"
            };
            context.ReturnHeadDTOs.Add(returnHead);
            context.SaveChanges();
        }
    }
}
