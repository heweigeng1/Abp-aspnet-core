using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Dependency;
using Shundao.Areas.Dto;
using Shundao.Common.Paged;
using Shundao.Common.Paged.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shundao.Areas
{
    public interface IAreaAppService : IAsyncShundaoCrudAppService<AreaDto,Guid, SelectInput, CreateAreaDto,AreaDto>
    {

    }
}
