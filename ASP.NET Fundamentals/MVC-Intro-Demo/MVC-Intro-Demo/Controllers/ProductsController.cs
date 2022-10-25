using Microsoft.AspNetCore.Mvc;
using MVC_Intro_Demo.Models;
using System.Net.Mail;
using System.Text;
using System.Text.Json;

namespace MVC_Intro_Demo.Controllers
{
    public class ProductsController : Controller
    {
        private IEnumerable<ProductViewModel> products = new List<ProductViewModel>()
        {
            new ProductViewModel()
            {
                Id = 1,
                Name = "Cheese",
                Price = 7.00
            },
            new ProductViewModel()
            {
                Id=2,
                Name = "Ham",
                Price = 5.50
            },
            new ProductViewModel()
            {
                Id=3,
                Name = "Bread",
                Price = 1.50

            }
        };

        [ActionName("My-Products")]
        public IActionResult All(string keyword)
        {
            if (keyword != null)
            {
                IEnumerable<ProductViewModel> foundProduct = products.Where(x => x.Name.ToLower().Contains(keyword.ToLower()));

                return View(foundProduct);
            }
           return View(products);   

        }
        //public IActionResult All()
        //{
        //    return View(this.products);
        //}

        public IActionResult ById(int Id)
        {
            ProductViewModel product = products.FirstOrDefault(x => x.Id == Id);

            if (product == null)
            {
                return BadRequest();
            }
            return View(product);
        }

        public IActionResult AllAsJson()
        {
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };
            return Json(products, options);
        }

        public IActionResult AllAsText()
        {
            StringBuilder text = new StringBuilder();
            foreach (ProductViewModel product in products)
            {
                text.AppendLine($"Product {product.Id}: {product.Name} - {product.Price}lv");
            }
            return Content(text.ToString());
        }

        public IActionResult AllAsTextFile()
        {
            StringBuilder text = new StringBuilder();
            foreach (ProductViewModel product in products)
            {
                text.AppendLine($"Product {product.Id}: {product.Name} - {product.Price}lv");
            }

            Response.Headers.Add("content-disposition", "attachment; filename=products.txt");

            return File(Encoding.UTF8.GetBytes(text.ToString()), "text/plain");

            //return File(Encoding.UTF8.GetBytes(text.ToString()), "text/plain", "products.txt");
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
