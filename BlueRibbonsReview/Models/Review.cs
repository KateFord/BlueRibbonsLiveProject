using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace BlueRibbonsReview.Models
{
    public class Review
    {
        public Guid ReviewID { get; set; }
        [DisplayFormat(DataFormatString = "{0:MMM-dd-yyyy}", ApplyFormatInEditMode = true)]
        [DisplayName("Review Date")]
        public DateTime ReviewDate { get; set; }
        [DisplayName("Product Rating")]
        public int? ProductRating { get; set; }
        [DisplayName("Review")]
        public string ReviewDetails { get; set; }

        public int? CampaignId { get; set; }

        public string UserId { get; set; }
        
        public virtual ApplicationUser ApplicationUser { get; set; }
        public virtual Campaign Campaign { get; set; }
    }
}