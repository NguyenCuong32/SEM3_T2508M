using eVehicle_Web.Repository;
using eVehicle_Web.Services;
using Microsoft.EntityFrameworkCore;

namespace eVehicle_Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            string connectionString = configuration.GetConnectionString("eVehicleConnect");
            builder.Services.AddDbContext<eVehicleDbContext>(options => options.UseSqlServer(connectionString));
            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddScoped<IVehicleService, VehicleSevice>();
            builder.Services.AddScoped<IVehicleRepository, VehicleRepository>();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
