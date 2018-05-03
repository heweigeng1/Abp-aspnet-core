using Abp.Application.Services;
using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.Runtime.Caching;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AbpTree.Services
{
    public class TreeService : ApplicationService
    {
        private readonly IRepository<AbpTreeEntity,Guid> treeRepository;
        private readonly ICacheManager cacheManager;
        public TreeService(IRepository<AbpTreeEntity, Guid> _treerepository, ICacheManager _cacheManager)
        {
            treeRepository = _treerepository;
            cacheManager = _cacheManager;
        }
        public AbpTreeEntity Get(Guid id)
        {
            return treeRepository.FirstOrDefault(id);
        }
        public List<AbpTreeEntity> GetList()
        {
            var cache = cacheManager.GetCache("AbpTreeCache");
            return cache.Get("allTreeItem", () => { return treeRepository.GetAllList(); });
        }

        public AbpTreeEntity InitTree()
        {
            throw new NotImplementedException();
        }

    }
}
