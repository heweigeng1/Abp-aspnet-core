using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shundao.Areas
{
    public interface IRepository: IRepository<Area,Guid>
    {
    }
}
