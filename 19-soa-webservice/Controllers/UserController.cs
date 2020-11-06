using _19_soa_webservice.Models;
using _19_soa_webservice.Utility;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace _19_soa_webservice.Controllers
{
    public class UserController : ApiController
    {
        /// <summary>
        /// 加上FromUri特性
        /// 才能映射成对象
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        //[HttpGet]
        //public string GetUserInfo([FromUri]User user)
        //{
        //    return JsonConvert.SerializeObject(user);
        //}

        [HttpPost]
        public string GetUserInfo1([FromBody] User user)
        {
            return JsonConvert.SerializeObject(user);
        }

        [HttpPost]
        public string GetUserInfo2([FromBody] dynamic user)
        {
            Console.WriteLine(user.Id);
            Console.WriteLine(user.UserName);
            return user.ToString();
        }

        //[HttpGet]
        //[CustomBasicAuthorize]
        //public string GetUserInfo()
        //{
        //    return JsonConvert.SerializeObject(new User() { Id = 1 });
        //}

        /// <summary>
        /// 异常处理
        /// 
        /// 
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        //[CustomExceptionFilter]
        public string GetExceptionHandle()
        {
            Random random = new Random();
            if(random.Next()%2 == 0)
            {
                return JsonConvert.SerializeObject(new User() { Id = 1 });
            }
            throw new Exception("出问题了！");
        }

    }
}