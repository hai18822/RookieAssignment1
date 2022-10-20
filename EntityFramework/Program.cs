using EntityFramework.Models;
using EntityFramework.Repositories;
using EntityFramework.Repositories.Interfaces;
using EntityFramework.Services;
using EntityFramework.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IStudentService, StudentService>();

builder.Services.AddScoped<IStudentRepository, StudentRepository>();

builder.Services.AddDbContext<StudentContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("DBConnString")));

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
