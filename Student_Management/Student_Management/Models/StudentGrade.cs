using System;
using System.Collections.Generic;

#nullable disable

namespace Student_Management.Models
{
    public partial class StudentGrade
    {
        public int? StudentId { get; set; }
        public int? SubjectId { get; set; }
        public int? GradeId { get; set; }

        public virtual Grade Grade { get; set; }
        public virtual Student Student { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
