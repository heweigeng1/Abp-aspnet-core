using System;
using Abp.Domain.Repositories;
using Abp.Web.Models;
using Shundao.Areas.Dto;
using Shundao.Common.Paged.Services;
using WxOpenApi.AppPay;

namespace Shundao.Areas
{
    public class AreaAppService : AsyncShundaoCrudAppService<Area,AreaDto,Guid, SelectInput, CreateAreaDto,AreaDto>, IAreaAppService
    {
        private readonly IRepository<Area, Guid> _areaRepository;
        private readonly AreaManager _areaManager;
        public AreaAppService(AreaManager areaManager, IRepository<Area, Guid> areaRepository, MobliePayAppService mobliePayAppService):base(areaRepository)
        {
            _areaRepository = areaRepository;
            _areaManager = areaManager;
        }
        [DontWrapResult]
        public void GetTest2(SelectInput input)
        {
            var dd = input;
        }
        public AreaDto GetAreaMap()
        {
            var list = _areaManager.GetAllListCache();
            var area = list.Find(c => c.NodeName == "中国");
            return ObjectMapper.Map<AreaDto>(area);
        }
    }
}
