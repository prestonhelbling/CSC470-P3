using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_Code
{
    //IAppUser Interface
    interface IAppUser
    {
        bool Login(string Username, string Password);
        List<AppUser> GetAll();
        void SetAuthentication(string UserName, bool IsAuthenticated);
        AppUser GetByUserName(string Username);
    }
}