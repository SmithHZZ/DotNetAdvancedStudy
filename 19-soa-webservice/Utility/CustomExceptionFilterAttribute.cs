using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Filters;

namespace _19_soa_webservice.Utility
{
    public class CustomExceptionFilterAttribute : ExceptionFilterAttribute
    {

        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            //可以获取Request Response

            Console.WriteLine(actionExecutedContext.Exception.Message);

            actionExecutedContext.Response = actionExecutedContext.Request.CreateResponse(HttpStatusCode.OK, actionExecutedContext.Exception);

            //base.OnException(actionExecutedContext);

        }

    }
}