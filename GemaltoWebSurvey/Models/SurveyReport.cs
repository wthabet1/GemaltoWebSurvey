﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GemaltoWebSurvey.Models
{
    public class SurveyReport
    {
        public SurveyReport(List<Survey> surveys)
        {
            double _dblRecommondataion = 0;
            int _intSatisfiedCustomers = 0;
            int _intHighQualityResponse = 0;
            int _intPositiveProductDesc = 0;
            int _intNegativeProductDesc = 0;
            int _intSuitableProductResp = 0;
            int _intResponsiveCustomerCare = 0;
            int _intEstablishedCustomer = 0;
            int _intValueForMoneyResp = 0;
            int _intResponsesWithComments = 0;
            int _intLikelyToRepurchase = 0;


            SurveyTakers = surveys.Count();
            foreach (Survey survey in surveys)
            {
                if (survey.Recommendation != null)
                {
                    _dblRecommondataion += (double)survey.Recommendation;
                }

                if (survey.Satisfied()) _intSatisfiedCustomers++;
                if (survey.HighQuality()) _intHighQualityResponse++;
                if (survey.Suitable()) _intSuitableProductResp++;

                if (survey.EstablishedCustomer()) _intEstablishedCustomer++;
                if (survey.HasValueForMoney()) _intValueForMoneyResp++;
                if (survey.Comments != null) _intResponsesWithComments++;
                if (survey.PositiveProductFeedback()) _intPositiveProductDesc++;
                if (survey.NegativeProductFeedback()) _intNegativeProductDesc++;
                if (survey.LikelyToRepurchase()) _intLikelyToRepurchase++;

                bool blnApplicable = false;
                if (survey.IsCustomerCareResponsive(out blnApplicable))
                {
                    if (blnApplicable) _intResponsiveCustomerCare++;
                }

            }
            if (SurveyTakers > 0)
            {
                AverageRecommendations = Math.Floor(_dblRecommondataion / SurveyTakers);
                SatisfiedCustomers = Math.Round((double)_intSatisfiedCustomers / SurveyTakers, 2);
                ResponsesWithHighQuality = Math.Round((double)_intHighQualityResponse / SurveyTakers, 2);
                PositiveProductFeedback = Math.Round((double)_intPositiveProductDesc / SurveyTakers, 2);
                NegativeProductFeedback = Math.Round((double)_intNegativeProductDesc / SurveyTakers, 2);
                SuitableProdctResponses = Math.Round((double)_intSuitableProductResp / SurveyTakers, 2);
                ResponsesWithComments = Math.Round((double)_intResponsesWithComments / SurveyTakers, 2);
                EstablishedCustomers = Math.Round((double)_intEstablishedCustomer / SurveyTakers, 2);
                ValueForMoney = Math.Round((double)_intValueForMoneyResp / SurveyTakers, 2);
                ResponsiveCustomerCare = Math.Round((double)_intResponsiveCustomerCare / SurveyTakers, 2);
                LikelyToRepurchase = Math.Round((double)_intLikelyToRepurchase / SurveyTakers, 2);
            }
        }

        [DisplayName("Number of Customers who took survey")]
        public int SurveyTakers { get; }

        [DisplayName("Average Recommendation")]
        public double AverageRecommendations { get; }

        [DisplayFormat(DataFormatString = "{0:P0}")]
        [DisplayName("Satisfied customers")]
        public double SatisfiedCustomers { get; }

        [DisplayFormat(DataFormatString = "{0:P0}")]
        [DisplayName("Product of high quality")]
        public double ResponsesWithHighQuality { get; }

        [DisplayFormat(DataFormatString = "{0:P0}")]
        [DisplayName("Positive product feedback")]
        public double PositiveProductFeedback { get; }

        [DisplayFormat(DataFormatString = "{0:P0}")]
        [DisplayName("Negative product feedback")]
        public double NegativeProductFeedback { get; }

        [DisplayFormat(DataFormatString = "{0:P0}")]
        [DisplayName("Product suitable")]
        public double SuitableProdctResponses { get; }

        [DisplayFormat(DataFormatString = "{0:P0}")]
        [DisplayName("Customer care responsive")]
        public double ResponsiveCustomerCare { get; }

        [DisplayFormat(DataFormatString = "{0:P0}")]
        [DisplayName("Established customers")]
        public double EstablishedCustomers { get; }

        [DisplayFormat(DataFormatString = "{0:P0}")]
        [DisplayName("Likely to repurchase")]
        public double LikelyToRepurchase { get; }

        [DisplayFormat(DataFormatString = "{0:P0}")]
        [DisplayName("High product value")]
        public double ValueForMoney { get; }


        [DisplayFormat(DataFormatString = "{0:P0}")]
        [DisplayName("Responses with comments")]
        public double ResponsesWithComments { get; }

    }
}