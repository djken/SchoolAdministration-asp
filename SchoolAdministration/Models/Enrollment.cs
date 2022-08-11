using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace SchoolAdministration.Models
{
    public partial class Enrollment
    {
        public int Id { get; set; }
        [DisplayName("Teachers")]
        public int? TeacherId { get; set; }

        [DisplayName("Students")]
        public int? StudentId { get; set; }
        [DisplayName("Titre du Cours")]
        public int? CourseId { get; set; }
        [DisplayName("Grade")]
        public string? Grade { get; set; }

        public virtual Course? Course { get; set; }
        public virtual Student? Student { get; set; }
        public virtual Teacher? Teacher { get; set; }
    }
}
