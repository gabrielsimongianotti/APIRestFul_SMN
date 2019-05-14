using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_RESTFul_SMN.Model.Context;
using API_RESTFul_SMN.Services;
using API_RESTFul_SMN.Services.inplementattions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration configuration;
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var connection = Configuration["SqlConnection:SqlConnectionString"];
            //services.AddDbContext<MySQLContext>(options => options.UseMySql(connection));
            services.AddDbContext<SQLContext>(options => options.UseSqlServer(connection));
            //services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddMvc();
            services.AddScoped<IProfissoesService, ProfissoesServiceImpl>();
            services.AddScoped<IParentescoService, ParentescoServiceImpl>();
            services.AddScoped<IFuncionariosService, FuncionariosServiceImpl>();
            services.AddScoped<IEstadoCivilService, EstadoCivilServiceImpl>();
            services.AddScoped<IEmpresaService, EmpresaServiceImpl>();
            services.AddScoped<IDependentesService, DependentesServiceImpl>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
