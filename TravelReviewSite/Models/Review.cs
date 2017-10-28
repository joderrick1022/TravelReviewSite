using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TravelReviewSite.Models
{
    public class Review
    {

        [Key]
        public  int ID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Pros { get; set; }
        public string Cons { get; set; }
        public double Cost { get; set; }
        public bool IsRecommended { get; set; }



        [ForeignKey("Category")]
        [Display(Name = "Category")]
        public int CatagoryID { get; set; }
        public virtual Category Category { get; set; }


    }
}