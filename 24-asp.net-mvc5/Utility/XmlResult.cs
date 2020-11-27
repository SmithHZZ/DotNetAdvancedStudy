using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using System.Xml.Serialization;

namespace _24_asp.net_mvc5.Utility
{


    public class XmlResult : ActionResult
    {
        private object _Data;

        public XmlResult(object data)
        {
            _Data = data;
        }

        public override void ExecuteResult(ControllerContext context)
        {
            var response = context.HttpContext.Response;

            response.ContentType = "text/xml";

            var serializer = new XmlSerializer(_Data.GetType());

            serializer.Serialize(response.Output, _Data);

        }
    }
}