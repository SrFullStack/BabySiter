using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Repository;
using Service;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddScoped<IBabysiterService, BabysiterService>();
builder.Services.AddScoped<IBabysiterRepository, BabysiterRepository>();
builder.Services.AddScoped<ISearchBabySiterService, SearchBabySiterService>();
builder.Services.AddScoped<ISearchBabySiterRepository, SearchBabySiterRepository>();
builder.Services.AddScoped<ITimeService, TimeService>();
builder.Services.AddScoped<ITimeRepository, TimeRepository>();
builder.Services.AddScoped<IRequsetSearchBabysiterRepository, RequsetSearchBabysiterRepository>();
builder.Services.AddScoped<IRequsetSearchBabysiterService, RequsetSearchBabysiterService>();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
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
