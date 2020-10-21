using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WebServiceAssigment2.Models.DataModels;

namespace WebServiceAssigment2.Service.Type_Blog
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Type_blogService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Type_blogService.svc or Type_blogService.svc.cs at the Solution Explorer and start debugging.
    public class Type_blogService : IType_blogService
    {
        FRDbContext db = new FRDbContext();

        public bool AddTypeBlog(TypeBlog typeBlog)
        {

            try
            {
                db.TypeBlogs.Add(typeBlog);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }

        public bool DeleteTypeBlog(int id)
        {
            try
            {
                var tb = db.TypeBlogs.Find(id);
                db.TypeBlogs.Remove(tb);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<TypeBlog> GetTypeBlogs()
        {
            var tb = db.TypeBlogs.ToList();
            return tb;
        }

        public bool UpdateUser(TypeBlog typeBlog)
        {
            var tb = db.TypeBlogs.Where(x => x.ID == typeBlog.ID).First();
            db.TypeBlogs.Remove(tb);
            db.TypeBlogs.Add(typeBlog);
            db.SaveChanges();
            return true;
        }
    }
}
