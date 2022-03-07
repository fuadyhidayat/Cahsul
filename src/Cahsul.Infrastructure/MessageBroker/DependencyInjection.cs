using Cahsul.Application.Services.MessageBroker;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Cahsul.Infrastructure.MessageBroker;

public static class DependencyInjection
{
    public static IServiceCollection AddMessageBrokerService(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<MessageBrokerOptions>(configuration.GetSection(MessageBrokerOptions.SectionKey));

        services.AddTransient<IMessageBrokerService, MessageBrokerService>();

        return services;
    }
}
