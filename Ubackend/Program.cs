using Microsoft.EntityFrameworkCore;
using Ubackend.Data;
using Ubackend.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
const string connect = "SQLSERVER";
var connectionString = builder.Configuration.GetConnectionString(connect);

builder.Services.AddDbContext<UbackendDbContext>(options => options.UseSqlServer(connectionString));
// añadir servicios
builder.Services.AddScoped<IStudentService, StudentService>();
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "CorsPolicy", builder =>
    {
        builder.AllowAnyOrigin();
        builder.AllowAnyMethod();
        builder.AllowAnyHeader();
    });
});
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
app.UseCors("CorsPolicy");

app.Run();
