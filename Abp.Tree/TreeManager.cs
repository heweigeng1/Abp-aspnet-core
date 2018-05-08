using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.Runtime.Caching;
using AbpTree.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AbpTree
{
    public class TreeManager<TreeEntity> : IDomainService where TreeEntity : AbpTreeEntity<TreeEntity>
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
        public TreeDto InitTree(List<TreeDto> list)
        {
            int minDepth = list.Min(c => c.Depth);
            var array = list.Where(c => c.Depth == minDepth).OrderBy(c=>c.Sorted).ToList();
            var root = new TreeDto
            {
                Depth = -1,
                NodeName = "root",
                Child = array
            };
            foreach (var item in root.Child)
            {
                item.Child = list.Where(c => c.ParentId == item.Id).ToList();
            }
            
            return root;
        }
        public void BrotherNode()
        {

        }
        public void LevelNode()
        {

        }
    }
}
