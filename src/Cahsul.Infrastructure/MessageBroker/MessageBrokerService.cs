using Cahsul.Application.Services.MessageBroker;
using Cahsul.Application.Services.MessageBroker.Models;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Cahsul.Infrastructure.MessageBroker;

public class MessageBrokerService : IMessageBrokerService
{
    private readonly MessageBrokerOptions _options;
    private readonly ILogger<MessageBrokerService> _logger;

    public MessageBrokerService(IOptions<MessageBrokerOptions> options, ILogger<MessageBrokerService> logger)
    {
        _options = options.Value;
        _logger= logger;
    }

    public void Send(SendMessageModel sendMessageModel)
    {
        if (_options.RabbitMQ.Enabled)
        {
            _logger.LogInformation($"{_options.RabbitMQ.NganuRabbitMQ}: {sendMessageModel.Content}");
        }

        if (_options.Kafka.Enabled)
        {
            _logger.LogInformation($"{_options.Kafka.NganuKafka}: {sendMessageModel.Content}");
        }

        if (_options.MB1.Enabled)
        {
            _logger.LogInformation($"{_options.MB1.NganuMB1}: {sendMessageModel.Content}");
        }

        if (_options.MB2.Enabled)
        {
            _logger.LogInformation($"{_options.MB2.NganuMB2}: {sendMessageModel.Content}");
        }

        if (_options.MB3.Enabled)
        {
            _logger.LogInformation($"{_options.MB3.NganuMB3}: {sendMessageModel.Content}");
        }
    }

    public void Receive()
    {
        throw new NotImplementedException();
    }
}
