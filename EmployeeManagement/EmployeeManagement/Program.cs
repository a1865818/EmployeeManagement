using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.InMemory;
using EmployeeManagement.Data;
using EmployeeManagement.Repositories;
namespace EmployeeManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<AppDbContext>(options =>
            {
                options.UseInMemoryDatabase("EmployeeDb");
            });

            builder.Services.AddCors(options =>
            {
                options.AddPolicy("MyCors", builder =>
                {
                    builder.WithOrigins("http://localhost:4200")
                           .AllowAnyMethod()
                           .AllowAnyHeader();
                });
            });
            //AddScoped creates a new instance of the repository for each request
            //For example, if two requests are made to the server, two instances of the repository will be created
            //Add the employee repository to the dependency injection container
            builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();

            builder.Services.AddControllers();

            builder.Services.AddEndpointsApiExplorer();

            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Employee Management API");
                    c.RoutePrefix = string.Empty;
                });
            }

            app.UseCors("MyCors");

            app.MapControllers();

            app.Run();
        }
    }
}
