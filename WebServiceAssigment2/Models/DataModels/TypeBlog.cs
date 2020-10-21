using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebServiceAssigment2.Models.DataModels
{
    public class TypeBlog
    {
        [Key]
        public int ID { get; set; }
        public string TypeName { get; set; }
        public string Descriptions { get; set; }
        public int Status { get; set; }
        public ICollection<Blog> Blogs { get; set; }
    }
}