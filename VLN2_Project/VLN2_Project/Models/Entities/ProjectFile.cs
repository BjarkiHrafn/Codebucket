using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace VLN2_Project.Models.Entities
{
    public class ProjectFile
    {
        [Key]
        public int _projectID { get; set; }
        public string _name { get; set; }
        public string _type { get; set; }
    }
}