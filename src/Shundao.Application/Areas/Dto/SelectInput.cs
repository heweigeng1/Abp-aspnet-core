using Abp.Application.Services.Dto;
using Shundao.Common.Paged;
using Shundao.Common.Paged.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Shundao.Areas.Dto
{
    public class SelectInput: PagedResultRequestDto
    {
        public string SelectText { get; set; }
    }
}
