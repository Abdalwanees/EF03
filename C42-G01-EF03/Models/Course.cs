using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G01_EF03.Models
{
    internal class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public TimeSpan Duration { get; set; }
        public string Description { get; set; }
        public int TopicId { get; set; }

        // Navigation Properties
        public virtual Topic Topic { get; set; }
        public virtual ICollection<Students_Course> Students_Courses { get; set; } = new List<Students_Course>();
        public virtual ICollection<Course_Insts> Course_Insts { get; set; } = new List<Course_Insts>();
    }
}
