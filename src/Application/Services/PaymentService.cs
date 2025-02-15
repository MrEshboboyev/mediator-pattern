using System;
using Domain.Interfaces;

namespace Application.Services;

public class PaymentService : IColleague
{
    private IMediator _mediator;

    public void SetMediator(IMediator mediator)
    {
        _mediator = mediator;
    }

    public void ProcessPayment()
    {
        Console.WriteLine("✅ Payment processed.");
        _mediator.Notify(this, "PaymentProcessed");
    }
}
