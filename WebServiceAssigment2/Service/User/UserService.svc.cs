using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WebServiceAssigment2.Models.DataModels;
using WebServiceAssigment2.Service;

namespace WebServiceAssigment2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "UserService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select UserService.svc or UserService.svc.cs at the Solution Explorer and start debugging.
    public class UserService : IUserService
    {
        FRDbContext db = new FRDbContext();

        public bool AddUser(User user)
        {
            try
            {
                db.Users.Add(user);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteUser(int id)
        {
            try
            {
                var user = db.Users.Find(id);
                db.Users.Remove(user);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<User> GetUsers()
        {
            var users = db.Users.ToList();
            return users;
        }

        public bool UpdateUser(User us)
        {
            var user = db.Users.Where(x => x.ID == us.ID).First();
            db.Users.Remove(user);
            db.Users.Add(us);
            db.SaveChanges();
            return true;

        }
    }
}
