﻿using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using WxOpenApi.AppPay.Dtos;
using WxOpenApi.Config;
using WxOpenApi.Utils;

namespace WxOpenApi.AppPay
{
    public class MobliePayAppService : ApplicationService, IMobliePayAppService
    {
        private object Request;

        public void Nodify()
        {
            using (MemoryStream ms = new MemoryStream())
            {
                
                //Request.Body.CopyTo(ms);
                byte[] bytes = ms.ToArray();
                string requestxml = Encoding.UTF8.GetString(bytes);
                string return_string = string.Empty;
                SortedDictionary<string, string> map = new SortedDictionary<string, string>();
                object obj = WxUtils.XmlDeserialize(typeof(AppPayUnifiedOrderCallbackDto), requestxml);
                if (obj is AppPayUnifiedOrderCallbackDto && ((AppPayUnifiedOrderCallbackDto)obj).result_code == "SUCCESS")
                {
                    //成功则在此对订单执行操作
                    map.Add("return_code", "SUCCESS");
                    map.Add("return_msg", "");
                }
                else
                {
                    map.Add("return_code", "FAIL");
                    map.Add("return_msg", "统一下单失败");
                }
                string xml = map.SortedDictionaryToWxXml();
                //Response.Body.Write(xml);
                //Response.Body.EndWrite();
                
            }

        }

        public PayingOutput Paying()
        {
            #region 统一下单map
            SortedDictionary<string, string> untifiedOrder = new SortedDictionary<string, string>()
            {
                {"appid",WxConfig.AppId},
                {"attach" , "wxpay" },
                { "body", "订单支付"},
                {" mch_id", WxConfig.MCH_ID },
                {"nonce_str", WxUtils.RandomStr(16)},
                { "notify_url", WxConfig.AppPayNodifyUrl},
                { "spbill_create_ip",""},//用户IP
                { "total_fee", "0.01"},//金额
                {"trade_type","APP" },
                {"out_trade_no",DateTime.Now.ToString("yyyyMMddHHmmss")+WxUtils.RandomStr(2) }
            };
            #endregion

            #region 生成sign
            string md5key = $@"{ untifiedOrder.SortedDictionaryToWxUrl()}&key={WxConfig.PARTNER_ID}";
            string sign = WxUtils.GetSign(md5key, "utf-8");
            #endregion

            #region 请求微信统一下单接口 获取预支付订单号
            string xml = untifiedOrder.SortedDictionaryToWxXml().Replace("</xml>", $@"<sign><![CDATA[{ sign }]]></sign></xml>");
            string callbackXml = WxUtils.PostToUnifiedOrder(xml);//请求微信统一下单接口
            AppPayUnifiedOrderCallbackDto callbackobj = (AppPayUnifiedOrderCallbackDto)WxUtils.XmlDeserialize(typeof(AppPayUnifiedOrderCallbackDto), callbackXml);
            #endregion
            #region 用户端sign
            PayingOutput output = new PayingOutput
            {
                appid = WxConfig.AppId,
                noncestr = WxUtils.RandomStr(16),
                package = "Sign=WXPay",
                partnerid = WxConfig.PARTNER_ID,
                prepayid = callbackobj.prepay_id,
                timestamp = DateTime.UtcNow.ToTimeStamp(),
                sign = "",
            };
            var appmap = WxUtils.ObjToSortedDictionary(output);
            string appmd5key = $@"{ appmap.SortedDictionaryToWxUrl()}&key={WxConfig.PARTNER_ID}";
            output.sign = WxUtils.GetSign(appmd5key, "utf-8");
            #endregion
            return output;
        }
    }
}
