using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VLN2_Project.Models.Entities
{
    public class User
    {
        [Key]
        public int ID { get; set; }
        public string _email { get; set; }
        public string _userName { get; set; }
        public string _passWord { get; set; }
    }
}