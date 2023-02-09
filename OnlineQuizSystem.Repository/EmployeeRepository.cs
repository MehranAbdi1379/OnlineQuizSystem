using Framework.Repository;
using OnlineQuizSystem.Domain;
using OnlineQuizSystem.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineQuizSystem.Repository;

public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
{
    public bool NationalCodeIsExist(string nationalCode)
    {
        throw new NotImplementedException();
    }
}