using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shundao.Areas.Dto
{
    public class AreaDto : EntityDto<Guid>
    {
        public string Code { get; set; }
    }
}
