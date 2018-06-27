using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlueRibbonsReview.Models
{
    public class Campaign
    {
        public int CampaignID { get; set; }
        public string ASIN { get; set; }
        public string Name { get; set; }
        public bool OpenCampaign { get; set; }
        public string ImageUrL { get; set; }
        public string Description { get; set; }
        [DisplayFormat(DataFormatString = "{0:0.00}")]
        public double RetailPrice { get; set; }
        [DisplayFormat(DataFormatString = "{0:0.00}")]
        public double SalePrice { get; set; }
        [Display(Name = "Start Date")]
        [DisplayFormat(DataFormatString = "{0:MMM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }
        [Display(Name = "Close Date")]
        [DisplayFormat(DataFormatString = "{0:MMM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? CloseDate { get; set; }
        [Display(Name = "Expire Date")]
        [DisplayFormat(DataFormatString = "{0:MMM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? ExpireDate { get; set; }
        public string VendorsPurchaseInstructions { get; set; }
        public string VendorsPurchaseURL { get; set; }
        public string UserId { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
        public virtual ICollection<Promotion> Promotions { get; set; }
    }
}