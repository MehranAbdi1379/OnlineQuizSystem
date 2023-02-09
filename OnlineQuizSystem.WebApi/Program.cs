using Framework.Repository;
using Microsoft.EntityFrameworkCore;
using OnlineQuizSystem.Domain.Repositories;
using OnlineQuizSystem.Repository;
using OnlineQuizSystem.Repository.DataBase;
using OnlineQuizSystem.WebApi.Extentions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<OnlineQuizSystemContext>(option => 
option.UseSqlServer(builder.Configuration.GetConnectionString("Default")));

//TODO: Avoid reputation

builder.Services.AddRepositories();

builder.Services.AddApplicationServices();

builder.Services.AddScoped<BaseDbContext>();

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
