
using ConnectifyHub.Application.Features.Queries.PostQueries;
using ConnectifyHub.Application.Interfaces.Repositories;
using ConnectifyHub.Domain.Entities.Concrete;
using ConnectifyHub.Infrastructure;
using ConnectifyHub.Infrastructure.Repositories.EFCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace ConnectifyHub.WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<ConnectifyContext>();
            builder.Services.AddIdentityCore<User>()
                            .AddRoles<IdentityRole>()
                            .AddEntityFrameworkStores<ConnectifyContext>();

            builder.Services.AddMediatR(opt => opt.RegisterServicesFromAssembly(typeof(PostGetAll).Assembly));

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddScoped<IPostRepository, PostRepository>();

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
