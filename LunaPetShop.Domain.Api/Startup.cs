using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LunaPetShop.Domain.Infra.Contexts;
using LunaPetShop.Domain.Infra.Repository;
using LunaPetShop.Domain.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore.InMemory;
using Microsoft.EntityFrameworkCore;
using LunaPetShop.Domain.Handlers;
using LunaPetShop.Domain.Infra.Respositories;
using Newtonsoft.Json;
using MediatR;
using System.Reflection;
using LunaPetShop.Domain.Handlers.Products;

namespace LunaPetShop.Domain.Api
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
            services.AddMediatR(typeof(Startup));

            services.AddMvc()
             .AddNewtonsoftJson(
                options =>
                {
                    options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                });
            services.AddDbContext<LunaPetShopContext>(opt => opt.UseSqlServer(Configuration.GetConnectionString("connectionString")));
            // services.AddDbContext<LunaPetShopContext>(x => x.UseInMemoryDatabase("database"));

            //Users Services
            services.AddScoped<CreateUserHandler, CreateUserHandler>();

            //Pets Services

            services.AddScoped<CreatePetHandler, CreatePetHandler>();
            services.AddScoped<DeletePetHandler, DeletePetHandler>();
            services.AddScoped<UpdatePetHandler, UpdatePetHandler>();

            //Products
            services.AddScoped<CreateProductHandler, CreateProductHandler>();

            //Contracts
            services.AddScoped<IPetRepository, PetRepository>();
            services.AddScoped<IUserRepository, UserRepository>();

            services.AddMediatR(Assembly.GetExecutingAssembly());

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
