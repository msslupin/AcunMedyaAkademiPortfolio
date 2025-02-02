using AcunMedyaAkademiPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiPortfolio.Models;

namespace AcunMedyaAkademiPortfolio.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        DbPortfolioEntities5 db = new DbPortfolioEntities5();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }

        public PartialViewResult PartialFeature()
        {
            var values = db.TblFeature.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialAbout()
        {
            var values = db.TblAbout.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialProfile()
        {
            var values = db.TblProfile.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialHobby()
        {
            var values = db.TblHobby.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialSkill()
        {
            var values = db.TblSkill.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialService()
        {
            var values = db.TblService.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialProjects()
        {
            var values = db.TblProject.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialTestimonials()
        {
            var values = db.TblTestimonial.ToList();
            return PartialView(values);
        }
        [HttpGet]
        public PartialViewResult PartialContact()
        {

            return PartialView();
        }
        [HttpPost]
        public PartialViewResult PartialContact(TblContact y)
        {
            if (ModelState.IsValid)
            {
                db.TblContact.Add(y);
                db.SaveChanges();

                ViewBag.RedirectUrl = Url.Action("Index", "Default");
            }
            return PartialView();
        }
        public PartialViewResult PartialAddress()
        {
            var values = db.TblAdress.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialFooter()
        {
            var values = db.TblContact.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialStatistic()
        {
            var skillcount = db.TblSkill.ToList().Count();
            ViewBag.SkillCount = skillcount;
            var Projectcount = db.TblProject.ToList().Count();
            ViewBag.ProjectCount = Projectcount;
            var TestimonialCount = db.TblTestimonial.ToList().Count();
            ViewBag.TestimonialCount = TestimonialCount;
            var ServiceCount = db.TblService.ToList().Count();
            ViewBag.ServiceCount = ServiceCount;
            return PartialView();
        }

    }
}