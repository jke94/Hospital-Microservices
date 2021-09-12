namespace HospitalRazorWebApp
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using HospitalRazorWebApp.ViewModels;

    public class Startup
    {
        public Startup(IConfiguration configuration, IWebHostEnvironment ennvironment)
        {
            Configuration = configuration;
            WebHostEnvironment = ennvironment;
        }

        public IConfiguration Configuration { get; }

        public IWebHostEnvironment WebHostEnvironment { get; set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            //services.InitializeAllApplicationServices(Configuration, WebHostEnvironment.EnvironmentName);

            services.AddHttpClient("DoctorsService", c =>
            {
                c.BaseAddress = new System.Uri(Configuration["Services:Doctors"]);
            });

            //services.AddTransient<IRepositoryWrapper, RepositoryWrapper>();
            services.AddTransient<IPatientViewModel, PatientViewModel>();
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

            //app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
