//1- Usings to work with entityFramework
using Microsoft.EntityFrameworkCore;
//3.1 nos conectamos al dataacces q creamos
using universityApiBackEnd.DataAccess;



var builder = WebApplication.CreateBuilder(args);


//2. Connection with SQL Server Express
const string CONNECTIONNAME = "UniversityDB"; //Connection to DB from appsettings.json
var connectionString = builder.Configuration.GetConnectionString(CONNECTIONNAME); //desde aca tomo el valor de url

//3. establecemos un contexto (creamos una carpeta llamada DataAcces, y agregamos una clase (aca llamada UniversityDBContext))
builder.Services.AddDbContext<UniversityDBContext>(options => options.UseSqlServer(connectionString));

//4. Creamos la carpeta Models->DataModels y el archivo BaseEntity, donde va a ser las columnas comunes a todas nuestras tablas, (id, createdBy, createdAt, etc..)

// Add services to the container.

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
