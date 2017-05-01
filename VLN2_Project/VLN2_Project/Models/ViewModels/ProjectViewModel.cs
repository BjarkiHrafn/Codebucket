using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using VLN2_Project.Models.Entities;

namespace VLN2_Project.Models.ViewModels
{
    public class ProjectViewModel
    {
        public string _title { get; set; }
        List<ProjectFile> _files { get; set; }
    }
}