//Credits
// http.www.youtube.com/watch?v=pmWFzzU_NB4
// tutorialsEU - C# => Demonstrated implentation of Razor and pages.

// Jeff Meyers
// Provided lectures and documentation on creating and using MVC Applications.



using Sprint11_HW_2._0.Models;

namespace Sprint11_HW_2._0
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddControllersWithViews();

            //Credits
            // http.www.youtube.com/watch?v=pmWFzzU_NB4
            // tutorialsEU - C# => Demonstrated implentation of Razor and pages.
            builder.Services.AddDbContext<DatabaseHandler>();

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

            app.MapRazorPages();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}