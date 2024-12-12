using Microsoft.EntityFrameworkCore;
using WebAPIEstatusAlumnos.Models.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//Agregar la referencia de la cadena de conexión de la base de datos
var connectionString = builder.Configuration.GetConnectionString("TichDic");
builder.Services.AddDbContext<EstatusContext>(x => x.UseSqlServer(connectionString));

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

builder.Services.AddCors(options => 
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
    builder =>
    {
        builder.WithOrigins("http://localhost:51369").AllowAnyMethod().AllowAnyHeader();
    });

 });


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

app.UseCors(MyAllowSpecificOrigins);

app.UseAuthorization();

app.MapControllers();

app.Run();
