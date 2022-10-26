using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebShopDemo.Core.Constants;
using WebShopDemo.Core.Contracts;
using WebShopDemo.Core.Models;

namespace WebShopDemo.Controllers
{
    /// <summary>
    /// Web shop products 
    /// </summary>

    public class ProductController : BaseController
    {

        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        /// <summary>
        /// List all products
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            IEnumerable<ProductDto> products = await _productService.GetAll();

            ViewData["Title"] = "Products";
            return View(products);
        }


        [HttpGet]
        [Authorize(Roles = $"{RoleConstants.Manager},{RoleConstants.Supervisor}")]
        public IActionResult Add()
        {
            ProductDto model = new ProductDto();
            ViewData["Title"] = "Add new product";
            return View(model);
        }

        [HttpPost]
        [Authorize(Roles = $"{RoleConstants.Manager},{RoleConstants.Supervisor}")]
        public async Task<IActionResult> Add(ProductDto model)
        {
            ViewData["Title"] = "Add new product";
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            await _productService.Add(model);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        //[Authorize(Roles = RoleConstants.Supervisor)]
        [Authorize(Policy = PolicyTypeConstants.CanDeleteProduct)]
        public async Task<IActionResult> Delete([FromForm] string id)
        {
            Guid idGuid = Guid.Parse(id);
            await _productService.Delete(idGuid);


            return RedirectToAction(nameof(Index));
        }

    }
}
