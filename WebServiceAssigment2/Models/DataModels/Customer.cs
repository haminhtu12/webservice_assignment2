using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebServiceAssigment2.Models.DataModels
{
    public class Customer
    {
        [Key]
        public int ID { get; set; }
        public string CustomerName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime Created { get; set; }
        public int Status { get; set; }
        public ICollection<Comments> Comments { get; set; }
    }
}