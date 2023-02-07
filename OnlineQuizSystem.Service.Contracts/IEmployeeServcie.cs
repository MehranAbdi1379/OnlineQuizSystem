using OnlineQuizSystem.Domain;
using OnlineQuizSystem.Service.Contracts.Dto;

namespace OnlineQuizSystem.Service.Contracts;

public interface IEmployeeService
{
    Employee CreateEmployee(CreateEmployeeDto dto);
}
