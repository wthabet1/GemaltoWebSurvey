using GemaltoWebSurvey.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GemaltoWebSurvey.Tests.Models
{
    [TestClass]
    public class SurveyReportTest
    {
        [TestMethod]
        public void NoSurveyTakers()
        {
            List<Survey> lstSurveys = new List<Survey>();
            SurveyReport report = new SurveyReport(lstSurveys);
            Assert.IsTrue(report.SurveyTakers == 0);
        }

        [TestMethod]
        public void OneSurveyTaker()
        {
            Survey survey = new Survey();
            List<Survey> lstSurveys = new List<Survey>();
            lstSurveys.Add(survey);
            SurveyReport report = new SurveyReport(lstSurveys);
            Assert.IsTrue(report.SurveyTakers == 1);
            Assert.IsTrue(report.PositiveProductFeedback == 0);
            Assert.IsTrue(report.NegativeProductFeedback == 0);
        }

    }
}
