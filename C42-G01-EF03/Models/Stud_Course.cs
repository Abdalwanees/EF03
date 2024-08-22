using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G01_EF03.Models
{
    internal class Students_Course
    {
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public string Grade { get; set; }

        // Navigation Properties
        public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }
    }
}
