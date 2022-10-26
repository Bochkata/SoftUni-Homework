using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebShopDemo.Core.Contracts;
using WebShopDemo.Core.Models;
using WebShopDemo.Core.Services;

namespace WebShopDemo.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductController : ControllerBase
	{
		private readonly IProductService _productService;

		public ProductController(IProductService productService)
		{
			_productService = productService;
		}
	/// <summary>
	/// Get all products
	/// </summary>
	/// <returns></returns>
		[HttpGet]
		[Produces("application/json")]
		[ProducesResponseType(200, StatusCode = StatusCodes.Status200OK, Type = typeof (IEnumerable<ProductDto>))]
		public async Task<IActionResult> GetAll()
		{
			return Ok(await _productService.GetAll());
		}

	}
}
