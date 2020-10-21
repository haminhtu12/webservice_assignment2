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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IUserService" in both code and config file together.
    [ServiceContract]
    public interface IUserService
    {
        [OperationContract]
        [WebInvoke(Method = "GET",
                RequestFormat = WebMessageFormat.Json,
                ResponseFormat = WebMessageFormat.Json,
                 BodyStyle = WebMessageBodyStyle.Bare,
                UriTemplate = "api/v1/GetUserList")]
        List<User> GetUsers();

        [OperationContract]
        [WebInvoke(Method = "POST",
               RequestFormat = WebMessageFormat.Json,
               ResponseFormat = WebMessageFormat.Json,
                BodyStyle = WebMessageBodyStyle.Bare,
               UriTemplate = "api/v1/CreateUser")]
        bool AddUser(User user);

        [WebInvoke(Method = "PUT",
               RequestFormat = WebMessageFormat.Json,
               ResponseFormat = WebMessageFormat.Json,
                BodyStyle = WebMessageBodyStyle.Bare,
               UriTemplate = "api/v1/EditUser")]
        bool UpdateUser(User st);

        [WebInvoke(Method = "DELETE",
               RequestFormat = WebMessageFormat.Json,
               ResponseFormat = WebMessageFormat.Json,
                BodyStyle = WebMessageBodyStyle.Bare,
               UriTemplate = "api/v1/DeleteUser")]
        bool DeleteUser(int id);

    }
}
