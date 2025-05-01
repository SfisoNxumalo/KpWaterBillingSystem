
using KpWaterBillingSystem.src.Model;
using KpWaterBillingSystem.src.Repository.DI;
using KpWaterBillingSystem.src.Repository.Interface;
using KpWaterBillingSystem.src.Repository.Storages;

namespace KpManagementSystemAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddScoped<IGenericRepository<Employee, int>, InMemoryDB<Employee>>();
            builder.Services.AddScoped<StorageService<Employee>>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
