using System;
using System.ComponentModel.DataAnnotations;

namespace RESTauranter.Models
{
    public class Recensione      // Italian for review/critique
    {
        [Key]
        public long id { get; set; }

        [Display(Name = "Your Name: ")]
        [Required(ErrorMessage = "*Required")]
        public string name { get; set; }

        [Display(Name = "Restaurant Name: ")]
        [Required(ErrorMessage = "*Required")]
        public string restaurant { get; set; }

        [Display(Name = "Review: ")]
        [Required(ErrorMessage = "*Required")]
        [MinLength(10)]
        public string review { get; set; }

        [Display(Name = "Stars: ")]
        [Required(ErrorMessage = "*Required")]
        public int rating { get; set; }

        [Display(Name = "Date of Visit: ")]
        [Required(ErrorMessage = "*Required")]
        public DateTime visit { get; set; }
        
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }

        public Recensione()
        {
            created_at = DateTime.Now;
            updated_at = DateTime.Now;
        }
    }
}