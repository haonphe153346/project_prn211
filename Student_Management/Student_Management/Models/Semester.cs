using System;
using System.Collections.Generic;

#nullable disable

namespace Student_Management.Models
{
    public partial class Semester
    {
        public Semester()
        {
            Classes = new HashSet<Class>();
            Subjects = new HashSet<Subject>();
        }

        public int SemesterId { get; set; }
        public string SemesterName { get; set; }

        public virtual ICollection<Class> Classes { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }
    }
}
