using Cahsul.Application.Services.MessageBroker;
using Cahsul.Application.Services.MessageBroker.Models;
using Cahsul.Domain.Entities;

namespace Cahsul.Application.Employees;

public class EmployeeService
{
    private readonly IMessageBrokerService _messageBrokerService;

    public EmployeeService(IMessageBrokerService messageBrokerService)
    {
        _messageBrokerService = messageBrokerService;
    }

    public Guid CreateEmployee(string name, decimal salary)
    {
        var employee = new Employee
        {
            Id = Guid.NewGuid(),
            Name = name,
            Salary = salary,
        };

        var sendMessageModel = new SendMessageModel
        {
            Content = $"{employee.Id} {employee.Name} {employee.Salary}"
        };

        _messageBrokerService.Send(sendMessageModel);

        return employee.Id;
    }
}
