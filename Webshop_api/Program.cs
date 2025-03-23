var builder = WebApplication.CreateBuilder(args);

// Lägg till CORS-policy om du behöver det för Blazor-kommunikation
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowBlazorApp",
        policy => policy.WithOrigins("https://localhost:5294") // Blazor appens URL
            .AllowAnyMethod()
            .AllowAnyHeader());
});

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Konfigurera routing för CORS
app.UseRouting();

// Lägg till CORS-policy
app.UseCors("AllowBlazorApp");

// Lägg till Authorization om du har användarbehörighet (valfritt)
app.UseAuthorization();

// Map controllers till API-rutter
app.MapControllers();

app.Run();