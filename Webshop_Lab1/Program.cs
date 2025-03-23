using Blazored.LocalStorage;
using Webshop_Lab1.Components;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Lägg till HttpClient och konfigurera BaseAddress för att anropa API:et
        builder.Services.AddHttpClient<WebshopApi>(client =>
        {
            client.BaseAddress = new Uri("https://localhost:7013/"); // API:ets URL
        });

        // Lägg till Blazor-komponenter och server-rendering
        builder.Services.AddRazorComponents()
            .AddInteractiveServerComponents();

        // Lägg till tjänst för att använda produktservice (WebshopApi)
        builder.Services.AddScoped<WebshopApi>();

        builder.Services.AddBlazoredLocalStorage();
        

        var app = builder.Build();

        // Konfigurera HTTP-förfrågningar
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error");
            app.UseHsts();  // Använd HSTS för produktion
        }

        app.UseHttpsRedirection();

        app.UseAntiforgery();

        // Lägg till statiska tillgångar
        app.MapStaticAssets();

        // Lägg till routing för Blazor-komponenter
        app.MapRazorComponents<App>()
            .AddInteractiveServerRenderMode();

        app.Run();
    }
}