using CarMarket.BL.Interfaces;
using CarMarket.BL.Services;
using CarMarket.DL.Interfaces;
using CarMarket.DL.Repositories;
using CarMarket.Healthchecks;
using FluentValidation;
using FluentValidation.AspNetCore;

namespace CarMarket
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services
       .AddSingleton<ICarRepository, CarRepository>();
            builder.Services
                .AddSingleton<ICarService, CarService>();
            builder.Services
               .AddSingleton<IBrandRepository, BrandRepository>();
            builder.Services
                .AddSingleton<IBrandService, BrandService>();
            builder.Services
                .AddSingleton<ILibraryService, LibraryService>();
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services
                .AddFluentValidationAutoValidation();
            builder.Services
                .AddValidatorsFromAssemblyContaining(typeof(Program));

            builder.Services.AddHealthChecks()
                .AddCheck<CustomHealthCheck>(nameof(CustomHealthCheck));

            builder.Services
                .AddFluentValidationAutoValidation();
            builder.Services
                .AddValidatorsFromAssemblyContaining(typeof(Program));



            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapHealthChecks("/healthz");

            app.MapControllers();

            app.Run();
        }
    }
}