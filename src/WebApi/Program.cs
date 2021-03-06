using Infrastructure.Persistance;
using Infrastructure.Persistance.Data;
using Infrastructure.Persistance.DIContainer;
using Application;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;
//Seed

// Add services to the container.

builder.Services.AddControllers();
//Db Registration
builder.Services.AddDbServices(configuration);
//DI Container
builder.Services.AddDIServices();
//Application
builder.Services.AddApplicationServices();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
//Seeding 
if (args.Length == 1 && args[0].ToLower() == "seeddata")
    SeedData(app);
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

void SeedData(IHost app)
{
    var scopedFactory = app.Services.GetService<IServiceScopeFactory>();

    using (var scope = scopedFactory.CreateScope())
    {
        var service = scope.ServiceProvider.GetService<DataSeeding>();
        service.Seed();
    }
}