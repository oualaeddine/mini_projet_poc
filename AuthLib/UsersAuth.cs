﻿using System;
using HumansLib;

namespace AuthLib
{
    public class UsersAuth : MarshalByRefObject

    {
        UsersDAO dao;

        public UsersAuth()
        {
            dao = new UsersDAO();
        }

        public bool login(User user, string password)
        {
            bool valid = validate(password);
         //   if (!valid)
            //    return false;
            return new UsersDAO().exists(user, password);
        }

        public bool changePassword(User user, string password)
        {
            bool valid = validate(password);
            if (!valid)
                return false;
            UsersDAO dao = new UsersDAO();
            user = (User) dao.getByID(user.id);
            return dao.edit(user);
        }

        private bool validate(string password)
        {
            return password.Length > 7;
        }
    }
}