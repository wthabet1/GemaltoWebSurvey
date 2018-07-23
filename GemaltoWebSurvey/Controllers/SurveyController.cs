using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GemaltoWebSurvey.Models;
using Newtonsoft.Json;

namespace GemaltoWebSurvey.Controllers
{
    public class SurveyController : Controller
    {
        // GET: Survey
        public ActionResult ThankYou()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        // GET: Survey/SurveyReport
        public ActionResult SurveyReport()
        {
            string strSurveyAsJsonObjects = string.Empty;
            var dataFile = Server.MapPath("~/App_Data/data.txt");
            if (System.IO.File.Exists(dataFile))
            {
                strSurveyAsJsonObjects = System.IO.File.ReadAllText(@dataFile);
                strSurveyAsJsonObjects = strSurveyAsJsonObjects.TrimEnd(',');

                strSurveyAsJsonObjects = "[" + strSurveyAsJsonObjects + "]";
                List<Survey> surveys = JsonConvert.DeserializeObject<List<Survey>>(strSurveyAsJsonObjects);
                SurveyReport report = new SurveyReport(surveys);
                return View(report);
            }
            return View();
        }

        // GET: Survey/TakeSurvey
        public ActionResult TakeSurvey()
        {
            Survey newSurvey = new Survey();
            return View(newSurvey);
        }

        // POST: Survey/TakeSurvey
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TakeSurvey(Survey newSurvey)
        {
            try
            {
                string strNewSurveyAsJoson =  JsonConvert.SerializeObject(newSurvey) + ",";
                var dataFile = Server.MapPath("~/App_Data/data.txt");
                if (!System.IO.File.Exists(dataFile))
                {
                    System.IO.File.WriteAllText(@dataFile, strNewSurveyAsJoson);
                }
                else
                {
                    System.IO.File.AppendAllText(@dataFile, strNewSurveyAsJoson);
                }

                return RedirectToAction("ThankYou");
            }
            catch(Exception e)
            {
                ViewBag.Error = e?.Message + ":" + e?.InnerException?.Message;
                return View(newSurvey);
            }
        }
    }
}
