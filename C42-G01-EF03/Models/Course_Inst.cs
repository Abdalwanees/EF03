using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G01_EF03.Models
{
    internal class Course_Insts
    {
        public int InstructorId { get; set; }
        public int CourseId { get; set; }
        public string Evaluate { get; set; }

        // Navigation Properties
        public virtual Instructor Instructor { get; set; }
        public virtual Course Course { get; set; }
    }
}