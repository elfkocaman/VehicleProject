
using Microsoft.EntityFrameworkCore;
using Vehicle.Dal;
using Vehicle.Dto;
using Vehicle.Entity.Concretes;
using Vehicle.Repos.Abstracts;
using Vehicle.Repos.Concretes;
using Vehicle.Ui;
using Vehicle.Uw;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
//add for session
builder.Services.AddDistributedMemoryCache();

//add for session
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromSeconds(10);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});



builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<MyContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("Baglanti")));
builder.Services.AddScoped<IUow, Uow>();
builder.Services.AddScoped<IBrandRep, BrandRep<Brand>>();
builder.Services.AddScoped<IModelRep, ModelRep<Model>>();
builder.Services.AddScoped<ICarRep, CarRep<Car>>();
builder.Services.AddScoped<IUserRep, UserRep<User>>();
builder.Services.AddScoped<Response>();
builder.Services.AddScoped<UserDto>();
//builder.Services.AddScoped<User>();
//builder.Services.AddScoped<Car>();
builder.Services.AddScoped<VehicleDTO>();


builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {


                          policy.AllowAnyOrigin();  //bütün origin leri kabul et demek 
                          policy.AllowAnyHeader();
                          policy.AllowAnyMethod();
                      });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(MyAllowSpecificOrigins);
app.UseHttpsRedirection();

app.UseAuthorization();

app.UseSession();
app.MapControllers();
app.Run();
