using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WebServiceAssigment2.Models.DataModels;

namespace WebServiceAssigment2.Service.Comment
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICommentService" in both code and config file together.
    [ServiceContract]
    public interface ICommentService
    {

        [OperationContract]
        [WebInvoke(Method = "GET",
                RequestFormat = WebMessageFormat.Json,
                ResponseFormat = WebMessageFormat.Json,
                 BodyStyle = WebMessageBodyStyle.Bare,
                UriTemplate = "api/v1/GetCommentList")]
        List<Comments> GetComments();

        [OperationContract]
        [WebInvoke(Method = "POST",
               RequestFormat = WebMessageFormat.Json,
               ResponseFormat = WebMessageFormat.Json,
                BodyStyle = WebMessageBodyStyle.Bare,
               UriTemplate = "api/v1/CreateComments")]
        bool AddComment(Comments comments, string email, string passWord);

        [WebInvoke(Method = "PUT",
               RequestFormat = WebMessageFormat.Json,
               ResponseFormat = WebMessageFormat.Json,
                BodyStyle = WebMessageBodyStyle.Bare,
               UriTemplate = "api/v1/EditComment")]
        bool UpdateComment(Comments comments, string email, string passWord);

        [WebInvoke(Method = "DELETE",
               RequestFormat = WebMessageFormat.Json,
               ResponseFormat = WebMessageFormat.Json,
                BodyStyle = WebMessageBodyStyle.Bare,
               UriTemplate = "api/v1/DeleteComment")]
        bool DeleteComment(int id, string email, string passWord);
    }
}
