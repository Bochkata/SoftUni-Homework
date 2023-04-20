using Industrial_Design.Contracts;
using Industrial_Design.Models.OrderModels;
using Microsoft.AspNetCore.Mvc;
namespace Industrial_Design.Controllers
{
    public class OrdersController : Controller
    {
        private readonly IOrderService _ìOrderService;
        public OrdersController(IOrderService iOrderService)
        {
            _ìOrderService = iOrderService;
        }

        [HttpGet]
        public async Task<IActionResult> AllOrders()
        {
            OrdersAllViewModel OrderAllViewModel = await _ìOrderService.GetAllOrdersAsync();
            return View(OrderAllViewModel);
        }
        [HttpGet]

        public async Task<IActionResult> AddOrder()
        {
            OrderFormModel оrderFormModel = new OrderFormModel();
            return View(оrderFormModel);
        }
        [HttpPost]

        public async Task<IActionResult> AddOrder(OrderFormModel orderFormModel)
        {
            if (!ModelState.IsValid)
            {
                return View(orderFormModel);
            }
            try
            {
                await _ìOrderService.AddOrderAsync(orderFormModel);
                return RedirectToAction(nameof(AllOrders));
            }
            catch (Exception)
            {
                ModelState.AddModelError(string.Empty, "You have entered invalid or incorrect data!");
                return View(orderFormModel);
            }
        }
    }
}
