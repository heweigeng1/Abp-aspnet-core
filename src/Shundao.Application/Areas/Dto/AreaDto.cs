using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using AbpTree.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shundao.Areas.Dto
{
    [AutoMapFrom(typeof(Area))]
    public class AreaDto : AbpTreeDto<AreaDto>
    {
        public string Code { get; set; }
    }
}
