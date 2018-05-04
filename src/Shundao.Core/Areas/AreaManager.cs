using Abp.Dependency;
using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.Runtime.Caching;
using Abp.Threading.Timers;
using AbpTree;
using System;

namespace Shundao.Areas
{
    public class AreaManager : TreeManager<Area>, IDomainService, ISingletonDependency
    {
       public  IRepository<Area, Guid> _repository {protected get; set; }
        public AreaManager(IRepository<Area, Guid> repository,AbpTimer timer, ICacheManager cacheManager) : base(repository, cacheManager)
        {
            repository = _repository;
        }

    }
}
