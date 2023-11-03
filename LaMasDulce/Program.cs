using Microsoft.AspCore.Builder;
using Microsft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using LaMasDulce.Models;

namespace LaMasDulce
{
    class Program
    {
        static void Main(string[] args)
        {
            WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<LaMasDulce>(
                            dbContextOptions => dbContextOptions
                            .UseMySql(
                                builder.Configuration["ConnectionStrings:DefaultConnection"], ServerVersion.AutoDetect(builder.Configuration["ConnectionStrings:DefaultConnection"]
                                )
                            )
            );
WebApplication app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
        }
    }
}