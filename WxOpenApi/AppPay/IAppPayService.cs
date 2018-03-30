using Abp.Application.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace WxOpenApi.AppPay
{
    public interface IAppPayService: IApplicationService
    {
        [HttpPost]
        void Paying();
        [HttpGet]
        void Nodify();
    }
}
