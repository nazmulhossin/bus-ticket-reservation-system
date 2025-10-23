using BusTicketReservation.Application.Contracts.Interfaces.Repositories;
using BusTicketReservation.Application.Contracts.Interfaces.Services;
using BusTicketReservation.Application.Services;
using BusTicketReservation.Infrastructure.Data;
using BusTicketReservation.Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddOpenApi();
builder.Services.Configure<ApiBehaviorOptions>(options =>
{
    options.SuppressModelStateInvalidFilter = true;
});

// Database Configuration
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

// Register Repositories
builder.Services.AddScoped<IBusScheduleRepository, BusScheduleRepository>();
builder.Services.AddScoped<ITicketRepository, TicketRepository>();

// Register Application Services
builder.Services.AddScoped<ISearchService, SearchService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/openapi/v1.json", "OpenAPI V1");
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
