using Application.Services;
using Domain.Command;
using Domain.Interfaces;
using Infra.Data.Context;
using Infra.Data.Repository;
using Infra.Data.UoW;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using AutoMapper;
using Application.AutoMapper;

namespace Livraria.WebApi
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
            services.AddMvc();

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<LivrariaContext>();

            services.AddScoped<ILivroRepository, LivroRepository>();
            services.AddScoped<ILivroService, LivroService>();
            services.AddScoped<ILivroCommand, LivroCommand>();

            services.AddAutoMapper(typeof(DomainProfile), typeof(ViewModelProfile));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(c =>
            {
                c.AllowAnyHeader();
                c.AllowAnyMethod();
                c.AllowAnyOrigin();
            });

            app.UseMvc();
        }
    }
}
