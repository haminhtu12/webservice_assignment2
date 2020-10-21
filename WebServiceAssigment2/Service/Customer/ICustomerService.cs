using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WebServiceAssigment2.Models.DataModels;

namespace WebServiceAssigment2.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICustomerService" in both code and config file together.
    [ServiceContract]
    public interface ICustomerService
    {

        [OperationContract]
        [WebInvoke(Method = "GET",
               RequestFormat = WebMessageFormat.Json,
               ResponseFormat = WebMessageFormat.Json,
                BodyStyle = WebMessageBodyStyle.Bare,
               UriTemplate = "api/v1/GetCustomerList")]
        List<WebServiceAssigment2.Models.DataModels.Customer> GetCustomer();

        [OperationContract]
        [WebInvoke(Method = "POST",
               RequestFormat = WebMessageFormat.Json,
               ResponseFormat = WebMessageFormat.Json,
                BodyStyle = WebMessageBodyStyle.Bare,
               UriTemplate = "api/v1/CreateCustomer")]
        bool AddCustomer(WebServiceAssigment2.Models.DataModels.Customer customer);

        [WebInvoke(Method = "PUT",
               RequestFormat = WebMessageFormat.Json,
               ResponseFormat = WebMessageFormat.Json,
                BodyStyle = WebMessageBodyStyle.Bare,
               UriTemplate = "api/v1/EditCustomer")]
        bool UpdateCustomer(WebServiceAssigment2.Models.DataModels.Customer customer);

        [WebInvoke(Method = "DELETE",
               RequestFormat = WebMessageFormat.Json,
               ResponseFormat = WebMessageFormat.Json,
                BodyStyle = WebMessageBodyStyle.Bare,
               UriTemplate = "api/v1/DeleteCustomer")]
        bool DeleteCustomer(int id);

    }
}
