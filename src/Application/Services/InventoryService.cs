using System;
using Domain.Interfaces;

namespace Application.Services;

public class InventoryService : IColleague
{
    private IMediator _mediator;

    public void SetMediator(IMediator mediator)
    {
        _mediator = mediator;
    }

    public void UpdateStock()
    {
        Console.WriteLine("📦 Stock updated.");
        _mediator.Notify(this, "StockUpdated");
    }
}
