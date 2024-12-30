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
        DbportfolioEntities db=new DbportfolioEntities();
        // GET: Statistic
        public ActionResult Index()
        {
            ViewBag.categoryCount = db.TblCategory.Count();
            ViewBag.projectCount= db.TblProject.Count();
            ViewBag.skillCount= db.TblSkill.Count();
            ViewBag.skillAvgValue = db.TblSkill.Average(x => x.Value);
            ViewBag.lastSkillTitleName = db.GetLastSkillTitle().FirstOrDefault();
            ViewBag.mvcCategoryProjectCount=db.TblProject.Where(x => x.ProjectCategoryId ==4).Count();
            return View();
        }
    }
}