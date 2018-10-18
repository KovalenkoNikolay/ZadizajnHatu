using RestEase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.ApiContracts
{
    public interface IUserApi
    {
        [Post("api/user")]
        Task RegisterClientAsync([Body] Contracts.User user);
    }
}
