using HumansLib;
using System;

namespace AuthLib
{
    public class UsersAuth
    {
        UsersDAO dao;
        public UsersAuth()
        {
            dao = new UsersDAO();
        }

        bool login(User user, string password)
        {
            bool valid = validate(password);
            if (!valid)
                return false;
            return new UsersDAO().exists(user, password);
        }
        bool changePassword(User user, string password)
        {
            bool valid = validate(password);
            if (!valid)
                return false;
            StudentsDAO dao = new StudentsDAO();
            user = (User)dao.getByID(user.id);
            return dao.edit(user);
        }
        private bool validate(string password)
        {
            throw new NotImplementedException();//todo
        }

    }
}
