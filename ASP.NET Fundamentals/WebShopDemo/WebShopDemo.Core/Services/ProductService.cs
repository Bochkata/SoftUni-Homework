
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Text.Json.Serialization;
using WebShopDemo.Core.Contracts;
using WebShopDemo.Core.Data.Common;
using WebShopDemo.Core.Data.Models;
using WebShopDemo.Core.Models;

namespace WebShopDemo.Core.Services
{
    /// <summary>
    /// Manipulates product data
    /// </summary>
    public class ProductService : IProductService
    {
        private readonly IRepository _repo;

        private readonly IConfiguration _config;
        /// <summary>
        /// IoC container
        /// </summary>
        /// <param name="config">Application configuration</param>
        public ProductService(IConfiguration config,
            IRepository repo)
        {
            _config = config;
            _repo = repo;
        }

        /// <summary>
        /// Add new product
        /// </summary>
        /// <param name="productDto">Product model</param>
        /// <returns></returns>
        public async Task Add(ProductDto productDto)
        {
            Product product = new Product()
            {
                Name = productDto.Name,
                Price = productDto.Price,
                Quantity = productDto.Quantity
            };

            await _repo.AddAsync(product);
            await _repo.SaveChangesAsync();
        }

        public async Task Delete(Guid id)
        {
            Product product = await _repo.All<Product>()
                .FirstOrDefaultAsync(p => p.Id == id);

            if (product != null)
            {
                product.IsActive = false;
                await _repo.SaveChangesAsync();
            }
        }

        /// <summary>
        /// Get all products
        /// </summary>
        /// <returns>List of products</returns>
        public async Task<IEnumerable<ProductDto>> GetAll()
        {
            return await _repo.AllReadonly<Product>()
                .Where(p=>p.IsActive)
                .Select(p => new ProductDto()
                {
                    Id = p.Id,
                    Name = p.Name,
                    Price = p.Price,
                    Quantity = p.Quantity
                })
                .ToListAsync();


            //string dataPath = _config.GetSection("DataFiles:Products").Value;
            //string data = await File.ReadAllTextAsync(dataPath);

            //return JsonConvert.DeserializeObject<IEnumerable<ProductDto>>(data);

        }
    }
}
