using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MyApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private static List<Product> products = new List<Product>
{
    new Product
{
    Id = 1,
    Name = "Hel Lax",
    Description = "Färsk och vildfångad hel lax, perfekt för grillning eller bakning.",
    ImageUrl = "https://media.istockphoto.com/id/1454326106/sv/foto/fresh-salmon.jpg?s=1024x1024&w=is&k=20&c=21K70znpg3yGpaK6FPYj9nDxf9Ay7yPT8D3DmRACKUk=",
    Price = 249.99m
},
new Product
{
    Id = 2,
    Name = "Hel Guldsparid",
    Description = "Hel Guldsparid med fin vit fiskkött, perfekt för stekning eller ugn. Vikt: ca 500 gram.",
    ImageUrl = "https://media.istockphoto.com/id/1740257486/sv/foto/top-view-of-raw-sea-bream-fish-on-ice-on-display-at-seafood-fish-market.jpg?s=1024x1024&w=is&k=20&c=FAkGXQIccXeKV1jQojkRKdxvXB3LV8NweAR-xv-nbo8=", // Byt till en riktig bildlänk
    Price = 249.99m
},
new Product
{
    Id = 3,
    Name = "Hel Makrill",
    Description = "Färska hela makrillar, perfekta för grillning eller rökning. Vikt: ca 500 g per styck.",
    ImageUrl = "https://media.istockphoto.com/id/154948441/sv/foto/mackerel-isolated-on-white-background.jpg?b=1&s=612x612&w=0&k=20&c=M9fGiNpRieicoho2Cp8-CI7GpeA5GaNCXJPVptZFX2E=", // Byt till en riktig bildlänk
    Price = 89.99m
},
new Product
{
    Id = 4,
    Name = "Hel Hälleflundra",
    Description = "Färsk hälleflundra, en stor och smakrik fisk som passar bra till grillning eller ugnsbakning.",
    ImageUrl = "https://media.istockphoto.com/id/450450081/sv/foto/fresh-halibut-fish.jpg?s=1024x1024&w=is&k=20&c=oN9dLQhBW0jJeh_37Za7Dsv0AF2x7THu8UStZpfmUYI=", // Byt till en riktig bildlänk
    Price = 599.99m
},
new Product
{
    Id = 5,
    Name = "Hel Marulk",
    Description = "Frisk, hel Marulk. Perfekt för Stekning.",
    ImageUrl = "https://media.istockphoto.com/id/687067050/sv/foto/marulk.jpg?s=612x612&w=0&k=20&c=LLQU8VaPD-M5O5GZeRaRwZW_dRFXEUupeH0V9lOWZ-g=", // Byt till en riktig bildlänk
    Price = 79.99m
},
new Product
{
    Id = 6,
    Name = "Hel Regnbåge",
    Description = "Regnbågslax i sin helhet, perfekt för att tillaga hela på grillen eller i ugn. Vikt: ca 1.8 kg.",
    ImageUrl = "https://media.istockphoto.com/id/529572923/sv/foto/native-rainbow-trout-on-white.jpg?s=612x612&w=0&k=20&c=c3g41YIXVAvkwTVb8POEv1GtZIIkbORvL6bjFV0ln8w=", // Byt till en riktig bildlänk
    Price = 299.99m
},
new Product
{
    Id = 7,
    Name = "Hel Röding",
    Description = "Hela röding, perfekt för grillning eller stekning. Vikt: ca 1.2 kg.",
    ImageUrl = "https://media.istockphoto.com/id/1045546270/sv/foto/f%C3%A4rsk-r%C3%B6ding.jpg?s=612x612&w=0&k=20&c=vntqVGoOwV50v8J18qtUAh_cJd0LcAZ5JAuCVgwY-5A=", // Byt till en riktig bildlänk
    Price = 229.99m
},
new Product
{
    Id = 8,
    Name = "Hel Piggvar",
    Description = "Färsk piggvar, en delikat fisk som passar för lyxiga middagar och festmåltider.",
    ImageUrl = "https://media.istockphoto.com/id/472876440/sv/foto/turbot-fish.jpg?s=612x612&w=0&k=20&c=jzPWCvRbdKl9W2lW5W3MbgmQXdcYN4RewItrAWKywgE=", // Byt till en riktig bildlänk
    Price = 799.99m
},
new Product
{
    Id = 9,
    Name = "Hel Hummer",
    Description = "Hel Hummer, perfekt för lyxiga fiskrätter eller som en del av en skaldjursmiddag.",
    ImageUrl = "https://media.istockphoto.com/id/148792864/sv/foto/red-lobster-isolated-on-white-background.jpg?s=612x612&w=0&k=20&c=YeZOEf6YQiCosLqf2BtMkHVU2bfwEkgBAiRJiPgy7Tg=", // Byt till en riktig bildlänk
    Price = 499.99m
},
new Product
{
    Id = 10,
    Name = "Hel Abborre",
    Description = "Färsk abborre, perfekt för grillning eller stekning. Vikt: ca 800 g.",
    ImageUrl = "https://media.istockphoto.com/id/1154809644/sv/foto/f%C3%A4rsk-fisk-havs-abborre-isolerad-p%C3%A5-vitt.jpg?s=612x612&w=0&k=20&c=aP052I_0A1nrQNtrVVxGg4veh4yp0dmw7SqDGRCg--4=", // Byt till en riktig bildlänk
    Price = 159.99m
},
new Product
{
    Id = 11,
    Name = "Ostron",
    Description = "Ostron är en lyxig skaldjurssort med frisk, salt smak och krämig textur. De kan ätas råa med citron eller tillagas för en rikare upplevelse.",
    ImageUrl = "https://images.pexels.com/photos/2647939/pexels-photo-2647939.jpeg?auto=compress&cs=tinysrgb&w=600",
    Price = 10.99m
},
new Product
{
    Id = 11,
    Name = "Hel Bläckfisk",
    Description = "Hel åttaarmad bläckfisk, perfekt för att grilla eller att steka",
    ImageUrl = "https://media.istockphoto.com/id/1275277646/sv/foto/hela-fryst-bl%C3%A4ckfisk-p%C3%A5-is.jpg?b=1&s=612x612&w=0&k=20&c=qmA5Vjwn4Mi_r1MMDRmWfDO7W8w7upUe8nNL7IjPgDo=",
    Price = 699m
},
new Product
{
    Id = 12,
    Name = "Squid",
    Description = "Hel  Squid, perfekt för att grilla, fritera eller att steka",
    ImageUrl = "https://media.istockphoto.com/id/155156786/sv/foto/squid-seafood-isolated-on-white.jpg?b=1&s=612x612&w=0&k=20&c=VlxW8qe5kXGf_dpgnOJku3zt12uQsuM2OanhlUx1NRg=",
    Price = 300m
},
new Product
{
    Id = 13,
    Name = "Shrimp",
    Description = "1kg Shrimp, perfect for your pasta dish!",
    ImageUrl = "https://media.istockphoto.com/id/618957070/sv/foto/close-up-fresh-shrimps-display-on-ice-fishermen-market-store.jpg?b=1&s=612x612&w=0&k=20&c=key-nb59nOyQCQ6fa72fNhdCAUjaPii0plzn8bbjNRM=",
    Price = 200m
},
};


        [HttpGet]
        public ActionResult<List<Product>> GetProducts()
        {
            return Ok(products);
        }

        [HttpGet("{id}")]
        public ActionResult<Product> GetProduct(int id)
        {
            var product = products.Find(p => p.Id == id);
            if (product == null)
                return NotFound();
            return Ok(product);
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
}