using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BemaxWeekendTask.Models;
namespace BemaxWeekendTask.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            HomeVM model = new HomeVM();
            model.slider = db.Sliders.ToList();
            model.IconBoxes = db.IconBoxes.ToList();
            model.LatestBlogPost = db.LatestPosts.ToList();
            model.testimonial = db.Testimonials.ToList();
            model.working = db.WorkingWithOutAreas.FirstOrDefault() ?? new WorkingWithOutArea();
            model.miniSliders = db.MiniSliders.ToList();
            model.weAreBemaxAreas = db.WeAreBemaxAreas.ToList();
            model.whyChooseUsAreas = db.WhyChooseUsAreas.ToList();
            model.TestimonialsBodies = db.TestimonialsBodies.ToList();
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}