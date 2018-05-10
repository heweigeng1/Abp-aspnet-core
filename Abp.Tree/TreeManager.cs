using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.Runtime.Caching;
using AbpTree.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AbpTree
{
    public class TreeManager<TreeEntity, TreeDto> : IDomainService where TreeEntity : AbpTreeEntity<TreeEntity> where TreeDto : AbpTreeDto<TreeDto>
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
        public TreeDto InitTree(List<TreeDto> list, TreeDto dto)
        {
            RecursionToChild(list, dto);
            return dto;
        }
        public void BrotherNode()
        {

        }
        public void LevelNode()
        {

        }
        private void RecursionToChild(List<TreeDto> list, TreeDto entity)
        {
            var data = list.Where(c => c.ParentId == entity.Id).ToList();
            entity.Child.AddRange(data);
            foreach (var item in data)
            {
                RecursionToChild(list, item);
            }
        }
    }
}
