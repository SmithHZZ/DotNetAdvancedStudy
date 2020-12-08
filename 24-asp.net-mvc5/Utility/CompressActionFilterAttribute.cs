using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _24_asp.net_mvc5.Utility
{
    public class CompressActionFilterAttribute : ActionFilterAttribute
    {
        private object CompressModex;

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            base.OnActionExecuted(filterContext);
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //这里进行参数检测、敏感词过滤
            foreach (var item in filterContext.ActionParameters)
            {
                LogHelper.WriteLog($"访问接口{filterContext.HttpContext.Request.Url}携带参数：{item.Key} = {item.Value}");
            }

            var request = filterContext.HttpContext.Request;
            var response = filterContext.HttpContext.Response;
            string acceptEncoding = request.Headers["Accept-Encoding"];
            if(!string.IsNullOrWhiteSpace(acceptEncoding) && acceptEncoding.ToUpper().Contains("GZIP"))
            {
                response.AddHeader("Content-Encoding", "gzip");
                response.Filter = new GZipStream(response.Filter, CompressionMode.Compress);
            }
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            base.OnResultExecuted(filterContext);
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            base.OnResultExecuting(filterContext);
        }

    }
}