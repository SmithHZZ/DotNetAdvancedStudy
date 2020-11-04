using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_soa_webservice.Models
{
    public interface IUserService
    {
        User GetUserById(int id);
    }
}
