using System;
using System.Collections.Generic;
using System.Text;
using Abp.Application.Services;
using Abp.Domain.Repositories;
using Abp.Runtime.Caching;
using AbpTree;
using AbpTree.Domain;
using AutoMapper;
using Shundao.Areas.Dto;
using Shundao.EntityFrameworkCore.Repositories;

namespace Shundao.Areas
{
    public class AreaAppService : ApplicationService, IAreaAppService
    {
        //private readonly IRepository<Area, Guid> _areaRepository;
        private readonly ShundaoRepositoryBase<Area, Guid> _areaRepository;
        private readonly TreeManager<Area, AreaDto> _treeManager;
        public AreaAppService(TreeManager<Area, AreaDto> treeManager)
        {
            //_areaRepository = areaRepository;
            _treeManager = treeManager;
        }
        public void Test1()
        {
          
            var entity = new Area
            {
                Id = Guid.NewGuid(),
                Code = "010",
                NodeName = "中国",
            };
            List<Area> list = new List<Area>();
            list.Add(entity);
            list.Add(new Area {
                Code="100000",
                NodeName="北京",
                ParentId=entity.Id
            });
            _areaRepository.Context.AddRange(list);
        }
        public AreaDto GetAreaMap()
        {
            var list = ObjectMapper.Map<List<AreaDto>>(_treeManager.GetAllListCache());
            var dto = list.Find(c => c.NodeName == "中国");
            return _treeManager.InitTree(list, dto);
        }
    }
}
