using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BinaryStudioAcademy.FacebookLikeApp.Models;

namespace BinaryStudioAcademy.FacebookLikeApp.Controllers
{
    public class ProfileController : Controller
    {
        //
        // GET: /Profile/
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddFriend()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Edit()
        {
            
            return View();
    }
        [HttpPost]
        public ActionResult Edit(User user )
        {
            return View("Index", user);
        }

    }
}
