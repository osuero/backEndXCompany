using Api.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using AutoMapper;
using Api.XEnterprise.Mappers;
using Api.Business.EntitiesRepository;

namespace Api.XEnterprise
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddDbContext<ApiDbContext>(x => x.UseSqlServer(Configuration.GetConnectionString("Default")));
            services.AddAutoMapper(typeof(MapperProfiles));

            services.AddTransient<PermissionRepository, PermissionRepository>();
            services.AddTransient<PermissionTypeRepository, PermissionTypeRepository>();
            services.AddSwaggerGen();

            services.AddCors(options => {
                options.AddPolicy("default",
                builder => builder.WithOrigins("*").WithHeaders("*").WithMethods("*"));
            });

        }

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

            app.UseCors("default");

            app.UseSwagger();


            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
