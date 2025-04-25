using GameDiary.Bll.Mapping;
using GameDiary.Bll.Services;
using GameDiary.Core.Abstractions;
using GameDiary.Core.Models;
using GameDiary.Dao;
using GameDiary.Dao.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<GameDiaryDbContext>(
    options =>
    {
        options.UseNpgsql(builder.Configuration.GetConnectionString(nameof(GameDiaryDbContext)));
    });

builder.Services.AddAutoMapper(typeof(MappingProfile));

builder.Services.AddScoped<IDeveloperService, DeveloperService>();
builder.Services.AddScoped<IDevelopRepository, DevelopRepository>();

builder.Services.AddScoped<IPublisherService, PublisherService>();
builder.Services.AddScoped<IPublisherRepository, PublisherRepository>();

builder.Services.AddScoped<IGameService, GameService>();
builder.Services.AddScoped<IGameRepository, GameRepository>();

builder.Services.AddScoped<IGameDeveloperService, GameDeveloperService>();
builder.Services.AddScoped<IGameDevelopRepository, GameDevelopRepository>();

builder.Services.AddScoped<IGamePublisherRepository, GamePublisherRepository>();
builder.Services.AddScoped<IGamePublisherRepository, GamePublisherRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "My API v1");
        options.RoutePrefix = ""; // Открывает Swagger на главной странице
    });
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();
app.MapRazorPages()
   .WithStaticAssets();

app.MapControllers();

app.Run();
