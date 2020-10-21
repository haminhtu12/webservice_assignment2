using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WebServiceAssigment2.Models.DataModels;

namespace WebServiceAssigment2.Service.Type_Blog
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IType_blogService" in both code and config file together.
    [ServiceContract]
    public interface IType_blogService
    {

        [OperationContract]
        [WebInvoke(Method = "GET",
                RequestFormat = WebMessageFormat.Json,
                ResponseFormat = WebMessageFormat.Json,
                 BodyStyle = WebMessageBodyStyle.Bare,
                UriTemplate = "api/v1/GetTypeBlogList")]
        List<TypeBlog> GetTypeBlogs();

        [OperationContract]
        [WebInvoke(Method = "POST",
               RequestFormat = WebMessageFormat.Json,
               ResponseFormat = WebMessageFormat.Json,
                BodyStyle = WebMessageBodyStyle.Bare,
               UriTemplate = "api/v1/CreateTypeBlog")]
        bool AddTypeBlog(TypeBlog typeBlog);

        [WebInvoke(Method = "PUT",
               RequestFormat = WebMessageFormat.Json,
               ResponseFormat = WebMessageFormat.Json,
                BodyStyle = WebMessageBodyStyle.Bare,
               UriTemplate = "api/v1/EditTypeBlog")]
        bool UpdateUser(TypeBlog typeBlog);

        [WebInvoke(Method = "DELETE",
               RequestFormat = WebMessageFormat.Json,
               ResponseFormat = WebMessageFormat.Json,
                BodyStyle = WebMessageBodyStyle.Bare,
               UriTemplate = "api/v1/DeleteTypeBlog")]
        bool DeleteTypeBlog(int id);
    }
}
