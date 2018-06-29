using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlueRibbonsReview.Models
{
    public class Referral
    {
        public int ReferralID { get; set; }

        [Display(Name = "Name of Referral")]
        public string ReferralName { get; set; }

        [Display(Name = "Email of Referral")]
        public string ReferralEmail { get; set; }

        [Display(Name = "Personal Message")]
        public string Message { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}