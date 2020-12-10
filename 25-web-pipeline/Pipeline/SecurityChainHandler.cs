using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _25_web_pipeline.Pipeline
{

    /// <summary>
    /// 防盗链
    /// 
    /// 
    /// 
    /// </summary>
    public class SecurityChainHandler : IHttpHandler
    {
        public bool IsReusable => true;

        public void ProcessRequest(HttpContext context)
        {
            if(context.Request.UrlReferrer == null || context.Request.UrlReferrer.Host == null)
            {
                context.Response.ContentType = "image/JPEG";
                context.Response.WriteFile("~/Content/Image/no.jpg");
            }
            else
            {
                if(context.Request.UrlReferrer.Host.Contains("localhost"))
                {
                    string file = context.Server.MapPath(context.Request.FilePath);
                    context.Response.ContentType = "image/JPEG";
                    context.Response.WriteFile(file);
                }
                else
                {
                    context.Response.ContentType = "image/JPEG";
                    context.Response.WriteFile("~/Content/Image/no.jpg");
                }
            }
        }
    }
}