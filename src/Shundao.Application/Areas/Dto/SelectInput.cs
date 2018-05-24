using Shundao.Common.Paged;
using Shundao.Common.Paged.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Shundao.Areas.Dto
{
    public class SelectInput
    {
        [Display(Name = "selectText")]
        public string SelectText { get; set; }
        [Display(Name = "pagination")]
        public AntdProPagedDto Pagination { get; set; }
    }
}
