using Cahsul.Application.Employees;
using Microsoft.Extensions.DependencyInjection;

namespace Cahsul.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddEmployeeService();

        return services;
    }
}
