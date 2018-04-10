using Abp.Application.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using WxOpenApi.AppPay.Dtos;

namespace WxOpenApi.AppPay
{
    public interface IMobliePayAppService: IApplicationService
    {
        [HttpPost]
        PayingOutput Paying();
        [HttpPost]
        void Nodify();
    }
}
