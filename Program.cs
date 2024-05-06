using task1mvc.Data;
using task1mvc.Models;

namespace task1mvc
{
    public class Program
    {
        public static void Main(string[] args)
        {/*
            AppDbContext context = new AppDbContext();

            List<Employee> Employees = new List<Employee>()
             { new Employee()
             {
                 Name="sohaib",
                 title= "amman",
                 age=24
             },
              new Employee()
             {
                  Name="ali",
                 title= "Jerash",
                 age=30
             },
              new Employee()
             {
 Name="zaki",
                 title= "Irbid",
                 age=32
             },
              new Employee()
             {
 Name="rami",
                 title= "Mafraq",
                 age=30
             },
              new Employee()
             {
 Name="aya",
                 title= "Tafila",
                 age=25
             },
              new Employee()
             {
 Name="ameera",
                 title= "Ramtha",
                 age=33
             },
              new Employee()
             {
 Name="ahmad",
                 title= "Salt",
                 age=55
             }

             };

            context.Employees.AddRange(Employees);
            context.SaveChanges();*/

            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
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
