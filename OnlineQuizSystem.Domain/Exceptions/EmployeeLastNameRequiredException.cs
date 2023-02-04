using Framework.Domain;

namespace OnlineQuizSystem.Domain.Exceptions
{
    public class EmployeeLastNameRequiredException : DomainException
    {
        public override string Message => ExceptionMessages.EmployeeLastNameRequiredException;
    }
}
