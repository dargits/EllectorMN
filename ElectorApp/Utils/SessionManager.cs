using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectorApp.Utils
{
    internal class SessionManager
    {
        public static bool isLoggedIn = false;
        public static int userId = 0;
        public static bool isAdmin = false;

        public static void Login(int userId, bool isAdmin)
        {
            SessionManager.userId = userId;
            SessionManager.isAdmin = isAdmin;
            isLoggedIn = true;
        }

        public static void Logout()
        {
            userId = 0;
            isAdmin = false;
            isLoggedIn = false;
        }
    }
}
