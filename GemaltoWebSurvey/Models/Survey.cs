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
        [Required]
        [DisplayName("1. How likely is it that you would recommend this company to a friend or colleague?")]
        int Recommendation { get; set; }

        [Required]
        [DisplayName("2. Overall, how satisfied or dissatisfied are you with our company?")]
        int Satisfaction { get; set; }

        [Required]
        [DisplayName("3. Which of the following words would you use to describe our products? Select all that apply.")]
        List<string> ProductDescription { get; set; }
        
        [Required]
        [DisplayName("4. How well do our products meet your needs?")]
        int Suitability { get; set; }

        [Required]
        [DisplayName("5. How would you rate the quality of the product?")]
        int ProductQuality { get; set; }

        [Required]
        [DisplayName("6. How would you rate the value for money of the product?")]
        int ValueForMoney { get; set; }

        [Required]
        [DisplayName("7. How responsive have we been to your questions or concerns about our products?")]
        int Responsiveness { get; set; }

        [Required]
        [DisplayName("8. How long have you been a customer of our company?")]
        int TimeAsCustomer { get; set; }

        [Required]
        [DisplayName("9. How likely are you to purchase any of our products again?")]
        string Repurchase { get; set; }

        [DisplayName("10. Do you have any other comments, questions, or concerns?")]
        string Comments { get; set; }
    }
}