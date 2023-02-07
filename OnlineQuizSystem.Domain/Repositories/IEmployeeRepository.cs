using Framework.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineQuizSystem.Domain.Repositories
{
    public interface IEmployeeRepository : IBaseRepository <Employee>
    {
        bool NationalCodeIsExist(string nationalCode);
    }
}
