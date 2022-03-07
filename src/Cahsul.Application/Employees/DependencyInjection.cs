using Microsoft.Extensions.DependencyInjection;

namespace Cahsul.Application.Employees;

public static class DependencyInjection
{
    public static IServiceCollection AddEmployeeService(this IServiceCollection services)
    {
        services.AddTransient<EmployeeService>();

        return services;
    }
}
