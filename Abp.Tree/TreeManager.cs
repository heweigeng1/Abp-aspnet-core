using Abp.Domain.Repositories;
using Abp.Runtime.Caching;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbpTree
{
    public class TreeManager<TreeEntity>: IDisposable where TreeEntity: AbpTreeEntity
    {
        private readonly ICacheManager _cacheManager;
        private readonly IRepository<TreeEntity, Guid> _repository;
        public TreeManager(ICacheManager cacheManager, IRepository<TreeEntity, Guid> repository)
        {
            _cacheManager = cacheManager;
            _repository = repository;
        }

        public void Dispose()
        {
        }

        public List<TreeEntity> GetAllListCache()
        {
            var cache = _cacheManager.GetCache("AbpTreeCache");
            return cache.Get("allTreeItem", () => { return _repository.GetAllList(); });
        }
    }
}
