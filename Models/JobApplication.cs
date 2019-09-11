using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Appli.Models
{
    public class JobApplication
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; }

        public ApplicationUser User { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime DateCreated { get; set; }

        [NotMapped]
        private DateTime? _nextInterview = null;

        [NotMapped]
        [Display(Name = "Next Interview")]
        public DateTime? NextInterview { get
            { foreach( Interview i in Interviews)
                {

                    if (i.Date >= DateTime.Now.Date && i.Date <= _nextInterview)
                    {
                        _nextInterview = i.Date;
                    }
                    else if (i.Date >= DateTime.Now.Date)
                    {
                        _nextInterview = i.Date;
                    }
                }
                return _nextInterview;
            }
        }

        [Display(Name = "Company Name")]
        [StringLength(30)]
        [Required]
        public string CompanyName { get; set; }

        [Display(Name = "Position")]
        [StringLength(30)]
        [Required]
        public string Position { get; set; }

        public int? RecruiterId { get; set; }

        public Recruiter Recruiter { get; set; }

        [Display(Name = "Position Link")]
        public string PositionLink { get; set; }

        [Display(Name = "Rejected")]
        public bool Rejected { get; set; }

        [Display(Name = "Offer")]
        public string Offer { get; set; }

        [Display(Name = "Last Contact")]
        [DataType(DataType.Date)]
        public DateTime LastContact { get; set; }

        [Display(Name = "Notes")]
        [StringLength(300)]
        public string Notes { get; set; }

        [Display(Name = "Still Active?")]
        public bool IsActive { get; set; }
        public virtual ICollection<Interview> Interviews { get; set; }

    }
}
