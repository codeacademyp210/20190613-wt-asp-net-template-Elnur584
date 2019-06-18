using BemaxWeekendTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BemaxWeekendTask.Controllers
{
    public class BaseController : Controller
    {
        protected BemaxEntities2 db;

        public BaseController()
        {
            db = new BemaxEntities2();
            ViewBag.Ayarlar = db.Settings.FirstOrDefault();
            ViewBag.Settings = db.ContactSettings.FirstOrDefault();
        }
        
    }
}