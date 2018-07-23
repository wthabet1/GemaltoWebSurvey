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
    public class SurveyTest
    {
        [TestMethod]
        public void VerySatisfied()
        {
            Survey survey = new Survey();
            survey.Satisfaction = "Very satisfied";
            Assert.IsTrue(survey.Satisfied());
        }

        [TestMethod]
        public void SomewhatSatisfied()
        {
            Survey survey = new Survey();
            survey.Satisfaction = "Somewhat satisfied";
            Assert.IsTrue(survey.Satisfied());
        }

        [TestMethod]
        public void NeitherSatisfiedNorDissatisfied()
        {
            Survey survey = new Survey();
            survey.Satisfaction = "Neither satisfied nor dissatisfied";
            Assert.IsFalse(survey.Satisfied());
        }

        [TestMethod]
        public void SomewhatDissatisfied()
        {
            Survey survey = new Survey();
            survey.Satisfaction = "Somewhat dissatisfied";
            Assert.IsFalse(survey.Satisfied());
        }

        [TestMethod]
        public void Dissatisfied()
        {
            Survey survey = new Survey();
            survey.Satisfaction = "Very dissatisfied";
            Assert.IsFalse(survey.Satisfied());
        }

        [TestMethod]
        public void IsReliable()
        {
            Survey survey = new Survey();
            List<string> productDesc = new List<string>();
            productDesc.Add("Reliable");
            survey.ProductDescription = productDesc;
            Assert.IsTrue(survey.PositiveProductFeedback());
            Assert.IsFalse(survey.NegativeProductFeedback());
        }

        [TestMethod]
        public void HighQuality()
        {
            Survey survey = new Survey();
            List<string> productDesc = new List<string>();
            productDesc.Add("High quality");
            survey.ProductDescription = productDesc;
            Assert.IsTrue(survey.PositiveProductFeedback());
            Assert.IsFalse(survey.NegativeProductFeedback());
        }

        [TestMethod]
        public void Useful()
        {
            Survey survey = new Survey();
            List<string> productDesc = new List<string>();
            productDesc.Add("Useful");
            survey.ProductDescription = productDesc;
            Assert.IsTrue(survey.PositiveProductFeedback());
            Assert.IsFalse(survey.NegativeProductFeedback());
        }

        [TestMethod]
        public void Unique()
        {
            Survey survey = new Survey();
            List<string> productDesc = new List<string>();
            productDesc.Add("Unique");
            survey.ProductDescription = productDesc;
            Assert.IsTrue(survey.PositiveProductFeedback());
            Assert.IsFalse(survey.NegativeProductFeedback());
        }

        [TestMethod]
        public void GoodValueForMoney()
        {
            Survey survey = new Survey();
            List<string> productDesc = new List<string>();
            productDesc.Add("Good value for money");
            survey.ProductDescription = productDesc;
            Assert.IsTrue(survey.PositiveProductFeedback());
            Assert.IsFalse(survey.NegativeProductFeedback());
        }

        [TestMethod]
        public void Overpriced()
        {
            Survey survey = new Survey();
            List<string> productDesc = new List<string>();
            productDesc.Add("Overpriced");
            survey.ProductDescription = productDesc;
            Assert.IsFalse(survey.PositiveProductFeedback());
            Assert.IsTrue(survey.NegativeProductFeedback());
        }

        [TestMethod]
        public void Impractical()
        {
            Survey survey = new Survey();
            List<string> productDesc = new List<string>();
            productDesc.Add("Impractical");
            survey.ProductDescription = productDesc;
            Assert.IsFalse(survey.PositiveProductFeedback());
            Assert.IsTrue(survey.NegativeProductFeedback());
        }

        [TestMethod]
        public void Ineffective()
        {
            Survey survey = new Survey();
            List<string> productDesc = new List<string>();
            productDesc.Add("Ineffective");
            survey.ProductDescription = productDesc;
            Assert.IsFalse(survey.PositiveProductFeedback());
            Assert.IsTrue(survey.NegativeProductFeedback());
        }

        [TestMethod]
        public void PoorQuality()
        {
            Survey survey = new Survey();
            List<string> productDesc = new List<string>();
            productDesc.Add("Poor quality");
            survey.ProductDescription = productDesc;
            Assert.IsFalse(survey.PositiveProductFeedback());
            Assert.IsTrue(survey.NegativeProductFeedback());
        }

        [TestMethod]
        public void Unreliable()
        {
            Survey survey = new Survey();
            List<string> productDesc = new List<string>();
            productDesc.Add("Unreliable");
            survey.ProductDescription = productDesc;
            Assert.IsFalse(survey.PositiveProductFeedback());
            Assert.IsTrue(survey.NegativeProductFeedback());
        }

        [TestMethod]
        public void MixedProductDesc()
        {
            Survey survey = new Survey();
            List<string> productDesc = new List<string>();
            productDesc.Add("Unreliable");
            productDesc.Add("Unique");
            survey.ProductDescription = productDesc;
            Assert.IsTrue(survey.PositiveProductFeedback());
            Assert.IsTrue(survey.NegativeProductFeedback());
        }

        [TestMethod]
        public void SuitableExtremelyWell()
        {
            Survey survey = new Survey();
            survey.Suitability = "Extremely well";
            Assert.IsTrue(survey.Suitable());
        }

        [TestMethod]
        public void SuitableVeryWell()
        {
            Survey survey = new Survey();
            survey.Suitability = "Very well";
            Assert.IsTrue(survey.Suitable());
        }

        [TestMethod]
        public void SuitableSomewhatWell()
        {
            Survey survey = new Survey();
            survey.Suitability = "Somewhat well";
            Assert.IsFalse(survey.Suitable());
        }

        [TestMethod]
        public void SuitableNotSoWell()
        {
            Survey survey = new Survey();
            survey.Suitability = "Not so well";
            Assert.IsFalse(survey.Suitable());
        }

        [TestMethod]
        public void SuitableNotAtWell()
        {
            Survey survey = new Survey();
            survey.Suitability = "Not at all well";
            Assert.IsFalse(survey.Suitable());
        }

        [TestMethod]
        public void VeryHighQuality()
        {
            Survey survey = new Survey();
            survey.ProductQuality = "Very high quality";
            Assert.IsTrue(survey.HighQuality());
        }

        [TestMethod]
        public void HighQualityProduct()
        {
            Survey survey = new Survey();
            survey.ProductQuality = "High quality";
            Assert.IsTrue(survey.HighQuality());
        }

        [TestMethod]
        public void NeitherHighQualityNorPoorQuality()
        {
            Survey survey = new Survey();
            survey.ProductQuality = "Neither high nor low quality";
            Assert.IsFalse(survey.HighQuality());
        }

        [TestMethod]
        public void LowQuality()
        {
            Survey survey = new Survey();
            survey.ProductQuality = "Low quality";
            Assert.IsFalse(survey.HighQuality());
        }

        [TestMethod]
        public void VeryLowQuality()
        {
            Survey survey = new Survey();
            survey.ProductQuality = "Very low quality";
            Assert.IsFalse(survey.HighQuality());
        }

        [TestMethod]
        public void ExcellentValueForMoney()
        {
            Survey survey = new Survey();
            survey.ValueForMoney = "Excellent";
            Assert.IsTrue(survey.HasValueForMoney());
        }

        [TestMethod]
        public void AboveAvgValueForMoney()
        {
            Survey survey = new Survey();
            survey.ValueForMoney = "Above average";
            Assert.IsTrue(survey.HasValueForMoney());
        }

        [TestMethod]
        public void AvgValueForMoney()
        {
            Survey survey = new Survey();
            survey.ValueForMoney = "Average";
            Assert.IsFalse(survey.HasValueForMoney());
        }

        [TestMethod]
        public void BelowAvgValueForMoney()
        {
            Survey survey = new Survey();
            survey.ValueForMoney = "Below average";
            Assert.IsFalse(survey.HasValueForMoney());
        }

        [TestMethod]
        public void PoorValueForMoney()
        {
            Survey survey = new Survey();
            survey.ValueForMoney = "Poor";
            Assert.IsFalse(survey.HasValueForMoney());
        }

        [TestMethod]
        public void CustomerCareExtremelyResponsive()
        {
            Survey survey = new Survey();
            survey.CustomerCare = "Extremely responsive";
            bool blnApplicable = false;
            Assert.IsTrue(survey.IsCustomerCareResponsive(out blnApplicable));
        }

        [TestMethod]
        public void CustomerCareVeryResponsive()
        {
            Survey survey = new Survey();
            survey.CustomerCare = "Very responsive";
            bool blnApplicable = false;
            Assert.IsTrue(survey.IsCustomerCareResponsive(out blnApplicable));
        }

        [TestMethod]
        public void CustomerCareSomewhatResponsive()
        {
            Survey survey = new Survey();
            survey.CustomerCare = "Somewhat responsive";
            bool blnApplicable = false;
            Assert.IsFalse(survey.IsCustomerCareResponsive(out blnApplicable));
        }

        [TestMethod]
        public void CustomerCareNotSoResponsive()
        {
            Survey survey = new Survey();
            survey.CustomerCare = "Not so responsive";
            bool blnApplicable = false;
            Assert.IsFalse(survey.IsCustomerCareResponsive(out blnApplicable));
        }

        [TestMethod]
        public void CustomerCareNotAtAllResponsive()
        {
            Survey survey = new Survey();
            survey.CustomerCare = "Not at all responsive";
            bool blnApplicable = false;
            Assert.IsFalse(survey.IsCustomerCareResponsive(out blnApplicable));
            Assert.IsTrue(blnApplicable);
        }
        
        [TestMethod]
        public void CustomerCareNotApplicable()
        {
            Survey survey = new Survey();
            survey.CustomerCare = "Not applicable";
            bool blnApplicable = true;
            Assert.IsTrue(survey.IsCustomerCareResponsive(out blnApplicable));
            Assert.IsFalse(blnApplicable);
        }

        [TestMethod]
        public void FirstPurchase()
        {
            Survey survey = new Survey();
            survey.CustomerHistory = "This is my first purchase";
            Assert.IsFalse(survey.EstablishedCustomer());
        }

        [TestMethod]
        public void LessThanSixMonths()
        {
            Survey survey = new Survey();
            survey.CustomerHistory = "Less than six months";
            Assert.IsFalse(survey.EstablishedCustomer());
        }

        [TestMethod]
        public void SixMonthsToYear()
        {
            Survey survey = new Survey();
            survey.CustomerHistory = "Six months to a year";
            Assert.IsFalse(survey.EstablishedCustomer());
        }


        [TestMethod]
        public void OneToTwoYear()
        {
            Survey survey = new Survey();
            survey.CustomerHistory = "1 - 2 years";
            Assert.IsTrue(survey.EstablishedCustomer());
        }

        [TestMethod]
        public void ThreeOrMoreYears()
        {
            Survey survey = new Survey();
            survey.CustomerHistory = "3 or more years";
            Assert.IsTrue(survey.EstablishedCustomer());
        }

        [TestMethod]
        public void NotACustomer()
        {
            Survey survey = new Survey();
            survey.CustomerHistory = "I haven't made a purchase yet";
            Assert.IsFalse(survey.EstablishedCustomer());
        }

        [TestMethod]
        public void ExtremelyLikelyToRepurchase()
        {
            Survey survey = new Survey();
            survey.Repurchase = "Extremely likely";
            Assert.IsTrue(survey.LikelyToRepurchase());
        }

        [TestMethod]
        public void VeryLikelyToRepurchase()
        {
            Survey survey = new Survey();
            survey.Repurchase = "Very likely";
            Assert.IsTrue(survey.LikelyToRepurchase());
        }

        [TestMethod]
        public void SomewhatLikelyToRepurchase()
        {
            Survey survey = new Survey();
            survey.Repurchase = "Somewhat likely";
            Assert.IsTrue(survey.LikelyToRepurchase());
        }

        [TestMethod]
        public void NotSoLikelyToRepurchase()
        {
            Survey survey = new Survey();
            survey.Repurchase = "Not so likely";
            Assert.IsFalse(survey.LikelyToRepurchase());
        }

        [TestMethod]
        public void NotAtAllLikelyToRepurchase()
        {
            Survey survey = new Survey();
            survey.Repurchase = "Not at all likely";
            Assert.IsFalse(survey.LikelyToRepurchase());
        }
    }
}
