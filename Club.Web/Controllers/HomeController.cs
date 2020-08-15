using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Club.Core.Domain;
using Club.Core.Domains;
using Club.Core.Domains.Coachs;
using Club.Core.Model;
using Club.Data;

namespace Club.Web.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {
            
        }

        public ActionResult Index()

        {
            return View("About");
        }

       [HttpPost]
        public ActionResult About(CoachViewModel viewModel)
       {
           var map = AutoMapper.Mapper.Map<Coach>(viewModel);
           return null;
       }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}