using FurnitureStore.BusinessLayer.Services.Interface;
using FurnitureStore.BusinessLayer.Services;
using FurnitureStore.Data.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using FurnitureStore.DataLayer.Repositories.Interface;
using FurnitureStore.DataLayer.Repositories;
using FurnitureStore.DataLayer.AutoMapperConfig;

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddScoped<IFurnitureRepository, FurnitureRepository>();
builder.Services.AddScoped<IFurnitureService, FurnitureService>();

builder.Services.AddAutoMapper(typeof(AutoMapperConfigProfile));

// Add services to the container.
builder.Services.AddDbContext<FurnitureStoreDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

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

app.UseAuthorization();

app.MapControllers();

app.Run();
