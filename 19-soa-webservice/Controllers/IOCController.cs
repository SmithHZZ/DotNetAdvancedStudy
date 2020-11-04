using _19_soa_webservice.Models;
using _19_soa_webservice.Utility;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Unity;

namespace _19_soa_webservice.Controllers
{
    public class IOCController : ApiController
    {

        private IUserService _UserService;

        public IOCController(IUserService service)
        {
            _UserService = service;
        }

        //还没做到自动注入
        //public string Get(int id)
        //{
        //    IUserService userService = ContainerFactory.BuildContainer().Resolve<IUserService>();

        //    return JsonConvert.SerializeObject(userService.GetUserById(id));
        //}

        public string Get(int id)
        {
            return JsonConvert.SerializeObject(_UserService.GetUserById(id));
        }

    }
}
