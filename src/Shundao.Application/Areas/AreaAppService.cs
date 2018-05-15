using System;
using System.Collections.Generic;
using System.Text;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Abp.Runtime.Caching;
using Abp.Web.Models;
using AbpTree;
using AbpTree.Domain;
using AutoMapper;
using Shundao.Areas.Dto;
using Shundao.EntityFrameworkCore.Repositories;
using WxOpenApi.AppPay;

namespace Shundao.Areas
{
    public class AreaAppService : AsyncCrudAppService<Area,AreaDto,Guid,PagedResultRequestDto,CreateAreaDto,AreaDto>, IAreaAppService
    {
        private readonly IRepository<Area, Guid> _areaRepository;
        //private readonly MobliePayAppService _mobliePayAppService;
        //private readonly ShundaoRepositoryBase<Area, Guid> _areaRepository;
        private readonly AreaManager _areaManager;
        public AreaAppService(AreaManager areaManager, IRepository<Area, Guid> areaRepository, MobliePayAppService mobliePayAppService):base(areaRepository)
        {
            _areaRepository = areaRepository;
            _areaManager = areaManager;
        }
        public void Test1()
        {
            var entity = new Area
            {
                Id = Guid.NewGuid(),
                Code = "010",
                NodeName = "中国",
            };
            List<Area> list = new List<Area>
            {
                entity,
                new Area
                {
                    Code = "100000",
                    NodeName = "北京",
                    ParentId = entity.Id
                }
            };
            foreach (var item in list)
            {
                _areaRepository.Insert(item);
            }
        }
        [DontWrapResult]
        public void Test2()
        {
        }
        public AreaDto GetAreaMap()
        {
            var list = _areaManager.GetAllListCache();
            var area = list.Find(c => c.NodeName == "中国");
            return ObjectMapper.Map<AreaDto>(area);
        }
    }
}
