using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VLN2_Project.Models;
using VLN2_Project.Models.ViewModels;

namespace VLN2_Project.Services
{
    public class UserService
    {
        private ApplicationDbContext _db;
        public UserService()
        {
            _db = new ApplicationDbContext();
        }

        public List<UserViewModel> getAllUsers()
        {
            return null;
        }

        public UserViewModel getSpecificUser(int id)
        {
            return null;
        }
    }
}