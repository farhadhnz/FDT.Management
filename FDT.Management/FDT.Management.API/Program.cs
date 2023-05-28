using FDT.Management.Base.CommandHandlers;
using FDT.Management.Base.Commands;
using FDT.Management.Base.Entities;
using FDT.Management.Base.Persistence;
using FDT.Management.Core.CommandHandlers;
using FDT.Management.Persistence;
using FDT.Management.Persistence.Entities;
using FDT.Management.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<AppDbContext>(opt => 
    opt.UseSqlServer(builder.Configuration.GetConnectionString("DTConnectionString")));
builder.Services.AddControllers().AddNewtonsoftJson(options => {
    options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ICommandHandler<CreateDigitalTwinCommand>, CreateDigitalTwinCommandHandler>();
builder.Services.AddScoped<IDigitalTwinRepository<DigitalTwinEntity>, DigitalTwinRepository>();
builder.Services.AddScoped<IDigitalTwinPropertyRepository<DigitalTwinPropertyEntity>, DigitalTwinPropertyRepository>();



var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    dbContext.Database.EnsureCreated();
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();

