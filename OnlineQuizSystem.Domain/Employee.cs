using Framework.Domain;
using OnlineQuizSystem.Domain.Exceptions;
using OnlineQuizSystem.Domain.Repositories;

namespace OnlineQuizSystem.Domain;

public class Employee : BaseEntity
{
    private readonly IEmployeeRepository repository;

    public Employee(string firstName, 
        string lastName, 
        string nationalCode,
        DateTime birthDate,
        IEmployeeRepository repository)
    {
        SetFirstName(firstName);
        SetLastName(lastName);
        this.repository = repository;
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string NationalCode { get; set; }
    public DateTime BirthDate { get; set; }

    private void SetFirstName(string firstName)
    {
        if (string.IsNullOrWhiteSpace(firstName))
            throw new EmployeeFirstNameRequiredException();
        FirstName = firstName;
    }

    private void SetLastName(string lastName)
    {
        if (string.IsNullOrWhiteSpace(lastName))
            throw new EmployeeFirstNameRequiredException();
        FirstName = lastName;
    }

    private void SetNationalCode(string nationalCode)
    {
        if (repository.NationalCodeIsExist(nationalCode))
            //TODO: Create Exception
            throw new Exception();
    }
}

