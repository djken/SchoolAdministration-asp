using System;
using System.Collections.Generic;

namespace SchoolAdministration.Models
{
    public partial class Student
    {
        public Student()
        {
            Enrollments = new HashSet<Enrollment>();
        }

        public int Id { get; set; }
        public string Lastname { get; set; } = null!;
        public string Firstname { get; set; } = null!;
        public DateTime Dateofbirth { get; set; }
        public DateTime? Enrollmentdate { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
