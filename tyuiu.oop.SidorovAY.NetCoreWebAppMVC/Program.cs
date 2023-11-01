using Microsoft.EntityFrameworkCore;
using tyuiu.oop.SidorovAY.NetCoreWebAppMVC.DataModels;

namespace tyuiu.oop.SidorovAY.NetCoreWebAppMVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<MyDBContext>(options =>
            {
                options.UseSqlite(@"Data source=C:\TEMP\NetCoreWebAppMVC.db");
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                using (var scope = app.Services.CreateScope())
                {
                    using (var context = scope.ServiceProvider.GetService<MyDBContext>())
                        context!.Database.EnsureCreated();
                }

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