using Abp.Application.Services;
using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.Runtime.Caching;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AbpTree.Services
{
    public class TreeService : ApplicationService, ITreeService
    {
        private readonly IRepository<ITreeEntity,Guid> treeRepository;
        private readonly ICacheManager cacheManager;
        public TreeService(IRepository<ITreeEntity,Guid> _treerepository, ICacheManager _cacheManager)
        {
            treeRepository = _treerepository;
            cacheManager = _cacheManager;
        }
        public ITreeEntity Get(Guid id)
        {
            return treeRepository.FirstOrDefault(id);
        }
        public List<ITreeEntity> GetList()
        {
            var cache = cacheManager.GetCache("AbpTreeCache");
            return cache.Get("allTreeItem", () => { return treeRepository.GetAllList(); });
        }

        public ITreeEntity InitTree()
        {
            throw new NotImplementedException();
        }

    }
}
