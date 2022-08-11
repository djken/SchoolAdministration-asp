using System;
using System.Collections.Generic;

namespace SchoolAdministration.Models
{
    public partial class Course
    {
        public Course()
        {
            Enrollments = new HashSet<Enrollment>();
        }

        public int CourseId { get; set; }
        public string Title { get; set; } = null!;
        public int? NumberOfCredits { get; set; }
        public string CourseCode { get; set; } = null!;

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
