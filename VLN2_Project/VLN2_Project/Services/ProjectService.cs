using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VLN2_Project.Models;
using VLN2_Project.Models.ViewModels;

namespace VLN2_Project.Services
{
    public class ProjectService
    {
        private ApplicationDbContext _db;
        public ProjectService()
        {
            _db = new ApplicationDbContext();
        }

        public List<ProjectViewModel> getProjectsByUser(int id)
        {
            return null;
        }

        public ProjectViewModel getSpecificProjectByUser(string name, int id)
        {
            return null;
        }
    }
}