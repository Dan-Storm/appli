using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Appli.Models
{
    public class Recruiter
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(40)]
        public string FullName { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        public string EmailAddress { get; set; }

        public virtual ICollection<JobApplication> JobApplications { get; set; }

        [Required]
        [DefaultValue(true)]
        public bool IsActive { get; set; }
    }
}
