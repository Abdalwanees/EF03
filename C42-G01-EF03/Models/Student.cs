
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G01_EF03.Models
{
    internal class Student
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public int DeptId { get; set; }

        // Navigation Properties
        public virtual Department Department { get; set; }
        public virtual ICollection<Students_Course> Students_Courses { get; set; } = new List<Students_Course>();
    }
}
