using Abp.Application.Services;
using Shundao.Areas.Dto;
using System;

namespace Shundao.Areas
{
    public interface IAreaAppService : IAsyncCrudAppService<AreaDto,Guid, SelectInput, CreateAreaDto,AreaDto>
    {

    }
}
