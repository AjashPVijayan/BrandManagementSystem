using BrandManagementSystem.DAL;
using BrandManagementSystem.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using System;
using BrandManagementSystem.Models;

namespace BrandManagementSystem
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
            //Ajash  Inject Appsettings
            services.Configure<ApplicationSettings>(Configuration.GetSection("ApplicationSettings"));

            services.AddControllersWithViews();
            // In production, the Angular files will be served from this directory
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "ClientApp/dist";
            });

            services.AddScoped<ISnapshotServices, SnapshotServices>();
            services.AddScoped<ISnapshotDAL, SnapshotDAL>();

            var Keyvalue = Encoding.UTF8.GetBytes(Configuration["ApplicationSettings:JWT_Sec"].ToString());
            services.AddAuthentication(aut =>
            {
                aut.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                aut.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                aut.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;

            }).AddJwtBearer(meta=> {
                meta.RequireHttpsMetadata = false;
                meta.SaveToken = false; //do we need to save token on server?
                meta.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Keyvalue),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ClockSkew = TimeSpan.Zero

                };
            });
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
            }

            app.UseStaticFiles();
            if (!env.IsDevelopment())
            {
                app.UseSpaStaticFiles();
            }

            app.UseRouting();

            app.Use(async (context, next) =>
            {
                foreach (KeyValuePair<string, string> header in addResponseHeaders)
                {
                    context.Response.Headers.Add(header.Key, header.Value);
                }
                if (!env.IsDevelopment())
                {
                    context.Response.Headers.Add("Strict-Transport-Security", "max-age=50000000");
                }
                await next();
            });
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller}/{action=Index}/{id?}");
            });

            app.UseSpa(spa =>
            {
                // To learn more about options for serving an Angular SPA from ASP.NET Core,
                // see https://go.microsoft.com/fwlink/?linkid=864501

                spa.Options.SourcePath = "ClientApp";

                if (env.IsDevelopment())
                {
                    spa.UseAngularCliServer(npmScript: "start");
                }
            });
        }
        // Http Response headers to be added for each API request for security.
        private readonly Dictionary<string, string> addResponseHeaders = new Dictionary<string, string>()
        {
            { "X-Frame-Options", "SAMEORIGIN" },
            { "X-XSS-Protection", "1; mode=block" },
            { "X-Content-Type-Options", "nosniff" },
            { "Referrer-Policy", "no-referrer" }
        };
    }
}
