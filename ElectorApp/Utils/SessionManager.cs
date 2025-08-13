using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectorApp.Utils
{
    internal class SessionManager
    {
        private static bool isLoggedIn = false;
        private static long userId = 0;
        private static bool isAdmin = false;

        public static void Login(long userId, bool isAdmin)
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
