﻿using System;
using System.Collections.Generic;
using System.Text;
using Abp.Application.Services;
using Abp.Domain.Repositories;
using Abp.Runtime.Caching;
using AbpTree;
using AbpTree.Services;

namespace Shundao.Areas
{
    public class AreaAppService : ApplicationService, IAreaAppService
    {
        private readonly IRepository<Area, Guid> _areaRepository;
        private readonly AreaManager  _areaManager;
        //private readonly IRepository<ITreeEntity, Guid> treeRepository;
        //private readonly ICacheManager cacheManager;
        public AreaAppService(IRepository<Area, Guid> areaRepository, ICacheManager cacheManager,AreaManager areaManager) 
        {
            _areaRepository = areaRepository;
            _areaManager = areaManager;
        }
        public void Test1()
        {
            _areaRepository.Insert(new Area
            {
                Id = Guid.NewGuid(),
                Code = "527200",
                NodeName = "顶顶顶",
                
            });
        }
        public int Test2()
        {
          return  _areaManager.GetAllListCache().Count;
        }
    }
}