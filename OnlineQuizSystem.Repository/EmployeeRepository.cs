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
    public EmployeeRepository(BaseDbContext context) : base(context)
    {
    }

    public bool NationalCodeIsExist(string nationalCode)
    {
        return context.Set<Employee>().Any(e => e.NationalCode == nationalCode);
    }
}