using Microsoft.Extensions.Options;
using backend_part.SERVICES.Innovatives;
using backend_part.SERVICES.Task;
using backend_part.SERVICES.Tasks;
using backend_part.SERVICES.Users;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IInnovativeRepository, InnovativeSqlService>();
builder.Services.AddScoped<IUserRepository, UserSqlService>();
builder.Services.AddScoped<ITaskRepository, TaskSqlService>();

var provider = builder.Services.BuildServiceProvider();
var condfiguration = provider.GetRequiredService<IConfiguration>();

builder.Services.AddCors(Options =>
{
    var frontendURL = condfiguration.GetValue<String>("frontend_url");

    Options.AddDefaultPolicy(builder =>
    {
        builder.WithOrigins(frontendURL).AllowAnyMethod().AllowAnyHeader();
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
