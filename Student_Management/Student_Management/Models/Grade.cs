using System;
using System.Collections.Generic;

#nullable disable

namespace Student_Management.Models
{
    public partial class Grade
    {
        public int GradeId { get; set; }
        public int? GradeCategoryId { get; set; }
        public string GradeName { get; set; }

        public virtual GradeCategory GradeCategory { get; set; }
    }
}
