using HumansLib;

namespace AuthLib
{
    public class UsersAuth
    {
        UsersDAO dao;
        public UsersAuth()
        {
            dao = new UsersDAO();
        }

        bool login(User user, string password) {
            return false;
        }
        bool changePassword(User user, string password) { return false; }
    }
}
