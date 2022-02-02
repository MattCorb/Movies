using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DateME.Models
{
    public class ApplicationResponse
    {
        [Key]
        [Required]
        public int ApplicationId { get; set; }
        [Required(ErrorMessage = "What even is Category")]
        //build the foreign key migrations
        public int Categoryid { get; set; }
        public Category Category { get; set; }

        [Required(ErrorMessage = "What even is this movie it needs a title")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Year?")]
        public int Year { get; set; }
        [Required(ErrorMessage = "We need a director please")]
        public string Director { get; set; }
        [Required(ErrorMessage = "Rating fool")]
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string LentTo { get; set; }
        public string Notes { get; set; }

    }
}
