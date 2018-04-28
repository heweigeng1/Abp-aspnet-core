using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.Runtime.Caching;
using System;
using System.Collections.Generic;

namespace AbpTree.Services
{
    public class TreeService<TPrimaryKey> : DomainService, ITreeService<TPrimaryKey>
    {
        private readonly IRepository<ITreeEntity<TPrimaryKey>, TPrimaryKey> treeRepository;
        private readonly ICacheManager cacheManager;
        public TreeService(IRepository<ITreeEntity<TPrimaryKey>, TPrimaryKey> _treerepository, ICacheManager _cacheManager)
        {
            treeRepository = _treerepository;
            cacheManager = _cacheManager;
        }
        public ITreeEntity<TPrimaryKey> Get(TPrimaryKey id)
        {
            return treeRepository.FirstOrDefault(id);
        }

        public List<ITreeEntity<TPrimaryKey>> GetList()
        {
            var cache = cacheManager.GetCache("AbpTreeCache");
            return cache.Get("allTreeItem", () => { return treeRepository.GetAllList(); });
        }

        public ITreeEntity<TPrimaryKey> InitTree()
        {
            throw new NotImplementedException();
        }

    }
}
