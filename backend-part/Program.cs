global using Microsoft.EntityFrameworkCore;
global using backend_part.Models;
global using backend_part.Data;
global using backend_part.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//services cors
builder.Services.AddCors(options =>
{
    options.AddPolicy("MyAllowedOriginsThilini",
        policy =>
        {
            policy.AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod();
        });
});

builder.Services.AddDbContext<DataContext>();
builder.Services.AddScoped<IMeeting, MeetingService>();
builder.Services.AddScoped<IMeetingNote, MeetingNoteService>();
builder.Services.AddScoped<IRating, RatingService>();
builder.Services.AddScoped<IViewMeetingProject, ViewMeetingProjectService>();
builder.Services.AddScoped<IInnovative, InnovativeService>();
builder.Services.AddScoped<IProjectUser, ProjectUsesrService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();

}

app.UseHttpsRedirection();
app.UseRouting();
//app cors
app.UseCors("MyAllowedOriginsThilini");
app.UseAuthorization();
app.MapControllers();

app.Run();
