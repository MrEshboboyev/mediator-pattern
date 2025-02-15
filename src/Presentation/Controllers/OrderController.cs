using Microsoft.AspNetCore.Mvc;
using Infrastructure.Services;

namespace Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class OrderController : ControllerBase
{
    private readonly OrderService _orderService;

    public OrderController()
    {
        _orderService = new OrderService();
    }

    [HttpPost("process")]
    public IActionResult ProcessOrder()
    {
        _orderService.ProcessOrder();
        return Ok("Order processing started.");
    }
}
