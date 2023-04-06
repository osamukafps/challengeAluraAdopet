using AutoMapper;
using ChallengeAluraAdopet.API.Config;
using ChallengeAluraAdopet.API.Context;
using ChallengeAluraAdopet.API.Repository;
using ChallengeAluraAdopet.API.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Configuring Database
builder.Services.AddDbContext<MyContext>(options =>
    options.UseSqlServer(builder.Configuration["DatabaseConnection:ConnectionString"]));
MyContext.TestConnection(builder.Configuration["DatabaseConnection:ConnectionString"]);

//Configuring AutoMapper
IMapper mapper = MappingConfig.RegisterMaps().CreateMapper();
builder.Services.AddSingleton(mapper);
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

//Repository
builder.Services.AddTransient<MyContext>();
builder.Services.AddTransient<ITutorRepository, TutorRepository>();

//Services
builder.Services.AddScoped<ITutorService, TutorService>();


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
