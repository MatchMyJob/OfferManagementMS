using Application.DTO.Config;
using Application.Interfaces;
using Application.UseCase.Services;
using Domain.Entities;
using Infraestructure.Command;
using Infraestructure.Persistence;
using Infraestructure.Query;
using Infraestructure.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddNewtonsoftJson();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1.0.0",
        Title = "API Template",
        Description = "Basic architecture of the project.",
        Contact = new OpenApiContact
        {
            Name = "Ivan Brestt",
            Url = new Uri("https://github.com/ivyab97")
        }
    });

    //Swagger Documentation
    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
});


//Custom
var connectionString = builder.Configuration["ConnectionString"];

builder.Services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(connectionString));


builder.Services.Configure<ApiBehaviorOptions>(options =>
{
    options.SuppressModelStateInvalidFilter = true;
});

builder.Services.AddCors(options =>
{
    options.AddPolicy("NewPolicy", app =>
    {
        app.AllowAnyOrigin()
           .AllowAnyMethod()
           .AllowAnyHeader();
    }); 
});


builder.Services.AddScoped<IGenericRepository,GenericRepository>();

builder.Services.AddScoped<IApplicationService, ApplicationService>();
builder.Services.AddScoped<IApplicationQuery, ApplicationQuery>();
builder.Services.AddScoped<IApplicationCommand, ApplicationsCommand>();

builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ICategoryQuery, CategoryQuery>();
builder.Services.AddScoped<ICategoryCommand, CategoryCommand>();

builder.Services.AddScoped<IOfferService, OfferService>();
builder.Services.AddScoped<IOfferQuery, OfferQuery>();

builder.Services.AddScoped<IStudyTypeService, StudyTypeService>();
builder.Services.AddScoped<IStudyTypeQuery, StudyTypeQuery>();


builder.Services.AddScoped<ISkillService, SkillService>();
builder.Services.AddScoped<ISkillQuery, SkillQuery>();

builder.Services.AddScoped<IJobOfferModeService, JobOfferModeService>();
builder.Services.AddScoped<IJobOfferModeQuery, JobOfferModeQuery>();

//builder.Services.AddScoped<ICategoryCommand, CategoryCommand>();

builder.Services.AddScoped<IProvinceService, ProvinceService>();
builder.Services.AddScoped<IProvinceQuery, ProvinceQuery>();


var config = new AutoMapper.MapperConfiguration(
    options =>
    {
        options.AllowNullDestinationValues = true;
        options.AllowNullCollections = true;
        options.AddProfile(new AutoMapperProfile());
    });
builder.Services.AddSingleton(config.CreateMapper());

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
