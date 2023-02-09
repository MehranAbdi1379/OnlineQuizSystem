using Framework.Core;
using Framework.Domain;
using OnlineQuizSystem.Domain.Exceptions;
using OnlineQuizSystem.Domain.Repositories;

namespace OnlineQuizSystem.Domain;

public class Employee : BaseEntity
{
    public Employee()
    {

    }

    public Employee(string firstName, 
        string lastName, 
        string nationalCode,
        DateTime birthDate,
        IEmployeeRepository repository)
    {
        SetFirstName(firstName);
        SetLastName(lastName);
        SetNationalCode(nationalCode , repository);
    }

    public string FirstName { get; private set; }
    public string LastName { get;  private set; }
    public string NationalCode { get;  private set; }
    public DateTime BirthDate { get;   private set; }

    public void SetFirstName(string firstName)
    {
        if (string.IsNullOrWhiteSpace(firstName))
            throw new EmployeeFirstNameRequiredException();
        FirstName = firstName;
    }

    public void SetLastName(string lastName)
    {
        if (string.IsNullOrWhiteSpace(lastName))
            throw new EmployeeFirstNameRequiredException();
        FirstName = lastName;
    }

    public void SetNationalCode(string nationalCode, IEmployeeRepository repository)
    {
        if (repository.NationalCodeIsExist(nationalCode))
            throw new EmployeeNationalCodeException();
        NationalCode = nationalCode;
    }
}

