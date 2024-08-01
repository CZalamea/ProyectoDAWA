using Microsoft.EntityFrameworkCore;
using ProyectoDAW.Models;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
var conecctionString = builder.Configuration.GetConnectionString("Conexion");
builder.Services.AddDbContext<RestauranteDbContext>(options =>
    options.UseSqlServer(conecctionString)
);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


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
