using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.Runtime.Caching;
using Abp.Threading.BackgroundWorkers;
using Abp.Threading.Timers;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbpTree
{
    public class TreeManager<TreeEntity> : IDomainService where TreeEntity : AbpTreeEntity
    {
        private readonly ICacheManager _cacheManager;
        private readonly IRepository<TreeEntity, Guid> _repository;
        public TreeManager(IRepository<TreeEntity, Guid> repository, ICacheManager cacheManager)
        {
            _repository = repository;
            _cacheManager = cacheManager;
        }

        public List<TreeEntity> GetAllListCache()
        {
            var cache = _cacheManager.GetCache("AbpTreeCache");
            return cache.Get("allTreeItem", () => { return _repository.GetAllList(); });
        }
        
    }
}
