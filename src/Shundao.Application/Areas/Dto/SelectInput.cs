using Abp.Application.Services.Dto;

namespace Shundao.Areas.Dto
{
    public class SelectInput: PagedResultRequestDto
    {
        public string SelectText { get; set; }
    }
}
