using Application.Mediators;
using Application.Services;

namespace Infrastructure.Services;

public class OrderService
{
    private readonly OrderMediator _mediator;
    private readonly PaymentService _paymentService;
    private readonly InventoryService _inventoryService;
    private readonly ShippingService _shippingService;
    private readonly NotificationService _notificationService;

    public OrderService()
    {
        _mediator = new OrderMediator();

        _paymentService = new PaymentService();
        _inventoryService = new InventoryService();
        _shippingService = new ShippingService();
        _notificationService = new NotificationService();

        _mediator.PaymentService = _paymentService;
        _mediator.InventoryService = _inventoryService;
        _mediator.ShippingService = _shippingService;
        _mediator.NotificationService = _notificationService;

        _paymentService.SetMediator(_mediator);
        _inventoryService.SetMediator(_mediator);
        _shippingService.SetMediator(_mediator);
        _notificationService.SetMediator(_mediator);
    }

    public void ProcessOrder()
    {
        _paymentService.ProcessPayment();
    }
}
