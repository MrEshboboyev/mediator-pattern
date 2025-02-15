using System;
using Domain.Interfaces;

namespace Application.Services;

public class NotificationService : IColleague
{
    private IMediator _mediator;

    public void SetMediator(IMediator mediator)
    {
        _mediator = mediator;
    }

    public void SendEmail()
    {
        Console.WriteLine("📧 Confirmation email sent.");
    }
}
