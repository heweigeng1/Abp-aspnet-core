using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Shundao.Common.Paged
{
    public class AntdProPagedDto: PagedResultRequestDto
    {
        [JsonProperty("pageSize")]
        public override int MaxResultCount { get; set; }
        [JsonProperty("skip")]
        public override int SkipCount { get; set; }
        [JsonProperty("sorter")]
        public string Sorter { get; set; }
        [JsonProperty("current")]
        public string Current { get; set; }
    }
}
