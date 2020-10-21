using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WebServiceAssigment2.Models.DataModels;

namespace WebServiceAssigment2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Blogservice" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Blogservice.svc or Blogservice.svc.cs at the Solution Explorer and start debugging.
    public class Blogservice : IBlogservice
    {
        FRDbContext db = new FRDbContext();

        public bool AddBlog(Blog bl)
        {
            try
            {
                db.Blogs.Add(bl);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }

        public bool DeleteBlog(int id)
        {
            try
            {
                var data = db.Blogs.Where(x => x.ID == id).First();
                db.Blogs.Remove(data);
                db.SaveChanges();

                //Blog st = (   from blog in db.Blogs
                //              where blog.ID == id
                //              select blog).Single();
                //db.Blogs.Remove(st);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Blog> GetBlogs()
        {
            var data = db.Blogs.ToList();
            return data;

        }

        public bool UpdateBlog(Blog bl)
        {
            var blog = db.Blogs.Where(x => x.ID == bl.ID).First();
            db.Blogs.Remove(blog);
            db.Blogs.Add(bl);
            db.SaveChanges();
            //db.SubmitChanges();
            return true;
        }
    }
}
