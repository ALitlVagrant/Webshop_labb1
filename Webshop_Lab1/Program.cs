using Blazored.LocalStorage;
using Webshop_Lab1.Components;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddHttpClient<WebshopApi>(client =>
        {
            client.BaseAddress = new Uri("https://localhost:7013/"); // API:ets URL
        });

        builder.Services.AddRazorComponents()
            .AddInteractiveServerComponents();

        builder.Services.AddScoped<WebshopApi>();

        builder.Services.AddBlazoredLocalStorage();
        

        var app = builder.Build();

        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error");
            app.UseHsts();  // Använd HSTS för produktion
        }

        app.UseHttpsRedirection();

        app.UseAntiforgery();

        app.MapStaticAssets();

        // Lägg till routing för Blazor-komponenter
        app.MapRazorComponents<App>()
            .AddInteractiveServerRenderMode();

        app.Run();
    }
}