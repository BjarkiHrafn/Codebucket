using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VLN2_Project.Services;

namespace VLN2_Project.Controllers
{
    public class ProjectController : Controller
    {
        private ProjectService _service = new ProjectService();

        // GET: Project
        public ActionResult Index()
        {
            return View();
        }
    }
}