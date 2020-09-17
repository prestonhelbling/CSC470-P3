using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_Code
{
    public class FakeAppUserRepository : IAppUser
    {
        private static Dictionary<string, AppUser> AppUsers;

        public FakeAppUserRepository()
        {
            if (AppUsers == null)
            {
                AppUsers = new Dictionary<string, AppUser>();
                // Add some default app users
                AppUsers.Add("BobTheBuilder", new AppUser
                {
                    UserName = "BobTheBuilder",
                    Password = "YesWeCan",
                    FirstName = "Bob",
                    LastName = "TheBuilder",
                    EmailAddress = "bob@canwedoit.org",
                    IsAuthenticated = true
                });

                AppUsers.Add("DoraTheExplorer", new AppUser
                {
                    UserName = "DoraTheExplorer",
                    Password = "SwiperNoSwiping",
                    FirstName = "Dora",
                    LastName = "TheExplorer",
                    EmailAddress = "dora@everybodyletsgo.org",
                    IsAuthenticated = true
                });
            }
        }
        public bool Login(string UserName, string Password)
        {
            AppUser user;
            bool ignore = AppUsers.TryGetValue(UserName, out user);

            if (ignore)
                if (user.Password == Password)
                    return true;

            return false;
        }

        public List<AppUser> GetAll()
        {
            List<AppUser> users = new List<AppUser>();

            foreach (KeyValuePair<string, AppUser> user in AppUsers)
            {
                users.Add(user.Value);
            }

            return users;
        }

        public void SetAuthentication(string UserName, bool IsAuthenticated)
        {
            AppUser user;
            bool ignore = AppUsers.TryGetValue(UserName, out user);
            user.IsAuthenticated = IsAuthenticated;
        }

        public AppUser GetByUserName(string Username)
        {
            AppUser user;
            bool ignore = AppUsers.TryGetValue(Username, out user);
            return user;
        }
    }
}
