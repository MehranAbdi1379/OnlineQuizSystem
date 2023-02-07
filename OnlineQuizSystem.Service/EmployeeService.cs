using OnlineQuizSystem.Domain;
using OnlineQuizSystem.Domain.Repositories;
using OnlineQuizSystem.Service.Contracts;
using OnlineQuizSystem.Service.Contracts.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineQuizSystem.Service;

public class EmployeeService : IEmployeeService
{
    private readonly IEmployeeRepository repository;

    public EmployeeService(IEmployeeRepository repository)
    {
        this.repository = repository;
    }
    
    public Employee CreateEmployee(CreateEmployeeDto dto)
    {
        var employee = new Employee(
                dto.FirstName,
                dto.LastName,
                dto.NationalCode,
                dto.BirthDate,
                repository
            );

        repository.Create(employee);
        return employee;
    }
}
