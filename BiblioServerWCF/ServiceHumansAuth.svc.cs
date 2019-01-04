using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AuthLib;
using HumansLib;
using HumansLib.profs;

namespace BiblioServerWCF
{
    public class ServiceHumansAuth : IServiceHumansAuth
    {
        public bool login(string type, string username, string password)
        {
            switch (type)
            {
                case "prof":
                {
                    var prof = new Prof {email = username};
                    return new AuthMember().login(prof, password);
                }
                case "student":
                {
                    var student = new Student() {email = username};
                    return new AuthMember().login(student, password);
                }
                case "user":
                {
                    var user = new User();
                    return new UsersAuth().login(user, password);
                }
                default: return false;
            }
        }

        public bool changePassword(string type, string userId, string password)
        {
            switch (type)
            {
                case "prof":
                {
                    var prof = new Prof {id = Convert.ToInt32(userId)};
                    return new AuthMember().changePassword(prof, password);
                }
                case "student":
                {
                    var student = new Student() {id = Convert.ToInt32(userId)};
                    return new AuthMember().changePassword(student, password);
                }
                case "user":
                {
                    var user = new User() {id = Convert.ToInt32(userId)};
                    return new UsersAuth().changePassword(user, password);
                }
                default: return false;
            }
        }
    }
}