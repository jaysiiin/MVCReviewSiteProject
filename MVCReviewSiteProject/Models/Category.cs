using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCReviewSiteProject.Models
{
    public class Category
    {
        public int ID { get; set; }
        [Display(Name = "Location")]
        public string location { get; set; }
        public virtual ICollection<Review> Reviews { get; set;}
    }
}