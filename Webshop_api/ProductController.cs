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
        Name = "Wireless Headphones",
        Description = "High-quality wireless headphones with noise cancellation and 20 hours of battery life.",
        ImageUrl = "https://example.com/images/headphones.jpg",
        Price = 299.99m
    },
    new Product
    {
        Id = 2,
        Name = "Smartphone",
        Description = "A cutting-edge smartphone with a 6.5 inch display, 128GB storage, and a powerful camera.",
        ImageUrl = "https://example.com/images/smartphone.jpg",
        Price = 799.99m
    },
    new Product
    {
        Id = 3,
        Name = "Laptop",
        Description = "A lightweight laptop with an Intel i7 processor, 16GB RAM, and 512GB SSD.",
        ImageUrl = "https://example.com/images/laptop.jpg",
        Price = 1099.99m
    },
    new Product
    {
        Id = 4,
        Name = "Bluetooth Speaker",
        Description = "Compact Bluetooth speaker with excellent sound quality and up to 12 hours of playback time.",
        ImageUrl = "https://example.com/images/speaker.jpg",
        Price = 89.99m
    },
    new Product
    {
        Id = 5,
        Name = "Smartwatch",
        Description = "A stylish smartwatch with fitness tracking, heart rate monitor, and sleep tracking features.",
        ImageUrl = "https://example.com/images/smartwatch.jpg",
        Price = 179.99m
    },
    new Product
    {
        Id = 6,
        Name = "Gaming Mouse",
        Description = "Precision gaming mouse with customizable buttons and RGB lighting.",
        ImageUrl = "https://example.com/images/gaming-mouse.jpg",
        Price = 49.99m
    },
    new Product
    {
        Id = 7,
        Name = "4K Ultra HD TV",
        Description = "A 50-inch 4K Ultra HD TV with HDR, perfect for movie nights and gaming.",
        ImageUrl = "https://example.com/images/tv.jpg",
        Price = 599.99m
    },
    new Product
    {
        Id = 8,
        Name = "Digital Camera",
        Description = "High-resolution digital camera with 4K video recording and a 20MP sensor.",
        ImageUrl = "https://example.com/images/camera.jpg",
        Price = 499.99m
    },
    new Product
    {
        Id = 9,
        Name = "Electric Kettle",
        Description = "Fast boiling electric kettle with 1.7L capacity and automatic shut-off for safety.",
        ImageUrl = "https://example.com/images/kettle.jpg",
        Price = 29.99m
    },
    new Product
    {
        Id = 10,
        Name = "Coffee Maker",
        Description = "Automatic coffee maker with a 12-cup capacity and programmable settings.",
        ImageUrl = "https://example.com/images/coffeemaker.jpg",
        Price = 59.99m
    }
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