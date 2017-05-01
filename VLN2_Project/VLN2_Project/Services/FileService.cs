using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VLN2_Project.Models;
using VLN2_Project.Models.ViewModels;

namespace VLN2_Project.Services
{
    public class FileService
    {
        private ApplicationDbContext _db;
        public FileService()
        {
            _db = new ApplicationDbContext();
        }

        public List<ProjectFileViewModel> getFilesByProject(int id)
        {
            return null;
        }
    }
}