using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiPortfolio.Models;

namespace AcunMedyaAkademiPortfolio.Controllers
{
    public class StatisticController : Controller
    {
        DbPortfolioEntities5 db = new DbPortfolioEntities5();
        public ActionResult Index()
        {

            ViewBag.categoryCount = db.TblCategory.Count();
            ViewBag.projectCount = db.TblProject.Count();
            ViewBag.skillCount = db.TblSkill.Count();
            ViewBag.skillAvgValue = db.TblSkill.Average(x => x.Value);
            ViewBag.lastSkillTitleName = db.GetLastSkillTitle().FirstOrDefault();
            ViewBag.mvcCategoryProjectCount = db.TblProject.Where(x => x.ProjectCategory == 4).Count();
            ViewBag.cssCategoryProjectCount = db.TblProject.Where(x => x.ProjectCategory == 7).Count();
            ViewBag.javaCategoryProjectCount = db.TblProject.Where(x => x.ProjectCategory == 5).Count();
            ViewBag.phpCategoryProjectCount = db.TblProject.Where(x => x.ProjectCategory == 6).Count();
            ViewBag.hobbyCount = db.TblHobby.Count();
            return View();
        }
    }
}