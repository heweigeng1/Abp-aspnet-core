using Abp.Application.Services;
using Abp.Dependency;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shundao.Areas
{
    public interface IAreaAppService : IApplicationService
    {
        void Test1();
    }
}
