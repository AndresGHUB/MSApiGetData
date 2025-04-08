using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;
using MSApiGetData.Services;
using MSApiGetData.Models.Data;

var builder = WebApplication.CreateBuilder(args);

// Agregar servicios al contenedor.
builder.Services.AddControllers();

//Added
builder.Services.AddScoped<IServReportHiring, ServReportHiring>();
builder.Services.AddScoped<IDataExtract, DataExtract>();

// Get bdd settings
builder.Services.Configure<BddSettings>(builder.Configuration.GetSection("BDDSettings"));

var app = builder.Build();

// Configurar la tubería de solicitudes HTTP.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
