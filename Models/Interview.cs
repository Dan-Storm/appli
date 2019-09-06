using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Appli.Models
{
    public class Interview
    {
        public int Id { get; set; }

        public int JobApplicationId { get; set; }

        public DateTime Date { get; set; }

        public string Address { get; set; }

        public string Notes { get; set; }
    }
}
