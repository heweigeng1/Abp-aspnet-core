using Abp.Dependency;
using AbpTree.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shundao.Areas
{
    public interface IAreaAppService:ITransientDependency
    {
        void Test1();
    }
}
