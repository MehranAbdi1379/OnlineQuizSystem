using Framework.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineQuizSystem.Domain.Exceptions
{
    public class EmployeeNationalCodeException : DomainException
    {
        public override string Message => ExceptionMessages.EmployeeNationalCodeException;
    }
}
