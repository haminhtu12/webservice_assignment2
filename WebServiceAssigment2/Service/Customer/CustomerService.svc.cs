using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WebServiceAssigment2.Models.DataModels;

namespace WebServiceAssigment2.Service.Customer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CustomerService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CustomerService.svc or CustomerService.svc.cs at the Solution Explorer and start debugging.
    public class CustomerService : ICustomerService
    {

        FRDbContext db = new FRDbContext();

        public bool AddCustomer(WebServiceAssigment2.Models.DataModels.Customer customer)
        {
            try
            {
                db.Customers.Add(customer);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteCustomer(int id)
        {
            try
            {
                var customer = db.Customers.Find(id);
                db.Customers.Remove(customer);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<WebServiceAssigment2.Models.DataModels.Customer> GetCustomer()
        {
            var customer = db.Customers.ToList();
            return customer;
        }

        public bool UpdateCustomer(WebServiceAssigment2.Models.DataModels.Customer customer)
        {
            var cs = db.Customers.Find(customer.ID);
            db.Customers.Remove(cs);
            db.Customers.Add(customer);
            db.SaveChanges();
            //db.Entry(customer).State = EntityState.Modified;
            //db.SaveChanges();
            return true;

            //var user = db.Users.Where(x => x.ID == us.ID).First();
            //db.Users.Remove(user);
            //db.Users.Add(us);
            //db.SaveChanges();
            //return true;


        }
    }
}
