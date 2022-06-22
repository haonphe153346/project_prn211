using System;
using System.Collections.Generic;

#nullable disable

namespace PRN291_StudentManagerment.Models
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
