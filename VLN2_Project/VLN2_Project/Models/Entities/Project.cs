using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VLN2_Project.Models.Entities
{
    public class Project
    {
        public string _title { get; set; }
        [Key]
        public int _ownerID { get; set; }
        List<int> _participantIDs { get; set; }
        List<ProjectFile> _files { get; set; }
        public byte [] bytes { get; set; }
    }
}