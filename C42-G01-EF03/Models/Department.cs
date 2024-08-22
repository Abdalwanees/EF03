using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G01_EF03.Models
{
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int InstructorId { get; set; }
        public DateTime HiringDate { get; set; }

        // Navigation Properties
        public virtual Instructor Instructor { get; set; }
        public virtual ICollection<Student> Students { get; set; } = new List<Student>();
    }
}
