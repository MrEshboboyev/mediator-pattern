namespace Domain.Interfaces;

public interface IMediator
{
    void Notify(object sender, string eventType);
}
