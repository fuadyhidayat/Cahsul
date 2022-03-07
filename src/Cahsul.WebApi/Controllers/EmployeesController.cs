using Cahsul.Application.Employees;
using Microsoft.AspNetCore.Mvc;

namespace Cahsul.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class EmployeesController : ControllerBase
{
    private readonly EmployeeService _employeeService;

    public EmployeesController(EmployeeService employeeService )
    {
        _employeeService = employeeService;
    }

    [HttpPost]
    public ActionResult<Guid> CreateEmployee([FromForm] string name, [FromForm] decimal salary)
    {
        var employeeId = _employeeService.CreateEmployee(name, salary);

        return CreatedAtAction(nameof(CreateEmployee), employeeId);
    }
}
