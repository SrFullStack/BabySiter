using Microsoft.EntityFrameworkCore;
using Repository;
using Service;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<IBabysiterService, BabysiterService>();
builder.Services.AddScoped<IBabysiterRepository, BabysiterRepository>();

builder.Services.AddControllers();

string ConnectionString = builder.Configuration.GetConnectionString("home");

builder.Services.AddDbContext<DB_BABYSITERContext>(option => option.UseSqlServer(ConnectionString));


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
