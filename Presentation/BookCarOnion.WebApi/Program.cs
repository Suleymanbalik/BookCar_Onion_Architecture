using BookCarOnion.Application.Features.CQRS.Handlers.AboutHandlers;
using BookCarOnion.Application.Features.CQRS.Handlers.BannerHandlers;
using BookCarOnion.Application.Features.CQRS.Handlers.BrandHandlers;
using BookCarOnion.Application.Features.CQRS.Handlers.CarHandlers;
using BookCarOnion.Application.Features.CQRS.Handlers.CategoryHandlers;
using BookCarOnion.Application.Interfaces;
using BookCarOnion.Application.Interfaces.CarInterfaces;
using BookCarOnion.Persistence.Context;
using BookCarOnion.Persistence.Repositories;
using BookCarOnion.Persistence.Repositories.CarRepositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//--Services for Context Class Start-**-
builder.Services.AddScoped<BookCarContext>();
//--Services for Context Class End-**-

//--Services for IRepository Start-**-
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
//--Services for IRepository End-**-

//--Services for ICarRepository Start-**-
builder.Services.AddScoped(typeof(ICarRepository), typeof(CarRepository));
//--Services for ICarRepository End-**-

//--Services for About Start-**-
builder.Services.AddScoped<GetAboutQueryHandler>();
builder.Services.AddScoped<GetAboutByIdQueryHandler>();
builder.Services.AddScoped<CreateAboutCommandHandler>();
builder.Services.AddScoped<UpdateAboutCommandHandler>();
builder.Services.AddScoped<RemoveAboutCommandHandler>();
//--Services for About End-**-

//--Services for Banner Start-**-
builder.Services.AddScoped<GetBannerQueryHandler>();
builder.Services.AddScoped<GetBannerByIdQueryHandler>();
builder.Services.AddScoped<CreateBannerCommandHandler>();
builder.Services.AddScoped<UpdateBannerCommandHandler>();
builder.Services.AddScoped<RemoveBannerCommandHandler>();
//--Services for Banner End-**-

//--Services for Brand Start-**-
builder.Services.AddScoped<GetBrandQueryHandler>();
builder.Services.AddScoped<GetBrandByIdQueryHandler>();
builder.Services.AddScoped<CreateBrandCommandHandler>();
builder.Services.AddScoped<UpdateBrandCommandHandler>();
builder.Services.AddScoped<RemoveBrandCommandHandler>();
//--Services for Brand End-**-

//--Services for Car Start-**-
builder.Services.AddScoped<GetCarQueryHandler>();
builder.Services.AddScoped<GetCarByIdQueryHandler>();
builder.Services.AddScoped<CreateCarCommandHandler>();
builder.Services.AddScoped<UpdateCarCommandHandler>();
builder.Services.AddScoped<RemoveCarCommandHandler>();
builder.Services.AddScoped<GetCarWithBrandQueryHandler>();
//--Services for Car End-**-

//--Services for Category Start-**-
builder.Services.AddScoped<GetCategoryQueryHandler>();
builder.Services.AddScoped<GetCategoryByIdQueryHandler>();
builder.Services.AddScoped<CreateCategoryCommandHandler>();
builder.Services.AddScoped<UpdateCategoryCommandHandler>();
builder.Services.AddScoped<RemoveCategoryCommandHandler>();
//--Services for Category End-**-

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
