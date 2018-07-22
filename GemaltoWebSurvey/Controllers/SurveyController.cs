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
        public ActionResult Index()
        {
            return View();
        }

        // GET: Survey/Details/5
        public ActionResult Details(int id)
        {
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
        public ActionResult TakeSurvey(Survey newSurvey)
        {
            try
            {
                // TODO: Add insert logic here
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

                return RedirectToAction("TakeSurvey");
            }
            catch
            {
                return View(newSurvey);
            }
        }

        // GET: Survey/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Survey/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Survey/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Survey/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
