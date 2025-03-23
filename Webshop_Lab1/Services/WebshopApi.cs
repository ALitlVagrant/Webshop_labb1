
public class WebshopApi
{
    private readonly HttpClient _httpClient;

    public WebshopApi(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<Product>> GetProductsAsync()
    {
        try
        {
            Console.WriteLine("Sending request to API..."); // Logg för att kontrollera om anropet skickas
            var products = await _httpClient.GetFromJsonAsync<List<Product>>("https://localhost:7013/api/products");
            Console.WriteLine($"Received {products?.Count} products."); // Logg för att se om vi får tillbaka några produkter
            return products;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error fetching products: {ex.Message}"); // Logg för eventuella fel
            return new List<Product>();
        }
    }
    public async Task<Product> GetProductByIdAsync(int id)
    {
        try
        {
            var product = await _httpClient.GetFromJsonAsync<Product>($"https://localhost:7013/api/products/{id}");
            return product;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error fetching product with ID {id}: {ex.Message}");
            return null; // Returnera null vid fel
        }
    }


}


public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
    public decimal Price { get; set; }
}