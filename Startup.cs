using Financial.Application.Protos;
using Financial_Client.Mapper;
using Financial_Client.Mapper.Interface;
using Financial_Client.Services;
using Financial_Client.Services.Interface;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Financial_Client
{
    public class Startup
    {
        private const string FINANCE_CLIENT = "GrpcSettings:UserUrl";
        private const string SWAGGERFILE_PATH = "./swagger/v1/swagger.json";
        private const string API_VERSION = "v1";
        public const string PROJECT_NAME = "Financial API";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddRazorPages();
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc(API_VERSION, new OpenApiInfo { Title = PROJECT_NAME, Version = API_VERSION });
            });
            services.AddGrpcClient<FinanceAccountsProtoService.FinanceAccountsProtoServiceClient>(options => options.Address = new Uri(Configuration[FINANCE_CLIENT]));
            services.AddGrpcClient<PaymentTermsProtoService.PaymentTermsProtoServiceClient>(options => options.Address = new Uri(Configuration[FINANCE_CLIENT]));
            services.AddScoped<IFinanceAccountsService, FinanceAccountsService>();
            services.AddScoped<IPaymentTermsService, PaymentTermsService>();
            services.AddScoped<IPaymentTermsItemsService, PaymentTermsItemsService>();
            services.AddScoped<IMapperService, MapperService>();
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            // Swagger
            app.UseSwagger()
               .UseSwaggerUI(c =>
               {
                   c.RoutePrefix = string.Empty;
                   c.SwaggerEndpoint(SWAGGERFILE_PATH, PROJECT_NAME + API_VERSION);
               });

            //app.UseHttpsRedirection();
            //app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapRazorPages();
                endpoints.MapControllers();
            });
        }
    }
}
