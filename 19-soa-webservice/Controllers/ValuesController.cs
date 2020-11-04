using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _19_soa_webservice.Controllers
{

    //[RoutePrefix("api/Values/")]
    //路由前缀
    //某个Action不想用统一前缀可以再特性路由上加 `符号
    public class ValuesController : ApiController
    {
        // GET: api/Values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Values/5
        //特性路由
        //约束路由
        [Route(template: "api/Values/{id:int}")]
        public string Get(int id)
        {
            return "value";
        }

        //特性路由
        [Route(template: "api/Values/{id}/v2")]
        public string Getv2(int id)
        {
            return DateTime.Now.ToString();
        }

        [Route(template: "api/Values/{name}")]
        public string Get(string name)
        {
            return $"value {name}";
        }

        //多参数
        [Route(template: "api/Values/{id}/name/{name}")]
        public string Get(int id,string name)
        {
            return $"{id} {name}";
        }

        [ActionName("Test")]
        public string GetTest()
        {
            return $"id name";
        }

        // POST: api/Values
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Values/5
        public void Delete(int id)
        {
        }
    }
}
