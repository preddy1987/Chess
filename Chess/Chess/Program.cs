using ChessAPI;
using ChessAPI.Services;
using ChessAPI.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ChessContext>(
    opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("ChessDB"))
    .EnableSensitiveDataLogging());
//.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));


builder.Services.AddScoped<IChessService, ChessService>();

builder.Services.AddControllers()
    .AddJsonOptions(opt=> opt.JsonSerializerOptions.ReferenceHandler=System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles);
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
