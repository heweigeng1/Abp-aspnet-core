using System;
using System.Collections.Generic;
using System.Text;
using Abp.Application.Services;
using Abp.Domain.Repositories;
using Abp.Runtime.Caching;
using AbpTree;
using AbpTree.Services;

namespace Shundao.Areas
{
    public class AreaService : ApplicationService, IAreaService
    {
        private readonly IRepository<Area, Guid> areaRepository;
        //private readonly IRepository<ITreeEntity, Guid> treeRepository;
        //private readonly ICacheManager cacheManager;
        public AreaService(IRepository<Area, Guid> _areaRepository, IRepository<AbpTreeEntity, Guid> _treeRepository, ICacheManager _cacheManager) 
        {
            areaRepository = _areaRepository;
        }
        public void Test1()
        {

        }
    }
}
