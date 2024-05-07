using Microsoft.EntityFrameworkCore;
using MySqlAPi.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var mySqlConfiguration = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<MyApiDbContext>(
    options => options.UseMySql(mySqlConfiguration, ServerVersion.AutoDetect(mySqlConfiguration)));

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
