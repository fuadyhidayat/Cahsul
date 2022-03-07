using Cahsul.Application.Services.MessageBroker.Models;

namespace Cahsul.Application.Services.MessageBroker;

public interface IMessageBrokerService
{
    void Send(SendMessageModel sendMessageModel);
    void Receive();
}
