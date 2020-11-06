using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.ExceptionHandling;
using System.Web.Http.Results;

namespace _19_soa_webservice.Utility
{
    public class CustomExceptionHandler : ExceptionHandler
    {

        public override void Handle(ExceptionHandlerContext context)
        {
            context.Result = new ResponseMessageResult(context.Request.CreateResponse(HttpStatusCode.OK, context.Exception));
            //base.Handle(context);
        }

        public override bool ShouldHandle(ExceptionHandlerContext context)
        {
            return context.Request.RequestUri.AbsoluteUri.Contains("/api/");
        }

    }
}