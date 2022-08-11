using System;
using System.Collections.Generic;

namespace SchoolAdministration.Models
{
    public partial class Teacher
    {
        public Teacher()
        {
            Enrollments = new HashSet<Enrollment>();
        }

        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime? DateJoined { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
