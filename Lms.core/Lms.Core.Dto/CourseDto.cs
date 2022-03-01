using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.core.Lms.Core.Dto
{
    public class CourseDto
    {
        [Required]
        [MaxLength(25)]
        public string Title { get; set; }
        public DateTime StartDate { get; set; }

        public DateTime EndDate => StartDate.AddMonths(3).AddDays(-3);
    }
}
