using Application.Services;
using Domain.Interfaces;

namespace Application.Mediators;

public class OrderMediator : IMediator
{
    public PaymentService PaymentService { get; set; }
    public InventoryService InventoryService { get; set; }
    public ShippingService ShippingService { get; set; }
    public NotificationService NotificationService { get; set; }

    public void Notify(object sender, string eventType)
    {
        if (eventType == "PaymentProcessed")
        {
            Console.WriteLine("💰 Payment successful, updating inventory...");
            InventoryService.UpdateStock();
        }
        else if (eventType == "StockUpdated")
        {
            Console.WriteLine("📦 Stock updated, initiating shipping...");
            ShippingService.ShipOrder();
        }
        else if (eventType == "OrderShipped")
        {
            Console.WriteLine("📧 Order shipped, sending confirmation email...");
            NotificationService.SendEmail();
        }
    }
}
