using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCReviewSiteProject.Models
{
    public class Review
    {
        //fields
        [Key]
        public int ID { get; set; }
        [Display(Name ="First Name")]
        public string firstName { get; set; }
        [Display(Name = "Last Name")]
        public string lastName { get; set; }
        [Display(Name = "Date")]
        public DateTime date { get; set; }
        [Display(Name = "Description")]
        public string description { get; set; }
        //added rating system
        [Display(Name = "Rating Star")]
        public string rating { get; set; }

        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

    }
}