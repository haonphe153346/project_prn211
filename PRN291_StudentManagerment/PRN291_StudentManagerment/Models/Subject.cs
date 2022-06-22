using System;
using System.Collections.Generic;

#nullable disable

namespace PRN291_StudentManagerment.Models
{
    public partial class Subject
    {
        public int SubjectId { get; set; }
        public int? SemesterId { get; set; }
        public int? ClassId { get; set; }
        public string SubjectCode { get; set; }
        public string SubjectName { get; set; }

        public virtual Class Class { get; set; }
        public virtual Semester Semester { get; set; }
    }
}
