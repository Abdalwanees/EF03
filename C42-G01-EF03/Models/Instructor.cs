using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace C42_G01_EF03.Models
{
    internal class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Bouns { get; set; }
        public double Salary { get; set; }
        public double HourlyRate { get; set; }

        // Navigation Properties
        public virtual Department Department { get; set; } // ربط بالعلاقة 1 إلى 1
        public virtual ICollection<Course_Insts> Course_Insts { get; set; } = new List<Course_Insts>();
    }
}
