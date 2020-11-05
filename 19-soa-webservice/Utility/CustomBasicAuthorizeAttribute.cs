using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;

namespace _19_soa_webservice.Utility
{

    public class CustomBasicAuthorizeAttribute : AuthorizeAttribute
    {

        /// <summary>
        /// Action执行前先来这里完成权限校验
        /// 
        /// 
        /// </summary>
        /// <param name="actionContext"></param>
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            try
            {
                string token = actionContext.ControllerContext.Request.Headers.Authorization.Parameter;

                if (token.Contains("1"))
                {
                    return;
                }
            }
            catch(Exception exc)
            {
                throw new HttpResponseException(System.Net.HttpStatusCode.Unauthorized);
            }

        }
    }
}