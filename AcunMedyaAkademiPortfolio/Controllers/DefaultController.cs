using AcunMedyaAkademiPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Mvc;
namespace AcunMedyaAkademiPortfolio.Controllers
{
    public class DefaultController : Controller
    {
        DbportfolioEntities db = new DbportfolioEntities();
        // GET: Default
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
        public PartialViewResult PartialSkill()
        {
            var values = db.TblSkill.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialStatistic()
        {
            var skillCount = db.TblSkill.ToList().Count();
            ViewBag.SkillCount = skillCount;

            var projectCount = db.TblProject.ToList().Count();
            ViewBag.ProjectCount = projectCount;

            var testimonialCount = db.TblTestimonial.ToList().Count();
            ViewBag.TestimonialCount = testimonialCount;

            var servicesCount = db.TblService.ToList().Count();
            ViewBag.ServicesCount = servicesCount;

            return PartialView();
        }
        public PartialViewResult PartialProfile()
        {
            var values = db.TblProfile.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialService()
        {
            var values = db.TblService.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialProject()
        {
            var values = db.TblProject.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialTestimonial()
        {
            var values = db.TblTestimonial.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialContact()
        {
            var values = db.TblContact.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialAdress()
        {
            var values = db.TblAdress.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialFooter()
        {
            using (var context = new DbportfolioEntities()) 
            {
                var model = new PartialViewModel
                {
                    Table1Data = context.TblService.ToList(),
                    Table2Data = context.TblProfile.ToList(),
                    Table3Data = context.TblSocialMedia.ToList()
                };
                return PartialView("PartialFooter", model);
            }

           
        }
        
    }
}