using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GemaltoWebSurvey;
using GemaltoWebSurvey.Controllers;

namespace GemaltoWebSurvey.Tests.Controllers
{
    [TestClass]
    public class SurveyControllerTest
    {
        [TestMethod]
        public void TakeSurvey()
        {
            // Arrange
            SurveyController controller = new SurveyController();

            // Act
            ViewResult result = controller.TakeSurvey() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void SurveyReport()
        {
            // Arrange
            SurveyController controller = new SurveyController();

            // Act
            ViewResult result = controller.SurveyReport() as ViewResult;
       
            // Assert
            Assert.IsNotNull(result);
        }
    }
}
