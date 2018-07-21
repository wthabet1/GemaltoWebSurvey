using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GemaltoWebSurvey.Models
{
    public class Survey
    {
        public Survey()
        {
            Recommendation = 0;
            Satisfaction = string.Empty;
            ProductDescription = new List<string>();
            Suitability = string.Empty;
            ProductQuality = string.Empty;
            ValueForMoney = string.Empty;
            Responsiveness = string.Empty;
            CustomerHistory = string.Empty;
            Repurchase = string.Empty;
            Comments = string.Empty;
        }

        [Required]
        [Range(0, 10, ErrorMessage = "Response must be between 0 for unlikely and 10 for extremely likely.")]
        [DisplayName("1. How likely is it that you would recommend this company to a friend or colleague?")]
        public int Recommendation { get; set; }

        [Required]
        [DisplayName("2. Overall, how satisfied or dissatisfied are you with our company?")]
        public string Satisfaction { get; set; }

        [Required]
        [DisplayName("3. Which of the following words would you use to describe our products? Select all that apply.")]
        public List<string> ProductDescription { get; set; }
        
        [Required]
        [DisplayName("4. How well do our products meet your needs?")]
        public string Suitability { get; set; }

        [Required]
        [DisplayName("5. How would you rate the quality of the product?")]
        public string ProductQuality { get; set; }

        [Required]
        [DisplayName("6. How would you rate the value for money of the product?")]
        public string ValueForMoney { get; set; }

        [Required]
        [DisplayName("7. How responsive have we been to your questions or concerns about our products?")]
        public string Responsiveness { get; set; }

        [Required]
        [DisplayName("8. How long have you been a customer of our company?")]
        public string CustomerHistory { get; set; }

        [Required]
        [DisplayName("9. How likely are you to purchase any of our products again?")]
        public string Repurchase { get; set; }

        [DisplayName("10. Do you have any other comments, questions, or concerns?")]
        public string Comments { get; set; }

        private List<string> _strSatisfactionLevels = new List<string> { "Very satisfied",
                                                                         "Somewhat satisfied",
                                                                         "Neither satisfied nor dissatisfied",
                                                                         "Somewhat dissatisfied",
                                                                         "Very dissatisfied"
        };

        private List<string> _productDescriptions = new List<string> { "Reliable",
                                                                        "High quality",
                                                                        "Useful",
                                                                        "Unique",
                                                                        "Good value for money",
                                                                        "Overpriced",
                                                                        "Impractical",
                                                                        "Ineffective",
                                                                        "Poor quality",
                                                                        "Unreliable"
        };

        private List<string> _suitability = new List<string> { "Extremely well",
                                                                "Very well",
                                                                "Somewhat well",
                                                                "Not so well",
                                                                "Not at all well"
        };

        private List<string> _quality = new List<string> { "Very high quality",
                                                           "High quality",
                                                           "Neither high nor low quality",
                                                           "Low quality",
                                                           "Very low quality"
        };

        private List<string> _valueForMoney = new List<string> { "Excellent",
                                                                 "Above average",
                                                                 "Average",
                                                                 "Below average",
                                                                 "Poor"
        };


        private List<string> _responsiveness = new List<string> { "Extremely responsive",
                                                                  "Very responsive",
                                                                  "Somewhat responsive",
                                                                  "Not so responsive",
                                                                  "Not at all responsive",
                                                                  "Not applicable"
        };

        private List<string> _timeAsCustomer = new List<string> { "This is my first purchase",
                                                                  "Less than six months",
                                                                  "Six months to a year",
                                                                  "1 - 2 years",
                                                                  "3 or more years",
                                                                  "I haven't made a purchase yet"
        };

        private List<string> _repurchaseLikelihood = new List<string> { "Extremely likely",
                                                                        "Very likely",
                                                                        "Somewhat likely",
                                                                        "Not so likely",
                                                                        "Not at all likely"
        };

    }
}