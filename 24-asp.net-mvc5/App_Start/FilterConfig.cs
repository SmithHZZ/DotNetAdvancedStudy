using _24_asp.net_mvc5.Utility;
using System.Web;
using System.Web.Mvc;

namespace _24_asp.net_mvc5
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            //filters.Add(new CustomAuthorizeAttribute());
        }
    }
}
