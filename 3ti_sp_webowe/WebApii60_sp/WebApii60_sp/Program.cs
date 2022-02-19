using Microsoft.EntityFrameworkCore;
using WebApii60_sp.Data;
using WebApii60_sp.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<FilmDbContext>(options => {
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnString"));
});

builder.Services.AddScoped<IFilmRepo, SqLiteFilmRepo>();
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
