global using Microsoft.EntityFrameworkCore;
global using backend_part.Models;
global using backend_part.Data;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataContext>();

var provider = builder.Services.BuildServiceProvider();
var condfiguration = provider.GetRequiredService<IConfiguration>();

builder.Services.AddCors(Options =>
{
    var frontendURL = condfiguration.GetValue<String>("frontend_url");

    Options.AddDefaultPolicy(builder =>
    {
        builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
    });
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();