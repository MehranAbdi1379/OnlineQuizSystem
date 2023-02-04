using Framework.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineQuizSystem.Domain.Exceptions
{
    public class EmployeeFirstNameRequiredException : DomainException
    {
        public override string Message => ExceptionMessages.EmployeeFirstNameRequiredException;
    }
}
