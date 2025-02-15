using System;
using Domain.Interfaces;

namespace Application.Services;

public class ShippingService : IColleague
{
    private IMediator _mediator;

    public void SetMediator(IMediator mediator)
    {
        _mediator = mediator;
    }

    public void ShipOrder()
    {
        Console.WriteLine("🚚 Order shipped.");
        _mediator.Notify(this, "OrderShipped");
    }
}
