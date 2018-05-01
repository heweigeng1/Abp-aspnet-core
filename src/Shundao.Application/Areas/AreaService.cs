using System;
using System.Collections.Generic;
using System.Text;
using Abp.Domain.Repositories;
using Abp.Runtime.Caching;
using AbpTree;
using AbpTree.Services;

namespace Shundao.Areas
{
    public class AreaService : TreeService, IAreaService
    {
        private readonly IRepository<Area, Guid> areaRepository;
        //private readonly IRepository<ITreeEntity, Guid> treeRepository;
        //private readonly ICacheManager cacheManager;
        public AreaService(IRepository<Area, Guid> _areaRepository, IRepository<ITreeEntity, Guid> _treeRepository, ICacheManager _cacheManager) : base(_treeRepository, _cacheManager)
        {
            areaRepository = _areaRepository;
        }
        public void Test1()
        {
            base.GetList();
        }
    }
}
