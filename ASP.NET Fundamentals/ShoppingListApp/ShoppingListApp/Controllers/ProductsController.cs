using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ShoppingListApp.Data;
using ShoppingListApp.Models;

namespace ShoppingListApp.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ShoppingListDbContext _shoppingListDbContext;
        public ProductsController(ShoppingListDbContext shoppingListDbContext)
        {
            _shoppingListDbContext = shoppingListDbContext; 
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult All()
        {
            List<ProductViewModel> products = _shoppingListDbContext.Products
                .Select(p=> new ProductViewModel
                {
                    Id = p.Id,
                    Name = p.Name
                })
                .ToList();  
            return View(products);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]  
        public IActionResult Add(ProductFormModel model)
        {
            Product product = new Product()
            {
                Name = model.Name,
            };

            _shoppingListDbContext.Products.Add(product);
            _shoppingListDbContext.SaveChanges();
             return RedirectToAction(nameof(All));
        }
        /// <summary>
        /// Http Get - display the Edit Form
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult Edit(int id)
        {
            Product product = _shoppingListDbContext.Products.Find(id);
            
            return View(new ProductFormModel
            {
                Name = product.Name
            }); 
        }
        /// <summary>
        /// Http Post - Update the database
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Edit(int id, Product model)
        {
            Product product = _shoppingListDbContext.Products.Find(id); 
           
            product.Name = model.Name;
            _shoppingListDbContext.SaveChanges();
            return RedirectToAction(nameof(All));
        }

        [HttpPost]

        public IActionResult Delete(int id)
        {
            Product product = _shoppingListDbContext.Products.Find(id); 
            _shoppingListDbContext.Products.Remove(product);
            _shoppingListDbContext.SaveChanges();
            return RedirectToAction(nameof(All));
        }
    }
}
