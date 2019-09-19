using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Appli.Models
{
    public class Interview
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int JobApplicationId { get; set; }

        public JobApplication JobApplication { get; set; }

        [Display(Name = "Date")]
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime Date { get; set; }

        [Display(Name = "Address")]
        public string Address { get; set; }

        [Display(Name = "Notes")]
        public string Notes { get; set; }
    }
}
