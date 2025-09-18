using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// AGGIUNTA DEL DB CONTEXT


// AGGIUNTA DELL'AUTO MAPPING


// AGGIUNTA DELL'ADD SCOPED 


// Aggiunta dei controller
builder.Services.AddControllers();

// Aggiunta di Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Rental System API", Version = "v1" });
});

var app = builder.Build();

// Abilita Swagger solo in sviluppo
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Rental System API V1");
        c.RoutePrefix = string.Empty;
    });
}

// Mappa i controller
app.MapControllers();

app.Run();