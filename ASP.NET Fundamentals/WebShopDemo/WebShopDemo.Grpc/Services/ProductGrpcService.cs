using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using WebShopDemo.Core.Contracts;
using WebShopDemo.Core.Models;

namespace WebShopDemo.Grpc.Services
{
	public class ProductGrpcService : Product.ProductBase
	{
		private readonly IProductService _productService;

		public ProductGrpcService(IProductService productService)
		{
			_productService = productService;
		}

		public override async Task<ProductList> GetAll(Empty request, ServerCallContext context)
		{
			ProductList productList = new ProductList();
			IEnumerable<ProductDto> products = await _productService.GetAll();
			productList.Items.AddRange(products.Select(x => new ProductItem()
			{
				Name = x.Name,
				Id = x.Id.ToString(),
				Price = (double)x.Price,
				Quantity = x.Quantity

			}));


			return productList;
		}
	}
}
