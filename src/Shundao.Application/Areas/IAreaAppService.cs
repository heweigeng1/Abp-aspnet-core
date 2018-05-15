using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Dependency;
using Shundao.Areas.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shundao.Areas
{
    public interface IAreaAppService : IAsyncCrudAppService<AreaDto,Guid,PagedResultRequestDto,CreateAreaDto,AreaDto>
    {

    }
}
