using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WebServiceAssigment2.Models.DataModels;

namespace WebServiceAssigment2.Service.Comment
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CommentService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CommentService.svc or CommentService.svc.cs at the Solution Explorer and start debugging.
    public class CommentService : ICommentService
    {
        FRDbContext db = new FRDbContext();

        public bool AddComment(Comments comments, string email, string passWord)
        {
            try
            {
                var obj = db.Customers.Where(a => a.Email.Equals(email)
          && a.Password.Equals(passWord)).FirstOrDefault();
                if (obj != null)
                {
                    db.Comments.Add(comments);
                    db.SaveChanges();
                    return true;

                }
                else
                {
                    return false;
                }

            }
            catch
            {
                return false;
            }
        }

        public bool DeleteComment(int id, string email, string passWord)
        {
            try
            {
                var obj = db.Customers.Where(a => a.Email.Equals(email)
                            && a.Password.Equals(passWord)).FirstOrDefault();
                if (obj != null)
                {

                    var cm = db.Comments.Find(id);
                    db.Comments.Remove(cm);
                    db.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public List<Comments> GetComments()
        {
            var cm = db.Comments.ToList();
            return cm;
        }

        public bool UpdateComment(Comments comments, string email, string passWord)
        {
            var obj = db.Customers.Where(a => a.Email.Equals(email)
                        && a.Password.Equals(passWord)).FirstOrDefault();
            if (obj != null)
            {

                var cm = db.Comments.Where(x => x.ID == comments.ID).First();
                db.Comments.Remove(cm);
                db.Comments.Add(cm);
                db.SaveChanges();
            }
            else
            {
                return false;
            }
            return true;
        }
    }
}
