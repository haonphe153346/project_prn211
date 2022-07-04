using System;
using System.Collections.Generic;

#nullable disable

namespace Student_Management.Models
{
    public partial class GradeCategory
    {
        public GradeCategory()
        {
            Grades = new HashSet<Grade>();
        }

        public int GradeCategoryId { get; set; }
        public string GradeCategoryName { get; set; }

        public virtual ICollection<Grade> Grades { get; set; }
    }
}
