
using BallBox.Client.Services;
using BallBox.Data;
using BallBox.Data.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BallBox.API
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

			builder.Services.AddDbContext<BallBoxDbContext>(options =>
				options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

			builder.Services.AddScoped<TeamRepository>();
			builder.Services.AddScoped<PlayerRepository>();

			builder.Services.AddCors(options =>
			{
				options.AddPolicy("AllowSpecificOrigin",
					builder => builder.WithOrigins("https://localhost:5001")
									   .AllowAnyMethod()
									   .AllowAnyHeader());
			});

			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (app.Environment.IsDevelopment())
			{
				app.UseSwagger();
				app.UseSwaggerUI();
			}

			app.UseHttpsRedirection();

			app.UseAuthorization();

			app.UseCors("AllowSpecificOrigin");

			app.MapControllers();

			app.Run();
		}
	}
}
