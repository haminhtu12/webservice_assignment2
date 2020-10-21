using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceAssigment2.Service.Comment
{
    public class test
    {
    }
}



//FRDbContext db = new FRDbContext();

//public bool AddCustomer(Customer customer)
//{
//    try
//    {
//        db.Customers.Add(customer);
//        db.SaveChanges();
//        return true;
//    }
//    catch
//    {
//        return false;
//    }
//}

//public bool DeleteCustomer(int id)
//{
//    try
//    {
//        var customer = db.Customers.Find(id);
//        db.Customers.Remove(customer);
//        db.SaveChanges();
//        return true;
//    }
//    catch
//    {
//        return false;
//    }
//}

//public List<Customer> GetCustomer()
//{
//    var customer = db.Customers.ToList();
//    return customer;
//}

//public bool UpdateCustomer(Customer customer)
//{
//    var cs = db.Customers.Find(customer.ID);
//    db.Customers.Remove(cs);
//    db.Customers.Add(cs);
//    db.SaveChanges();
//    //db.Entry(customer).State = EntityState.Modified;
//    //db.SaveChanges();
//    return true;

//    //var user = db.Users.Where(x => x.ID == us.ID).First();
//    //db.Users.Remove(user);
//    //db.Users.Add(us);
//    //db.SaveChanges();
//    //return true;


//}

//[OperationContract]
//[WebInvoke(Method = "GET",
//       RequestFormat = WebMessageFormat.Json,
//       ResponseFormat = WebMessageFormat.Json,
//        BodyStyle = WebMessageBodyStyle.Bare,
//       UriTemplate = "api/v1/GetCustomerList")]
//List<Customer> GetCustomer();

//[OperationContract]
//[WebInvoke(Method = "POST",
//       RequestFormat = WebMessageFormat.Json,
//       ResponseFormat = WebMessageFormat.Json,
//        BodyStyle = WebMessageBodyStyle.Bare,
//       UriTemplate = "api/v1/CreateCustomer")]
//bool AddCustomer(Customer customer);

//[WebInvoke(Method = "PUT",
//       RequestFormat = WebMessageFormat.Json,
//       ResponseFormat = WebMessageFormat.Json,
//        BodyStyle = WebMessageBodyStyle.Bare,
//       UriTemplate = "api/v1/EditCustomer")]
//bool UpdateCustomer(Customer customer);

//[WebInvoke(Method = "DELETE",
//       RequestFormat = WebMessageFormat.Json,
//       ResponseFormat = WebMessageFormat.Json,
//        BodyStyle = WebMessageBodyStyle.Bare,
//       UriTemplate = "api/v1/DeleteCustomer")]
//bool DeleteCustomer(int id);
//    }
//}