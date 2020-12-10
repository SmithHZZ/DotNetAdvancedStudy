using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _25_web_pipeline.Pipeline
{
    /// <summary>
    /// 直播平台
    /// 网页播放
    /// jwplayer
    /// 需要一个配置文件.rtmp
    /// 
    /// 
    /// 现在所有的.rtmp都直接到这里来处理
    /// </summary>
    public class CustomRTMPHandler : IHttpHandler
    {
        public bool IsReusable => true;

        public void ProcessRequest(HttpContext context)
        {
            Console.WriteLine("CustomRTMPHandler ProcessRequest");

            context.Response.ContentType = "text/html";
        }
    }
}