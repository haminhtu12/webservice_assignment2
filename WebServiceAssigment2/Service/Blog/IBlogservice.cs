using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WebServiceAssigment2.Models.DataModels;

namespace WebServiceAssigment2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IBlogservice" in both code and config file together.
    [ServiceContract]
    public interface IBlogservice
    {
        [OperationContract]
        [WebInvoke(Method = "GET",
               RequestFormat = WebMessageFormat.Json,
               ResponseFormat = WebMessageFormat.Json,
                BodyStyle = WebMessageBodyStyle.Bare,
               UriTemplate = "api/v1/GetBlogList")]
        List<Blog> GetBlogs();

        [OperationContract]
        [WebInvoke(Method = "POST",
               RequestFormat = WebMessageFormat.Json,
               ResponseFormat = WebMessageFormat.Json,
                BodyStyle = WebMessageBodyStyle.Bare,
               UriTemplate = "api/v1/CreateBlog")]
        bool AddBlog(Blog bl);

        [WebInvoke(Method = "PUT",
               RequestFormat = WebMessageFormat.Json,
               ResponseFormat = WebMessageFormat.Json,
                BodyStyle = WebMessageBodyStyle.Bare,
               UriTemplate = "api/v1/EditBlog")]
        bool UpdateBlog(Blog st);

        [WebInvoke(Method = "DELETE",
               RequestFormat = WebMessageFormat.Json,
               ResponseFormat = WebMessageFormat.Json,
                BodyStyle = WebMessageBodyStyle.Bare,
               UriTemplate = "api/v1/DeleteBlog")]
        bool DeleteBlog(int id);

    }
}
