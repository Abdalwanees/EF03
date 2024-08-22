using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G01_EF03.Models
{
    internal class Topic
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Navigation Property
        public virtual ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
