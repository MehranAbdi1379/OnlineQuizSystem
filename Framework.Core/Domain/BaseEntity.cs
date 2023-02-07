using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Core;

public class BaseEntity
{
	public BaseEntity()
	{
		Id = Guid.NewGuid();
	}

    public Guid Id { get; set; }
}

